namespace Hastane_Proje2
{
    partial class FrmBrans
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txbrans = new System.Windows.Forms.TextBox();
            this.txid = new System.Windows.Forms.TextBox();
            this.lblbransad = new System.Windows.Forms.Label();
            this.lblbransid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(310, 177);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btngüncelle.Location = new System.Drawing.Point(98, 168);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(121, 31);
            this.btngüncelle.TabIndex = 26;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsil.Location = new System.Drawing.Point(166, 131);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(53, 31);
            this.btnsil.TabIndex = 25;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnekle.Location = new System.Drawing.Point(98, 131);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(54, 31);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txbrans
            // 
            this.txbrans.Location = new System.Drawing.Point(98, 84);
            this.txbrans.Name = "txbrans";
            this.txbrans.Size = new System.Drawing.Size(121, 27);
            this.txbrans.TabIndex = 20;
            this.txbrans.TextChanged += new System.EventHandler(this.txbrans_TextChanged);
            // 
            // txid
            // 
            this.txid.Location = new System.Drawing.Point(98, 30);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(121, 27);
            this.txid.TabIndex = 19;
            // 
            // lblbransad
            // 
            this.lblbransad.AutoSize = true;
            this.lblbransad.Location = new System.Drawing.Point(10, 92);
            this.lblbransad.Name = "lblbransad";
            this.lblbransad.Size = new System.Drawing.Size(71, 19);
            this.lblbransad.TabIndex = 15;
            this.lblbransad.Text = "Branş Ad:";
            // 
            // lblbransid
            // 
            this.lblbransid.AutoSize = true;
            this.lblbransid.Location = new System.Drawing.Point(10, 38);
            this.lblbransid.Name = "lblbransid";
            this.lblbransid.Size = new System.Drawing.Size(68, 19);
            this.lblbransid.TabIndex = 14;
            this.lblbransid.Text = "Branş ID:";
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 223);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txbrans);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.lblbransad);
            this.Controls.Add(this.lblbransid);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txbrans;
        private System.Windows.Forms.TextBox txid;
        private System.Windows.Forms.Label lblbransad;
        private System.Windows.Forms.Label lblbransid;
    }
}