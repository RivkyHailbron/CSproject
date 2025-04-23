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
            products = new Button();
            customers = new Button();
            sales = new Button();
            TOGO = new Label();
            helloManager = new Label();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(654, 241);
            products.Name = "products";
            products.Size = new Size(219, 98);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.Location = new Point(388, 241);
            customers.Name = "customers";
            customers.Size = new Size(219, 98);
            customers.TabIndex = 0;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // sales
            // 
            sales.Location = new Point(123, 241);
            sales.Name = "sales";
            sales.Size = new Size(219, 98);
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
            TOGO.Location = new Point(312, 44);
            TOGO.Name = "TOGO";
            TOGO.Size = new Size(351, 113);
            TOGO.TabIndex = 2;
            TOGO.Text = "TOGO";
            TOGO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // helloManager
            // 
            helloManager.BackColor = Color.Red;
            helloManager.Font = new Font("Segoe UI", 10F);
            helloManager.ForeColor = SystemColors.ButtonHighlight;
            helloManager.Location = new Point(41, 44);
            helloManager.Name = "helloManager";
            helloManager.Size = new Size(120, 36);
            helloManager.TabIndex = 3;
            helloManager.Text = "שלום מנהל";
            helloManager.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 492);
            Controls.Add(helloManager);
            Controls.Add(TOGO);
            Controls.Add(sales);
            Controls.Add(customers);
            Controls.Add(products);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customers;
        private Button sales;
        private Label TOGO;
        private Label helloManager;
    }
}