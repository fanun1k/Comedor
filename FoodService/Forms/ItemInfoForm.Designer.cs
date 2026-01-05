namespace FoodService.Forms
{
    partial class ItemInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Controls.ItemInfoPanel itemInfoPanel1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInfoForm));
            this.itemInfoPanel1 = new Controls.ItemInfoPanel();
            this.SuspendLayout();
            // 
            // itemInfoPanel1
            // 
            this.itemInfoPanel1.Caption = resources.GetString("itemInfoPanel1.Caption");
            this.itemInfoPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemInfoPanel1.Detail = resources.GetString("itemInfoPanel1.Detail");
            this.itemInfoPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemInfoPanel1.Location = new System.Drawing.Point(0, 0);
            this.itemInfoPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.itemInfoPanel1.Name = "itemInfoPanel1";
            this.itemInfoPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.itemInfoPanel1.Parent_ = null;
            this.itemInfoPanel1.Picture = ((System.Drawing.Image)(resources.GetObject("itemInfoPanel1.Picture")));
            this.itemInfoPanel1.Size = new System.Drawing.Size(400, 438);
            this.itemInfoPanel1.TabIndex = 0;
            // 
            // ItemInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(430, 438);
            this.ControlBox = false;
            this.Controls.Add(this.itemInfoPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemInfoForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Informacion";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.ResumeLayout(false);

        }

        #endregion

    }
}