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
        enum PhepToan { Cong, Tru, Nhan, Chia };
        PhepToan pheptoan;


        double nho;

        private void NhapSo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            NhapSo(btn.Text);
        }
        private void NhapSo(string so)
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
            Tinhketqua();
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+": pheptoan = PhepToan.Cong; break;
                case "-": pheptoan = PhepToan.Tru; break;
                case "*": pheptoan = PhepToan.Nhan; break;
                case "/": pheptoan = PhepToan.Chia; break;

            }
            nho = double.Parse(lblDisplay.Text);
            IsTyingNumber = false;
        }
        private void Tinhketqua()
        {
            double tam = double.Parse(lblDisplay.Text);
            double ketqua = 0.0;
            switch (pheptoan)
            {
                case PhepToan.Cong: ketqua = nho + tam; break;
                case PhepToan.Tru: ketqua = nho - tam; break;
                case PhepToan.Nhan: ketqua = nho * tam; break;
                case PhepToan.Chia: ketqua = nho / tam; break;
            }
            lblDisplay.Text = ketqua.ToString();

        }
        private void btnbang_click(object sender, EventArgs e)
        {
            Tinhketqua();
            IsTyingNumber = false;
        }
        private void frmcalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    NhapSo("" + e.KeyChar);
                    break;

            }
        }
        private void btnCan_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (Math.Sqrt(Double.Parse(lblDisplay.Text))).ToString();
        }

        private void btnDoiGiau_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (-1 * (double.Parse(lblDisplay.Text))).ToString();
        }

        private void btnPhanTram_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = ((double.Parse(lblDisplay.Text) / 100)).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 0)
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1);
        }
      }  
} 
