namespace FoodService.Controls
{
    partial class OrderPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlItems = new FlowLayoutPanel();
            pnlButtons = new Panel();
            btnOrdenar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            txt_Total = new TextBox();
            panel2 = new Panel();
            lblPrice = new Label();
            lblTotal = new Label();
            lblName = new Label();
            lblQuantity = new Label();
            calendar = new MonthCalendar();
            pnlButtons.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlItems
            // 
            pnlItems.AutoScroll = true;
            pnlItems.Dock = DockStyle.Fill;
            pnlItems.Location = new Point(0, 234);
            pnlItems.Margin = new Padding(5, 4, 5, 4);
            pnlItems.Name = "pnlItems";
            pnlItems.Size = new Size(306, 366);
            pnlItems.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnOrdenar);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 666);
            pnlButtons.Margin = new Padding(5, 4, 5, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(306, 123);
            pnlButtons.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.LemonChiffon;
            btnOrdenar.Dock = DockStyle.Fill;
            btnOrdenar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.ForeColor = Color.DimGray;
            btnOrdenar.Image = Properties.Resources.UserCard32;
            btnOrdenar.ImageAlign = ContentAlignment.MiddleRight;
            btnOrdenar.Location = new Point(0, 0);
            btnOrdenar.Margin = new Padding(5, 4, 5, 4);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(306, 123);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "FINALIZAR";
            btnOrdenar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrdenar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_Total);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 600);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(7, 8, 7, 8);
            panel1.Size = new Size(306, 66);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 8);
            label1.Margin = new Padding(7, 8, 7, 8);
            label1.Name = "label1";
            label1.Size = new Size(117, 48);
            label1.TabIndex = 1;
            label1.Text = "TOTAL =";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Total
            // 
            txt_Total.Dock = DockStyle.Right;
            txt_Total.Enabled = false;
            txt_Total.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Total.Location = new Point(116, 8);
            txt_Total.Margin = new Padding(5, 4, 5, 4);
            txt_Total.Multiline = true;
            txt_Total.Name = "txt_Total";
            txt_Total.ReadOnly = true;
            txt_Total.Size = new Size(181, 48);
            txt_Total.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblQuantity);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 207);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 27);
            panel2.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.Dock = DockStyle.Right;
            lblPrice.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(188, 0);
            lblPrice.Margin = new Padding(2, 3, 2, 3);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 27);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "PRECIO";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Dock = DockStyle.Right;
            lblTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(240, 0);
            lblTotal.Margin = new Padding(5, 4, 5, 4);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 27);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(41, 0);
            lblName.Margin = new Padding(7, 8, 7, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(265, 27);
            lblName.TabIndex = 4;
            lblName.Text = "ITEM";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            lblQuantity.BorderStyle = BorderStyle.FixedSingle;
            lblQuantity.Dock = DockStyle.Left;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(0, 0);
            lblQuantity.Margin = new Padding(7, 8, 7, 8);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(41, 27);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "#";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calendar
            // 
            calendar.Dock = DockStyle.Top;
            calendar.Enabled = false;
            calendar.Location = new Point(0, 0);
            calendar.Margin = new Padding(11, 13, 11, 13);
            calendar.Name = "calendar";
            calendar.TabIndex = 4;
            // 
            // OrderPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlItems);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(calendar);
            Controls.Add(pnlButtons);
            Margin = new Padding(5, 4, 5, 4);
            Name = "OrderPanel";
            Size = new Size(306, 789);
            pnlButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlItems;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.MonthCalendar calendar;
    }
}
