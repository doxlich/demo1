namespace forms1
{
    partial class Form1
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
            this.btn_MakeOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sosudNumber = new System.Windows.Forms.TextBox();
            this.txtBox_customer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_FullName = new System.Windows.Forms.TextBox();
            this.tBox_Company = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cBox_Service = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MakeOrder
            // 
            this.btn_MakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_MakeOrder.Location = new System.Drawing.Point(16, 356);
            this.btn_MakeOrder.Name = "btn_MakeOrder";
            this.btn_MakeOrder.Size = new System.Drawing.Size(278, 45);
            this.btn_MakeOrder.TabIndex = 0;
            this.btn_MakeOrder.Text = "Сделать заказ";
            this.btn_MakeOrder.UseVisualStyleBackColor = true;
            this.btn_MakeOrder.Click += new System.EventHandler(this.btn_MakeOder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер";
            // 
            // sosudNumber
            // 
            this.sosudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.sosudNumber.Location = new System.Drawing.Point(175, 51);
            this.sosudNumber.Name = "sosudNumber";
            this.sosudNumber.Size = new System.Drawing.Size(205, 29);
            this.sosudNumber.TabIndex = 4;
            this.sosudNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sosudNumber_KeyPress);
            this.sosudNumber.MouseHover += new System.EventHandler(this.sosudNumber_MouseHover);
            // 
            // txtBox_customer
            // 
            this.txtBox_customer.AutoSize = true;
            this.txtBox_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtBox_customer.Location = new System.Drawing.Point(14, 96);
            this.txtBox_customer.Name = "txtBox_customer";
            this.txtBox_customer.Size = new System.Drawing.Size(92, 24);
            this.txtBox_customer.TabIndex = 5;
            this.txtBox_customer.Text = "Заказчик";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ЮЛ",
            "ФЛ"});
            this.comboBox1.Location = new System.Drawing.Point(175, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 32);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО Клиента";
            // 
            // tBox_FullName
            // 
            this.tBox_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tBox_FullName.Location = new System.Drawing.Point(175, 145);
            this.tBox_FullName.Name = "tBox_FullName";
            this.tBox_FullName.Size = new System.Drawing.Size(205, 29);
            this.tBox_FullName.TabIndex = 8;
            // 
            // tBox_Company
            // 
            this.tBox_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tBox_Company.Location = new System.Drawing.Point(175, 189);
            this.tBox_Company.Name = "tBox_Company";
            this.tBox_Company.Size = new System.Drawing.Size(205, 29);
            this.tBox_Company.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Компания";
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_AddCustomer.Location = new System.Drawing.Point(575, 12);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(213, 45);
            this.btn_AddCustomer.TabIndex = 11;
            this.btn_AddCustomer.Text = "Добавить ЮЛ";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(575, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить ФЛ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBox_Service
            // 
            this.cBox_Service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cBox_Service.FormattingEnabled = true;
            this.cBox_Service.Items.AddRange(new object[] {
            "Доставка",
            "Звонок",
            "Покупка мелочей",
            "Заказать станок",
            "Заказать детали",
            "Установка деталей",
            "Починка техники"});
            this.cBox_Service.Location = new System.Drawing.Point(175, 236);
            this.cBox_Service.Name = "cBox_Service";
            this.cBox_Service.Size = new System.Drawing.Size(205, 32);
            this.cBox_Service.TabIndex = 14;
            this.cBox_Service.SelectedIndexChanged += new System.EventHandler(this.cBox_Service_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(14, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Услуга";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Location = new System.Drawing.Point(575, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Список клиентов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Окно формирование заказа";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button3.Location = new System.Drawing.Point(575, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "Услуги ОТК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button4.Location = new System.Drawing.Point(575, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 45);
            this.button4.TabIndex = 18;
            this.button4.Text = "Заказы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button5.Location = new System.Drawing.Point(575, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 45);
            this.button5.TabIndex = 19;
            this.button5.Text = "Оказанная услуга";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button6.Location = new System.Drawing.Point(575, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 45);
            this.button6.TabIndex = 20;
            this.button6.Text = "данные сотрудников";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cBox_Service);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.tBox_Company);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBox_FullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBox_customer);
            this.Controls.Add(this.sosudNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MakeOrder);
            this.Name = "Form1";
            this.Text = "Окно заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MakeOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sosudNumber;
        private System.Windows.Forms.Label txtBox_customer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_FullName;
        private System.Windows.Forms.TextBox tBox_Company;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBox_Service;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

