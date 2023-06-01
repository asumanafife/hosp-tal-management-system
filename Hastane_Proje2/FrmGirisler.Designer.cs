namespace Hastane_Proje2
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhastagiris = new System.Windows.Forms.Button();
            this.btnsekretergiris = new System.Windows.Forms.Button();
            this.btndoktorgiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(283, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(503, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vladimir Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(-6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 78);
            this.label4.TabIndex = 7;
            this.label4.Text = "Simge Hastanesi";
            // 
            // btnhastagiris
            // 
            this.btnhastagiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagiris.BackgroundImage")));
            this.btnhastagiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagiris.Location = new System.Drawing.Point(28, 207);
            this.btnhastagiris.Name = "btnhastagiris";
            this.btnhastagiris.Size = new System.Drawing.Size(160, 121);
            this.btnhastagiris.TabIndex = 8;
            this.btnhastagiris.UseVisualStyleBackColor = true;
            this.btnhastagiris.Click += new System.EventHandler(this.btnhastagiris_Click);
            // 
            // btnsekretergiris
            // 
            this.btnsekretergiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergiris.BackgroundImage")));
            this.btnsekretergiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergiris.Location = new System.Drawing.Point(470, 207);
            this.btnsekretergiris.Name = "btnsekretergiris";
            this.btnsekretergiris.Size = new System.Drawing.Size(149, 121);
            this.btnsekretergiris.TabIndex = 9;
            this.btnsekretergiris.UseVisualStyleBackColor = true;
            this.btnsekretergiris.Click += new System.EventHandler(this.btnsekretergiris_Click);
            // 
            // btndoktorgiris
            // 
            this.btndoktorgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgiris.BackgroundImage")));
            this.btndoktorgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgiris.Location = new System.Drawing.Point(250, 207);
            this.btndoktorgiris.Name = "btndoktorgiris";
            this.btndoktorgiris.Size = new System.Drawing.Size(156, 121);
            this.btndoktorgiris.TabIndex = 10;
            this.btndoktorgiris.UseVisualStyleBackColor = true;
            this.btndoktorgiris.Click += new System.EventHandler(this.btndoktorgiris_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 393);
            this.Controls.Add(this.btndoktorgiris);
            this.Controls.Add(this.btnsekretergiris);
            this.Controls.Add(this.btnhastagiris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simge Hastanesi Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhastagiris;
        private System.Windows.Forms.Button btnsekretergiris;
        private System.Windows.Forms.Button btndoktorgiris;
    }
}

