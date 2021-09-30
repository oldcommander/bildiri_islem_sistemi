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
    public partial class system_load : Form
    {
        int start_time = 0;
        public system_load()
        {
            InitializeComponent();
        }

        private void system_load_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.timer1.Interval = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start_time += 1;
            bunifuCircleProgressbar1.Value = start_time;

            if (bunifuCircleProgressbar1.Value == 100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
        }
    }
}
