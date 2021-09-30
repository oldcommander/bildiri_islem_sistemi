using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bis_yönetici
{
    public partial class istek_ve_öneri : Form
    {
        string isim;
        MySqlConnection baglan;
        public istek_ve_öneri()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            yonlendirme yf = new yonlendirme();
            this.Hide();
            yf.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_tarih.Text = monthCalendar1.SelectionStart.ToString("d");
            txt_görüş_tarih.Text = monthCalendar1.SelectionStart.ToString("d");
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_tarih.Text == "")
            {
                MessageBox.Show("Lütfen Bir Tarih Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string aranan = txt_tarih.Text.ToString() + @"\";
                string tarih = txt_tarih.Text.ToString();

                if (Directory.Exists(@"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + tarih))
                {
                    DialogResult secim = MessageBox.Show("Seçtiğiniz Tarihe Ait İstek ve Öneri Bildirileri Bulundu. Klasöre Gitmek İster Misiniz?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (secim == DialogResult.OK)
                    {
                        string klasör = @"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + aranan;
                        System.Diagnostics.Process islem = new System.Diagnostics.Process();
                        islem.StartInfo.FileName = klasör;
                        islem.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Tarihe Ait Şikayet Bildirisi Bulunamadı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {


            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Lütfen Bir Adet txt Dosyası Seçin";
            file.Multiselect = false;

            if(file.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = file.FileName;
                string dosya_adı = file.SafeFileName;

                 isim = dosya_adı.Substring(0,7);
                txt_kişi.Text = isim;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (txt_görüş_saat.Text == "")
            {
                MessageBox.Show("Lütfen Görüşme Saatini Belirleyin.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_görüş_tarih.Text == "")
            {
                MessageBox.Show("Lütfen Görüşme Tarihini Belirleyin.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_kişi.Text == "")
            {
                MessageBox.Show("Lütfen Görüşülecek Bildiriyi Seçin.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool sayi_mi(string text)
                {
                    bool sonuç = true;
                    if (!char.IsDigit(text[0]))
                    {
                        sonuç = false;

                    }
                    return sonuç;
                }
                if (sayi_mi(txt_kişi.Text) == true)
                {
                    string _server = "localhost";
                    string _dbname = "bildiri_takip";
                    string _user = "root";
                    string _password = "Kuleli172@";

                    string MySQLbaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

                    using (baglan = new MySqlConnection(MySQLbaglanti))
                    {
                        try
                        {
                            baglan.Open();
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Bağlantı yapılamadı... nedeni: \n" + hata.ToString(), "Hata: " + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    baglan.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT*FROM clk_personel", baglan);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (isim == dr["sicil_no"].ToString())
                        {

                            SmtpClient sc = new SmtpClient();
                            sc.Port = 587;
                            sc.Host = "smtp.gmail.com";
                            sc.EnableSsl = true;
                            sc.Credentials = new NetworkCredential("tezkontrolsistemi@gmail.com", "Kuleli172@");

                            // sistem için oluşturulmuş mail hesabından kullanıcının hesabına veritabanındaki parolası iletilecektir.

                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("tezkontrolsistemi@gmail.com", "Çalık Denim - İstek ve Öneri Geri Bildirim Servisi");
                            mail.To.Add(dr["e_posta"].ToString());
                            mail.IsBodyHtml = true;

                            mail.Body = "Sayın " + dr["adi"].ToString() + " " + dr["soyadi"].ToString() + " Yapmış olduğunuz İstek ve Öneri bildiriminiz için teşekkür ederiz." +
                                " Sizi " + txt_görüş_tarih.Text + " tarihinde ve " + txt_görüş_saat.Text + " saatinde görüşlerinizi almak için kurumumuza bekliyoruz. " +
                                "Yapmış olduğunuz katkılardan dolayı teşekkür ederiz." + "     Saygılarımızla.";
                            mail.Subject = "Çalık Denim Tekstil A.Ş.";
                            sc.Send(mail);

                        }
                        break;
                    }
                    DialogResult secim = MessageBox.Show("Görüşme maili ilgili misafire iletilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (secim == DialogResult.OK)
                    {
                        txt_görüş_saat.Text = "";
                        txt_görüş_tarih.Text = "";
                        txt_kişi.Text = "";
                        txt_tarih.Text = "";
                    }
                }
                else
                {
                    string _server = "localhost";
                    string _dbname = "bildiri_takip";
                    string _user = "root";
                    string _password = "Kuleli172@";

                    string MySQLbaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

                    using (baglan = new MySqlConnection(MySQLbaglanti))
                    {
                        try
                        {
                            baglan.Open();
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Bağlantı yapılamadı... nedeni: \n" + hata.ToString(), "Hata: " + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    baglan.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT*FROM clk_misafir", baglan);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (isim == dr["ziyaretci_no"].ToString())
                        {

                            SmtpClient sc = new SmtpClient();
                            sc.Port = 587;
                            sc.Host = "smtp.gmail.com";
                            sc.EnableSsl = true;
                            sc.Credentials = new NetworkCredential("tezkontrolsistemi@gmail.com", "tezkontrol");

                            // sistem için oluşturulmuş mail hesabından kullanıcının hesabına veritabanındaki parolası iletilecektir.

                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("tezkontrolsistemi@gmail.com", "Çalık Denim - İstek ve Öneri Geri Bildirim Servisi");
                            mail.To.Add(dr["e_posta"].ToString());
                            mail.IsBodyHtml = true;

                            mail.Body = "Sayın " + dr["adi"].ToString() + " " + dr["soyadi"].ToString() + " Yapmış olduğunuz İstek ve Öneri bildiriminiz için teşekkür ederiz." +
                                " Sizi " + txt_görüş_tarih.Text + " tarihinde ve " + txt_görüş_saat.Text + " saatinde görüşlerinizi almak için kurumumuza bekliyoruz. " +
                                "Yapmış olduğunuz katkılardan dolayı teşekkür ederiz." + "     Saygılarımızla.";
                            mail.Subject = "Çalık Denim Tekstil A.Ş.";
                            sc.Send(mail);
                        }
                        break;
                    }

                  DialogResult secim =  MessageBox.Show("Görüşme maili ilgili misafire iletilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (secim == DialogResult.OK)
                    {
                        txt_görüş_saat.Text = "";
                        txt_görüş_tarih.Text = "";
                        txt_kişi.Text = "";
                        txt_tarih.Text = "";
                    }

                }
            }
        }
    }
}
