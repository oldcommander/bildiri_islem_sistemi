using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bis_yönetici
{
    public partial class yonlendirme : Form
    {
        public yonlendirme()
        {
            InitializeComponent();
        }

        private void btn_sikayet_Click(object sender, EventArgs e)
        {
            sikayet şkyt = new sikayet();
            this.Hide();
            şkyt.Show();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            istek_ve_öneri iö = new istek_ve_öneri();
            this.Hide();
            iö.Show(); 
        }

        private void btn_çıkıs_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Sistemi Kapatmak Üzeresiniz. Devam Etmek İstiyor Musunuz?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (secim == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
