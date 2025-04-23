namespace UI
{
    partial class ManagerSales
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
            Label productId;
            tabControlCustomers = new TabControl();
            add = new TabPage();
            dateTimePickerEndDateSale = new DateTimePicker();
            dateTimePickerStartDateSale = new DateTimePicker();
            checkBoxClub = new CheckBox();
            EndDateSale = new Label();
            StartDateSale = new Label();
            buttonAdd = new Button();
            textBoxminAmountForSale = new TextBox();
            textBoxsalePrice = new TextBox();
            textBoxproductId = new TextBox();
            salePrice = new Label();
            minAmountForSale = new Label();
            update = new TabPage();
            labeProductUpdate = new Label();
            textBox1productIdUpdate = new TextBox();
            dateTimePickerendDateUpdate = new DateTimePicker();
            BtnUpdate = new Button();
            labelendDateUpdate = new Label();
            dateTimePickerstartDateUpdate = new DateTimePicker();
            sendIdToUpdate = new Button();
            checkBoxClubUpdate = new CheckBox();
            labelstartDateUpdate = new Label();
            textBoxidSaleUpdate = new TextBox();
            idSaleupdate = new Label();
            textBoxMinAmountForSaleUpdate = new TextBox();
            labelSalePriceUpdate = new Label();
            labelMinAmountForSaleUpdate = new Label();
            textBoxSalePriceUpdate = new TextBox();
            delete = new TabPage();
            BtnDelete = new Button();
            textBoxDeleteId = new TextBox();
            label5 = new Label();
            readById = new TabPage();
            labelClubDisplay = new Label();
            dateTimePickerendidend = new DateTimePicker();
            idSaledisplay = new Label();
            label6endidend = new Label();
            labelMinAmountDisplay = new Label();
            dateTimePickerstartId = new DateTimePicker();
            labelsalePriceDisplay = new Label();
            sendDisplay = new Button();
            textBoxidSaledisplay = new TextBox();
            label7DateIdStart = new Label();
            filter = new TabPage();
            listBoxFilter = new ListBox();
            label1 = new Label();
            button1 = new Button();
            textBoxFilter = new TextBox();
            listBoxSales = new ListBox();
            comboBoxlistProductAdd = new ComboBox();
            productId = new Label();
            tabControlCustomers.SuspendLayout();
            add.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            readById.SuspendLayout();
            filter.SuspendLayout();
            SuspendLayout();
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Location = new Point(317, 86);
            productId.Name = "productId";
            productId.RightToLeft = RightToLeft.Yes;
            productId.Size = new Size(63, 15);
            productId.TabIndex = 0;
            productId.Text = "מזהה מוצר";
            // 
            // tabControlCustomers
            // 
            tabControlCustomers.Controls.Add(add);
            tabControlCustomers.Controls.Add(update);
            tabControlCustomers.Controls.Add(delete);
            tabControlCustomers.Controls.Add(readById);
            tabControlCustomers.Controls.Add(filter);
            tabControlCustomers.Location = new Point(26, 9);
            tabControlCustomers.Margin = new Padding(3, 2, 3, 2);
            tabControlCustomers.Name = "tabControlCustomers";
            tabControlCustomers.RightToLeft = RightToLeft.Yes;
            tabControlCustomers.RightToLeftLayout = true;
            tabControlCustomers.SelectedIndex = 0;
            tabControlCustomers.Size = new Size(530, 438);
            tabControlCustomers.TabIndex = 3;
            // 
            // add
            // 
            add.Controls.Add(comboBoxlistProductAdd);
            add.Controls.Add(dateTimePickerEndDateSale);
            add.Controls.Add(dateTimePickerStartDateSale);
            add.Controls.Add(checkBoxClub);
            add.Controls.Add(EndDateSale);
            add.Controls.Add(StartDateSale);
            add.Controls.Add(buttonAdd);
            add.Controls.Add(textBoxminAmountForSale);
            add.Controls.Add(textBoxsalePrice);
            add.Controls.Add(textBoxproductId);
            add.Controls.Add(salePrice);
            add.Controls.Add(minAmountForSale);
            add.Controls.Add(productId);
            add.Location = new Point(4, 24);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Padding = new Padding(3, 2, 3, 2);
            add.Size = new Size(522, 410);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndDateSale
            // 
            dateTimePickerEndDateSale.Location = new Point(164, 260);
            dateTimePickerEndDateSale.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEndDateSale.Name = "dateTimePickerEndDateSale";
            dateTimePickerEndDateSale.Size = new Size(219, 23);
            dateTimePickerEndDateSale.TabIndex = 11;
            // 
            // dateTimePickerStartDateSale
            // 
            dateTimePickerStartDateSale.Location = new Point(164, 220);
            dateTimePickerStartDateSale.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStartDateSale.Name = "dateTimePickerStartDateSale";
            dateTimePickerStartDateSale.Size = new Size(219, 23);
            dateTimePickerStartDateSale.TabIndex = 10;
            // 
            // checkBoxClub
            // 
            checkBoxClub.AutoSize = true;
            checkBoxClub.Location = new Point(261, 147);
            checkBoxClub.Margin = new Padding(3, 2, 3, 2);
            checkBoxClub.Name = "checkBoxClub";
            checkBoxClub.RightToLeft = RightToLeft.No;
            checkBoxClub.Size = new Size(56, 19);
            checkBoxClub.TabIndex = 9;
            checkBoxClub.Text = "מועדון";
            checkBoxClub.UseVisualStyleBackColor = true;
            // 
            // EndDateSale
            // 
            EndDateSale.AutoSize = true;
            EndDateSale.Location = new Point(311, 243);
            EndDateSale.Name = "EndDateSale";
            EndDateSale.Size = new Size(66, 15);
            EndDateSale.TabIndex = 3;
            EndDateSale.Text = "תאריך סיום";
            // 
            // StartDateSale
            // 
            StartDateSale.AutoSize = true;
            StartDateSale.Location = new Point(292, 203);
            StartDateSale.Name = "StartDateSale";
            StartDateSale.Size = new Size(84, 15);
            StartDateSale.TabIndex = 4;
            StartDateSale.Text = "תאריך התחלה";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(192, 293);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוסף";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // textBoxminAmountForSale
            // 
            textBoxminAmountForSale.Location = new Point(127, 174);
            textBoxminAmountForSale.Margin = new Padding(3, 2, 3, 2);
            textBoxminAmountForSale.Name = "textBoxminAmountForSale";
            textBoxminAmountForSale.Size = new Size(110, 23);
            textBoxminAmountForSale.TabIndex = 1;
            // 
            // textBoxsalePrice
            // 
            textBoxsalePrice.Location = new Point(178, 112);
            textBoxsalePrice.Margin = new Padding(3, 2, 3, 2);
            textBoxsalePrice.Name = "textBoxsalePrice";
            textBoxsalePrice.Size = new Size(110, 23);
            textBoxsalePrice.TabIndex = 1;
            // 
            // textBoxproductId
            // 
            textBoxproductId.Location = new Point(178, 80);
            textBoxproductId.Margin = new Padding(3, 2, 3, 2);
            textBoxproductId.Name = "textBoxproductId";
            textBoxproductId.Size = new Size(110, 23);
            textBoxproductId.TabIndex = 1;
            // 
            // salePrice
            // 
            salePrice.AutoSize = true;
            salePrice.Location = new Point(314, 112);
            salePrice.Name = "salePrice";
            salePrice.Size = new Size(65, 15);
            salePrice.TabIndex = 0;
            salePrice.Text = "מחיר מבצע";
            // 
            // minAmountForSale
            // 
            minAmountForSale.AutoSize = true;
            minAmountForSale.Location = new Point(257, 179);
            minAmountForSale.Name = "minAmountForSale";
            minAmountForSale.Size = new Size(114, 15);
            minAmountForSale.TabIndex = 0;
            minAmountForSale.Text = "כמות מינימום למבצע";
            // 
            // update
            // 
            update.Controls.Add(labeProductUpdate);
            update.Controls.Add(textBox1productIdUpdate);
            update.Controls.Add(dateTimePickerendDateUpdate);
            update.Controls.Add(BtnUpdate);
            update.Controls.Add(labelendDateUpdate);
            update.Controls.Add(dateTimePickerstartDateUpdate);
            update.Controls.Add(sendIdToUpdate);
            update.Controls.Add(checkBoxClubUpdate);
            update.Controls.Add(labelstartDateUpdate);
            update.Controls.Add(textBoxidSaleUpdate);
            update.Controls.Add(idSaleupdate);
            update.Controls.Add(textBoxMinAmountForSaleUpdate);
            update.Controls.Add(labelSalePriceUpdate);
            update.Controls.Add(labelMinAmountForSaleUpdate);
            update.Controls.Add(textBoxSalePriceUpdate);
            update.Location = new Point(4, 24);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Padding = new Padding(3, 2, 3, 2);
            update.Size = new Size(522, 410);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // labeProductUpdate
            // 
            labeProductUpdate.AutoSize = true;
            labeProductUpdate.Location = new Point(329, 96);
            labeProductUpdate.Name = "labeProductUpdate";
            labeProductUpdate.Size = new Size(63, 15);
            labeProductUpdate.TabIndex = 26;
            labeProductUpdate.Text = "מזהה מוצר";
            labeProductUpdate.Visible = false;
            // 
            // textBox1productIdUpdate
            // 
            textBox1productIdUpdate.Location = new Point(185, 88);
            textBox1productIdUpdate.Margin = new Padding(3, 2, 3, 2);
            textBox1productIdUpdate.Name = "textBox1productIdUpdate";
            textBox1productIdUpdate.Size = new Size(110, 23);
            textBox1productIdUpdate.TabIndex = 25;
            textBox1productIdUpdate.Visible = false;
            // 
            // dateTimePickerendDateUpdate
            // 
            dateTimePickerendDateUpdate.Location = new Point(178, 311);
            dateTimePickerendDateUpdate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerendDateUpdate.Name = "dateTimePickerendDateUpdate";
            dateTimePickerendDateUpdate.Size = new Size(219, 23);
            dateTimePickerendDateUpdate.TabIndex = 23;
            dateTimePickerendDateUpdate.Visible = false;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(127, 363);
            BtnUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(82, 22);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "עדכן";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Visible = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // labelendDateUpdate
            // 
            labelendDateUpdate.AutoSize = true;
            labelendDateUpdate.Location = new Point(325, 286);
            labelendDateUpdate.Name = "labelendDateUpdate";
            labelendDateUpdate.Size = new Size(66, 15);
            labelendDateUpdate.TabIndex = 19;
            labelendDateUpdate.Text = "תאריך סיום";
            labelendDateUpdate.Visible = false;
            // 
            // dateTimePickerstartDateUpdate
            // 
            dateTimePickerstartDateUpdate.Location = new Point(178, 259);
            dateTimePickerstartDateUpdate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerstartDateUpdate.Name = "dateTimePickerstartDateUpdate";
            dateTimePickerstartDateUpdate.Size = new Size(219, 23);
            dateTimePickerstartDateUpdate.TabIndex = 22;
            dateTimePickerstartDateUpdate.Visible = false;
            // 
            // sendIdToUpdate
            // 
            sendIdToUpdate.Location = new Point(255, 62);
            sendIdToUpdate.Margin = new Padding(3, 2, 3, 2);
            sendIdToUpdate.Name = "sendIdToUpdate";
            sendIdToUpdate.Size = new Size(82, 22);
            sendIdToUpdate.TabIndex = 4;
            sendIdToUpdate.Text = "שלח";
            sendIdToUpdate.UseVisualStyleBackColor = true;
            sendIdToUpdate.Click += sendIdToUpdate_Click;
            // 
            // checkBoxClubUpdate
            // 
            checkBoxClubUpdate.AutoSize = true;
            checkBoxClubUpdate.Location = new Point(335, 155);
            checkBoxClubUpdate.Margin = new Padding(3, 2, 3, 2);
            checkBoxClubUpdate.Name = "checkBoxClubUpdate";
            checkBoxClubUpdate.RightToLeft = RightToLeft.No;
            checkBoxClubUpdate.Size = new Size(56, 19);
            checkBoxClubUpdate.TabIndex = 21;
            checkBoxClubUpdate.Text = "מועדון";
            checkBoxClubUpdate.UseVisualStyleBackColor = true;
            checkBoxClubUpdate.Visible = false;
            // 
            // labelstartDateUpdate
            // 
            labelstartDateUpdate.AutoSize = true;
            labelstartDateUpdate.Location = new Point(314, 234);
            labelstartDateUpdate.Name = "labelstartDateUpdate";
            labelstartDateUpdate.Size = new Size(84, 15);
            labelstartDateUpdate.TabIndex = 20;
            labelstartDateUpdate.Text = "תאריך התחלה";
            labelstartDateUpdate.Visible = false;
            // 
            // textBoxidSaleUpdate
            // 
            textBoxidSaleUpdate.Location = new Point(180, 23);
            textBoxidSaleUpdate.Margin = new Padding(3, 2, 3, 2);
            textBoxidSaleUpdate.Name = "textBoxidSaleUpdate";
            textBoxidSaleUpdate.Size = new Size(110, 23);
            textBoxidSaleUpdate.TabIndex = 3;
            // 
            // idSaleupdate
            // 
            idSaleupdate.AutoSize = true;
            idSaleupdate.Location = new Point(304, 26);
            idSaleupdate.Name = "idSaleupdate";
            idSaleupdate.Size = new Size(67, 15);
            idSaleupdate.TabIndex = 2;
            idSaleupdate.Text = "מזהה מבצע";
            // 
            // textBoxMinAmountForSaleUpdate
            // 
            textBoxMinAmountForSaleUpdate.Location = new Point(143, 188);
            textBoxMinAmountForSaleUpdate.Margin = new Padding(3, 2, 3, 2);
            textBoxMinAmountForSaleUpdate.Name = "textBoxMinAmountForSaleUpdate";
            textBoxMinAmountForSaleUpdate.Size = new Size(110, 23);
            textBoxMinAmountForSaleUpdate.TabIndex = 15;
            textBoxMinAmountForSaleUpdate.Visible = false;
            // 
            // labelSalePriceUpdate
            // 
            labelSalePriceUpdate.AutoSize = true;
            labelSalePriceUpdate.Location = new Point(324, 135);
            labelSalePriceUpdate.Name = "labelSalePriceUpdate";
            labelSalePriceUpdate.Size = new Size(65, 15);
            labelSalePriceUpdate.TabIndex = 12;
            labelSalePriceUpdate.Text = "מחיר מבצע";
            labelSalePriceUpdate.Visible = false;
            // 
            // labelMinAmountForSaleUpdate
            // 
            labelMinAmountForSaleUpdate.AutoSize = true;
            labelMinAmountForSaleUpdate.Location = new Point(280, 190);
            labelMinAmountForSaleUpdate.Name = "labelMinAmountForSaleUpdate";
            labelMinAmountForSaleUpdate.Size = new Size(114, 15);
            labelMinAmountForSaleUpdate.TabIndex = 13;
            labelMinAmountForSaleUpdate.Text = "כמות מינימום למבצע";
            labelMinAmountForSaleUpdate.Visible = false;
            // 
            // textBoxSalePriceUpdate
            // 
            textBoxSalePriceUpdate.Location = new Point(185, 133);
            textBoxSalePriceUpdate.Margin = new Padding(3, 2, 3, 2);
            textBoxSalePriceUpdate.Name = "textBoxSalePriceUpdate";
            textBoxSalePriceUpdate.Size = new Size(110, 23);
            textBoxSalePriceUpdate.TabIndex = 16;
            textBoxSalePriceUpdate.Visible = false;
            // 
            // delete
            // 
            delete.Controls.Add(BtnDelete);
            delete.Controls.Add(textBoxDeleteId);
            delete.Controls.Add(label5);
            delete.Location = new Point(4, 24);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Size = new Size(522, 410);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(220, 151);
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
            textBoxDeleteId.Location = new Point(173, 119);
            textBoxDeleteId.Margin = new Padding(3, 2, 3, 2);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(110, 23);
            textBoxDeleteId.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 121);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 5;
            label5.Text = "מזהה מבצע";
            // 
            // readById
            // 
            readById.Controls.Add(labelClubDisplay);
            readById.Controls.Add(dateTimePickerendidend);
            readById.Controls.Add(idSaledisplay);
            readById.Controls.Add(label6endidend);
            readById.Controls.Add(labelMinAmountDisplay);
            readById.Controls.Add(dateTimePickerstartId);
            readById.Controls.Add(labelsalePriceDisplay);
            readById.Controls.Add(sendDisplay);
            readById.Controls.Add(textBoxidSaledisplay);
            readById.Controls.Add(label7DateIdStart);
            readById.Location = new Point(4, 24);
            readById.Margin = new Padding(3, 2, 3, 2);
            readById.Name = "readById";
            readById.Size = new Size(522, 410);
            readById.TabIndex = 3;
            readById.Text = "הצגת מבצע ע\"י מזהה";
            readById.UseVisualStyleBackColor = true;
            // 
            // labelClubDisplay
            // 
            labelClubDisplay.AutoSize = true;
            labelClubDisplay.Location = new Point(280, 162);
            labelClubDisplay.Name = "labelClubDisplay";
            labelClubDisplay.Size = new Size(99, 15);
            labelClubDisplay.TabIndex = 37;
            labelClubDisplay.Text = "מיועד לחבר מועדון";
            labelClubDisplay.Visible = false;
            // 
            // dateTimePickerendidend
            // 
            dateTimePickerendidend.Location = new Point(178, 319);
            dateTimePickerendidend.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerendidend.Name = "dateTimePickerendidend";
            dateTimePickerendidend.Size = new Size(219, 23);
            dateTimePickerendidend.TabIndex = 36;
            dateTimePickerendidend.Visible = false;
            // 
            // idSaledisplay
            // 
            idSaledisplay.AutoSize = true;
            idSaledisplay.Location = new Point(312, 39);
            idSaledisplay.Name = "idSaledisplay";
            idSaledisplay.Size = new Size(67, 15);
            idSaledisplay.TabIndex = 24;
            idSaledisplay.Text = "מזהה מבצע";
            // 
            // label6endidend
            // 
            label6endidend.AutoSize = true;
            label6endidend.Location = new Point(326, 293);
            label6endidend.Name = "label6endidend";
            label6endidend.Size = new Size(66, 15);
            label6endidend.TabIndex = 32;
            label6endidend.Text = "תאריך סיום";
            label6endidend.Visible = false;
            // 
            // labelMinAmountDisplay
            // 
            labelMinAmountDisplay.AutoSize = true;
            labelMinAmountDisplay.Location = new Point(282, 214);
            labelMinAmountDisplay.Name = "labelMinAmountDisplay";
            labelMinAmountDisplay.Size = new Size(117, 15);
            labelMinAmountDisplay.TabIndex = 29;
            labelMinAmountDisplay.Text = "כמות מינימום למבצע:";
            labelMinAmountDisplay.Visible = false;
            // 
            // dateTimePickerstartId
            // 
            dateTimePickerstartId.Location = new Point(178, 266);
            dateTimePickerstartId.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerstartId.Name = "dateTimePickerstartId";
            dateTimePickerstartId.Size = new Size(219, 23);
            dateTimePickerstartId.TabIndex = 35;
            dateTimePickerstartId.Visible = false;
            // 
            // labelsalePriceDisplay
            // 
            labelsalePriceDisplay.AutoSize = true;
            labelsalePriceDisplay.Location = new Point(312, 124);
            labelsalePriceDisplay.Name = "labelsalePriceDisplay";
            labelsalePriceDisplay.Size = new Size(68, 15);
            labelsalePriceDisplay.TabIndex = 28;
            labelsalePriceDisplay.Text = "מחיר מבצע:";
            labelsalePriceDisplay.Visible = false;
            // 
            // sendDisplay
            // 
            sendDisplay.Location = new Point(248, 77);
            sendDisplay.Margin = new Padding(3, 2, 3, 2);
            sendDisplay.Name = "sendDisplay";
            sendDisplay.Size = new Size(82, 22);
            sendDisplay.TabIndex = 26;
            sendDisplay.Text = "שלח";
            sendDisplay.UseVisualStyleBackColor = true;
            sendDisplay.Click += sendDisplay_Click;
            // 
            // textBoxidSaledisplay
            // 
            textBoxidSaledisplay.Location = new Point(188, 37);
            textBoxidSaledisplay.Margin = new Padding(3, 2, 3, 2);
            textBoxidSaledisplay.Name = "textBoxidSaledisplay";
            textBoxidSaledisplay.Size = new Size(110, 23);
            textBoxidSaledisplay.TabIndex = 25;
            // 
            // label7DateIdStart
            // 
            label7DateIdStart.AutoSize = true;
            label7DateIdStart.Location = new Point(315, 242);
            label7DateIdStart.Name = "label7DateIdStart";
            label7DateIdStart.Size = new Size(84, 15);
            label7DateIdStart.TabIndex = 33;
            label7DateIdStart.Text = "תאריך התחלה";
            label7DateIdStart.Visible = false;
            // 
            // filter
            // 
            filter.Controls.Add(listBoxFilter);
            filter.Controls.Add(label1);
            filter.Controls.Add(button1);
            filter.Controls.Add(textBoxFilter);
            filter.Location = new Point(4, 24);
            filter.Name = "filter";
            filter.Size = new Size(522, 410);
            filter.TabIndex = 4;
            filter.Text = "סינון לפי מוצר";
            filter.UseVisualStyleBackColor = true;
            // 
            // listBoxFilter
            // 
            listBoxFilter.FormattingEnabled = true;
            listBoxFilter.ItemHeight = 15;
            listBoxFilter.Location = new Point(63, 142);
            listBoxFilter.Name = "listBoxFilter";
            listBoxFilter.Size = new Size(407, 214);
            listBoxFilter.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 58);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 27;
            label1.Text = "מזהה מוצר";
            // 
            // button1
            // 
            button1.Location = new Point(253, 96);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 29;
            button1.Text = "שלח";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(193, 56);
            textBoxFilter.Margin = new Padding(3, 2, 3, 2);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(110, 23);
            textBoxFilter.TabIndex = 28;
            // 
            // listBoxSales
            // 
            listBoxSales.FormattingEnabled = true;
            listBoxSales.ItemHeight = 15;
            listBoxSales.Location = new Point(571, 9);
            listBoxSales.Margin = new Padding(3, 2, 3, 2);
            listBoxSales.Name = "listBoxSales";
            listBoxSales.Size = new Size(301, 439);
            listBoxSales.TabIndex = 2;
            // 
            // comboBoxlistProductAdd
            // 
            comboBoxlistProductAdd.FormattingEnabled = true;
            comboBoxlistProductAdd.Location = new Point(51, 78);
            comboBoxlistProductAdd.Name = "comboBoxlistProductAdd";
            comboBoxlistProductAdd.Size = new Size(121, 23);
            comboBoxlistProductAdd.TabIndex = 12;
            // 
            // ManagerSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 467);
            Controls.Add(tabControlCustomers);
            Controls.Add(listBoxSales);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagerSales";
            Text = "ManagerSales";
            Load += ManagerSales_Load;
            tabControlCustomers.ResumeLayout(false);
            add.ResumeLayout(false);
            add.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            readById.ResumeLayout(false);
            readById.PerformLayout();
            filter.ResumeLayout(false);
            filter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCustomers;
        private TabPage add;
        private Button buttonAdd;
        private TextBox textBoxminAmountForSale;
        private TextBox textBoxsalePrice;
        private TextBox textBoxproductId;
        private Label salePrice;
        private Label minAmountForSale;
        private Label productId;
        private TabPage update;
        private Button BtnUpdate;
        private Button sendIdToUpdate;
        private TextBox textBoxidSaleUpdate;
        private Label idSaleupdate;
        private TabPage delete;
        private Button BtnDelete;
        private TextBox textBoxDeleteId;
        private Label label5;
        private TabPage readById;
        private ListBox listBoxSales;
        private Label EndDateSale;
        private Label StartDateSale;
        private DateTimePicker dateTimePickerEndDateSale;
        private DateTimePicker dateTimePickerStartDateSale;
        private CheckBox checkBoxClub;
        private DateTimePicker dateTimePickerendDateUpdate;
        private Label labelendDateUpdate;
        private DateTimePicker dateTimePickerstartDateUpdate;
        private CheckBox checkBoxClubUpdate;
        private Label labelstartDateUpdate;
        private TextBox textBoxMinAmountForSaleUpdate;
        private Label labelSalePriceUpdate;
        private Label labelMinAmountForSaleUpdate;
        private TextBox textBoxSalePriceUpdate;
        private DateTimePicker dateTimePickerendidend;
        private Label idSaledisplay;
        private TextBox textBox5;
        private Label label6endidend;
        private Label labelMinAmountDisplay;
        private DateTimePicker dateTimePickerstartId;
        private Label labelsalePriceDisplay;
        private Button sendDisplay;
        private TextBox textBox4;
        private CheckBox checkBox2;
        private TextBox textBoxidSaledisplay;
        private Label label7DateIdStart;
        private Label labelClubDisplay;
        private TextBox textBox1productIdUpdate;
        private Label labeProductUpdate;
        private TabPage filter;
        private ListBox listBoxFilter;
        private Label label1;
        private Button button1;
        private TextBox textBoxFilter;
        private ComboBox comboBoxlistProductAdd;
    }
}