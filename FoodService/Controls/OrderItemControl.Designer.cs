using FoodService.Properties;

namespace FoodService.Controls
{
    partial class OrderItemControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItemControl));
            lblQuantity = new Label();
            lblName = new Label();
            lblTotal = new Label();
            lblPrice = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.Dock = DockStyle.Left;
            lblQuantity.Location = new Point(2, 2);
            lblQuantity.Margin = new Padding(6, 6, 6, 6);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(33, 18);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "00";
            lblQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(35, 2);
            lblName.Margin = new Padding(6, 6, 6, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 18);
            lblName.TabIndex = 0;
            lblName.Text = "itemName";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Dock = DockStyle.Right;
            lblTotal.Location = new Point(170, 2);
            lblTotal.Margin = new Padding(4, 3, 4, 3);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 18);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0 Bs.";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.Dock = DockStyle.Right;
            lblPrice.Location = new Point(124, 2);
            lblPrice.Margin = new Padding(2);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 18);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "0 Bs.";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Dock = DockStyle.Right;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(228, 2);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(27, 18);
            btnDelete.TabIndex = 1;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // OrderItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Controls.Add(lblTotal);
            Controls.Add(btnDelete);
            Controls.Add(lblQuantity);
            Margin = new Padding(1);
            Name = "OrderItemControl";
            Padding = new Padding(2);
            Size = new Size(257, 22);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
    }
}
