using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CE_TMS.subWindows.dialog
{
    public partial class ServiceProviderDialogForm : Form
    {
        public ServiceProviderDialogForm()
        {
            InitializeComponent();
        }
        public delegate void ChangeServiceCodeDelegate(string providerCode,string providerName); //委托 服务商
        public event ChangeServiceCodeDelegate ChangeProviderEvent;//服务商  事件值回传 
    }

    
}
