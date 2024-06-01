using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            IN_TXT.Parent = pictureBox1;
            IN_TXT.BackColor = Color.Transparent;

            pictureBox2_logo.Parent = pictureBox1;
            pictureBox2_logo.BackColor = Color.Transparent;

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void IN_TXT_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void admin_label_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            Hide();
        }

        private void pharmacist_button_Click(object sender, EventArgs e)
        {
            pharmacist phar = new pharmacist();
            phar.Show();
            Hide();
        }

        private void pictureBox2_logo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
