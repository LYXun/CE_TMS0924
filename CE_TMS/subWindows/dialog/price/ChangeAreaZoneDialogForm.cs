using CES_TMS.COMMON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.subWindows.dialog.price
{
    public partial class ChangeAreaZoneDialogForm : Form
    {
        public ChangeAreaZoneDialogForm()
        {
            InitializeComponent();
        }

        public delegate void ChangeZone(TmsPriceZone obj);
        public event ChangeZone ChangeZoneEvent;
    }
}
