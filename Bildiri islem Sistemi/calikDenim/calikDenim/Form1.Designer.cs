namespace calikDenim
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
            this.btn_sikayet = new Guna.UI.WinForms.GunaTileButton();
            this.btn_istek_ve_oneri = new Guna.UI.WinForms.GunaTileButton();
            this.btn_yardim = new Guna.UI.WinForms.GunaTileButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btn_cikis = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // btn_sikayet
            // 
            this.btn_sikayet.AnimationHoverSpeed = 0.07F;
            this.btn_sikayet.AnimationSpeed = 0.03F;
            this.btn_sikayet.BackColor = System.Drawing.Color.Transparent;
            this.btn_sikayet.BaseColor = System.Drawing.Color.Transparent;
            this.btn_sikayet.BorderColor = System.Drawing.Color.Black;
            this.btn_sikayet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sikayet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sikayet.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sikayet.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sikayet.ForeColor = System.Drawing.Color.Black;
            this.btn_sikayet.Image = ((System.Drawing.Image)(resources.GetObject("btn_sikayet.Image")));
            this.btn_sikayet.ImageSize = new System.Drawing.Size(80, 90);
            this.btn_sikayet.Location = new System.Drawing.Point(33, 373);
            this.btn_sikayet.Name = "btn_sikayet";
            this.btn_sikayet.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_sikayet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sikayet.OnHoverForeColor = System.Drawing.Color.DarkRed;
            this.btn_sikayet.OnHoverImage = null;
            this.btn_sikayet.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_sikayet.Radius = 12;
            this.btn_sikayet.Size = new System.Drawing.Size(234, 242);
            this.btn_sikayet.TabIndex = 2;
            this.btn_sikayet.Text = "ŞİKAYET BİLDİR";
            this.btn_sikayet.Click += new System.EventHandler(this.btn_sikayet_Click);
            // 
            // btn_istek_ve_oneri
            // 
            this.btn_istek_ve_oneri.AnimationHoverSpeed = 0.07F;
            this.btn_istek_ve_oneri.AnimationSpeed = 0.03F;
            this.btn_istek_ve_oneri.BackColor = System.Drawing.Color.Transparent;
            this.btn_istek_ve_oneri.BaseColor = System.Drawing.Color.Transparent;
            this.btn_istek_ve_oneri.BorderColor = System.Drawing.Color.Black;
            this.btn_istek_ve_oneri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_istek_ve_oneri.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_istek_ve_oneri.FocusedColor = System.Drawing.Color.Empty;
            this.btn_istek_ve_oneri.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_istek_ve_oneri.ForeColor = System.Drawing.Color.Black;
            this.btn_istek_ve_oneri.Image = ((System.Drawing.Image)(resources.GetObject("btn_istek_ve_oneri.Image")));
            this.btn_istek_ve_oneri.ImageSize = new System.Drawing.Size(80, 80);
            this.btn_istek_ve_oneri.Location = new System.Drawing.Point(322, 373);
            this.btn_istek_ve_oneri.Name = "btn_istek_ve_oneri";
            this.btn_istek_ve_oneri.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_istek_ve_oneri.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_istek_ve_oneri.OnHoverForeColor = System.Drawing.Color.LimeGreen;
            this.btn_istek_ve_oneri.OnHoverImage = null;
            this.btn_istek_ve_oneri.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_istek_ve_oneri.Radius = 12;
            this.btn_istek_ve_oneri.Size = new System.Drawing.Size(241, 242);
            this.btn_istek_ve_oneri.TabIndex = 2;
            this.btn_istek_ve_oneri.Text = "İSTEK VE ÖNERİ BİLDİR ";
            this.btn_istek_ve_oneri.Click += new System.EventHandler(this.btn_istek_ve_oneri_Click);
            // 
            // btn_yardim
            // 
            this.btn_yardim.AnimationHoverSpeed = 0.07F;
            this.btn_yardim.AnimationSpeed = 0.03F;
            this.btn_yardim.BackColor = System.Drawing.Color.Transparent;
            this.btn_yardim.BaseColor = System.Drawing.Color.Transparent;
            this.btn_yardim.BorderColor = System.Drawing.Color.Black;
            this.btn_yardim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yardim.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_yardim.FocusedColor = System.Drawing.Color.Empty;
            this.btn_yardim.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yardim.ForeColor = System.Drawing.Color.Black;
            this.btn_yardim.Image = ((System.Drawing.Image)(resources.GetObject("btn_yardim.Image")));
            this.btn_yardim.ImageSize = new System.Drawing.Size(130, 100);
            this.btn_yardim.Location = new System.Drawing.Point(634, 373);
            this.btn_yardim.Name = "btn_yardim";
            this.btn_yardim.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_yardim.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_yardim.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_yardim.OnHoverImage = null;
            this.btn_yardim.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_yardim.Radius = 12;
            this.btn_yardim.Size = new System.Drawing.Size(217, 242);
            this.btn_yardim.TabIndex = 2;
            this.btn_yardim.Text = "YARDIM";
            this.btn_yardim.Click += new System.EventHandler(this.btn_yardim_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(231, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(421, 43);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "BİLDİRİ İŞLEM EKRANI";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.Location = new System.Drawing.Point(433, 641);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(418, 23);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Tüm Hakları Saklıdır © ÇKN Yazılım-2021       ver. 0.0.1";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.Image = null;
            this.btn_cikis.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_cikis.Location = new System.Drawing.Point(857, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.OnHoverImage = null;
            this.btn_cikis.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_cikis.Size = new System.Drawing.Size(47, 43);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btn_cikis;
            this.ClientSize = new System.Drawing.Size(916, 673);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_yardim);
            this.Controls.Add(this.btn_istek_ve_oneri);
            this.Controls.Add(this.btn_sikayet);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTileButton btn_sikayet;
        private Guna.UI.WinForms.GunaTileButton btn_istek_ve_oneri;
        private Guna.UI.WinForms.GunaTileButton btn_yardim;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaImageButton btn_cikis;
    }
}

