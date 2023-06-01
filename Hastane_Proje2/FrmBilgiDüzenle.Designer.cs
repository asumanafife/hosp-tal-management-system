namespace Hastane_Proje2
{
    partial class FrmBilgiDüzenle
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
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.txsoyad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txad = new System.Windows.Forms.TextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnbilgigüncelle.Location = new System.Drawing.Point(167, 276);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(100, 42);
            this.btnbilgigüncelle.TabIndex = 7;
            this.btnbilgigüncelle.Text = "Güncelle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = false;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.btnbilgigüncelle_Click);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(167, 223);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(100, 27);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // txsoyad
            // 
            this.txsoyad.Location = new System.Drawing.Point(167, 66);
            this.txsoyad.Name = "txsoyad";
            this.txsoyad.Size = new System.Drawing.Size(100, 27);
            this.txsoyad.TabIndex = 2;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(167, 104);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(100, 27);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(66, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "TC Kimlik NO:";
            // 
            // txsifre
            // 
            this.txsifre.Location = new System.Drawing.Point(167, 184);
            this.txsifre.Name = "txsifre";
            this.txsifre.Size = new System.Drawing.Size(100, 27);
            this.txsifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cinsiyet:";
            // 
            // txad
            // 
            this.txad.Location = new System.Drawing.Point(167, 28);
            this.txad.Name = "txad";
            this.txad.Size = new System.Drawing.Size(100, 27);
            this.txad.TabIndex = 1;
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(167, 144);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(100, 27);
            this.msktelefon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ad:";
            // 
            // FrmBilgiDüzenle
            // 
            this.AcceptButton = this.btnbilgigüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 380);
            this.Controls.Add(this.btnbilgigüncelle);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.txsoyad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txad);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBilgiDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.TextBox txsoyad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txad;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}