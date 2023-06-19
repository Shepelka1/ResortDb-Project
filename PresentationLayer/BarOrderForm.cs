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
    public partial class BarOrderForm : Form
    {
        ResortDbContext dbContext = new ResortDbContext();
        BarOrderDbContext barOrderDbContext = new BarOrderDbContext();
        BarOrder orderFromDb;

        public BarOrderForm()
        {
            InitializeComponent();
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                barOrderDbContext.Create(new BarOrder(BarDatePick.Value, decimal.Parse(PriceTBox.Text)));
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
                BarOrder searchedBar = new BarOrder(BarDatePick.Value, decimal.Parse(PriceTBox.Text));
                orderFromDb = dbContext.BarOrders.Where(x => x.TotalPrice == searchedBar.TotalPrice && x.OrderDate == searchedBar.OrderDate).First();
                if(orderFromDb != null)
                {
                    ResultLabel.Text = "Found";
                } else
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
                if(orderFromDb != null)
                {
                    orderFromDb.TotalPrice = decimal.Parse(PriceTBox.Text);
                    orderFromDb.OrderDate = BarDatePick.Value;
                } else
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
                if (orderFromDb != null)
                {
                    barOrderDbContext.Delete(orderFromDb);
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

        private void BarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BarOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resortDbNewDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.resortDbNewDataSet1.Clients);
            // TODO: This line of code loads data into the 'resortDbNewDataSet.BarOrders' table. You can move, or remove it, as needed.
            this.barOrdersTableAdapter.Fill(this.resortDbNewDataSet.BarOrders);

        }
    }
}
