namespace bis_yönetici
{
    partial class istek_ve_öneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(istek_ve_öneri));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tarih = new Guna.UI.WinForms.GunaTextBox();
            this.btn_ara = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_görüş_tarih = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_görüş_saat = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_kişi = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.BackgroundImage")));
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(133, 14);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(342, 62);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(543, 12);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 1;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 64);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(65, 104);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(502, 30);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "İSTEK VE ÖNERİ BİLDİRİ YÖNETİM EKRANI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.txt_tarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lütfen İstek ve Öneri Görüntülemek istediğiniz Tarihi Seçin veya Yandaki Bölüme Y" +
    "azın";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih:";
            // 
            // txt_tarih
            // 
            this.txt_tarih.BaseColor = System.Drawing.Color.White;
            this.txt_tarih.BorderColor = System.Drawing.Color.Silver;
            this.txt_tarih.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tarih.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tarih.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tarih.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tarih.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tarih.Location = new System.Drawing.Point(332, 124);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.PasswordChar = '\0';
            this.txt_tarih.SelectedText = "";
            this.txt_tarih.Size = new System.Drawing.Size(217, 51);
            this.txt_tarih.TabIndex = 4;
            // 
            // btn_ara
            // 
            this.btn_ara.AnimationHoverSpeed = 0.07F;
            this.btn_ara.AnimationSpeed = 0.03F;
            this.btn_ara.BackColor = System.Drawing.Color.Transparent;
            this.btn_ara.BaseColor = System.Drawing.Color.Navy;
            this.btn_ara.BorderColor = System.Drawing.Color.Black;
            this.btn_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ara.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ara.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ara.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Image = null;
            this.btn_ara.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ara.Location = new System.Drawing.Point(351, 220);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ara.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ara.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_ara.OnHoverImage = null;
            this.btn_ara.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ara.Radius = 20;
            this.btn_ara.Size = new System.Drawing.Size(160, 51);
            this.btn_ara.TabIndex = 5;
            this.btn_ara.Text = "ARA";
            this.btn_ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaButton2);
            this.gunaGroupBox1.Controls.Add(this.gunaButton1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.txt_kişi);
            this.gunaGroupBox1.Controls.Add(this.txt_görüş_saat);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.txt_görüş_tarih);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Yellow;
            this.gunaGroupBox1.Location = new System.Drawing.Point(29, 481);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(587, 302);
            this.gunaGroupBox1.TabIndex = 5;
            this.gunaGroupBox1.Text = "Görüşme Detayı Oluştur";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.Location = new System.Drawing.Point(21, 51);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(244, 25);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Görüşme Tarihi: (gg.aa.yyyy)";
            // 
            // txt_görüş_tarih
            // 
            this.txt_görüş_tarih.BaseColor = System.Drawing.Color.White;
            this.txt_görüş_tarih.BorderColor = System.Drawing.Color.Silver;
            this.txt_görüş_tarih.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_görüş_tarih.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_görüş_tarih.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_görüş_tarih.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_görüş_tarih.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_görüş_tarih.Location = new System.Drawing.Point(17, 91);
            this.txt_görüş_tarih.Name = "txt_görüş_tarih";
            this.txt_görüş_tarih.PasswordChar = '\0';
            this.txt_görüş_tarih.SelectedText = "";
            this.txt_görüş_tarih.Size = new System.Drawing.Size(197, 48);
            this.txt_görüş_tarih.TabIndex = 4;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel3.Location = new System.Drawing.Point(292, 51);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(283, 25);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Görüşme Yapılacak Bildiriyi Seçin";
            // 
            // txt_görüş_saat
            // 
            this.txt_görüş_saat.BaseColor = System.Drawing.Color.White;
            this.txt_görüş_saat.BorderColor = System.Drawing.Color.Silver;
            this.txt_görüş_saat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_görüş_saat.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_görüş_saat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_görüş_saat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_görüş_saat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_görüş_saat.Location = new System.Drawing.Point(17, 222);
            this.txt_görüş_saat.Name = "txt_görüş_saat";
            this.txt_görüş_saat.PasswordChar = '\0';
            this.txt_görüş_saat.SelectedText = "";
            this.txt_görüş_saat.Size = new System.Drawing.Size(197, 48);
            this.txt_görüş_saat.TabIndex = 4;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel4.Location = new System.Drawing.Point(21, 181);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(192, 25);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Görüşme Saati: (ss.dd)";
            // 
            // txt_kişi
            // 
            this.txt_kişi.BaseColor = System.Drawing.Color.White;
            this.txt_kişi.BorderColor = System.Drawing.Color.Silver;
            this.txt_kişi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kişi.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_kişi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_kişi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_kişi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kişi.Location = new System.Drawing.Point(303, 158);
            this.txt_kişi.Name = "txt_kişi";
            this.txt_kişi.PasswordChar = '\0';
            this.txt_kişi.ReadOnly = true;
            this.txt_kişi.SelectedText = "";
            this.txt_kişi.Size = new System.Drawing.Size(258, 48);
            this.txt_kişi.TabIndex = 4;
            this.txt_kişi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(355, 91);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 18;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "SEÇ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(366, 236);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Yellow;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 18;
            this.gunaButton2.Size = new System.Drawing.Size(149, 49);
            this.gunaButton2.TabIndex = 7;
            this.gunaButton2.Text = "OLUŞTUR";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // istek_ve_öneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 795);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "istek_ve_öneri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton btn_ara;
        private Guna.UI.WinForms.GunaTextBox txt_tarih;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txt_görüş_saat;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_görüş_tarih;
        private Guna.UI.WinForms.GunaTextBox txt_kişi;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}