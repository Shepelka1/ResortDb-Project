using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainMenuForm : Form
    {

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BarOrder_Btn_Click(object sender, EventArgs e)
        {
            BarOrderForm barOrderForm = new BarOrderForm();
            barOrderForm.ShowDialog();
            this.Close();
        }

        private void Client_Btn_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
            this.Close();
        }

        private void RestaurantOrder_Btn_Click(object sender, EventArgs e)
        {
            RestaurantOrderForm restaurantOrderForm = new RestaurantOrderForm();
            restaurantOrderForm.ShowDialog();
            this.Close();
        }

        private void RoomReservation_Btn_Click(object sender, EventArgs e)
        {
            RoomReservationForm roomReservationForm = new RoomReservationForm();
            roomReservationForm.ShowDialog();
            this.Close();
        }

        private void SpaSession_Btn_Click(object sender, EventArgs e)
        {
            SpaSessionForm spaSessionForm = new SpaSessionForm();
            spaSessionForm.ShowDialog();
            this.Close();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
