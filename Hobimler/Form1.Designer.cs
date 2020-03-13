namespace Hobimler
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
            this.lstHobiler = new System.Windows.Forms.ListBox();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cboHobiler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstHobiler
            // 
            this.lstHobiler.DisplayMember = "HobiAd";
            this.lstHobiler.FormattingEnabled = true;
            this.lstHobiler.Location = new System.Drawing.Point(213, 87);
            this.lstHobiler.Name = "lstHobiler";
            this.lstHobiler.Size = new System.Drawing.Size(172, 225);
            this.lstHobiler.TabIndex = 0;
            this.lstHobiler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstHobiler_KeyDown);
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.DisplayMember = "OgrenciAd";
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.Location = new System.Drawing.Point(35, 87);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(172, 225);
            this.lstOgrenciler.TabIndex = 1;
            this.lstOgrenciler.SelectedIndexChanged += new System.EventHandler(this.lstOgrenciler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(35, 48);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cboHobiler
            // 
            this.cboHobiler.DisplayMember = "HobiAd";
            this.cboHobiler.FormattingEnabled = true;
            this.cboHobiler.Location = new System.Drawing.Point(116, 48);
            this.cboHobiler.Name = "cboHobiler";
            this.cboHobiler.Size = new System.Drawing.Size(121, 21);
            this.cboHobiler.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 364);
            this.Controls.Add(this.cboHobiler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.lstHobiler);
            this.Name = "Form1";
            this.Text = "Hobilerimiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHobiler;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cboHobiler;
    }
}

