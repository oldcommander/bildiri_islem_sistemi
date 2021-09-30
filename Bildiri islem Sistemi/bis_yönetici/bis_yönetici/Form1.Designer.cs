namespace bis_yönetici
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_parola = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_sicilno = new Guna.UI.WinForms.GunaTextBox();
            this.btn_giris = new Guna.UI.WinForms.GunaButton();
            this.btn_cikis = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.Location = new System.Drawing.Point(59, 447);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(409, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tüm hakları saklıdır © ÇKN Yazılım-2021      ver. 0.0.1";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.BackgroundImage")));
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(117, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(313, 56);
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(130, 87);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(269, 29);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "BİLDİRİ İŞLEM SİSTEMİ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.txt_sicilno);
            this.groupBox1.Controls.Add(this.txt_parola);
            this.groupBox1.Controls.Add(this.gunaLabel4);
            this.groupBox1.Controls.Add(this.gunaLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sicil Numaranızı ve Parolanızı Aşağıdaki Alana Giriniz";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel3.Location = new System.Drawing.Point(26, 171);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(84, 23);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Parolanız";
            // 
            // txt_parola
            // 
            this.txt_parola.BaseColor = System.Drawing.Color.White;
            this.txt_parola.BorderColor = System.Drawing.Color.Silver;
            this.txt_parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_parola.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_parola.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_parola.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_parola.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_parola.Location = new System.Drawing.Point(26, 204);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.PasswordChar = '*';
            this.txt_parola.SelectedText = "";
            this.txt_parola.Size = new System.Drawing.Size(269, 42);
            this.txt_parola.TabIndex = 1;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel4.Location = new System.Drawing.Point(26, 55);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(138, 23);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Sicil Numaranız";
            // 
            // txt_sicilno
            // 
            this.txt_sicilno.BaseColor = System.Drawing.Color.White;
            this.txt_sicilno.BorderColor = System.Drawing.Color.Silver;
            this.txt_sicilno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sicilno.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_sicilno.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_sicilno.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_sicilno.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sicilno.Location = new System.Drawing.Point(26, 90);
            this.txt_sicilno.Name = "txt_sicilno";
            this.txt_sicilno.PasswordChar = '\0';
            this.txt_sicilno.SelectedText = "";
            this.txt_sicilno.Size = new System.Drawing.Size(269, 40);
            this.txt_sicilno.TabIndex = 1;
            // 
            // btn_giris
            // 
            this.btn_giris.AnimationHoverSpeed = 0.07F;
            this.btn_giris.AnimationSpeed = 0.03F;
            this.btn_giris.BackColor = System.Drawing.Color.Transparent;
            this.btn_giris.BaseColor = System.Drawing.Color.Navy;
            this.btn_giris.BorderColor = System.Drawing.Color.Black;
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_giris.FocusedColor = System.Drawing.Color.Empty;
            this.btn_giris.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Image = null;
            this.btn_giris.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_giris.Location = new System.Drawing.Point(337, 204);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_giris.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_giris.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_giris.OnHoverImage = null;
            this.btn_giris.OnPressedColor = System.Drawing.Color.Black;
            this.btn_giris.Radius = 17;
            this.btn_giris.Size = new System.Drawing.Size(121, 42);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cikis.Image = null;
            this.btn_cikis.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_cikis.Location = new System.Drawing.Point(479, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.OnHoverImage = null;
            this.btn_cikis.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_cikis.Size = new System.Drawing.Size(50, 56);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 479);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton btn_giris;
        private Guna.UI.WinForms.GunaTextBox txt_sicilno;
        private Guna.UI.WinForms.GunaTextBox txt_parola;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaImageButton btn_cikis;
    }
}

