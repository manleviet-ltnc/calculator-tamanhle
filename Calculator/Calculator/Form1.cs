using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        bool IsTyingNumber = false;
        enum PhepToan
        {
            PhepCong = +,
            PhepTru = -,
            PhepNhan = *,
            PhepChia = /,

        }
            
        private void NhapSo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            NhapSo(btn.Text);
        }
        private void NhapSo(string so )
        {
            if (IsTyingNumber)
                lblDisplay.Text = lblDisplay.Text + so;
             
            else
               {
                lblDisplay.Text = so;
                IsTyingNumber = true;
               }
        }
        private void NhapPhepToan(object sender, EventArgs e)
        {

        }
    }
}
