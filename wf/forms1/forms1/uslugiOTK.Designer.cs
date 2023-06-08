namespace forms1
{
    partial class uslugiOTK
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
            this.NameServ = new System.Windows.Forms.TextBox();
            this.CostServ = new System.Windows.Forms.TextBox();
            this.CodeServ = new System.Windows.Forms.TextBox();
            this.TimeComplete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_MakeOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameServ
            // 
            this.NameServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NameServ.Location = new System.Drawing.Point(197, 47);
            this.NameServ.Name = "NameServ";
            this.NameServ.Size = new System.Drawing.Size(205, 29);
            this.NameServ.TabIndex = 5;
            // 
            // CostServ
            // 
            this.CostServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CostServ.Location = new System.Drawing.Point(197, 98);
            this.CostServ.Name = "CostServ";
            this.CostServ.Size = new System.Drawing.Size(205, 29);
            this.CostServ.TabIndex = 6;
            // 
            // CodeServ
            // 
            this.CodeServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CodeServ.Location = new System.Drawing.Point(197, 158);
            this.CodeServ.Name = "CodeServ";
            this.CodeServ.Size = new System.Drawing.Size(205, 29);
            this.CodeServ.TabIndex = 7;
            // 
            // TimeComplete
            // 
            this.TimeComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TimeComplete.Location = new System.Drawing.Point(197, 209);
            this.TimeComplete.Name = "TimeComplete";
            this.TimeComplete.Size = new System.Drawing.Size(205, 29);
            this.TimeComplete.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "код";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "срок выполнения";
            // 
            // btn_MakeOrder
            // 
            this.btn_MakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_MakeOrder.Location = new System.Drawing.Point(16, 325);
            this.btn_MakeOrder.Name = "btn_MakeOrder";
            this.btn_MakeOrder.Size = new System.Drawing.Size(278, 45);
            this.btn_MakeOrder.TabIndex = 13;
            this.btn_MakeOrder.Text = "добавить услугу";
            this.btn_MakeOrder.UseVisualStyleBackColor = true;
            this.btn_MakeOrder.Click += new System.EventHandler(this.btn_MakeOrder_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(418, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "просмотреть услуги";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uslugiOTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_MakeOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeComplete);
            this.Controls.Add(this.CodeServ);
            this.Controls.Add(this.CostServ);
            this.Controls.Add(this.NameServ);
            this.Name = "uslugiOTK";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameServ;
        private System.Windows.Forms.TextBox CostServ;
        private System.Windows.Forms.TextBox CodeServ;
        private System.Windows.Forms.TextBox TimeComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_MakeOrder;
        private System.Windows.Forms.Button button1;
    }
}