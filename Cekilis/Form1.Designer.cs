
namespace Cekilis
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstAdlar = new System.Windows.Forms.ListBox();
            this.btnCekilis = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.chkKaldir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(47, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 20);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAd_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(188, 16);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstAdlar
            // 
            this.lstAdlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAdlar.FormattingEnabled = true;
            this.lstAdlar.Location = new System.Drawing.Point(21, 44);
            this.lstAdlar.Name = "lstAdlar";
            this.lstAdlar.Size = new System.Drawing.Size(242, 277);
            this.lstAdlar.TabIndex = 3;
            this.lstAdlar.SelectedIndexChanged += new System.EventHandler(this.lstAdlar_SelectedIndexChanged);
            this.lstAdlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAdlar_KeyDown);
            // 
            // btnCekilis
            // 
            this.btnCekilis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCekilis.Location = new System.Drawing.Point(21, 358);
            this.btnCekilis.Name = "btnCekilis";
            this.btnCekilis.Size = new System.Drawing.Size(242, 23);
            this.btnCekilis.TabIndex = 4;
            this.btnCekilis.Text = "ÇEKİLİŞ YAP";
            this.btnCekilis.UseVisualStyleBackColor = true;
            this.btnCekilis.Click += new System.EventHandler(this.btnCekilis_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSonuc.BackColor = System.Drawing.Color.Black;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblSonuc.Location = new System.Drawing.Point(324, 16);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(424, 365);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "?";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYukari
            // 
            this.btnYukari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnYukari.BackgroundImage = global::Cekilis.Properties.Resources.up;
            this.btnYukari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYukari.Location = new System.Drawing.Point(268, 150);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(48, 36);
            this.btnYukari.TabIndex = 6;
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAsagi.BackgroundImage = global::Cekilis.Properties.Resources.down;
            this.btnAsagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsagi.Location = new System.Drawing.Point(269, 192);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(48, 36);
            this.btnAsagi.TabIndex = 7;
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // chkKaldir
            // 
            this.chkKaldir.AutoSize = true;
            this.chkKaldir.Location = new System.Drawing.Point(24, 335);
            this.chkKaldir.Name = "chkKaldir";
            this.chkKaldir.Size = new System.Drawing.Size(163, 17);
            this.chkKaldir.TabIndex = 8;
            this.chkKaldir.Text = "Çekilişte çıkanı listeden kaldır";
            this.chkKaldir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 397);
            this.Controls.Add(this.chkKaldir);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCekilis);
            this.Controls.Add(this.lstAdlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çekiliş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstAdlar;
        private System.Windows.Forms.Button btnCekilis;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.CheckBox chkKaldir;
    }
}

