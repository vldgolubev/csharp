﻿namespace AutoserviceUI.View
{
    partial class OrderWorksFormView
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
            this.dataGridOrderWorks = new System.Windows.Forms.DataGridView();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWork = new System.Windows.Forms.ComboBox();
            this.butInsert = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.groupWorks = new System.Windows.Forms.GroupBox();
            this.butSelectWorksByOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumWork = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderWorks)).BeginInit();
            this.groupWorks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridOrderWorks
            // 
            this.dataGridOrderWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderWorks.Location = new System.Drawing.Point(12, 145);
            this.dataGridOrderWorks.Name = "dataGridOrderWorks";
            this.dataGridOrderWorks.Size = new System.Drawing.Size(846, 315);
            this.dataGridOrderWorks.TabIndex = 0;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(9, 52);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.Visible = false;
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(65, 15);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(619, 21);
            this.cmbOrder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заказ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Работы:";
            // 
            // cmbWork
            // 
            this.cmbWork.FormattingEnabled = true;
            this.cmbWork.Location = new System.Drawing.Point(133, 73);
            this.cmbWork.Name = "cmbWork";
            this.cmbWork.Size = new System.Drawing.Size(533, 21);
            this.cmbWork.TabIndex = 7;
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(709, 91);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(82, 32);
            this.butInsert.TabIndex = 8;
            this.butInsert.Text = "Добавить";
            this.butInsert.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(690, 466);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(80, 32);
            this.butDelete.TabIndex = 9;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(776, 466);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(82, 32);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Выход";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберете категорию:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(133, 28);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(533, 21);
            this.cmbCategory.TabIndex = 12;
            // 
            // groupWorks
            // 
            this.groupWorks.Controls.Add(this.cmbCategory);
            this.groupWorks.Controls.Add(this.label2);
            this.groupWorks.Controls.Add(this.cmbWork);
            this.groupWorks.Controls.Add(this.label3);
            this.groupWorks.Controls.Add(this.txtOrderID);
            this.groupWorks.Location = new System.Drawing.Point(12, 39);
            this.groupWorks.Name = "groupWorks";
            this.groupWorks.Size = new System.Drawing.Size(672, 100);
            this.groupWorks.TabIndex = 13;
            this.groupWorks.TabStop = false;
            this.groupWorks.Text = "Работы:";
            // 
            // butSelectWorksByOrder
            // 
            this.butSelectWorksByOrder.Location = new System.Drawing.Point(709, 15);
            this.butSelectWorksByOrder.Name = "butSelectWorksByOrder";
            this.butSelectWorksByOrder.Size = new System.Drawing.Size(149, 43);
            this.butSelectWorksByOrder.TabIndex = 14;
            this.butSelectWorksByOrder.Text = "Найти работы по заказу";
            this.butSelectWorksByOrder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Сумма работ:";
            // 
            // txtSumWork
            // 
            this.txtSumWork.Enabled = false;
            this.txtSumWork.Location = new System.Drawing.Point(578, 470);
            this.txtSumWork.Name = "txtSumWork";
            this.txtSumWork.Size = new System.Drawing.Size(100, 20);
            this.txtSumWork.TabIndex = 16;
            // 
            // OrderWorksFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 502);
            this.Controls.Add(this.txtSumWork);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butSelectWorksByOrder);
            this.Controls.Add(this.groupWorks);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.dataGridOrderWorks);
            this.Name = "OrderWorksFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderFormView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderWorks)).EndInit();
            this.groupWorks.ResumeLayout(false);
            this.groupWorks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrderWorks;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWork;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox groupWorks;
        private System.Windows.Forms.Button butSelectWorksByOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSumWork;
    }
}