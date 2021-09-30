using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calikDenim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_istek_ve_oneri_Click(object sender, EventArgs e)
        {
            suggestion_and_request sar = new suggestion_and_request();
            this.Hide();
            sar.Show();
        }

        private void btn_sikayet_Click(object sender, EventArgs e)
        {
            complaint cmp = new complaint();
            this.Hide();
            cmp.Show();
        }

        private void btn_yardim_Click(object sender, EventArgs e)
        {
            help hlp = new help();
            this.Hide();
            hlp.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
         DialogResult secenek =  MessageBox.Show("Sistemi kapatmak üzeresiniz. Devam etmek istiyor musunuz?","DİKKAT!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (secenek == DialogResult.OK)
            {
                this.Close();
            }

        }
    }
}
