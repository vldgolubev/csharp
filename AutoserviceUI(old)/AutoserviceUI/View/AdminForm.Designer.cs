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
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(61, 20);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(192, 20);
            this.textLogin.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(61, 48);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(192, 20);
            this.textPassword.TabIndex = 3;
            // 
            // butInsertAdmin
            // 
            this.butInsertAdmin.Location = new System.Drawing.Point(26, 94);
            this.butInsertAdmin.Name = "butInsertAdmin";
            this.butInsertAdmin.Size = new System.Drawing.Size(106, 30);
            this.butInsertAdmin.TabIndex = 4;
            this.butInsertAdmin.Text = "Добавить";
            this.butInsertAdmin.UseVisualStyleBackColor = true;
            // 
            // butCancelAdmin
            // 
            this.butCancelAdmin.Location = new System.Drawing.Point(147, 94);
            this.butCancelAdmin.Name = "butCancelAdmin";
            this.butCancelAdmin.Size = new System.Drawing.Size(106, 30);
            this.butCancelAdmin.TabIndex = 5;
            this.butCancelAdmin.Text = "Выйти";
            this.butCancelAdmin.UseVisualStyleBackColor = true;
            // 
            // dataAdminGridView
            // 
            this.dataAdminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdminGridView.Location = new System.Drawing.Point(260, 13);
            this.dataAdminGridView.Name = "dataAdminGridView";
            this.dataAdminGridView.Size = new System.Drawing.Size(394, 296);
            this.dataAdminGridView.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 321);
            this.Controls.Add(this.dataAdminGridView);
            this.Controls.Add(this.butCancelAdmin);
            this.Controls.Add(this.butInsertAdmin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
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
    }
}