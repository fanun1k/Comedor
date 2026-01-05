namespace FoodService.Controls
{
    partial class ItemInfoPanel: UserControl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInfoPanel));
            panelEx1 = new DevComponents.DotNetBar.PanelEx();
            panel3 = new Panel();
            textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            pictureBox2 = new PictureBox();
            panelEx1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelEx1
            // 
            panelEx1.CanvasColor = SystemColors.Control;
            panelEx1.Controls.Add(panel3);
            panelEx1.Controls.Add(panel1);
            panelEx1.Controls.Add(panel2);
            panelEx1.Cursor = Cursors.Hand;
            panelEx1.Dock = DockStyle.Fill;
            panelEx1.Location = new Point(2, 2);
            panelEx1.Margin = new Padding(4, 3, 4, 3);
            panelEx1.Name = "panelEx1";
            panelEx1.Size = new Size(444, 589);
            panelEx1.Style.Alignment = StringAlignment.Center;
            panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            panelEx1.Style.BorderWidth = 5;
            panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            panelEx1.Style.GradientAngle = 90;
            panelEx1.TabIndex = 0;
            panelEx1.Click += CloseParent;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxX1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 378);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(6);
            panel3.Size = new Size(444, 211);
            panel3.TabIndex = 2;
            panel3.Click += CloseParent;
            // 
            // textBoxX1
            // 
            textBoxX1.BackColor = Color.LightYellow;
            // 
            // 
            // 
            textBoxX1.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            textBoxX1.Border.BorderBottomWidth = 1;
            textBoxX1.Border.BorderColor = Color.DarkGray;
            textBoxX1.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            textBoxX1.Border.BorderLeftWidth = 1;
            textBoxX1.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            textBoxX1.Border.BorderRightWidth = 1;
            textBoxX1.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            textBoxX1.Border.BorderTopWidth = 1;
            textBoxX1.Border.Class = "TextBoxBorder";
            textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            textBoxX1.CharacterCasing = CharacterCasing.Upper;
            textBoxX1.Cursor = Cursors.Default;
            textBoxX1.Dock = DockStyle.Fill;
            textBoxX1.Enabled = false;
            textBoxX1.FocusHighlightColor = Color.Empty;
            textBoxX1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxX1.ForeColor = Color.SlateGray;
            textBoxX1.Location = new Point(6, 6);
            textBoxX1.Margin = new Padding(4, 3, 4, 3);
            textBoxX1.Multiline = true;
            textBoxX1.Name = "textBoxX1";
            textBoxX1.ReadOnly = true;
            textBoxX1.Size = new Size(432, 199);
            textBoxX1.TabIndex = 0;
            textBoxX1.Text = resources.GetString("textBoxX1.Text");
            textBoxX1.TextAlign = HorizontalAlignment.Center;
            textBoxX1.Click += CloseParent;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 84);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(444, 294);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.silpancho;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += CloseParent;
            // 
            // panel2
            // 
            panel2.Controls.Add(reflectionLabel1);
            panel2.Controls.Add(pictureBox2);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2);
            panel2.Size = new Size(444, 84);
            panel2.TabIndex = 0;
            // 
            // reflectionLabel1
            // 
            reflectionLabel1.BackColor = Color.Transparent;
            // 
            // 
            // 
            reflectionLabel1.BackgroundStyle.BorderBottomWidth = 2;
            reflectionLabel1.BackgroundStyle.BorderColor = Color.SlateGray;
            reflectionLabel1.BackgroundStyle.BorderLeftWidth = 2;
            reflectionLabel1.BackgroundStyle.BorderRightWidth = 2;
            reflectionLabel1.BackgroundStyle.BorderTopWidth = 2;
            reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            reflectionLabel1.Cursor = Cursors.Hand;
            reflectionLabel1.Dock = DockStyle.Fill;
            reflectionLabel1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reflectionLabel1.ForeColor = Color.White;
            reflectionLabel1.Location = new Point(2, 2);
            reflectionLabel1.Margin = new Padding(4, 3, 4, 3);
            reflectionLabel1.Name = "reflectionLabel1";
            reflectionLabel1.Size = new Size(397, 80);
            reflectionLabel1.TabIndex = 0;
            reflectionLabel1.Text = "<div align=\"center\"><b><i>Sopa de Mani y charque de llama con fideo</i></b></div>";
            reflectionLabel1.Click += CloseParent;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(399, 2);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += CloseParent;
            // 
            // ItemInfoPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelEx1);
            Cursor = Cursors.Hand;
            Margin = new Padding(12);
            Name = "ItemInfoPanel";
            Padding = new Padding(2);
            Size = new Size(448, 593);
            Click += CloseParent;
            panelEx1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}