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
    public partial class ImportOrderNumberDialogForm : Form
    {
        public ImportOrderNumberDialogForm()
        {
            InitializeComponent();
        }
        public delegate void ChangeBusinessNoDelegate(string businessNo);
        public event ChangeBusinessNoDelegate ChangeBusinessEvent;
    }

   
}
