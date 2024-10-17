using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form.Properties
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

       

        private void home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }
    }
}
