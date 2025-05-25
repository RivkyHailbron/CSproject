namespace UI
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            products = new Button();
            customers = new Button();
            sales = new Button();
            TOGO = new Label();
            helloManager = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(942, 281);
            products.Margin = new Padding(3, 2, 3, 2);
            products.Name = "products";
            products.Size = new Size(421, 194);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.Location = new Point(478, 281);
            customers.Margin = new Padding(3, 2, 3, 2);
            customers.Name = "customers";
            customers.Size = new Size(421, 194);
            customers.TabIndex = 0;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // sales
            // 
            sales.Location = new Point(12, 281);
            sales.Margin = new Padding(3, 2, 3, 2);
            sales.Name = "sales";
            sales.Size = new Size(421, 194);
            sales.TabIndex = 0;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // TOGO
            // 
            TOGO.BackColor = Color.Red;
            TOGO.Font = new Font("Segoe UI", 50F);
            TOGO.ForeColor = SystemColors.ButtonHighlight;
            TOGO.Location = new Point(545, 510);
            TOGO.Name = "TOGO";
            TOGO.Size = new Size(354, 120);
            TOGO.TabIndex = 2;
            TOGO.Text = "TOGO";
            TOGO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // helloManager
            // 
            helloManager.BackColor = Color.Red;
            helloManager.Font = new Font("Segoe UI", 10F);
            helloManager.ForeColor = SystemColors.ButtonHighlight;
            helloManager.Location = new Point(36, 33);
            helloManager.Name = "helloManager";
            helloManager.Size = new Size(105, 27);
            helloManager.TabIndex = 3;
            helloManager.Text = "שלום מנהל";
            helloManager.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(510, 58);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 154);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 639);
            Controls.Add(pictureBox1);
            Controls.Add(helloManager);
            Controls.Add(TOGO);
            Controls.Add(sales);
            Controls.Add(customers);
            Controls.Add(products);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Manager";
            Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customers;
        private Button sales;
        private Label TOGO;
        private Label helloManager;
        private PictureBox pictureBox1;
    }
}