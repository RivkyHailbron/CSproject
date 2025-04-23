namespace UI
{
    partial class CustomerOrder
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
            listBoxProducts = new ListBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            delete = new TabPage();
            BtnDelete = new Button();
            textBoxDeleteId = new TextBox();
            label5 = new Label();
            add = new TabPage();
            label6 = new Label();
            numericUpDownAmount = new NumericUpDown();
            buttonAdd = new Button();
            textBoxId = new TextBox();
            ID = new Label();
            tabControlCustomers = new TabControl();
            btnForPay = new Button();
            AmountForPay = new Label();
            delete.SuspendLayout();
            add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            tabControlCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(891, 62);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(281, 504);
            listBoxProducts.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 504);
            listBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(974, 23);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 0;
            label3.Text = "רשימת המוצרים";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 9);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 0;
            label4.Text = "ההזמנה שלי";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 562);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 0;
            label7.Text = "סה\"כ לתשלום:";
            // 
            // delete
            // 
            delete.Controls.Add(BtnDelete);
            delete.Controls.Add(textBoxDeleteId);
            delete.Controls.Add(label5);
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Size = new Size(391, 351);
            delete.TabIndex = 2;
            delete.Text = "מחק מוצר מהזמנה";
            delete.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(120, 182);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "מחק";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(66, 139);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(125, 27);
            textBoxDeleteId.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 142);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "קוד מוצר";
            // 
            // add
            // 
            add.Controls.Add(label6);
            add.Controls.Add(numericUpDownAmount);
            add.Controls.Add(buttonAdd);
            add.Controls.Add(textBoxId);
            add.Controls.Add(ID);
            add.Location = new Point(4, 29);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(391, 351);
            add.TabIndex = 0;
            add.Text = "הוסף מוצר להזמנה";
            add.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 136);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 4;
            label6.Text = "כמות";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(93, 131);
            numericUpDownAmount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(125, 27);
            numericUpDownAmount.TabIndex = 3;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(143, 199);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוסף להזמנה";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(93, 76);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(230, 82);
            ID.Name = "ID";
            ID.Size = new Size(65, 20);
            ID.TabIndex = 0;
            ID.Text = "קוד מוצר";
            // 
            // tabControlCustomers
            // 
            tabControlCustomers.Controls.Add(add);
            tabControlCustomers.Controls.Add(delete);
            tabControlCustomers.Location = new Point(414, 42);
            tabControlCustomers.Name = "tabControlCustomers";
            tabControlCustomers.RightToLeft = RightToLeft.Yes;
            tabControlCustomers.RightToLeftLayout = true;
            tabControlCustomers.SelectedIndex = 0;
            tabControlCustomers.Size = new Size(399, 384);
            tabControlCustomers.TabIndex = 9;
            // 
            // btnForPay
            // 
            btnForPay.Location = new Point(25, 585);
            btnForPay.Name = "btnForPay";
            btnForPay.Size = new Size(94, 29);
            btnForPay.TabIndex = 11;
            btnForPay.Text = "תשלום";
            btnForPay.UseVisualStyleBackColor = true;
            btnForPay.Click += btnForPay_Click;
            // 
            // AmountForPay
            // 
            AmountForPay.AutoSize = true;
            AmountForPay.Location = new Point(25, 562);
            AmountForPay.Name = "AmountForPay";
            AmountForPay.Size = new Size(17, 20);
            AmountForPay.TabIndex = 12;
            AmountForPay.Text = "0";
            // 
            // CustomerOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 643);
            Controls.Add(AmountForPay);
            Controls.Add(btnForPay);
            Controls.Add(listBox1);
            Controls.Add(listBoxProducts);
            Controls.Add(label7);
            Controls.Add(tabControlCustomers);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "CustomerOrder";
            Text = "CustomerOrder";
            Load += CustomerOrder_Load;
            delete.ResumeLayout(false);
            delete.PerformLayout();
            add.ResumeLayout(false);
            add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            tabControlCustomers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProducts;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label label7;
        private TabPage delete;
        private Button BtnDelete;
        private TextBox textBoxDeleteId;
        private Label label5;
        private TabPage add;
        private Label label6;
        private NumericUpDown numericUpDownAmount;
        private Button buttonAdd;
        private TextBox textBoxId;
        private Label ID;
        private TabControl tabControlCustomers;
        private Button btnForPay;
        private Label AmountForPay;
    }
}