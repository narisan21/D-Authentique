using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDB
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            RestaurantLogin login = new RestaurantLogin();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}
