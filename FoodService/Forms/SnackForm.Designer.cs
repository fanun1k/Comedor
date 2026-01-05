namespace FoodService.Forms
{
    partial class SnackForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lbl_title = new Label();
            lbl_date = new Label();
            label1 = new Label();
            btnAdd = new Button();
            panel2 = new Panel();
            lbl_RegisterInfo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 26);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(751, 553);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_title);
            panel1.Controls.Add(lbl_date);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 26);
            panel1.TabIndex = 1;
            // 
            // lbl_title
            // 
            lbl_title.Dock = DockStyle.Fill;
            lbl_title.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.OrangeRed;
            lbl_title.Location = new Point(113, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(635, 26);
            lbl_title.TabIndex = 4;
            lbl_title.Text = "TITULO";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Dock = DockStyle.Right;
            lbl_date.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_date.Location = new Point(748, 0);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(160, 31);
            lbl_date.TabIndex = 3;
            lbl_date.Text = "22/05/2011";
            lbl_date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 2;
            label1.Text = "SNACK";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(821, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_RegisterInfo);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(751, 26);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(157, 553);
            panel2.TabIndex = 2;
            // 
            // lbl_RegisterInfo
            // 
            lbl_RegisterInfo.BorderStyle = BorderStyle.FixedSingle;
            lbl_RegisterInfo.Dock = DockStyle.Top;
            lbl_RegisterInfo.Location = new Point(5, 5);
            lbl_RegisterInfo.Name = "lbl_RegisterInfo";
            lbl_RegisterInfo.Size = new Size(147, 178);
            lbl_RegisterInfo.TabIndex = 0;
            // 
            // SnackForm
            // 
            ClientSize = new Size(908, 579);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SnackForm";
            ShowIcon = false;
            Text = "MenuForm";
            WindowState = FormWindowState.Maximized;
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_RegisterInfo;
        private System.Windows.Forms.Label lbl_title;





    }
}