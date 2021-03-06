﻿namespace AutoserviceUI.View
{
    partial class CarsFormView
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
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtNumberAuto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butInsertCar = new System.Windows.Forms.Button();
            this.butCancelCar = new System.Windows.Forms.Button();
            this.butDeleteCar = new System.Windows.Forms.Button();
            this.txtOwnerCarID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCars
            // 
            this.dataGridCars.AllowUserToAddRows = false;
            this.dataGridCars.AllowUserToDeleteRows = false;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(370, 12);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.Size = new System.Drawing.Size(836, 238);
            this.dataGridCars.TabIndex = 0;
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(81, 12);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(283, 21);
            this.cmbOwner.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(81, 39);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(283, 21);
            this.cmbModel.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(81, 66);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(283, 20);
            this.txtColor.TabIndex = 4;
            // 
            // txtNumberAuto
            // 
            this.txtNumberAuto.Location = new System.Drawing.Point(81, 92);
            this.txtNumberAuto.Name = "txtNumberAuto";
            this.txtNumberAuto.Size = new System.Drawing.Size(283, 20);
            this.txtNumberAuto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Владелец:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Модель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цвет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер:";
            // 
            // butInsertCar
            // 
            this.butInsertCar.Location = new System.Drawing.Point(168, 132);
            this.butInsertCar.Name = "butInsertCar";
            this.butInsertCar.Size = new System.Drawing.Size(95, 32);
            this.butInsertCar.TabIndex = 11;
            this.butInsertCar.Text = "Добавить";
            this.butInsertCar.UseVisualStyleBackColor = true;
            // 
            // butCancelCar
            // 
            this.butCancelCar.Location = new System.Drawing.Point(269, 132);
            this.butCancelCar.Name = "butCancelCar";
            this.butCancelCar.Size = new System.Drawing.Size(95, 32);
            this.butCancelCar.TabIndex = 12;
            this.butCancelCar.Text = "Выход";
            this.butCancelCar.UseVisualStyleBackColor = true;
            // 
            // butDeleteCar
            // 
            this.butDeleteCar.Location = new System.Drawing.Point(269, 170);
            this.butDeleteCar.Name = "butDeleteCar";
            this.butDeleteCar.Size = new System.Drawing.Size(95, 32);
            this.butDeleteCar.TabIndex = 13;
            this.butDeleteCar.Text = "Удалить";
            this.butDeleteCar.UseVisualStyleBackColor = true;
            // 
            // txtOwnerCarID
            // 
            this.txtOwnerCarID.Location = new System.Drawing.Point(12, 201);
            this.txtOwnerCarID.Name = "txtOwnerCarID";
            this.txtOwnerCarID.Size = new System.Drawing.Size(100, 20);
            this.txtOwnerCarID.TabIndex = 14;
            this.txtOwnerCarID.Visible = false;
            // 
            // CarsFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 262);
            this.Controls.Add(this.txtOwnerCarID);
            this.Controls.Add(this.butDeleteCar);
            this.Controls.Add(this.butCancelCar);
            this.Controls.Add(this.butInsertCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberAuto);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.dataGridCars);
            this.Name = "CarsFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtNumberAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butInsertCar;
        private System.Windows.Forms.Button butCancelCar;
        private System.Windows.Forms.Button butDeleteCar;
        private System.Windows.Forms.TextBox txtOwnerCarID;
    }
}