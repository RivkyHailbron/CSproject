namespace UI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            manager = new Button();
            customer = new Button();
            TOGO = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // manager
            // 
            manager.Location = new Point(433, 197);
            manager.Name = "manager";
            manager.Size = new Size(117, 39);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += manager_Click;
            // 
            // customer
            // 
            customer.Location = new Point(238, 197);
            customer.Name = "customer";
            customer.Size = new Size(135, 39);
            customer.TabIndex = 0;
            customer.Text = "קופאי";
            customer.UseVisualStyleBackColor = true;
            customer.Click += customer_Click;
            // 
            // TOGO
            // 
            TOGO.BackColor = Color.Red;
            TOGO.Font = new Font("Segoe UI", 50F);
            TOGO.ForeColor = SystemColors.ButtonHighlight;
            TOGO.Location = new Point(223, 30);
            TOGO.Name = "TOGO";
            TOGO.Size = new Size(353, 113);
            TOGO.TabIndex = 1;
            TOGO.Text = "TOGO";
            TOGO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(196, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 140);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(TOGO);
            Controls.Add(customer);
            Controls.Add(manager);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button customer;
        private Label TOGO;
        private PictureBox pictureBox1;
    }
}