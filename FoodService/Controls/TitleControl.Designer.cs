namespace FoodService.Controls
{
    partial class TitleControl
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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 25);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSlateGray;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 2, 0, 1);
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 6.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSlateGray;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(582, 25);
            label2.TabIndex = 1;
            label2.Text = "________________________________________________________________________________________________________________________________________________________________";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // TitleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TitleControl";
            Size = new Size(582, 24);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
