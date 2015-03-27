namespace AutoserviceUI.View
{
    partial class TypeModelForm
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
            this.textTypeModelID = new System.Windows.Forms.TextBox();
            this.textTypeModelType = new System.Windows.Forms.TextBox();
            this.dataGridTypeModel = new System.Windows.Forms.DataGridView();
            this.butInsertTypeModel = new System.Windows.Forms.Button();
            this.butCancelTypeModel = new System.Windows.Forms.Button();
            this.butDeleteTypeModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeModel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип:";
            // 
            // textTypeModelID
            // 
            this.textTypeModelID.Location = new System.Drawing.Point(55, 15);
            this.textTypeModelID.Name = "textTypeModelID";
            this.textTypeModelID.Size = new System.Drawing.Size(144, 20);
            this.textTypeModelID.TabIndex = 2;
            // 
            // textTypeModelType
            // 
            this.textTypeModelType.Location = new System.Drawing.Point(55, 50);
            this.textTypeModelType.Name = "textTypeModelType";
            this.textTypeModelType.Size = new System.Drawing.Size(144, 20);
            this.textTypeModelType.TabIndex = 3;
            // 
            // dataGridTypeModel
            // 
            this.dataGridTypeModel.AllowUserToAddRows = false;
            this.dataGridTypeModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypeModel.Location = new System.Drawing.Point(234, 15);
            this.dataGridTypeModel.Name = "dataGridTypeModel";
            this.dataGridTypeModel.Size = new System.Drawing.Size(317, 184);
            this.dataGridTypeModel.TabIndex = 4;
            // 
            // butInsertTypeModel
            // 
            this.butInsertTypeModel.Location = new System.Drawing.Point(16, 104);
            this.butInsertTypeModel.Name = "butInsertTypeModel";
            this.butInsertTypeModel.Size = new System.Drawing.Size(75, 23);
            this.butInsertTypeModel.TabIndex = 5;
            this.butInsertTypeModel.Text = "Добавить";
            this.butInsertTypeModel.UseVisualStyleBackColor = true;
            // 
            // butCancelTypeModel
            // 
            this.butCancelTypeModel.Location = new System.Drawing.Point(124, 104);
            this.butCancelTypeModel.Name = "butCancelTypeModel";
            this.butCancelTypeModel.Size = new System.Drawing.Size(75, 23);
            this.butCancelTypeModel.TabIndex = 6;
            this.butCancelTypeModel.Text = "Выход";
            this.butCancelTypeModel.UseVisualStyleBackColor = true;
            // 
            // butDeleteTypeModel
            // 
            this.butDeleteTypeModel.Location = new System.Drawing.Point(476, 217);
            this.butDeleteTypeModel.Name = "butDeleteTypeModel";
            this.butDeleteTypeModel.Size = new System.Drawing.Size(75, 23);
            this.butDeleteTypeModel.TabIndex = 7;
            this.butDeleteTypeModel.Text = "Удалить";
            this.butDeleteTypeModel.UseVisualStyleBackColor = true;
            // 
            // TypeModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 262);
            this.Controls.Add(this.butDeleteTypeModel);
            this.Controls.Add(this.butCancelTypeModel);
            this.Controls.Add(this.butInsertTypeModel);
            this.Controls.Add(this.dataGridTypeModel);
            this.Controls.Add(this.textTypeModelType);
            this.Controls.Add(this.textTypeModelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TypeModelForm";
            this.Text = "TypeModelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTypeModelID;
        private System.Windows.Forms.TextBox textTypeModelType;
        private System.Windows.Forms.DataGridView dataGridTypeModel;
        private System.Windows.Forms.Button butInsertTypeModel;
        private System.Windows.Forms.Button butCancelTypeModel;
        private System.Windows.Forms.Button butDeleteTypeModel;
    }
}