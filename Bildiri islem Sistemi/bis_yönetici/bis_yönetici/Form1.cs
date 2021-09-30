using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bis_yönetici
{
    public partial class Form1 : Form
    {
        MySqlConnection baglan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Sistemi Kapatmak Üzeresiniz. Devam Etmek İstiyor Musunuz?", "Dikkat!", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(secim == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_parola.Text == "" || txt_sicilno.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanların Tamamını Doldurunuz.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sicil_no = txt_sicilno.Text.ToString();
                string parola = txt_parola.Text.ToString();

                bool yetkili_mi = false;

                string _server = "localhost";
                string _dbname = "bildiri_takip";
                string _user = "root";
                string _password = "Kuleli172@";

                string MySQLBaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

                using(baglan = new MySqlConnection(MySQLBaglanti))
                {
                    try
                    {
                        baglan.Open();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bağlantı yapılamadı... nedeni: \n" + hata.ToString(), "Hata : " + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT*FROM clk_yonetici_girisi", baglan);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (sicil_no == dr["sicil_no"].ToString() && parola == dr["parola"].ToString())
                        yetkili_mi = true;
                    break;
                }
                if (yetkili_mi == true)
                {
                    yonlendirme ynld = new yonlendirme();
                    this.Hide();
                    ynld.Show();

                }
                else
                {
                    MessageBox.Show("Hatalı Giriş. Lütfen Bilgilerinizi Kontrol Edin ve Tekrar Deneyin.", "Dikkat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txt_parola.Text = "";
                    txt_sicilno.Text = "";
                }
            }

            
        }
    }
}
