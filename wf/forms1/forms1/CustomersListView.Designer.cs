namespace forms1
{
    partial class CustomersListView
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
            this.dataGridViewUL = new System.Windows.Forms.DataGridView();
            this.dataGridViewFl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUL
            // 
            this.dataGridViewUL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUL.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUL.Name = "dataGridViewUL";
            this.dataGridViewUL.Size = new System.Drawing.Size(1102, 150);
            this.dataGridViewUL.TabIndex = 0;
            // 
            // dataGridViewFl
            // 
            this.dataGridViewFl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFl.Location = new System.Drawing.Point(12, 234);
            this.dataGridViewFl.Name = "dataGridViewFl";
            this.dataGridViewFl.Size = new System.Drawing.Size(1102, 150);
            this.dataGridViewFl.TabIndex = 1;
            // 
            // CustomersListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 403);
            this.Controls.Add(this.dataGridViewFl);
            this.Controls.Add(this.dataGridViewUL);
            this.Name = "CustomersListView";
            this.Text = "CustomersListView";
            this.Load += new System.EventHandler(this.CustomersListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUL;
        private System.Windows.Forms.DataGridView dataGridViewFl;
    }
}