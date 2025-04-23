namespace UI
{
    partial class Customer
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
            button1 = new Button();
            button2 = new Button();
            textBoxGetCustomerId = new TextBox();
            send = new Button();
            checkBoxIsClub = new CheckBox();
            textBoxHello = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(441, 84);
            button1.Name = "button1";
            button1.Size = new Size(237, 29);
            button1.TabIndex = 0;
            button1.Text = "הכנס מזהה לקוח";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(328, 317);
            button2.Name = "button2";
            button2.Size = new Size(205, 29);
            button2.TabIndex = 1;
            button2.Text = "התחל הזמנה חדשה";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxGetCustomerId
            // 
            textBoxGetCustomerId.Location = new Point(328, 86);
            textBoxGetCustomerId.Name = "textBoxGetCustomerId";
            textBoxGetCustomerId.Size = new Size(83, 27);
            textBoxGetCustomerId.TabIndex = 2;
            textBoxGetCustomerId.Text = "0";
            // 
            // send
            // 
            send.Location = new Point(380, 160);
            send.Name = "send";
            send.Size = new Size(94, 29);
            send.TabIndex = 8;
            send.Text = "שלח";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // checkBoxIsClub
            // 
            checkBoxIsClub.AutoSize = true;
            checkBoxIsClub.Location = new Point(196, 88);
            checkBoxIsClub.Name = "checkBoxIsClub";
            checkBoxIsClub.Size = new Size(100, 24);
            checkBoxIsClub.TabIndex = 9;
            checkBoxIsClub.Text = "חבר מועדון";
            checkBoxIsClub.UseVisualStyleBackColor = true;
            // 
            // textBoxHello
            // 
            textBoxHello.AutoSize = true;
            textBoxHello.Location = new Point(363, 231);
            textBoxHello.Name = "textBoxHello";
            textBoxHello.Size = new Size(13, 20);
            textBoxHello.TabIndex = 10;
            textBoxHello.Text = " ";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxHello);
            Controls.Add(checkBoxIsClub);
            Controls.Add(send);
            Controls.Add(textBoxGetCustomerId);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxGetCustomerId;
        private Button send;
        private CheckBox checkBoxIsClub;
        private Label textBoxHello;
    }
}