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
    public partial class ItemInfoPanel : UserControl
    {
        private Form parent;
        private string captionFormat = "<div align=\"center\"><b><i>{0}</i></b></div>";

        public ItemInfoPanel() : this(null) { }

        public ItemInfoPanel(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public Form Parent_
        {
            get { return parent; }
            set { parent = value; }
        }

        private void CloseParent(object sender, EventArgs e)
        {
            if (parent != null)
                parent.Close();
        }

        public String Caption
        {
            get { return reflectionLabel1.Text; }
            set { reflectionLabel1.Text = String.Format(captionFormat, value); }
        }

        public Image Picture
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public String Detail
        {
            get { return textBoxX1.Text; }
            set { textBoxX1.Text = value; }
        }
    }
}
