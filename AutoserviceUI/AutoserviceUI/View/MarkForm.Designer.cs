﻿namespace AutoserviceUI.View
{
    partial class MarkForm
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
            this.dataGridMark = new System.Windows.Forms.DataGridView();
            this.butDeleteMark = new System.Windows.Forms.Button();
            this.textMarkID = new System.Windows.Forms.TextBox();
            this.textMarkName = new System.Windows.Forms.TextBox();
            this.textMarkCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butCancelMark = new System.Windows.Forms.Button();
            this.butInsertMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMark)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMark
            // 
            this.dataGridMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMark.Location = new System.Drawing.Point(295, 12);
            this.dataGridMark.Name = "dataGridMark";
            this.dataGridMark.Size = new System.Drawing.Size(277, 239);
            this.dataGridMark.TabIndex = 0;
            // 
            // butDeleteMark
            // 
            this.butDeleteMark.Location = new System.Drawing.Point(476, 274);
            this.butDeleteMark.Name = "butDeleteMark";
            this.butDeleteMark.Size = new System.Drawing.Size(75, 23);
            this.butDeleteMark.TabIndex = 1;
            this.butDeleteMark.Text = "Удалить";
            this.butDeleteMark.UseVisualStyleBackColor = true;
            // 
            // textMarkID
            // 
            this.textMarkID.Location = new System.Drawing.Point(55, 22);
            this.textMarkID.Name = "textMarkID";
            this.textMarkID.Size = new System.Drawing.Size(208, 20);
            this.textMarkID.TabIndex = 2;
            // 
            // textMarkName
            // 
            this.textMarkName.Location = new System.Drawing.Point(80, 63);
            this.textMarkName.Name = "textMarkName";
            this.textMarkName.Size = new System.Drawing.Size(183, 20);
            this.textMarkName.TabIndex = 3;
            // 
            // textMarkCountry
            // 
            this.textMarkCountry.Location = new System.Drawing.Point(163, 102);
            this.textMarkCountry.Name = "textMarkCountry";
            this.textMarkCountry.Size = new System.Drawing.Size(100, 20);
            this.textMarkCountry.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Марка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Страна-производитель:";
            // 
            // butCancelMark
            // 
            this.butCancelMark.Location = new System.Drawing.Point(188, 161);
            this.butCancelMark.Name = "butCancelMark";
            this.butCancelMark.Size = new System.Drawing.Size(75, 23);
            this.butCancelMark.TabIndex = 8;
            this.butCancelMark.Text = "Закрыть";
            this.butCancelMark.UseVisualStyleBackColor = true;
            // 
            // butInsertMark
            // 
            this.butInsertMark.Location = new System.Drawing.Point(34, 161);
            this.butInsertMark.Name = "butInsertMark";
            this.butInsertMark.Size = new System.Drawing.Size(75, 23);
            this.butInsertMark.TabIndex = 9;
            this.butInsertMark.Text = "Добавить";
            this.butInsertMark.UseVisualStyleBackColor = true;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 323);
            this.Controls.Add(this.butInsertMark);
            this.Controls.Add(this.butCancelMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMarkCountry);
            this.Controls.Add(this.textMarkName);
            this.Controls.Add(this.textMarkID);
            this.Controls.Add(this.butDeleteMark);
            this.Controls.Add(this.dataGridMark);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMark;
        private System.Windows.Forms.Button butDeleteMark;
        private System.Windows.Forms.TextBox textMarkID;
        private System.Windows.Forms.TextBox textMarkName;
        private System.Windows.Forms.TextBox textMarkCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butCancelMark;
        private System.Windows.Forms.Button butInsertMark;
    }
}