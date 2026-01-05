using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodService.Controls
{
    public partial class OrderItemControl : UserControl
    {
        private int quantity = 0;
        private double price = 0;
        private double total = 0;
        private string name = "";
        private int code = 0;
        private Model.item item;

        public OrderItemControl()
        {
            InitializeComponent();
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                this.quantity = value;
                lblQuantity.Text = String.Format("{0}", quantity);
                CalculateTotal();
            }
        }

        public string ItemName
        {
            get { return name; }
            set { this.name = value; lblName.Text = name; }
        }

        public int Codigo
        {
            get { return code; }
            set { this.code = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                lblPrice.Text = String.Format("{0:0.00}", price);
                CalculateTotal();
            }
        }

        private void CalculateTotal()
        {
            total = price * quantity;
            lblTotal.Text = String.Format("{0:0.00}", total);
        }

        public void PriceDetails(bool visible)
        {
            lblPrice.Visible = visible;
            lblTotal.Visible = visible;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        public Model.item Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
