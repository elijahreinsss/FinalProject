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
    public partial class admin_main_menu : Form
    {
        public admin_main_menu()
        {
            InitializeComponent();
        }

        private void Inventory_BTN_Click(object sender, EventArgs e)
        {

        }

        private void User_Management_BTN_Click(object sender, EventArgs e)
        {
            usermanagement usermanagement = new usermanagement();
            usermanagement.Show();
        }

        private void Supplier_Management_Click(object sender, EventArgs e)
        {

        }
    }
}
