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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            button1 = new Button();
            button2 = new Button();
            textBoxGetCustomerId = new TextBox();
            send = new Button();
            textBoxHello = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(731, 250);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(207, 22);
            button1.TabIndex = 0;
            button1.Text = "הכנס מזהה לקוח";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(632, 425);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(179, 22);
            button2.TabIndex = 1;
            button2.Text = "התחל הזמנה חדשה";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxGetCustomerId
            // 
            textBoxGetCustomerId.Location = new Point(632, 251);
            textBoxGetCustomerId.Margin = new Padding(3, 2, 3, 2);
            textBoxGetCustomerId.Name = "textBoxGetCustomerId";
            textBoxGetCustomerId.Size = new Size(73, 23);
            textBoxGetCustomerId.TabIndex = 2;
            textBoxGetCustomerId.Text = "0";
            // 
            // send
            // 
            send.Location = new Point(677, 307);
            send.Margin = new Padding(3, 2, 3, 2);
            send.Name = "send";
            send.Size = new Size(82, 22);
            send.TabIndex = 8;
            send.Text = "שלח";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // textBoxHello
            // 
            textBoxHello.AutoSize = true;
            textBoxHello.Location = new Point(663, 360);
            textBoxHello.Name = "textBoxHello";
            textBoxHello.Size = new Size(10, 15);
            textBoxHello.TabIndex = 10;
            textBoxHello.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(517, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 154);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 647);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxHello);
            Controls.Add(send);
            Controls.Add(textBoxGetCustomerId);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxGetCustomerId;
        private Button send;
        private Label textBoxHello;
        private PictureBox pictureBox1;
    }
}