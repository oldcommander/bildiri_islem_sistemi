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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btn_sikayet_Click(object sender, EventArgs e)
        {
            complaint cmp = new complaint();
            this.Hide();
            cmp.Show();
        }

        private void btn_istek_ve_öneri_bildir_Click(object sender, EventArgs e)
        {
            suggestion_and_request sar = new suggestion_and_request();
            this.Hide();
            sar.Show();
        }
    }
}
