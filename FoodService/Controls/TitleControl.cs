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
    public partial class TitleControl : UserControl
    {
        String name = "category";
        public TitleControl()
        {
            InitializeComponent();
        }

        public String Title
        {
            get { return name; }
            set
            {
                name = value;
                label1.Text = name;
            }
        }
    }
}
