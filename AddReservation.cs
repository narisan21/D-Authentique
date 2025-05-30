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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddReservation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reservations reservation = new Reservations();
            reservation.FormClosed += (s, args) => this.Close();
            reservation.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reservations reservation = new Reservations();
            reservation.FormClosed += (s, args) => this.Close();
            reservation.Show();
        }
    }
}
