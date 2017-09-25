namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnDoiDau = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTrư = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnPhanTram = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnNho = new System.Windows.Forms.Button();
            this.btnThapPhan = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDisplay.Location = new System.Drawing.Point(14, 15);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(254, 36);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn1
            // 
            this.btn1.CausesValidation = false;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn1.Location = new System.Drawing.Point(12, 214);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn2
            // 
            this.btn2.CausesValidation = false;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn2.Location = new System.Drawing.Point(70, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn3
            // 
            this.btn3.CausesValidation = false;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn3.Location = new System.Drawing.Point(126, 214);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn4
            // 
            this.btn4.CausesValidation = false;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn4.Location = new System.Drawing.Point(12, 168);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn5
            // 
            this.btn5.CausesValidation = false;
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn5.Location = new System.Drawing.Point(70, 168);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn0
            // 
            this.btn0.CausesValidation = false;
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn0.Location = new System.Drawing.Point(70, 263);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn9
            // 
            this.btn9.CausesValidation = false;
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn9.Location = new System.Drawing.Point(126, 122);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn8
            // 
            this.btn8.CausesValidation = false;
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn8.Location = new System.Drawing.Point(70, 122);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn7
            // 
            this.btn7.CausesValidation = false;
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn7.Location = new System.Drawing.Point(14, 122);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn6
            // 
            this.btn6.CausesValidation = false;
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn6.Location = new System.Drawing.Point(126, 168);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnDoiDau
            // 
            this.btnDoiDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiDau.Enabled = false;
            this.btnDoiDau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiDau.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoiDau.Location = new System.Drawing.Point(12, 263);
            this.btnDoiDau.Name = "btnDoiDau";
            this.btnDoiDau.Size = new System.Drawing.Size(40, 40);
            this.btnDoiDau.TabIndex = 1;
            this.btnDoiDau.Text = "-/+";
            this.btnDoiDau.UseVisualStyleBackColor = true;
            // 
            // btnCong
            // 
            this.btnCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCong.Enabled = false;
            this.btnCong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCong.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCong.Location = new System.Drawing.Point(181, 122);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(40, 40);
            this.btnCong.TabIndex = 1;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            // 
            // btnTrư
            // 
            this.btnTrư.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrư.Enabled = false;
            this.btnTrư.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrư.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrư.Location = new System.Drawing.Point(181, 168);
            this.btnTrư.Name = "btnTrư";
            this.btnTrư.Size = new System.Drawing.Size(40, 40);
            this.btnTrư.TabIndex = 1;
            this.btnTrư.Text = "-";
            this.btnTrư.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhan.Enabled = false;
            this.btnNhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhan.Location = new System.Drawing.Point(181, 214);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(40, 40);
            this.btnNhan.TabIndex = 1;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChia.Enabled = false;
            this.btnChia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChia.Location = new System.Drawing.Point(181, 263);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(40, 40);
            this.btnChia.TabIndex = 1;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // btnPhanTram
            // 
            this.btnPhanTram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanTram.Enabled = false;
            this.btnPhanTram.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhanTram.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhanTram.Location = new System.Drawing.Point(228, 122);
            this.btnPhanTram.Name = "btnPhanTram";
            this.btnPhanTram.Size = new System.Drawing.Size(40, 40);
            this.btnPhanTram.TabIndex = 1;
            this.btnPhanTram.Text = "%";
            this.btnPhanTram.UseVisualStyleBackColor = true;
            // 
            // btnCan
            // 
            this.btnCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCan.Enabled = false;
            this.btnCan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCan.Location = new System.Drawing.Point(228, 168);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(40, 40);
            this.btnCan.TabIndex = 1;
            this.btnCan.Text = "√";
            this.btnCan.UseVisualStyleBackColor = true;
            // 
            // btnNho
            // 
            this.btnNho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNho.Enabled = false;
            this.btnNho.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNho.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNho.Location = new System.Drawing.Point(14, 72);
            this.btnNho.Name = "btnNho";
            this.btnNho.Size = new System.Drawing.Size(84, 40);
            this.btnNho.TabIndex = 1;
            this.btnNho.Text = "C";
            this.btnNho.UseVisualStyleBackColor = true;
            // 
            // btnThapPhan
            // 
            this.btnThapPhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThapPhan.Enabled = false;
            this.btnThapPhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThapPhan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThapPhan.Location = new System.Drawing.Point(126, 263);
            this.btnThapPhan.Name = "btnThapPhan";
            this.btnThapPhan.Size = new System.Drawing.Size(40, 40);
            this.btnThapPhan.TabIndex = 1;
            this.btnThapPhan.Text = ".";
            this.btnThapPhan.UseVisualStyleBackColor = true;
            // 
            // btnBang
            // 
            this.btnBang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBang.Enabled = false;
            this.btnBang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBang.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBang.Location = new System.Drawing.Point(228, 214);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(40, 89);
            this.btnBang.TabIndex = 1;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.Location = new System.Drawing.Point(116, 72);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(152, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Backspace";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(294, 331);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnThapPhan);
            this.Controls.Add(this.btnNho);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnPhanTram);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTrư);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnDoiDau);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnDoiDau;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTrư;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnPhanTram;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnNho;
        private System.Windows.Forms.Button btnThapPhan;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnXoa;
    }
}

