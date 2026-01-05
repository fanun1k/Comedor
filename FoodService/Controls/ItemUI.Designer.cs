namespace FoodService.Controls
{
    partial class ItemUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemUI));
            lblName = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            txtQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            panelEx1 = new DevComponents.DotNetBar.PanelEx();
            LBL_PRECIO = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            btnDown = new DevComponents.DotNetBar.ButtonX();
            btnInfo = new DevComponents.DotNetBar.ButtonX();
            btnUp = new DevComponents.DotNetBar.ButtonX();
            panelEx1.SuspendLayout();
            groupPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            // 
            // 
            // 
            lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblName.Dock = DockStyle.Bottom;
            lblName.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(0, 131);
            lblName.Margin = new Padding(0);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 44);
            lblName.TabIndex = 2;
            lblName.Text = "<div align=\"center\">Sopa De Mani</div>";
            lblName.Click += lblName_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            // 
            // 
            // 
            txtQuantity.Border.Class = "TextBoxBorder";
            txtQuantity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            txtQuantity.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(2, 5);
            txtQuantity.Margin = new Padding(4, 3, 4, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(46, 23);
            txtQuantity.TabIndex = 4;
            txtQuantity.Text = "00";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.Visible = false;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // panelEx1
            // 
            panelEx1.BackgroundImageLayout = ImageLayout.Zoom;
            panelEx1.CanvasColor = Color.Transparent;
            panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            panelEx1.Controls.Add(LBL_PRECIO);
            panelEx1.Controls.Add(txtQuantity);
            panelEx1.Cursor = Cursors.Hand;
            panelEx1.Dock = DockStyle.Fill;
            panelEx1.Location = new Point(0, 0);
            panelEx1.Margin = new Padding(12);
            panelEx1.Name = "panelEx1";
            panelEx1.Size = new Size(130, 131);
            panelEx1.Style.Alignment = StringAlignment.Center;
            panelEx1.Style.BackColor1.Color = Color.Transparent;
            panelEx1.Style.BackColor2.Color = Color.Transparent;
            panelEx1.Style.BackgroundImage = (Image)resources.GetObject("panelEx1.Style.BackgroundImage");
            panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            panelEx1.Style.BorderColor.Color = Color.Transparent;
            panelEx1.Style.BorderWidth = 2;
            panelEx1.Style.CornerDiameter = 12;
            panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            panelEx1.Style.GradientAngle = 90;
            panelEx1.StyleMouseDown.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            panelEx1.StyleMouseDown.BorderColor.Color = Color.Orange;
            panelEx1.StyleMouseDown.BorderWidth = 2;
            panelEx1.StyleMouseOver.BackColor1.Color = Color.FromArgb(255, 128, 0);
            panelEx1.StyleMouseOver.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            panelEx1.StyleMouseOver.BorderColor.Color = Color.Gold;
            panelEx1.StyleMouseOver.BorderWidth = 2;
            panelEx1.TabIndex = 7;
            panelEx1.Click += panelEx1_Click;
            panelEx1.MouseEnter += panelEx1_MouseEnter;
            // 
            // LBL_PRECIO
            // 
            LBL_PRECIO.BackColor = Color.DimGray;
            // 
            // 
            // 
            LBL_PRECIO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LBL_PRECIO.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_PRECIO.ForeColor = SystemColors.ControlLightLight;
            LBL_PRECIO.Location = new Point(2, 105);
            LBL_PRECIO.Margin = new Padding(4, 3, 4, 3);
            LBL_PRECIO.Name = "LBL_PRECIO";
            LBL_PRECIO.ReflectionEnabled = false;
            LBL_PRECIO.Size = new Size(46, 23);
            LBL_PRECIO.TabIndex = 5;
            LBL_PRECIO.Text = "00.00";
            // 
            // groupPanel1
            // 
            groupPanel1.CanvasColor = SystemColors.Control;
            groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            groupPanel1.Controls.Add(panelEx1);
            groupPanel1.Controls.Add(lblName);
            groupPanel1.Dock = DockStyle.Fill;
            groupPanel1.DrawTitleBox = false;
            groupPanel1.Location = new Point(2, 2);
            groupPanel1.Margin = new Padding(4, 3, 4, 3);
            groupPanel1.Name = "groupPanel1";
            groupPanel1.ShowFocusRectangle = true;
            groupPanel1.Size = new Size(136, 181);
            // 
            // 
            // 
            groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            groupPanel1.Style.BackColorGradientAngle = 90;
            groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            groupPanel1.Style.BorderBottomWidth = 1;
            groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            groupPanel1.Style.BorderLeftWidth = 1;
            groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            groupPanel1.Style.BorderRightWidth = 1;
            groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            groupPanel1.Style.BorderTopWidth = 1;
            groupPanel1.Style.CornerDiameter = 4;
            groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            groupPanel1.TabIndex = 0;
            // 
            // btnDown
            // 
            btnDown.AccessibleRole = AccessibleRole.PushButton;
            btnDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDown.AntiAlias = true;
            btnDown.BackgroundImageLayout = ImageLayout.Zoom;
            btnDown.Checked = true;
            btnDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            btnDown.Cursor = Cursors.Hand;
            btnDown.FocusCuesEnabled = false;
            btnDown.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            btnDown.Image = (Image)resources.GetObject("btnDown.Image");
            btnDown.ImageFixedSize = new Size(28, 28);
            btnDown.Location = new Point(76, 62);
            btnDown.Margin = new Padding(4, 3, 4, 3);
            btnDown.Name = "btnDown";
            btnDown.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            btnDown.ShowSubItems = false;
            btnDown.Size = new Size(61, 58);
            btnDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            btnDown.TabIndex = 1;
            btnDown.Click += btnDown_Click;
            // 
            // btnInfo
            // 
            btnInfo.AccessibleRole = AccessibleRole.PushButton;
            btnInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInfo.AntiAlias = true;
            btnInfo.Checked = true;
            btnInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.FocusCuesEnabled = false;
            btnInfo.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            btnInfo.Image = (Image)resources.GetObject("btnInfo.Image");
            btnInfo.ImageFixedSize = new Size(25, 25);
            btnInfo.Location = new Point(84, 123);
            btnInfo.Margin = new Padding(4, 3, 4, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            btnInfo.ShowSubItems = false;
            btnInfo.Size = new Size(54, 40);
            btnInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            btnInfo.TabIndex = 3;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnUp
            // 
            btnUp.AccessibleRole = AccessibleRole.PushButton;
            btnUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUp.AntiAlias = true;
            btnUp.BackColor = Color.Transparent;
            btnUp.Checked = true;
            btnUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            btnUp.Cursor = Cursors.Hand;
            btnUp.FocusCuesEnabled = false;
            btnUp.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            btnUp.Image = (Image)resources.GetObject("btnUp.Image");
            btnUp.ImageFixedSize = new Size(28, 28);
            btnUp.Location = new Point(76, 3);
            btnUp.Margin = new Padding(4, 3, 4, 1);
            btnUp.Name = "btnUp";
            btnUp.PulseSpeed = 5;
            btnUp.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            btnUp.ShowSubItems = false;
            btnUp.Size = new Size(61, 58);
            btnUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            btnUp.TabIndex = 1;
            btnUp.Click += btnUp_Click;
            // 
            // ItemUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnInfo);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(groupPanel1);
            Margin = new Padding(23, 0, 0, 23);
            Name = "ItemUI";
            Padding = new Padding(2);
            Size = new Size(140, 185);
            Click += lblName_Click;
            panelEx1.ResumeLayout(false);
            groupPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel lblName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQuantity;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnInfo;
        private DevComponents.DotNetBar.ButtonX btnDown;
        private DevComponents.DotNetBar.ButtonX btnUp;
        private DevComponents.DotNetBar.Controls.ReflectionLabel LBL_PRECIO;
    }

        
    
}