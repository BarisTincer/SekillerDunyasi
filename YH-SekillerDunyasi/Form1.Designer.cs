namespace YH_SekillerDunyasi
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
            this.grbYeniSekil = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cboTur = new System.Windows.Forms.ComboBox();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            this.nudYuk = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudGen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.cdiRenk = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.grbYeniSekil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbYeniSekil
            // 
            this.grbYeniSekil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbYeniSekil.Controls.Add(this.label5);
            this.grbYeniSekil.Controls.Add(this.label4);
            this.grbYeniSekil.Controls.Add(this.btnEkle);
            this.grbYeniSekil.Controls.Add(this.cboTur);
            this.grbYeniSekil.Controls.Add(this.pboRenk);
            this.grbYeniSekil.Controls.Add(this.nudYuk);
            this.grbYeniSekil.Controls.Add(this.label3);
            this.grbYeniSekil.Controls.Add(this.nudGen);
            this.grbYeniSekil.Controls.Add(this.label2);
            this.grbYeniSekil.Controls.Add(this.nudY);
            this.grbYeniSekil.Controls.Add(this.label1);
            this.grbYeniSekil.Controls.Add(this.nudX);
            this.grbYeniSekil.Controls.Add(this.lblX);
            this.grbYeniSekil.Location = new System.Drawing.Point(585, 12);
            this.grbYeniSekil.Name = "grbYeniSekil";
            this.grbYeniSekil.Size = new System.Drawing.Size(504, 102);
            this.grbYeniSekil.TabIndex = 0;
            this.grbYeniSekil.TabStop = false;
            this.grbYeniSekil.Text = "Yeni Şekil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Renk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tür:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(411, 14);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 82);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cboTur
            // 
            this.cboTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTur.FormattingEnabled = true;
            this.cboTur.Items.AddRange(new object[] {
            "Dikdörtgen",
            "Elips"});
            this.cboTur.Location = new System.Drawing.Point(268, 13);
            this.cboTur.Name = "cboTur";
            this.cboTur.Size = new System.Drawing.Size(121, 21);
            this.cboTur.TabIndex = 10;
            // 
            // pboRenk
            // 
            this.pboRenk.BackColor = System.Drawing.Color.Black;
            this.pboRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboRenk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboRenk.Location = new System.Drawing.Point(268, 54);
            this.pboRenk.Name = "pboRenk";
            this.pboRenk.Size = new System.Drawing.Size(121, 20);
            this.pboRenk.TabIndex = 1;
            this.pboRenk.TabStop = false;
            this.pboRenk.Click += new System.EventHandler(this.pboRenk_Click);
            // 
            // nudYuk
            // 
            this.nudYuk.Location = new System.Drawing.Point(145, 54);
            this.nudYuk.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudYuk.Name = "nudYuk";
            this.nudYuk.Size = new System.Drawing.Size(61, 20);
            this.nudYuk.TabIndex = 7;
            this.nudYuk.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yük:";
            // 
            // nudGen
            // 
            this.nudGen.Location = new System.Drawing.Point(42, 54);
            this.nudGen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGen.Name = "nudGen";
            this.nudGen.Size = new System.Drawing.Size(61, 20);
            this.nudGen.TabIndex = 5;
            this.nudGen.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gen:";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(113, 14);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(61, 20);
            this.nudY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(26, 14);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(61, 20);
            this.nudX.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 16);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstSekiller);
            this.groupBox1.Location = new System.Drawing.Point(582, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 550);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şekiller";
            // 
            // lstSekiller
            // 
            this.lstSekiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.Location = new System.Drawing.Point(3, 16);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.Size = new System.Drawing.Size(501, 531);
            this.lstSekiller.TabIndex = 0;
            this.lstSekiller.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSekiller_KeyDown);
            // 
            // pnlCizim
            // 
            this.pnlCizim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(12, 12);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(564, 658);
            this.pnlCizim.TabIndex = 2;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            this.pnlCizim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseClick);
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(585, 673);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(87, 23);
            this.btnYukari.TabIndex = 3;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(585, 702);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(87, 23);
            this.btnAsagi.TabIndex = 4;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(972, 673);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(114, 23);
            this.btnSilme.TabIndex = 5;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 737);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.pnlCizim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbYeniSekil);
            this.Name = "Form1";
            this.Text = "Şekiller Dünyası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grbYeniSekil.ResumeLayout(false);
            this.grbYeniSekil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbYeniSekil;
        private System.Windows.Forms.NumericUpDown nudYuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox pboRenk;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cboTur;
        private System.Windows.Forms.ColorDialog cdiRenk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSekiller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnSilme;
    }
}

