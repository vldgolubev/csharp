namespace AutoserviceUI.View
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.butInsertAdmin = new System.Windows.Forms.Button();
            this.butCancelAdmin = new System.Windows.Forms.Button();
            this.dataAdminGridView = new System.Windows.Forms.DataGridView();
            this.butAdminDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textAdminID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(62, 47);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(192, 20);
            this.textLogin.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(62, 75);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(192, 20);
            this.textPassword.TabIndex = 3;
            // 
            // butInsertAdmin
            // 
            this.butInsertAdmin.Location = new System.Drawing.Point(27, 121);
            this.butInsertAdmin.Name = "butInsertAdmin";
            this.butInsertAdmin.Size = new System.Drawing.Size(106, 30);
            this.butInsertAdmin.TabIndex = 4;
            this.butInsertAdmin.Text = "Добавить";
            this.butInsertAdmin.UseVisualStyleBackColor = true;
            // 
            // butCancelAdmin
            // 
            this.butCancelAdmin.Location = new System.Drawing.Point(148, 121);
            this.butCancelAdmin.Name = "butCancelAdmin";
            this.butCancelAdmin.Size = new System.Drawing.Size(106, 30);
            this.butCancelAdmin.TabIndex = 5;
            this.butCancelAdmin.Text = "Выйти";
            this.butCancelAdmin.UseVisualStyleBackColor = true;
            // 
            // dataAdminGridView
            // 
            this.dataAdminGridView.AllowUserToAddRows = false;
            this.dataAdminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdminGridView.Location = new System.Drawing.Point(260, 13);
            this.dataAdminGridView.Name = "dataAdminGridView";
            this.dataAdminGridView.ReadOnly = true;
            this.dataAdminGridView.Size = new System.Drawing.Size(394, 250);
            this.dataAdminGridView.TabIndex = 6;
            // 
            // butAdminDelete
            // 
            this.butAdminDelete.Location = new System.Drawing.Point(563, 281);
            this.butAdminDelete.Name = "butAdminDelete";
            this.butAdminDelete.Size = new System.Drawing.Size(75, 23);
            this.butAdminDelete.TabIndex = 7;
            this.butAdminDelete.Text = "Удалить";
            this.butAdminDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // textAdminID
            // 
            this.textAdminID.Location = new System.Drawing.Point(62, 13);
            this.textAdminID.Name = "textAdminID";
            this.textAdminID.Size = new System.Drawing.Size(100, 20);
            this.textAdminID.TabIndex = 9;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 321);
            this.Controls.Add(this.textAdminID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butAdminDelete);
            this.Controls.Add(this.dataAdminGridView);
            this.Controls.Add(this.butCancelAdmin);
            this.Controls.Add(this.butInsertAdmin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адмиистраторы";
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button butInsertAdmin;
        private System.Windows.Forms.Button butCancelAdmin;
        private System.Windows.Forms.DataGridView dataAdminGridView;
        private System.Windows.Forms.Button butAdminDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAdminID;
    }
}