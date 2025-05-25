using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    partial class ManagerProducts
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerProducts));
            tabControlCustomers = new TabControl();
            add = new TabPage();
            comboBoxCategory = new ComboBox();
            buttonAdd = new Button();
            textBoxAmont = new TextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            amount = new Label();
            price = new Label();
            address = new Label();
            label7 = new Label();
            name = new Label();
            update = new TabPage();
            comboBoxUpdateCategory = new ComboBox();
            BtnUpdate = new Button();
            textBoxUpdateAmount = new TextBox();
            sendIdToUpdate = new Button();
            textBoxUpdatePrice = new TextBox();
            textBoxUpdateId = new TextBox();
            textBoxUpdateName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
            delete = new TabPage();
            BtnDelete = new Button();
            textBoxDeleteId = new TextBox();
            label5 = new Label();
            readById = new TabPage();
            textBoxReadAmount = new TextBox();
            textBoxReadPrice = new TextBox();
            textBoxReadCategory = new TextBox();
            textBoxReadName = new TextBox();
            labelReadAmount = new Label();
            labelReadPrice = new Label();
            labelReadCategort = new Label();
            labelReadName = new Label();
            BtnRead = new Button();
            textBoxReadId = new TextBox();
            label6 = new Label();
            listBoxProducts = new ListBox();
            pictureBox1 = new PictureBox();
            tabControlCustomers.SuspendLayout();
            add.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            readById.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlCustomers
            // 
            tabControlCustomers.Controls.Add(add);
            tabControlCustomers.Controls.Add(update);
            tabControlCustomers.Controls.Add(delete);
            tabControlCustomers.Controls.Add(readById);
            tabControlCustomers.Location = new Point(153, 197);
            tabControlCustomers.Margin = new Padding(3, 2, 3, 2);
            tabControlCustomers.Name = "tabControlCustomers";
            tabControlCustomers.RightToLeft = RightToLeft.Yes;
            tabControlCustomers.RightToLeftLayout = true;
            tabControlCustomers.SelectedIndex = 0;
            tabControlCustomers.Size = new Size(369, 424);
            tabControlCustomers.TabIndex = 3;
            // 
            // add
            // 
            add.Controls.Add(comboBoxCategory);
            add.Controls.Add(buttonAdd);
            add.Controls.Add(textBoxAmont);
            add.Controls.Add(textBoxPrice);
            add.Controls.Add(textBoxName);
            add.Controls.Add(amount);
            add.Controls.Add(price);
            add.Controls.Add(address);
            add.Controls.Add(label7);
            add.Controls.Add(name);
            add.Location = new Point(4, 24);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Padding = new Padding(3, 2, 3, 2);
            add.Size = new Size(361, 396);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(64, 94);
            comboBoxCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(110, 23);
            comboBoxCategory.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(111, 219);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוסף";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxAmont
            // 
            textBoxAmont.Location = new Point(64, 166);
            textBoxAmont.Margin = new Padding(3, 2, 3, 2);
            textBoxAmont.Name = "textBoxAmont";
            textBoxAmont.Size = new Size(111, 23);
            textBoxAmont.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(64, 131);
            textBoxPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(110, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(64, 54);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 1;
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Location = new Point(182, 171);
            amount.Name = "amount";
            amount.Size = new Size(70, 15);
            amount.TabIndex = 0;
            amount.Text = "כמות במלאי";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(200, 134);
            price.Name = "price";
            price.Size = new Size(33, 15);
            price.TabIndex = 0;
            price.Text = "מחיר";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(193, 100);
            address.Name = "address";
            address.Size = new Size(0, 15);
            address.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 95);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(49, 15);
            label7.TabIndex = 0;
            label7.Text = "קטגוריה";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(192, 56);
            name.Name = "name";
            name.RightToLeft = RightToLeft.Yes;
            name.Size = new Size(52, 15);
            name.TabIndex = 0;
            name.Text = "שם מוצר";
            // 
            // update
            // 
            update.Controls.Add(comboBoxUpdateCategory);
            update.Controls.Add(BtnUpdate);
            update.Controls.Add(textBoxUpdateAmount);
            update.Controls.Add(sendIdToUpdate);
            update.Controls.Add(textBoxUpdatePrice);
            update.Controls.Add(textBoxUpdateId);
            update.Controls.Add(textBoxUpdateName);
            update.Controls.Add(label2);
            update.Controls.Add(label1);
            update.Controls.Add(label3);
            update.Controls.Add(label9);
            update.Controls.Add(label4);
            update.Controls.Add(label8);
            update.Location = new Point(4, 24);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Padding = new Padding(3, 2, 3, 2);
            update.Size = new Size(544, 396);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // comboBoxUpdateCategory
            // 
            comboBoxUpdateCategory.FormattingEnabled = true;
            comboBoxUpdateCategory.Location = new Point(21, 139);
            comboBoxUpdateCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxUpdateCategory.Name = "comboBoxUpdateCategory";
            comboBoxUpdateCategory.Size = new Size(166, 23);
            comboBoxUpdateCategory.TabIndex = 12;
            comboBoxUpdateCategory.Visible = false;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(104, 237);
            BtnUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(82, 22);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "עדכן";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Visible = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // textBoxUpdateAmount
            // 
            textBoxUpdateAmount.Location = new Point(21, 206);
            textBoxUpdateAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdateAmount.Name = "textBoxUpdateAmount";
            textBoxUpdateAmount.Size = new Size(166, 23);
            textBoxUpdateAmount.TabIndex = 9;
            textBoxUpdateAmount.Visible = false;
            // 
            // sendIdToUpdate
            // 
            sendIdToUpdate.Location = new Point(104, 64);
            sendIdToUpdate.Margin = new Padding(3, 2, 3, 2);
            sendIdToUpdate.Name = "sendIdToUpdate";
            sendIdToUpdate.Size = new Size(82, 22);
            sendIdToUpdate.TabIndex = 4;
            sendIdToUpdate.Text = "שלח";
            sendIdToUpdate.UseVisualStyleBackColor = true;
            sendIdToUpdate.Click += sendIdToUpdate_Click;
            // 
            // textBoxUpdatePrice
            // 
            textBoxUpdatePrice.Location = new Point(21, 176);
            textBoxUpdatePrice.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdatePrice.Name = "textBoxUpdatePrice";
            textBoxUpdatePrice.Size = new Size(166, 23);
            textBoxUpdatePrice.TabIndex = 10;
            textBoxUpdatePrice.Visible = false;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(77, 32);
            textBoxUpdateId.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(110, 23);
            textBoxUpdateId.TabIndex = 3;
            // 
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(21, 98);
            textBoxUpdateName.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(166, 23);
            textBoxUpdateName.TabIndex = 11;
            textBoxUpdateName.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 212);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "כמות במלאי";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 37);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "מזהה מוצר";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 178);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "מחיר";
            label3.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 100);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(52, 15);
            label9.TabIndex = 8;
            label9.Text = "שם מוצר";
            label9.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 145);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 140);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(49, 15);
            label8.TabIndex = 7;
            label8.Text = "קטגוריה";
            label8.Visible = false;
            // 
            // delete
            // 
            delete.Controls.Add(BtnDelete);
            delete.Controls.Add(textBoxDeleteId);
            delete.Controls.Add(label5);
            delete.Location = new Point(4, 24);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Size = new Size(544, 396);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(105, 136);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(82, 22);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "מחיקה";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(58, 104);
            textBoxDeleteId.Margin = new Padding(3, 2, 3, 2);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(110, 23);
            textBoxDeleteId.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 106);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "מזהה מוצר";
            // 
            // readById
            // 
            readById.Controls.Add(textBoxReadAmount);
            readById.Controls.Add(textBoxReadPrice);
            readById.Controls.Add(textBoxReadCategory);
            readById.Controls.Add(textBoxReadName);
            readById.Controls.Add(labelReadAmount);
            readById.Controls.Add(labelReadPrice);
            readById.Controls.Add(labelReadCategort);
            readById.Controls.Add(labelReadName);
            readById.Controls.Add(BtnRead);
            readById.Controls.Add(textBoxReadId);
            readById.Controls.Add(label6);
            readById.Location = new Point(4, 24);
            readById.Margin = new Padding(3, 2, 3, 2);
            readById.Name = "readById";
            readById.Size = new Size(544, 396);
            readById.TabIndex = 3;
            readById.Text = "הצגת מוצר ע\"י מזהה";
            readById.UseVisualStyleBackColor = true;
            // 
            // textBoxReadAmount
            // 
            textBoxReadAmount.Location = new Point(80, 217);
            textBoxReadAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxReadAmount.Name = "textBoxReadAmount";
            textBoxReadAmount.Size = new Size(110, 23);
            textBoxReadAmount.TabIndex = 14;
            textBoxReadAmount.Visible = false;
            // 
            // textBoxReadPrice
            // 
            textBoxReadPrice.Location = new Point(80, 184);
            textBoxReadPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxReadPrice.Name = "textBoxReadPrice";
            textBoxReadPrice.Size = new Size(110, 23);
            textBoxReadPrice.TabIndex = 14;
            textBoxReadPrice.Visible = false;
            // 
            // textBoxReadCategory
            // 
            textBoxReadCategory.Location = new Point(80, 146);
            textBoxReadCategory.Margin = new Padding(3, 2, 3, 2);
            textBoxReadCategory.Name = "textBoxReadCategory";
            textBoxReadCategory.Size = new Size(110, 23);
            textBoxReadCategory.TabIndex = 15;
            textBoxReadCategory.Visible = false;
            // 
            // textBoxReadName
            // 
            textBoxReadName.Location = new Point(80, 106);
            textBoxReadName.Margin = new Padding(3, 2, 3, 2);
            textBoxReadName.Name = "textBoxReadName";
            textBoxReadName.Size = new Size(110, 23);
            textBoxReadName.TabIndex = 16;
            textBoxReadName.Visible = false;
            // 
            // labelReadAmount
            // 
            labelReadAmount.AutoSize = true;
            labelReadAmount.Location = new Point(214, 222);
            labelReadAmount.Name = "labelReadAmount";
            labelReadAmount.Size = new Size(70, 15);
            labelReadAmount.TabIndex = 11;
            labelReadAmount.Text = "כמות במלאי";
            labelReadAmount.Visible = false;
            // 
            // labelReadPrice
            // 
            labelReadPrice.AutoSize = true;
            labelReadPrice.Location = new Point(214, 189);
            labelReadPrice.Name = "labelReadPrice";
            labelReadPrice.Size = new Size(33, 15);
            labelReadPrice.TabIndex = 11;
            labelReadPrice.Text = "מחיר";
            labelReadPrice.Visible = false;
            // 
            // labelReadCategort
            // 
            labelReadCategort.AutoSize = true;
            labelReadCategort.Location = new Point(207, 151);
            labelReadCategort.Name = "labelReadCategort";
            labelReadCategort.Size = new Size(49, 15);
            labelReadCategort.TabIndex = 12;
            labelReadCategort.Text = "קטגוריה";
            labelReadCategort.Visible = false;
            // 
            // labelReadName
            // 
            labelReadName.AutoSize = true;
            labelReadName.Location = new Point(218, 112);
            labelReadName.Name = "labelReadName";
            labelReadName.RightToLeft = RightToLeft.Yes;
            labelReadName.Size = new Size(24, 15);
            labelReadName.TabIndex = 13;
            labelReadName.Text = "שם";
            labelReadName.Visible = false;
            // 
            // BtnRead
            // 
            BtnRead.Location = new Point(108, 58);
            BtnRead.Margin = new Padding(3, 2, 3, 2);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(82, 22);
            BtnRead.TabIndex = 10;
            BtnRead.Text = "שלח";
            BtnRead.UseVisualStyleBackColor = true;
            BtnRead.Click += BtnRead_Click;
            // 
            // textBoxReadId
            // 
            textBoxReadId.Location = new Point(60, 26);
            textBoxReadId.Margin = new Padding(3, 2, 3, 2);
            textBoxReadId.Name = "textBoxReadId";
            textBoxReadId.Size = new Size(110, 23);
            textBoxReadId.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 28);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 8;
            label6.Text = "מזההה מוצר";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(899, 197);
            listBoxProducts.Margin = new Padding(3, 2, 3, 2);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(402, 424);
            listBoxProducts.TabIndex = 2;
            listBoxProducts.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(510, 25);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 154);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ManagerProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 648);
            Controls.Add(pictureBox1);
            Controls.Add(tabControlCustomers);
            Controls.Add(listBoxProducts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagerProducts";
            Text = "ManagerProducts";
            Load += ManagerProducts_Load;
            tabControlCustomers.ResumeLayout(false);
            add.ResumeLayout(false);
            add.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            readById.ResumeLayout(false);
            readById.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCustomers;
        private TabPage add;
        private Button buttonAdd;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label price;
        private Label address;
        private Label name;
        private TabPage update;
        private Button BtnUpdate;

        private Button sendIdToUpdate;
        private TextBox textBoxUpdateId;
        private Label label1;
        private TabPage delete;
        private Button BtnDelete;
        private TextBox textBoxDeleteId;
        private Label label5;
        private TabPage readById;
        private TextBox textBoxReadPrice;
        private TextBox textBoxReadCategory;
        private TextBox textBoxReadName;
        private Label labelReadPrice;
        private Label labelReadCategort;

        private Label labelReadName;
        private Button BtnRead;
        private TextBox textBoxReadId;
        private Label label6;
        private ListBox listBoxProducts;
        private TextBox textBoxAmont;
        private Label amount;
        private Label label7;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxUpdateCategory;
        private TextBox textBoxUpdateAmount;
        private TextBox textBoxUpdatePrice;
        private TextBox textBoxUpdateName;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label4;
        private Label label8;
        private TextBox textBoxReadAmount;
        private Label labelReadAmount;
        private PictureBox pictureBox1;
    }
}