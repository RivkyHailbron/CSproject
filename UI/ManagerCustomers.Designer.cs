namespace UI
{
    partial class ManagerCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerCustomers));
            listBoxCustomers = new ListBox();
            tabControlCustomers = new TabControl();
            add = new TabPage();
            buttonAdd = new Button();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            phone = new Label();
            address = new Label();
            name = new Label();
            ID = new Label();
            update = new TabPage();
            BtnUpdate = new Button();
            textBoxUpdatePhone = new TextBox();
            textBoxUpdateAddress = new TextBox();
            textBoxUpdateName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sendIdToUpdate = new Button();
            textBoxUpdateId = new TextBox();
            label1 = new Label();
            delete = new TabPage();
            BtnDelete = new Button();
            textBoxDeleteId = new TextBox();
            label5 = new Label();
            readById = new TabPage();
            textBoxReadPhone = new TextBox();
            textBoxReadAddress = new TextBox();
            textBoxReadName = new TextBox();
            labelReadPhone = new Label();
            labelReadAddress = new Label();
            labelReadName = new Label();
            BtnRead = new Button();
            textBoxReadId = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            tabControlCustomers.SuspendLayout();
            add.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            readById.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.ItemHeight = 15;
            listBoxCustomers.Location = new Point(1015, 206);
            listBoxCustomers.Margin = new Padding(3, 2, 3, 2);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(402, 424);
            listBoxCustomers.TabIndex = 0;
            listBoxCustomers.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
            // 
            // tabControlCustomers
            // 
            tabControlCustomers.Controls.Add(add);
            tabControlCustomers.Controls.Add(update);
            tabControlCustomers.Controls.Add(delete);
            tabControlCustomers.Controls.Add(readById);
            tabControlCustomers.Location = new Point(107, 185);
            tabControlCustomers.Margin = new Padding(3, 2, 3, 2);
            tabControlCustomers.Name = "tabControlCustomers";
            tabControlCustomers.RightToLeft = RightToLeft.Yes;
            tabControlCustomers.RightToLeftLayout = true;
            tabControlCustomers.SelectedIndex = 0;
            tabControlCustomers.Size = new Size(358, 445);
            tabControlCustomers.TabIndex = 1;
            // 
            // add
            // 
            add.Controls.Add(buttonAdd);
            add.Controls.Add(textBoxPhone);
            add.Controls.Add(textBoxAddress);
            add.Controls.Add(textBoxName);
            add.Controls.Add(textBoxId);
            add.Controls.Add(phone);
            add.Controls.Add(address);
            add.Controls.Add(name);
            add.Controls.Add(ID);
            add.Location = new Point(4, 24);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Padding = new Padding(3, 2, 3, 2);
            add.Size = new Size(350, 417);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(100, 211);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוסף";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(76, 164);
            textBoxPhone.Margin = new Padding(3, 2, 3, 2);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(110, 23);
            textBoxPhone.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(76, 125);
            textBoxAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(110, 23);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(76, 86);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(76, 50);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(110, 23);
            textBoxId.TabIndex = 1;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(210, 169);
            phone.Name = "phone";
            phone.Size = new Size(36, 15);
            phone.TabIndex = 0;
            phone.Text = "טלפון";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(203, 130);
            address.Name = "address";
            address.Size = new Size(42, 15);
            address.TabIndex = 0;
            address.Text = "כתובת";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(214, 92);
            name.Name = "name";
            name.RightToLeft = RightToLeft.Yes;
            name.Size = new Size(24, 15);
            name.TabIndex = 0;
            name.Text = "שם";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(191, 52);
            ID.Name = "ID";
            ID.Size = new Size(68, 15);
            ID.TabIndex = 0;
            ID.Text = "תעודת זהות";
            // 
            // update
            // 
            update.Controls.Add(BtnUpdate);
            update.Controls.Add(textBoxUpdatePhone);
            update.Controls.Add(textBoxUpdateAddress);
            update.Controls.Add(textBoxUpdateName);
            update.Controls.Add(label2);
            update.Controls.Add(label3);
            update.Controls.Add(label4);
            update.Controls.Add(sendIdToUpdate);
            update.Controls.Add(textBoxUpdateId);
            update.Controls.Add(label1);
            update.Location = new Point(4, 24);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Padding = new Padding(3, 2, 3, 2);
            update.Size = new Size(562, 417);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(38, 225);
            BtnUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(82, 22);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "עדכן";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Visible = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // textBoxUpdatePhone
            // 
            textBoxUpdatePhone.Location = new Point(74, 177);
            textBoxUpdatePhone.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdatePhone.Name = "textBoxUpdatePhone";
            textBoxUpdatePhone.Size = new Size(110, 23);
            textBoxUpdatePhone.TabIndex = 8;
            textBoxUpdatePhone.Visible = false;
            // 
            // textBoxUpdateAddress
            // 
            textBoxUpdateAddress.Location = new Point(74, 139);
            textBoxUpdateAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdateAddress.Name = "textBoxUpdateAddress";
            textBoxUpdateAddress.Size = new Size(110, 23);
            textBoxUpdateAddress.TabIndex = 9;
            textBoxUpdateAddress.Visible = false;
            // 
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(74, 100);
            textBoxUpdateName.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(110, 23);
            textBoxUpdateName.TabIndex = 10;
            textBoxUpdateName.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 182);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "טלפון";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 144);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "כתובת";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 105);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(24, 15);
            label4.TabIndex = 7;
            label4.Text = "שם";
            label4.Visible = false;
            // 
            // sendIdToUpdate
            // 
            sendIdToUpdate.Location = new Point(124, 64);
            sendIdToUpdate.Margin = new Padding(3, 2, 3, 2);
            sendIdToUpdate.Name = "sendIdToUpdate";
            sendIdToUpdate.Size = new Size(82, 22);
            sendIdToUpdate.TabIndex = 4;
            sendIdToUpdate.Text = "שלח";
            sendIdToUpdate.UseVisualStyleBackColor = true;
            sendIdToUpdate.Click += sendIdToUpdate_Click;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(77, 32);
            textBoxUpdateId.Margin = new Padding(3, 2, 3, 2);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(110, 23);
            textBoxUpdateId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 34);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "תעודת זהות";
            // 
            // delete
            // 
            delete.Controls.Add(BtnDelete);
            delete.Controls.Add(textBoxDeleteId);
            delete.Controls.Add(label5);
            delete.Location = new Point(4, 24);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Size = new Size(562, 417);
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
            label5.Size = new Size(68, 15);
            label5.TabIndex = 5;
            label5.Text = "תעודת זהות";
            // 
            // readById
            // 
            readById.Controls.Add(textBoxReadPhone);
            readById.Controls.Add(textBoxReadAddress);
            readById.Controls.Add(textBoxReadName);
            readById.Controls.Add(labelReadPhone);
            readById.Controls.Add(labelReadAddress);
            readById.Controls.Add(labelReadName);
            readById.Controls.Add(BtnRead);
            readById.Controls.Add(textBoxReadId);
            readById.Controls.Add(label6);
            readById.Location = new Point(4, 24);
            readById.Margin = new Padding(3, 2, 3, 2);
            readById.Name = "readById";
            readById.Size = new Size(562, 417);
            readById.TabIndex = 3;
            readById.Text = "הצגת לקוח ע\"י ת.ז.";
            readById.UseVisualStyleBackColor = true;
            // 
            // textBoxReadPhone
            // 
            textBoxReadPhone.Location = new Point(80, 184);
            textBoxReadPhone.Margin = new Padding(3, 2, 3, 2);
            textBoxReadPhone.Name = "textBoxReadPhone";
            textBoxReadPhone.Size = new Size(110, 23);
            textBoxReadPhone.TabIndex = 14;
            textBoxReadPhone.Visible = false;
            // 
            // textBoxReadAddress
            // 
            textBoxReadAddress.Location = new Point(80, 146);
            textBoxReadAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxReadAddress.Name = "textBoxReadAddress";
            textBoxReadAddress.Size = new Size(110, 23);
            textBoxReadAddress.TabIndex = 15;
            textBoxReadAddress.Visible = false;
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
            // labelReadPhone
            // 
            labelReadPhone.AutoSize = true;
            labelReadPhone.Location = new Point(214, 189);
            labelReadPhone.Name = "labelReadPhone";
            labelReadPhone.Size = new Size(36, 15);
            labelReadPhone.TabIndex = 11;
            labelReadPhone.Text = "טלפון";
            labelReadPhone.Visible = false;
            // 
            // labelReadAddress
            // 
            labelReadAddress.AutoSize = true;
            labelReadAddress.Location = new Point(207, 151);
            labelReadAddress.Name = "labelReadAddress";
            labelReadAddress.Size = new Size(42, 15);
            labelReadAddress.TabIndex = 12;
            labelReadAddress.Text = "כתובת";
            labelReadAddress.Visible = false;
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
            label6.Size = new Size(68, 15);
            label6.TabIndex = 8;
            label6.Text = "תעודת זהות";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 154);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ManagerCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 662);
            Controls.Add(pictureBox1);
            Controls.Add(tabControlCustomers);
            Controls.Add(listBoxCustomers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagerCustomers";
            RightToLeftLayout = true;
            Text = "ManagerCustomers";
            Load += ManagerCustomers_Load;
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

        private ListBox listBoxCustomers;
        private TabControl tabControlCustomers;
        private TabPage add;
        private TabPage update;
        private TabPage delete;
        private TabPage readById;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label phone;
        private Label address;
        private Label name;
        private Label ID;
        private Button buttonAdd;
        private Button BtnUpdate;
        private TextBox textBoxUpdatePhone;
        private TextBox textBoxUpdateAddress;
        private TextBox textBoxUpdateName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button sendIdToUpdate;
        private TextBox textBoxUpdateId;
        private Label label1;
        private Button BtnDelete;
        private TextBox textBoxDeleteId;
        private Label label5;
        private TextBox textBoxReadPhone;
        private TextBox textBoxReadAddress;
        private TextBox textBoxReadName;
        private Label labelReadPhone;
        private Label labelReadAddress;
        private Label labelReadName;
        private Button BtnRead;
        private TextBox textBoxReadId;
        private Label label6;
        private PictureBox pictureBox1;
    }
}