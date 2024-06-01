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
    public partial class pharmacist : Form
    {
        public pharmacist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PHARback_button_Click(object sender, EventArgs e)
        {
            login BACK = new login();
            BACK.Show();
            Hide();
        }

        private void pharmacist_Load(object sender, EventArgs e)
        {
            PHARMACIST_NAME.Parent = pictureBox1;
            PHARMACIST_NAME.BackColor = Color.Transparent;

            PHARMACIST_PASSWORD.Parent = pictureBox1;
            PHARMACIST_PASSWORD.BackColor = Color.Transparent;

            PHARLogin_txt.Parent = pictureBox1;
            PHARLogin_txt.BackColor = Color.Transparent;

            AS_PHAR.Parent = pictureBox1;
            AS_PHAR.BackColor = Color.Transparent;

            PHARMACIST_TXT.Parent = pictureBox1;
            PHARMACIST_TXT.BackColor = Color.Transparent;
        }
    }
}
