namespace AutoserviceUI.View
{
    partial class ClientFormView
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtFathName = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.butInsertClient = new System.Windows.Forms.Button();
            this.butCancelClient = new System.Windows.Forms.Button();
            this.butDeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(106, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(183, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(106, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(183, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtFathName
            // 
            this.txtFathName.Location = new System.Drawing.Point(106, 64);
            this.txtFathName.Name = "txtFathName";
            this.txtFathName.Size = new System.Drawing.Size(183, 20);
            this.txtFathName.TabIndex = 2;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(106, 90);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(183, 20);
            this.txtPassport.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 116);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(183, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Паспорт:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Телефон:";
            // 
            // dataGridClient
            // 
            this.dataGridClient.AllowUserToAddRows = false;
            this.dataGridClient.AllowUserToDeleteRows = false;
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Location = new System.Drawing.Point(295, 12);
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.Size = new System.Drawing.Size(820, 238);
            this.dataGridClient.TabIndex = 12;
            // 
            // butInsertClient
            // 
            this.butInsertClient.Location = new System.Drawing.Point(106, 168);
            this.butInsertClient.Name = "butInsertClient";
            this.butInsertClient.Size = new System.Drawing.Size(84, 29);
            this.butInsertClient.TabIndex = 13;
            this.butInsertClient.Text = "Добавить";
            this.butInsertClient.UseVisualStyleBackColor = true;
            // 
            // butCancelClient
            // 
            this.butCancelClient.Location = new System.Drawing.Point(205, 168);
            this.butCancelClient.Name = "butCancelClient";
            this.butCancelClient.Size = new System.Drawing.Size(84, 29);
            this.butCancelClient.TabIndex = 14;
            this.butCancelClient.Text = "Выход";
            this.butCancelClient.UseVisualStyleBackColor = true;
            // 
            // butDeleteClient
            // 
            this.butDeleteClient.Location = new System.Drawing.Point(205, 221);
            this.butDeleteClient.Name = "butDeleteClient";
            this.butDeleteClient.Size = new System.Drawing.Size(84, 29);
            this.butDeleteClient.TabIndex = 15;
            this.butDeleteClient.Text = "Удалить";
            this.butDeleteClient.UseVisualStyleBackColor = true;
            // 
            // ClientFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 262);
            this.Controls.Add(this.butDeleteClient);
            this.Controls.Add(this.butCancelClient);
            this.Controls.Add(this.butInsertClient);
            this.Controls.Add(this.dataGridClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtFathName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Name = "ClientFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientFormView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtFathName;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.Button butInsertClient;
        private System.Windows.Forms.Button butCancelClient;
        private System.Windows.Forms.Button butDeleteClient;
    }
}