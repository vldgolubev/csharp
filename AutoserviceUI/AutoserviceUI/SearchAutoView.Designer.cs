﻿namespace AutoserviceUI
{
    partial class SearchAutoView
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
            this.dataGridSearchAuto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butAccept = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSearchAuto
            // 
            this.dataGridSearchAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchAuto.Location = new System.Drawing.Point(2, 33);
            this.dataGridSearchAuto.Name = "dataGridSearchAuto";
            this.dataGridSearchAuto.Size = new System.Drawing.Size(545, 397);
            this.dataGridSearchAuto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результаты поиска";
            // 
            // butAccept
            // 
            this.butAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAccept.Location = new System.Drawing.Point(144, 454);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(103, 38);
            this.butAccept.TabIndex = 2;
            this.butAccept.Text = "Выбрать";
            this.butAccept.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(280, 454);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(103, 38);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Отменить";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // SearchAutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 504);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSearchAuto);
            this.Name = "SearchAutoView";
            this.Text = "SearchAutoView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearchAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Button butCancel;
    }
}