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

namespace calikDenim
{
    public partial class complaint : Form
    { int sonuc;
        MySqlConnection baglan;
        public complaint()
        {
            InitializeComponent();
        }

        private void complaint_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int first = rnd.Next(10);
            int second = rnd.Next(10);
            sonuc = first + second;
            security_label.Text = first + " + " + second + " = ";
            complaint_textbox.Text = "";

        }

        private void btn_bildir_Click(object sender, EventArgs e)
        {
            if (complaint_textbox.Text == "")
            {
                MessageBox.Show("Şikayet metni boş bırakılamaz. Lütfen yandaki alanı doldurunuz.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_cevap.Text == "")
            {
                MessageBox.Show("Güvenlik sorusu boş bırakılamaz. Lütfen doldurunuz.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_cevap.Text != sonuc.ToString())
            {
                MessageBox.Show("Güvenlik sorusuna verdiğiniz yanıt yanlış. Lütfen Tekrar deneyin.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Random rnd = new Random();
                string numara = Convert.ToString(rnd.Next(10,100));
                string tarih = String.Format("{0:dd/MM/yyyy}", DateTime.Now)+@"\";
                if (Directory.Exists(@"C:\Users\tr\Desktop\çlk2\şikayet\" + String.Format("{0:dd/MM/yyyy}", DateTime.Now)))
                {
                    string dosya_yoluu = @"C:\Users\tr\Desktop\çlk2\şikayet\"+tarih + numara + "_" + String.Format("{0:dd/MM/yyyy}", DateTime.Now) + "_şikayet.txt";
                    FileStream fss = new FileStream(dosya_yoluu, FileMode.OpenOrCreate, FileAccess.Write);

                    StreamWriter sww = new StreamWriter(fss);
                    sww.WriteLine(complaint_textbox.Text.ToString());
                    MessageBox.Show("Bildiriniz Başarıyla Alındı. Teşekkür Ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    complaint_textbox.Clear();
                    sww.Flush();
                    sww.Close();
                    fss.Close();
                }

                else
                {
                    Directory.CreateDirectory(@"C:\Users\tr\Desktop\çlk2\şikayet\" + String.Format("{0:dd/MM/yyyy}", DateTime.Now));

                    string dosya_yolu = @"C:\Users\tr\Desktop\çlk2\şikayet\"+ tarih + numara + "_" + String.Format("{0:dd/MM/yyyy}", DateTime.Now) + "_şikayet.txt";
                    FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(complaint_textbox.Text.ToString());
                    MessageBox.Show("Bildiriniz Başarıyla Alındı. Teşekkür Ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    complaint_textbox.Clear();
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
                string _server = "localhost";
                string _dbname = "bildiri_takip";
                string _user = "root";
                string _password = "Kuleli172@";

                string MySQLBağlanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

                using (baglan = new MySqlConnection(MySQLBağlanti))
                {
                    try
                    {
                        baglan.Open();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bağlantı yapılamadı.... nedeni: \n" + hata.ToString(), "Hata: " + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT*FROM clk_yonetici_girisi", baglan);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("tezkontrolsistemi@gmail.com", "Kuleli172@");

                    // sistem için oluşturulmuş mail hesabından kullanıcının hesabına veritabanındaki parolası iletilecektir.

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("tezkontrolsistemi@gmail.com", "Çalık Denim - İstek ve Öneri Bildirim Servisi");
                    mail.To.Add(dr["e_posta"].ToString());
                    mail.IsBodyHtml = true;

                    mail.Body = "Sayın " + dr["adi"].ToString() + " " + dr["soyadi"].ToString() + " Yeni bir Şikayet Bildirimi mevcut. İncelemek için lütfen " +
                        "sisteme giriş yapın";
                    mail.Subject = "Çalık Denim Tekstil A.Ş.";
                    sc.Send(mail);
                }


                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Şikayet Bildiri Ekranı kapatılacak. Devam etmek istiyor musunuz? ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (secenek == DialogResult.OK)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }

        }
    }
}
