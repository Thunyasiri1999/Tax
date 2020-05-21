namespace WindowsFormsApp4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fm = new System.Windows.Forms.ComboBox();
            this.moneyall = new System.Windows.Forms.Button();
            this.stp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pk = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sn = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quark", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 58);
            this.label5.TabIndex = 8;
            this.label5.Text = "รายได้\r\n(ต่อเดือน)";
            // 
            // money
            // 
            this.money.Font = new System.Drawing.Font("Quark", 10F);
            this.money.Location = new System.Drawing.Point(111, 171);
            this.money.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(232, 30);
            this.money.TabIndex = 9;
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quark", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(51, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "สถานภาพ";
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Quark", 10F);
            this.bt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt.Location = new System.Drawing.Point(267, 106);
            this.bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(91, 30);
            this.bt.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Quark", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(51, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "บุตร-ธิดา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quark", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(69, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "บุพการี";
            // 
            // fm
            // 
            this.fm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fm.Font = new System.Drawing.Font("Quark", 10F);
            this.fm.FormattingEnabled = true;
            this.fm.Items.AddRange(new object[] {
            "บิดา-มารดา (อายุ 60 ปี ขึ้นไป)",
            "บิดา หรือ มารดา (อายุเกิน 60 ปี)",
            "บิดา-มารดา (อายุไม่เกิน 60 ปี )"});
            this.fm.Location = new System.Drawing.Point(149, 151);
            this.fm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fm.Name = "fm";
            this.fm.Size = new System.Drawing.Size(199, 31);
            this.fm.TabIndex = 26;
            // 
            // moneyall
            // 
            this.moneyall.BackColor = System.Drawing.Color.Transparent;
            this.moneyall.Font = new System.Drawing.Font("Quark", 20F, System.Drawing.FontStyle.Bold);
            this.moneyall.ForeColor = System.Drawing.Color.Crimson;
            this.moneyall.Location = new System.Drawing.Point(729, 555);
            this.moneyall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moneyall.Name = "moneyall";
            this.moneyall.Size = new System.Drawing.Size(141, 79);
            this.moneyall.TabIndex = 34;
            this.moneyall.Text = "Next";
            this.moneyall.UseVisualStyleBackColor = false;
            this.moneyall.Click += new System.EventHandler(this.button1_Click);
            // 
            // stp
            // 
            this.stp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stp.Font = new System.Drawing.Font("Quark", 10F);
            this.stp.FormattingEnabled = true;
            this.stp.Items.AddRange(new object[] {
            "โสด",
            "สมรส (คู่สมรสมีรายได้)",
            "สมรส (คู่สมรส ไม่มีรายได้)"});
            this.stp.Location = new System.Drawing.Point(149, 36);
            this.stp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stp.Name = "stp";
            this.stp.Size = new System.Drawing.Size(213, 31);
            this.stp.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quark", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(4, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "ค่าอุปการะผู้พิการ";
            // 
            // pk
            // 
            this.pk.Font = new System.Drawing.Font("Quark", 10F);
            this.pk.Location = new System.Drawing.Point(160, 202);
            this.pk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pk.Name = "pk";
            this.pk.Size = new System.Drawing.Size(189, 30);
            this.pk.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quark", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(13, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 58);
            this.label4.TabIndex = 41;
            this.label4.Text = "ค่าฝากครรภ์ \r\nและค่าคลอดบุตร";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quark", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(356, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 27);
            this.label8.TabIndex = 43;
            this.label8.Text = "บาท";
            // 
            // sn
            // 
            this.sn.Font = new System.Drawing.Font("Quark", 10F);
            this.sn.Location = new System.Drawing.Point(149, 254);
            this.sn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sn.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(199, 30);
            this.sn.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.money);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Quark", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(412, 375);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  ผู้มีรายได้   ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Quark", 10F);
            this.textBox2.Location = new System.Drawing.Point(111, 96);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 30);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quark", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(35, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "ชื่อผู้ใช้";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.stp);
            this.groupBox2.Controls.Add(this.bt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.fm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pk);
            this.groupBox2.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(476, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(428, 375);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   ลดหย่อน   ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Quark", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label20.Location = new System.Drawing.Point(367, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 27);
            this.label20.TabIndex = 48;
            this.label20.Text = "คน";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Quark", 8F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label19.Location = new System.Drawing.Point(263, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 19);
            this.label19.TabIndex = 47;
            this.label19.Text = "เกิดปี 2561 ขึ้นไป";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Quark", 8F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label18.Location = new System.Drawing.Point(156, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 19);
            this.label18.TabIndex = 46;
            this.label18.Text = "เกิดก่อนปี 2561 ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Quark", 10F);
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(149, 107);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 30);
            this.numericUpDown1.TabIndex = 45;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox3.Location = new System.Drawing.Point(12, 548);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(892, 95);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(892, 104);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(916, 653);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.moneyall);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown bt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fm;
        private System.Windows.Forms.Button moneyall;
        private System.Windows.Forms.ComboBox stp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown sn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

