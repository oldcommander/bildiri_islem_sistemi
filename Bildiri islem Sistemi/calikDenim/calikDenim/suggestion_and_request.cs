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
    
    public partial class suggestion_and_request : Form
    {
        MySqlConnection baglan;
     

        public suggestion_and_request()
        {
            InitializeComponent();
        }

       
        
        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void gunaRadioButton2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void gunaRadioButton1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void suggestion_and_request_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

        }


        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("İstek ve Öneri Bildiri Ekranı kapatılacak. Devam etmek istiyor musunuz?","Dikkat!",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (secim == DialogResult.OK)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
        }

        private void btn_bildir_Click(object sender, EventArgs e)
        {
            bool personel_kontrol = false;
            if (richTextBox1.Text == "")
            {
                    MessageBox.Show("İstek ve Öneri metni boş bırakılamaz. Lütfen yandaki alanı doldurun.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);  

            }
            else if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_sicilno.Text == "")

            {
                MessageBox.Show("Lütfen kişisel bilgileriniz ile ilgili alanın tamamını doldurun.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (gunaRadioButton1.Checked == false)
            {
                if (gunaRadioButton2.Checked == false)
                {

                    MessageBox.Show("Lütfen görevinizi seçin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string scl = txt_sicilno.Text.ToString();
                    string ad = txt_ad.Text.ToString();
                    string soyad = txt_soyad.Text.ToString();

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
                    MySqlCommand cmd = new MySqlCommand("SELECT*FROM clk_misafir", baglan);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    

                    while (dr.Read())
                    {
                        if (scl == dr["ziyaretci_no"].ToString() && ad == dr["adi"].ToString() && soyad == dr["soyadi"].ToString())
                        {
                            personel_kontrol = true;
                            break;
                        }
                    }
                    baglan.Close();
                    string tarih = String.Format("{0:dd/MM/yyyy}", DateTime.Now) + @"\";
                    if (personel_kontrol == true)
                    {
                        if (Directory.Exists(@"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + String.Format("{0:dd/MM/yyyy}", DateTime.Now)))
                        {

                            string dosya_yolu = @"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\"+tarih + txt_sicilno.Text.ToString() + "_" + String.Format("{0:dd/MM/yyyy}", monthCalendar1.TodayDate) + "_istek_ve_öneri.txt";
                            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(richTextBox1.Text.ToString());
                            MessageBox.Show("Bildiriniz Başarıyla Alındı. Teşekkür Ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            richTextBox1.Clear();
                            sw.Flush();
                            sw.Close();
                            fs.Close();
                        }
                        else
                        {
                            Directory.CreateDirectory(@"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + String.Format("{0:dd/MM/yyyy}", DateTime.Now));
                            string dosya_yolu = @"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + tarih + txt_sicilno.Text.ToString() + "_" + String.Format("{0:dd/MM/yyyy}", monthCalendar1.TodayDate) + "_istek_ve_öneri.txt";
                            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(richTextBox1.Text.ToString());
                            MessageBox.Show("Bildiriniz Başarıyla Alındı. Teşekkür Ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            richTextBox1.Clear();
                            sw.Flush();
                            sw.Close();
                            fs.Close();

                        }

                        Form1 frm = new Form1();
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz verilere ait misafir bilgisi bulunamadı. Lütfen Kontrol edip tekrar deneyin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                string scl = txt_sicilno.Text.ToString();
                string ad = txt_ad.Text.ToString();
                string soyad = txt_soyad.Text.ToString();

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
                MySqlCommand cmd = new MySqlCommand("SELECT*FROM clk_personel", baglan);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (scl == dr["sicil_no"].ToString() && ad == dr["adi"].ToString() && soyad == dr["soyadi"].ToString())
                    {
                        personel_kontrol = true;
                        break;
                    }
                }
                baglan.Close();
                string tarihh = String.Format("{0:dd/MM/yyyy}", DateTime.Now) + @"\";
                if (personel_kontrol == true)
                {

                    if (Directory.Exists(@"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + String.Format("{0:dd/MM/yyyy}", DateTime.Now)))
                    {

                        string dosya_yolu = @"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + tarihh + txt_sicilno.Text.ToString() + "_" + String.Format("{0:dd/MM/yyyy}", monthCalendar1.TodayDate) + "_istek_ve_öneri.txt";
                        FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(richTextBox1.Text.ToString());
                        MessageBox.Show("Bildiriniz Başarıyla Alındı. Teşekkür Ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        richTextBox1.Clear();
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + String.Format("{0:dd/MM/yyyy}", DateTime.Now));
                        string dosya_yolu = @"C:\Users\tr\Desktop\çlk2\istek_ve_öneri\" + tarihh + txt_sicilno.Text.ToString() + "_" + String.Format("{0:dd/MM/yyyy}", monthCalendar1.TodayDate) + "_istek_ve_öneri.txt";
                        FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(richTextBox1.Text.ToString());
                        MessageBox.Show("Bildiriniz Başarıyla Alındı. Teşekkür Ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        richTextBox1.Clear();
                        sw.Flush();
                        sw.Close();
                        fs.Close();

                    }
                    string __server = "localhost";
                    string __dbname = "bildiri_takip";
                    string __user = "root";
                    string __password = "Kuleli172@";

                    string MySQLBağlantii = $"SERVER={__server};DATABASE={__dbname};UID={__user};PWD={__password}";

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
                    MySqlCommand cmdd = new MySqlCommand("SELECT*FROM clk_yonetici_girisi", baglan);
                    MySqlDataReader drr = cmdd.ExecuteReader();

                    while (drr.Read())
                    {
                        SmtpClient sc = new SmtpClient();
                        sc.Port = 587;
                        sc.Host = "smtp.gmail.com";
                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential("tezkontrolsistemi@gmail.com", "Kuleli172@");

                        // sistem için oluşturulmuş mail hesabından kullanıcının hesabına veritabanındaki parolası iletilecektir.

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("tezkontrolsistemi@gmail.com", "Çalık Denim - İstek ve Öneri Bildirim Servisi");
                        mail.To.Add(drr["e_posta"].ToString());
                        mail.IsBodyHtml = true;

                        mail.Body = "Sayın " + drr["adi"].ToString() + " " + drr["soyadi"].ToString() + " Yeni bir İstek ve Öneri Bildirimi mevcut. İncelemek için lütfen " +
                            "sisteme giriş yapın";
                        mail.Subject = "Çalık Denim Tekstil A.Ş.";
                        sc.Send(mail);
                        break;
                    }

                    Form1 frm = new Form1();
                    this.Hide();
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("Girdiğiniz verilere ait personel bilgisi bulunamadı. Lütfen Kontrol edip tekrar deneyin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             
        }
    }
}
