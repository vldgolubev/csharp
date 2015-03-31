namespace AutoserviceUI.View
{
    partial class WorksFormView
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkName = new System.Windows.Forms.TextBox();
            this.txtWorkCost = new System.Windows.Forms.TextBox();
            this.cmbWorkCategory = new System.Windows.Forms.ComboBox();
            this.dataGridWorks = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название работы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категория работ:";
            // 
            // txtWorkName
            // 
            this.txtWorkName.Location = new System.Drawing.Point(137, 5);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(153, 20);
            this.txtWorkName.TabIndex = 3;
            // 
            // txtWorkCost
            // 
            this.txtWorkCost.Location = new System.Drawing.Point(137, 31);
            this.txtWorkCost.Name = "txtWorkCost";
            this.txtWorkCost.Size = new System.Drawing.Size(153, 20);
            this.txtWorkCost.TabIndex = 4;
            // 
            // cmbWorkCategory
            // 
            this.cmbWorkCategory.FormattingEnabled = true;
            this.cmbWorkCategory.Location = new System.Drawing.Point(12, 57);
            this.cmbWorkCategory.Name = "cmbWorkCategory";
            this.cmbWorkCategory.Size = new System.Drawing.Size(278, 21);
            this.cmbWorkCategory.TabIndex = 5;
            // 
            // dataGridWorks
            // 
            this.dataGridWorks.AllowUserToAddRows = false;
            this.dataGridWorks.AllowUserToDeleteRows = false;
            this.dataGridWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorks.Location = new System.Drawing.Point(296, 5);
            this.dataGridWorks.Name = "dataGridWorks";
            this.dataGridWorks.ReadOnly = true;
            this.dataGridWorks.Size = new System.Drawing.Size(598, 245);
            this.dataGridWorks.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(137, 84);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // WorksFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 262);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridWorks);
            this.Controls.Add(this.cmbWorkCategory);
            this.Controls.Add(this.txtWorkCost);
            this.Controls.Add(this.txtWorkName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorksFormView";
            this.Text = "WorksFormView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkName;
        private System.Windows.Forms.TextBox txtWorkCost;
        private System.Windows.Forms.ComboBox cmbWorkCategory;
        private System.Windows.Forms.DataGridView dataGridWorks;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}