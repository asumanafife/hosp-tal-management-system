namespace Hastane_Proje2
{
    partial class FrmDoktorBilgiDüzenle
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
            this.txsoyad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txsoyad
            // 
            this.txsoyad.Location = new System.Drawing.Point(168, 105);
            this.txsoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txsoyad.Name = "txsoyad";
            this.txsoyad.Size = new System.Drawing.Size(138, 30);
            this.txsoyad.TabIndex = 37;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(168, 151);
            this.msktc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(138, 30);
            this.msktc.TabIndex = 36;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "TC Kimlik NO:";
            // 
            // txsifre
            // 
            this.txsifre.Location = new System.Drawing.Point(168, 242);
            this.txsifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txsifre.Name = "txsifre";
            this.txsifre.Size = new System.Drawing.Size(138, 30);
            this.txsifre.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Şifre:";
            // 
            // txad
            // 
            this.txad.Location = new System.Drawing.Point(168, 59);
            this.txad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txad.Name = "txad";
            this.txad.Size = new System.Drawing.Size(138, 30);
            this.txad.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ad:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(168, 199);
            this.cmbbrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(138, 31);
            this.cmbbrans.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Branş:";
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btngüncelle.Location = new System.Drawing.Point(167, 292);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(139, 53);
            this.btngüncelle.TabIndex = 40;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 403);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.txsoyad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txsoyad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngüncelle;
    }
}