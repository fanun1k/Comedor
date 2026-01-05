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
    public partial class OrderPanel : UserControl
    {
        List<OrderItemControl> items = new List<OrderItemControl>();

        public delegate void OnFinalizeOrder(object sender, EventArgs ca);
        public event OnFinalizeOrder FinalizeOrder;

        public OrderPanel()
        {
            InitializeComponent();
        }


        public void AddItem(OrderItemControl item)
        {
            //item.PriceDetails(false);
            items.Add(item);
            this.pnlItems.Controls.Add(item);
        }

        public OrderItemControl FindByTag(object key)
        {
            OrderItemControl item = null;
            foreach (OrderItemControl o in items)
                if (o.Tag == key)
                {
                    item = o;
                    break;
                }
            return item;
        }

        public void CalcularTotal()
        {
            double total = 0;
            foreach (OrderItemControl o in items)
                total += o.Quantity * o.Price;
            txt_Total.Text = string.Format("{0:0.00} Bs.", total);
        }
        public void DeleteByTag(object key)
        {
            OrderItemControl item = FindByTag(key);
            items.Remove(item);
            this.pnlItems.Controls.Remove(item);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            items = new List<OrderItemControl>();
            this.pnlItems.Controls.Clear();
        }

        public void PriceDetails(bool visible)
        {
            foreach (OrderItemControl o in items)
                o.PriceDetails(visible);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                if (FinalizeOrder != null)
                    FinalizeOrder(this, null);
            }
        }

        public void Clear()
        {
            items = new List<OrderItemControl>();
            this.pnlItems.Controls.Clear();
            txt_Total.Text = "0";
        }

        public DateTime Date
        {
            get { return calendar.SelectionStart; }
        }

        public List<OrderItemControl> Items
        {
            get { return this.items; }
        }

        public void Manual()
        {
            calendar.Enabled = true;
            calendar.Visible = true;
        }

        public void Automatico()
        {
            //calendar.SetDate(Mobius.FoodService.Model.DbHelper.GetDate().Value);
            calendar.Enabled = false;
            //calendar.Visible = false;
        }
    }
}
