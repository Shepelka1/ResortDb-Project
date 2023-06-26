using BussinessLayer;
using DataLayer;
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
    public partial class ClientForm : Form
    {
        ResortDbContext dbContext = new ResortDbContext();
        ClientDbContext clientDbContext = new ClientDbContext();
        Client clientFromDb;


        public ClientForm()
        {
            InitializeComponent();
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                clientDbContext.Create(new Client(Name_TxtBox.Text,Phone_TxtBox.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Read_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Client searchedBar = new Client(Name_TxtBox.Text, Phone_TxtBox.Text);
                clientFromDb = dbContext.Clients.Where(x => x.Name == searchedBar.Name && x.PhoneNumber == searchedBar.PhoneNumber).First();
                if (clientFromDb != null)
                {
                    ResultLabel.Text = "Found";
                }
                else
                {
                    ResultLabel.Text = "Not Found";
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientFromDb != null)
                {
                    clientFromDb.Name = Name_TxtBox.Text;
                    clientFromDb.PhoneNumber = Phone_TxtBox.Text;
                }
                else
                {
                    ResultLabel.Text = "Error";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientFromDb != null)
                {
                    clientDbContext.Delete(clientFromDb);
                }
                else
                {
                    ResultLabel.Text = "Error";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resortDbNewDataSet1.Clients' table. You can move, or remove it, as needed.
           // this.clientsTableAdapter.Fill(this.resortDbNewDataSet1.Clients);
            // TODO: This line of code loads data into the 'resortDbNewDataSet.BarOrders' table. You can move, or remove it, as needed.
           // this.barOrdersTableAdapter.Fill(this.resortDbNewDataSet.BarOrders);
        }
    }
}
