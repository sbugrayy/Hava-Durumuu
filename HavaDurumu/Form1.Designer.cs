namespace HavaDurumu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.L1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.L2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.L3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB1
            // 
            resources.ApplyResources(this.TB1, "TB1");
            this.TB1.BorderColor = System.Drawing.Color.Black;
            this.TB1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB1.DefaultText = "";
            this.TB1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB1.ForeColor = System.Drawing.Color.Black;
            this.TB1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB1.Name = "TB1";
            this.TB1.PasswordChar = '\0';
            this.TB1.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB1.PlaceholderText = "";
            this.TB1.SelectedText = "";
            this.TB1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // L1
            // 
            resources.ApplyResources(this.L1, "L1");
            this.L1.BackColor = System.Drawing.Color.Transparent;
            this.L1.Name = "L1";
            // 
            // L2
            // 
            resources.ApplyResources(this.L2, "L2");
            this.L2.BackColor = System.Drawing.Color.Transparent;
            this.L2.Name = "L2";
            this.L2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // L3
            // 
            resources.ApplyResources(this.L3, "L3");
            this.L3.BackColor = System.Drawing.Color.Transparent;
            this.L3.Name = "L3";
            // 
            // guna2Button1
            // 
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::HavaDurumu.Properties.Resources.Hava_durumu;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.TB1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TB1;
        private Guna.UI2.WinForms.Guna2HtmlLabel L1;
        private Guna.UI2.WinForms.Guna2HtmlLabel L2;
        private Guna.UI2.WinForms.Guna2HtmlLabel L3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

