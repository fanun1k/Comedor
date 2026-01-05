using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodService.Forms;

namespace FoodService.Controls
{
    public partial class ItemUI : UserControl
    {
        public delegate void OnItemEnter(object sender, EventArgs ca);
        public event OnItemEnter ItemEnter;

        public delegate void OnItemSelectChanged(object sender, EventArgs ea);
        public event OnItemSelectChanged ItemSelectChanged;

        public delegate void OnQuantityChanged(object sender, EventArgs ca);
        public event OnQuantityChanged QuantityChanged;

        private int count = 0;
        private bool selected = false;
        private string itemName = "Sopa De Mani";
        private int codigo;
        private double precio;
        Image image;
        private Model.Item _item;

        String formatItemName = "<div align=\"center\"><b><font size=\"+2\r\n\"><i>{0}</i></font></b></div>";

        public ItemUI()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int old = Quantity;
            Quantity = (Quantity <= 0) ? 1 : count + 1;
            //txtQuantity.Text = String.Format("{0:00}", count);
            //txtQuantity.Visible = true;
            if (old != Quantity)
                QuantityChanged(this, null);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //this.btnDown.Checked = false;
            int old = Quantity;
            if (IsSelected())
                Quantity = (Quantity <= 1) ? 1 : Quantity - 1;
            else
                Quantity = (Quantity <= 0) ? 0 : Quantity - 1;
            //txtQuantity.Text = String.Format("{0:00}", count);
            //txtQuantity.Visible = (count > 0);
            if (old != Quantity)
                QuantityChanged(this, null);
            //this.btnDown.Checked = true;
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

            selected = !selected;


            if (selected)
            {
                this.groupPanel1.Style.BackColor = System.Drawing.Color.White;
                this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
                Quantity = (Quantity < 1) ? 1 : Quantity;
                lblName.ForeColor = Color.White;
                //txtQuantity.Text = String.Format("{0:00}", count);
                //txtQuantity.Visible = true;
                ControlsVisible = true;
            }
            else
            {
                this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
                this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
                lblName.ForeColor = Color.Black;
                Quantity = 0;
                //txtQuantity.Text = String.Format("{0:00}", count);
                //txtQuantity.Visible = false;
                ControlsVisible = false;
            }

            if (ItemSelectChanged != null)
                ItemSelectChanged(this, null);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (_item != null)
            {
                ItemInfoForm info = new ItemInfoForm();

                info.Picture = _item.Imagen != null
                    ? _item.Imagen.ToImage()               // 👈 conversión aquí
                    : panelEx1.Style.BackgroundImage;

                info.Caption = item.nombre;

                info.Detail = !string.IsNullOrEmpty(item.descripcion)
                    ? item.descripcion
                    : "Sin Descripción";

                info.ShowDialog(this);
            }
        }

        private void panelEx1_MouseEnter(object sender, EventArgs e)
        {
            if (ItemEnter != null)
            {
                ItemEnter(this, null);
                //if (IsSelected() && !this.ControlsVisible)
            }
            this.ControlsVisible = true;

        }

        public bool ControlsVisible
        {
            get { return this.btnInfo.Visible; }
            set
            {
                btnUp.Visible = IsSelected() && value;
                btnDown.Visible = IsSelected() && value;
                this.btnInfo.Visible = value;
            }
        }

        public int Codigo
        {
            get { return codigo; }
            set
            {
                codigo = value;
                this.Tag = codigo;
            }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                LBL_PRECIO.Text = string.Format("{0:#.00}", precio);
            }
        }

        public String ItemName
        {
            get { return itemName; }
            set
            {
                this.itemName = value;
                lblName.Text = String.Format(formatItemName, this.itemName);
            }
        }

        public bool IsSelected()
        {
            return selected;
        }

        public void SelectItem(bool value)
        {
            this.selected = value;

            if (selected)
            {
                this.groupPanel1.Style.BackColor = System.Drawing.Color.White;
                this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
                Quantity = (Quantity < 1) ? 1 : Quantity;
                lblName.ForeColor = Color.White;
                //txtQuantity.Text = String.Format("{0:00}", count);
                //txtQuantity.Visible = true;
                ControlsVisible = true;
            }
            else
            {
                this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
                this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
                lblName.ForeColor = Color.Black;
                Quantity = 0;
                //txtQuantity.Text = String.Format("{0:00}", count);
                //txtQuantity.Visible = false;
                ControlsVisible = false;
            }

        }

        public int Quantity
        {
            get { return count; }
            set
            {
                count = (value < 1) ? 0 : value;
                txtQuantity.Text = String.Format("{0:00}", count);
                txtQuantity.Visible = (count > 0);
            }
        }


        [Description("Set Image For Dish"), Category("Appearance"), DefaultValue(""), Browsable(true)]
        public Image Image
        {
            get { return image; }
            set
            {
                image = value;
                this.panelEx1.Style.BackgroundImage = image;
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (ItemEnter != null)
                ItemEnter(this, null);
            //if (IsSelected() && !this.ControlsVisible)
            this.ControlsVisible = true;
        }

        public Model.Item item
        {
            get { return _item; }
            set { _item = value; }
        }
    }
}
