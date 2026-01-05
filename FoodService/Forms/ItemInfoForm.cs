using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodService.Forms
{
    public partial class ItemInfoForm : Form
    {
        public ItemInfoForm()
        {
            InitializeComponent();
            itemInfoPanel1.Parent_ = this;
        }
        public Image Picture
        {
            set { itemInfoPanel1.Picture = value; }
        }

        public String Caption
        {
            set { itemInfoPanel1.Caption = value; }
        }

        public string Detail
        {
            set { itemInfoPanel1.Detail = value; }
        }

    }
}
