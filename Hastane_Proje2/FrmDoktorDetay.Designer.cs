namespace Hastane_Proje2
{
    partial class FrmDoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchşikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btnbilgidüzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad Soyad:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(113, 66);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(66, 19);
            this.lbladsoyad.TabIndex = 2;
            this.lbladsoyad.Text = "Null Null";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(113, 32);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(97, 19);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchşikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchşikayet
            // 
            this.rchşikayet.Location = new System.Drawing.Point(10, 40);
            this.rchşikayet.Name = "rchşikayet";
            this.rchşikayet.Size = new System.Drawing.Size(200, 107);
            this.rchşikayet.TabIndex = 3;
            this.rchşikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(256, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 430);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(298, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnçıkış);
            this.groupBox4.Controls.Add(this.btnduyurular);
            this.groupBox4.Controls.Add(this.btnbilgidüzenle);
            this.groupBox4.Location = new System.Drawing.Point(13, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 148);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnçıkış
            // 
            this.btnçıkış.BackColor = System.Drawing.Color.SkyBlue;
            this.btnçıkış.Location = new System.Drawing.Point(20, 106);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(179, 29);
            this.btnçıkış.TabIndex = 2;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = false;
            this.btnçıkış.Click += new System.EventHandler(this.btnçıkış_Click);
            // 
            // btnduyurular
            // 
            this.btnduyurular.BackColor = System.Drawing.Color.SkyBlue;
            this.btnduyurular.Location = new System.Drawing.Point(20, 71);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(179, 29);
            this.btnduyurular.TabIndex = 1;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = false;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // btnbilgidüzenle
            // 
            this.btnbilgidüzenle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnbilgidüzenle.Location = new System.Drawing.Point(20, 36);
            this.btnbilgidüzenle.Name = "btnbilgidüzenle";
            this.btnbilgidüzenle.Size = new System.Drawing.Size(179, 29);
            this.btnbilgidüzenle.TabIndex = 0;
            this.btnbilgidüzenle.Text = "Bilgi Düzenle";
            this.btnbilgidüzenle.UseVisualStyleBackColor = false;
            this.btnbilgidüzenle.Click += new System.EventHandler(this.btnbilgidüzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 457);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.btnbilgidüzenle_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchşikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btnbilgidüzenle;
    }
}