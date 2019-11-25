using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using HYTMS.MODEL;

namespace CES_TMS.COMMON
{
    public class UIHelper
    {
        private static UIHelper instance = null;
        private static object lockHelper = new object();

        private UIHelper()
        {

        }

        public static UIHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new UIHelper();
                        }
                    }
                }
                return instance;
            }
        }

        public void BindComboxData(ComboBoxEx comboBoxProduct, object plist, string filed, string value, bool isSelected= false)
        {
            comboBoxProduct.DataSource = plist;
            comboBoxProduct.ValueMember = value; //"PRODUCTCODE";
            comboBoxProduct.DisplayMember = filed;// "PRODUCTFULLNAME";
            if (isSelected)
            {
                comboBoxProduct.SelectedIndex = -1;
            }
        }

        public List<TmsServiceProduct> GetProductList(string channelCode)
        {
            var productLst = CachHelper.Instance.GetData("allProductList") as List<TmsServiceProduct>;
            if (productLst == null)
            {
                productLst = GetProductList(channelCode);
                CachHelper.Instance.Add("allProductList", productLst);
            }
            return productLst;
        }

        public void CloseForm(string[] formAry)
        {
            for (int i = 0; i < formAry.Length; i++)
            {
                Form frm = Application.OpenForms[formAry[i]];
                if (frm != null)
                {
                    if (!frm.IsDisposed)
                    {
                        frm.Dispose();
                    }
                    //frm.Close();
                }
            }
        }
    }
}
