﻿namespace AutoserviceUI.View
{
    partial class ModelForm
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
            this.cmbMark = new System.Windows.Forms.ComboBox();
            this.butInsertModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textModelName = new System.Windows.Forms.TextBox();
            this.textVolume = new System.Windows.Forms.TextBox();
            this.textPower = new System.Windows.Forms.TextBox();
            this.cmbTypeModel = new System.Windows.Forms.ComboBox();
            this.butCancelModel = new System.Windows.Forms.Button();
            this.butDeleteModel = new System.Windows.Forms.Button();
            this.dataGridModels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModels)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMark
            // 
            this.cmbMark.FormattingEnabled = true;
            this.cmbMark.Items.AddRange(new object[] {
            "Выберите марку"});
            this.cmbMark.Location = new System.Drawing.Point(136, 24);
            this.cmbMark.Name = "cmbMark";
            this.cmbMark.Size = new System.Drawing.Size(121, 21);
            this.cmbMark.TabIndex = 0;
            // 
            // butInsertModel
            // 
            this.butInsertModel.Location = new System.Drawing.Point(60, 189);
            this.butInsertModel.Name = "butInsertModel";
            this.butInsertModel.Size = new System.Drawing.Size(75, 23);
            this.butInsertModel.TabIndex = 1;
            this.butInsertModel.Text = "Добавить";
            this.butInsertModel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Марка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название модели:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Объем двигателя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Мощность двигателя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тип кузова:";
            // 
            // textModelName
            // 
            this.textModelName.Location = new System.Drawing.Point(136, 57);
            this.textModelName.Name = "textModelName";
            this.textModelName.Size = new System.Drawing.Size(121, 20);
            this.textModelName.TabIndex = 7;
            // 
            // textVolume
            // 
            this.textVolume.Location = new System.Drawing.Point(136, 88);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(121, 20);
            this.textVolume.TabIndex = 8;
            // 
            // textPower
            // 
            this.textPower.Location = new System.Drawing.Point(136, 122);
            this.textPower.Name = "textPower";
            this.textPower.Size = new System.Drawing.Size(121, 20);
            this.textPower.TabIndex = 9;
            // 
            // cmbTypeModel
            // 
            this.cmbTypeModel.FormattingEnabled = true;
            this.cmbTypeModel.Location = new System.Drawing.Point(136, 152);
            this.cmbTypeModel.Name = "cmbTypeModel";
            this.cmbTypeModel.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeModel.TabIndex = 10;
            // 
            // butCancelModel
            // 
            this.butCancelModel.Location = new System.Drawing.Point(182, 189);
            this.butCancelModel.Name = "butCancelModel";
            this.butCancelModel.Size = new System.Drawing.Size(75, 23);
            this.butCancelModel.TabIndex = 11;
            this.butCancelModel.Text = "Выход";
            this.butCancelModel.UseVisualStyleBackColor = true;
            // 
            // butDeleteModel
            // 
            this.butDeleteModel.Location = new System.Drawing.Point(847, 227);
            this.butDeleteModel.Name = "butDeleteModel";
            this.butDeleteModel.Size = new System.Drawing.Size(75, 23);
            this.butDeleteModel.TabIndex = 12;
            this.butDeleteModel.Text = "Удалить";
            this.butDeleteModel.UseVisualStyleBackColor = true;
            // 
            // dataGridModels
            // 
            this.dataGridModels.AllowUserToAddRows = false;
            this.dataGridModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModels.Location = new System.Drawing.Point(263, 12);
            this.dataGridModels.Name = "dataGridModels";
            this.dataGridModels.Size = new System.Drawing.Size(659, 209);
            this.dataGridModels.TabIndex = 13;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 262);
            this.Controls.Add(this.dataGridModels);
            this.Controls.Add(this.butDeleteModel);
            this.Controls.Add(this.butCancelModel);
            this.Controls.Add(this.cmbTypeModel);
            this.Controls.Add(this.textPower);
            this.Controls.Add(this.textVolume);
            this.Controls.Add(this.textModelName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butInsertModel);
            this.Controls.Add(this.cmbMark);
            this.Name = "ModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMark;
        private System.Windows.Forms.Button butInsertModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textModelName;
        private System.Windows.Forms.TextBox textVolume;
        private System.Windows.Forms.TextBox textPower;
        private System.Windows.Forms.ComboBox cmbTypeModel;
        private System.Windows.Forms.Button butCancelModel;
        private System.Windows.Forms.Button butDeleteModel;
        private System.Windows.Forms.DataGridView dataGridModels;
    }
}