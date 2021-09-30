using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bis_yönetici
{
    public partial class sikayet : Form
    {
        public sikayet()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            yonlendirme yf = new yonlendirme();
            this.Hide();
            yf.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Tarih Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string aranan = gunaTextBox1.Text.ToString()+@"\";
                string tarih = gunaTextBox1.Text.ToString();

                    if (Directory.Exists(@"C:\Users\tr\Desktop\çlk2\şikayet\"+tarih))
                    {
                        DialogResult secim = MessageBox.Show("Seçtiğiniz Tarihe Ait Şikayet Bildirileri Bulundu. Klasöre Gitmek İster Misiniz?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (secim == DialogResult.OK)
                        {
                            string klasör = @"C:\Users\tr\Desktop\çlk2\şikayet\" + aranan;
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

        private void sikayet_Load(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            gunaTextBox1.Text = monthCalendar1.SelectionStart.ToString("d");
        }
    }
}
