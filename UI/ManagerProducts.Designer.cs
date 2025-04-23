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
            tabControlCustomers.SuspendLayout();
            add.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            readById.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCustomers
            // 
            tabControlCustomers.Controls.Add(add);
            tabControlCustomers.Controls.Add(update);
            tabControlCustomers.Controls.Add(delete);
            tabControlCustomers.Controls.Add(readById);
            tabControlCustomers.Location = new Point(29, 33);
            tabControlCustomers.Name = "tabControlCustomers";
            tabControlCustomers.RightToLeft = RightToLeft.Yes;
            tabControlCustomers.RightToLeftLayout = true;
            tabControlCustomers.SelectedIndex = 0;
            tabControlCustomers.Size = new Size(357, 384);
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
            add.Location = new Point(4, 29);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(349, 351);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(73, 126);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(125, 28);
            comboBoxCategory.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(127, 292);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוסף";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxAmont
            // 
            textBoxAmont.Location = new Point(73, 221);
            textBoxAmont.Name = "textBoxAmont";
            textBoxAmont.Size = new Size(126, 27);
            textBoxAmont.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(73, 175);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(73, 72);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Location = new Point(208, 228);
            amount.Name = "amount";
            amount.Size = new Size(87, 20);
            amount.TabIndex = 0;
            amount.Text = "כמות במלאי";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(229, 178);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 0;
            price.Text = "מחיר";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(221, 134);
            address.Name = "address";
            address.Size = new Size(0, 20);
            address.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 127);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(62, 20);
            label7.TabIndex = 0;
            label7.Text = "קטגוריה";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(220, 75);
            name.Name = "name";
            name.RightToLeft = RightToLeft.Yes;
            name.Size = new Size(66, 20);
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
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(349, 351);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // comboBoxUpdateCategory
            // 
            comboBoxUpdateCategory.FormattingEnabled = true;
            comboBoxUpdateCategory.Location = new Point(24, 185);
            comboBoxUpdateCategory.Name = "comboBoxUpdateCategory";
            comboBoxUpdateCategory.Size = new Size(189, 28);
            comboBoxUpdateCategory.TabIndex = 12;
            comboBoxUpdateCategory.Visible = false;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(119, 316);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "עדכן";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Visible = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // textBoxUpdateAmount
            // 
            textBoxUpdateAmount.Location = new Point(24, 275);
            textBoxUpdateAmount.Name = "textBoxUpdateAmount";
            textBoxUpdateAmount.Size = new Size(189, 27);
            textBoxUpdateAmount.TabIndex = 9;
            textBoxUpdateAmount.Visible = false;
            // 
            // sendIdToUpdate
            // 
            sendIdToUpdate.Location = new Point(119, 86);
            sendIdToUpdate.Name = "sendIdToUpdate";
            sendIdToUpdate.Size = new Size(94, 29);
            sendIdToUpdate.TabIndex = 4;
            sendIdToUpdate.Text = "שלח";
            sendIdToUpdate.UseVisualStyleBackColor = true;
            sendIdToUpdate.Click += sendIdToUpdate_Click;
            // 
            // textBoxUpdatePrice
            // 
            textBoxUpdatePrice.Location = new Point(24, 234);
            textBoxUpdatePrice.Name = "textBoxUpdatePrice";
            textBoxUpdatePrice.Size = new Size(189, 27);
            textBoxUpdatePrice.TabIndex = 10;
            textBoxUpdatePrice.Visible = false;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(88, 43);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(125, 27);
            textBoxUpdateId.TabIndex = 3;
            // 
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(24, 131);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(189, 27);
            textBoxUpdateName.TabIndex = 11;
            textBoxUpdateName.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 282);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "כמות במלאי";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "מזהה מוצר";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 237);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "מחיר";
            label3.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(235, 134);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(66, 20);
            label9.TabIndex = 8;
            label9.Text = "שם מוצר";
            label9.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 193);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(235, 186);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(62, 20);
            label8.TabIndex = 7;
            label8.Text = "קטגוריה";
            label8.Visible = false;
            // 
            // delete
            // 
            delete.Controls.Add(BtnDelete);
            delete.Controls.Add(textBoxDeleteId);
            delete.Controls.Add(label5);
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Size = new Size(349, 351);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(120, 182);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "מחיקה";
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
            label5.Size = new Size(79, 20);
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
            readById.Location = new Point(4, 29);
            readById.Name = "readById";
            readById.Size = new Size(349, 351);
            readById.TabIndex = 3;
            readById.Text = "הצגת מוצר ע\"י מזהה";
            readById.UseVisualStyleBackColor = true;
            // 
            // textBoxReadAmount
            // 
            textBoxReadAmount.Location = new Point(92, 289);
            textBoxReadAmount.Name = "textBoxReadAmount";
            textBoxReadAmount.Size = new Size(125, 27);
            textBoxReadAmount.TabIndex = 14;
            textBoxReadAmount.Visible = false;
            // 
            // textBoxReadPrice
            // 
            textBoxReadPrice.Location = new Point(92, 245);
            textBoxReadPrice.Name = "textBoxReadPrice";
            textBoxReadPrice.Size = new Size(125, 27);
            textBoxReadPrice.TabIndex = 14;
            textBoxReadPrice.Visible = false;
            // 
            // textBoxReadCategory
            // 
            textBoxReadCategory.Location = new Point(92, 194);
            textBoxReadCategory.Name = "textBoxReadCategory";
            textBoxReadCategory.Size = new Size(125, 27);
            textBoxReadCategory.TabIndex = 15;
            textBoxReadCategory.Visible = false;
            // 
            // textBoxReadName
            // 
            textBoxReadName.Location = new Point(92, 142);
            textBoxReadName.Name = "textBoxReadName";
            textBoxReadName.Size = new Size(125, 27);
            textBoxReadName.TabIndex = 16;
            textBoxReadName.Visible = false;
            // 
            // labelReadAmount
            // 
            labelReadAmount.AutoSize = true;
            labelReadAmount.Location = new Point(245, 296);
            labelReadAmount.Name = "labelReadAmount";
            labelReadAmount.Size = new Size(87, 20);
            labelReadAmount.TabIndex = 11;
            labelReadAmount.Text = "כמות במלאי";
            labelReadAmount.Visible = false;
            // 
            // labelReadPrice
            // 
            labelReadPrice.AutoSize = true;
            labelReadPrice.Location = new Point(245, 252);
            labelReadPrice.Name = "labelReadPrice";
            labelReadPrice.Size = new Size(41, 20);
            labelReadPrice.TabIndex = 11;
            labelReadPrice.Text = "מחיר";
            labelReadPrice.Visible = false;
            // 
            // labelReadCategort
            // 
            labelReadCategort.AutoSize = true;
            labelReadCategort.Location = new Point(237, 201);
            labelReadCategort.Name = "labelReadCategort";
            labelReadCategort.Size = new Size(62, 20);
            labelReadCategort.TabIndex = 12;
            labelReadCategort.Text = "קטגוריה";
            labelReadCategort.Visible = false;
            // 
            // labelReadName
            // 
            labelReadName.AutoSize = true;
            labelReadName.Location = new Point(249, 149);
            labelReadName.Name = "labelReadName";
            labelReadName.RightToLeft = RightToLeft.Yes;
            labelReadName.Size = new Size(31, 20);
            labelReadName.TabIndex = 13;
            labelReadName.Text = "שם";
            labelReadName.Visible = false;
            // 
            // BtnRead
            // 
            BtnRead.Location = new Point(123, 77);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(94, 29);
            BtnRead.TabIndex = 10;
            BtnRead.Text = "שלח";
            BtnRead.UseVisualStyleBackColor = true;
            BtnRead.Click += BtnRead_Click;
            // 
            // textBoxReadId
            // 
            textBoxReadId.Location = new Point(69, 34);
            textBoxReadId.Name = "textBoxReadId";
            textBoxReadId.Size = new Size(125, 27);
            textBoxReadId.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 37);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 8;
            label6.Text = "מזההה מוצר";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(426, 33);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(345, 384);
            listBoxProducts.TabIndex = 2;
            listBoxProducts.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
            // 
            // ManagerProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlCustomers);
            Controls.Add(listBoxProducts);
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

    }
}