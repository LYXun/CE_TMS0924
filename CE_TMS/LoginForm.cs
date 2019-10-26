using CES_TMS.COMMON;
using CES_TMS.MODEL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS
{
    public partial class LoginForm : Form
    {
        private Thread thread;
        private bool isRun;
        private string stateUrl;
        private string jsonResult;
        private bool isLogin;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            thread = new Thread(MyThread);
            thread.IsBackground = true;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.labVersion.Text = string.Format("当前版本号：v{0}", version);
        }

        private void MyThread()
        {
           while(isRun)
            {
                ReadUserInfo();
                if(thread.ThreadState == ThreadState.Running)
                {
                    Thread.Sleep(500);
                }
            }
        }

        private void ReadUserInfo()
        {
            try
            {
                using (var http = new HttpClient())
                {
                    var resp = http.GetAsync(stateUrl).Result;
                    if(!resp.IsSuccessStatusCode)
                    {
                        return;
                    }
                    resp.EnsureSuccessStatusCode();
                    var result = resp.Content.ReadAsStringAsync();
                    var ret = result.Result;
                    jsonResult = ret;

                    if(jsonResult != null)
                    {
                        TmsCustomer cus = null;
                        var DynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonResult);
                        cus = new TmsCustomer();
                        cus.CreateOpId = DynamicObject.sub;
                        cus.CustomerCode = DynamicObject.email;
                        cus.CustomerFullName = DynamicObject.username;
                        if(!string.IsNullOrEmpty(cus.CustomerCode) && cus.CustomerCode.Length>0)
                        {
                            CacheHelper.Instance.Add("user",cus);
                            thread.Interrupt();
                            isRun = false;
                            isLogin = true;
                            this.BeginInvoke(new EventHandler(delegate
                            {
                                MainForm main = new MainForm();
                                main.TopMost = true;
                                this.Hide();
                                main.Show();
                            }));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isLogin = false;
                CommonHelper.Instance.ShowAlert(ex.Message.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || txtName.Text.Length < 1)
                {
                    ThreadPool.QueueUserWorkItem(a =>
                    {
                        CommonHelper.Instance.ShowAlert("用户名不能为空");
                    });
                    return;
                }
                if (string.IsNullOrEmpty(txtPwd.Text) || txtPwd.Text.Length < 1)
                {
                    ThreadPool.QueueUserWorkItem(a =>
                    {
                        CommonHelper.Instance.ShowAlert("密码不能为空");
                    });
                    return;
                }
                string url = ServicesAPIHelper.Instance.LoginUrl;
                dynamic reqUserObj = new JObject();
                reqUserObj.userName = txtName.Text.Trim();
                reqUserObj.pwd = txtPwd.Text.Trim();
                reqUserObj.sysCode = "TMS";

                string userParamsStr = reqUserObj.ToString();
                var result = NetHelper.HttpApi(url, userParamsStr, "POST");
                TmsReturnBaseObj<object> responseObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<object>>(result);
                if (responseObj == null)
                {
                    ThreadPool.QueueUserWorkItem(a =>
                    {
                        CommonHelper.Instance.ShowAlert("服务器返回数据为空");
                    });
                    txtName.Focus();
                    return;
                }
                if (!responseObj.UpdateObj.Code.Equals("0000"))
                {
                    ThreadPool.QueueUserWorkItem(a =>
                    {
                        CommonHelper.Instance.ShowAlert(responseObj.UpdateObj.Msg);
                    });
                    txtName.Focus();
                    return;
                }

                string token = responseObj.UpdateObj.Obj_Json;
                if(!string.IsNullOrEmpty(token))
                {
                    string json = AESHelper.AesDecrypt(token,"1234567890123456");
                    if(!string.IsNullOrEmpty(json))
                    {
                        TmsCustomer cus = new TmsCustomer();
                        var DynamicObject = JsonConvert.DeserializeObject<dynamic>(json);
                        cus.CreateOpId = DynamicObject.ID;
                        cus.CreateOpName = DynamicObject.ID;
                        cus.CreateOpName = DynamicObject.UserName;
                        cus.CustomerFullName = DynamicObject.UserName;
                        CacheHelper.Instance.Add("user",cus);
                        MainForm main = new MainForm();
                        this.Hide();
                        main.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                ThreadPool.QueueUserWorkItem(a => {
                    CommonHelper.Instance.ShowAlert(ex.Message);
                    CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message.ToString());
                });
            }
        }
    }
}
