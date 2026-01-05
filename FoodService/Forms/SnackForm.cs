using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FoodService.Controls;
using Model;
//using Extensions;

namespace FoodService.Forms
{
    public partial class SnackForm: DevComponents.DotNetBar.Office2007Form
    {
        public static readonly int TOUCH = 0;
        public static readonly int AUTOMATICO = 1;
        public static readonly int MANUAL = 2;

        private ItemUI itemSelected;
        private OrderPanel orderPanel;
        private int tipo;
        private item item;
        private ItemService itemService;
        public SnackForm(ItemService _itemService)
        {
            InitializeComponent();
            itemService = _itemService;
            
        }
        public void Init(OrderPanel op,int tipo)
        {
            itemSelected = null;
            orderPanel = op;
            if (tipo == MANUAL)
            {
                this.tipo = tipo;
                lbl_title.Text = "REGISTRO MANUAL";
                orderPanel.Manual();
            }
            else
            {
                this.tipo = AUTOMATICO;
                lbl_title.Text = "";
                orderPanel.Automatico();
            }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private void item1_Load(object sender, EventArgs e)
        {

        }

        private void item1_onItemEnter(object sender, EventArgs ca)
        {
            if (itemSelected != null)// && !itemSelected.IsSelected())
            {
                itemSelected.ControlsVisible = false;
                if(!itemSelected.IsSelected())
                    itemSelected.Quantity = 0;
            } 
            itemSelected = (ItemUI)sender; 
        }

        private void item_onSelectChanged(object sender, EventArgs ca)
        {
            if (itemSelected != null)
                itemSelected.ControlsVisible = false;
            itemSelected = (ItemUI)sender;
            
            //OrderPanel tb = (OrderPanel)orderPanel.Controls[0];
            if (itemSelected.IsSelected())
            {
                OrderItemControl item = new OrderItemControl();
                item.ItemName = itemSelected.ItemName;
                item.Quantity = itemSelected.Quantity;
                item.Price = itemSelected.Precio;
                item.Tag = itemSelected.Tag;
                item.Item = itemSelected.item;
                orderPanel.AddItem(item);
                orderPanel.CalcularTotal();
                if(!itemSelected.ControlsVisible)
                  itemSelected.ControlsVisible = true;
            }
            else
            {
                orderPanel.DeleteByTag(itemSelected.Tag);
                if (itemSelected.ControlsVisible)
                    itemSelected.ControlsVisible = false;
                orderPanel.CalcularTotal();
            }
        }

        public void item_onQuantityChanged(object sender, EventArgs ca)
        {
             ItemUI item = (ItemUI)sender;
             if (item.IsSelected())
             {
                 OrderItemControl o = orderPanel.FindByTag(item.Tag);
                 if (o != null)
                 {
                     o.Quantity = item.Quantity;
                     orderPanel.CalcularTotal();
                 }
             }
        }

        public void AddItem(ItemUI item)
        {
            item.ItemEnter += item1_onItemEnter;
            item.ItemSelectChanged += item_onSelectChanged;
            item.QuantityChanged += item_onQuantityChanged;
            this.flowLayoutPanel1.Controls.Add(item);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemUI item = new ItemUI();
            item.Tag = DateTime.Now.ToString("yyyyMMddhhmmssff");
            
            AddItem(item);
            this.flowLayoutPanel1.Focus();
            //TestControl c = new TestControl();
            //this.flowLayoutPanel1.Controls.Add(c);
        }

        public void SelectAll(Boolean value)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
                if (c is ItemUI)
                    ((ItemUI)c).SelectItem(value);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
           
            lbl_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            List<item> _items =itemService.GetByAll();
            foreach (var item in _items)
            {
                ItemUI i = new ItemUI();
                i.ItemName = item.nombre;
                i.Precio = item.precio;
                i.Codigo = item.id;
                i.item = item;
                i.SelectItem(false);
                i.Image = item.imagen.ToImage();
                AddItem(i);
            }

        }

        public void RegisterInfo(String info)
        {
            lbl_RegisterInfo.Text = info;
        }

        public void SetTipo(int tipo)
        {
            if (this.tipo == tipo)
                return;
            orderPanel.Clear();
            this.SelectAll(false);
            if (tipo == MANUAL)
            {
                this.tipo = tipo;
                lbl_title.Text = "REGISTRO MANUAL";
                orderPanel.Manual();
            }
            else
            {
                this.tipo = AUTOMATICO;
                lbl_title.Text = "";
                orderPanel.Automatico();
            }
        }
    }
}