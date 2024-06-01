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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            ADMIN_NAME.Parent = pictureBox1;
            ADMIN_NAME.BackColor = Color.Transparent;


            ADMIN_PASSWORD.Parent = pictureBox1;
            ADMIN_PASSWORD.BackColor = Color.Transparent;

            login_txt.Parent = pictureBox1;
            login_txt.BackColor = Color.Transparent;    

            as_txt.Parent = pictureBox1;
            as_txt.BackColor = Color.Transparent;

            admin_txt.Parent = pictureBox1;
            admin_txt.BackColor = Color.Transparent;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void admin_txt_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            login back = new login();
            back.Show();
            Hide();
        }
    }
}
