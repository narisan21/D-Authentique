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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            Orders order = new Orders();
            order.FormClosed += (s, args) => this.Close();
            order.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_employees menu = new Menu_employees();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            customers cust = new customers();
            cust.FormClosed += (s, args) => this.Close();
            cust.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            tables table = new tables();
            table.FormClosed += (s, args) => this.Close();
            table.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Payments payment = new Payments();
            payment.FormClosed += (s, args) => this.Close();
            payment.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reservations reservation = new Reservations();
            reservation.FormClosed += (s, args) => this.Close();
            reservation.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            Logout logout = new Logout();
            logout.FormClosed += (s, args) => this.Close();
            logout.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddReservation addRes = new AddReservation();
            addRes.FormClosed += (s, args) => this.Close();
            addRes.Show();
        }
    }
}
