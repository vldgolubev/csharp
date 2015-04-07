namespace AutoserviceUI
{
    partial class MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WoksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolCountUncompleteOrders = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupAuto = new System.Windows.Forms.GroupBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.butSearchAuto = new System.Windows.Forms.Button();
            this.rdoPassportNum = new System.Windows.Forms.RadioButton();
            this.rdoLastName = new System.Windows.Forms.RadioButton();
            this.rdoNumberAuto = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectedAuto = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1348, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminsMenuItem,
            this.автомобилиToolStripMenuItem,
            this.WoksMenuItem,
            this.OrdersMenuItem,
            this.ClientsMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // AdminsMenuItem
            // 
            this.AdminsMenuItem.Name = "AdminsMenuItem";
            this.AdminsMenuItem.Size = new System.Drawing.Size(170, 22);
            this.AdminsMenuItem.Text = "Администраторы";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarksMenuItem,
            this.ModelsMenuItem,
            this.TypesMenuItem});
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            // 
            // MarksMenuItem
            // 
            this.MarksMenuItem.Name = "MarksMenuItem";
            this.MarksMenuItem.Size = new System.Drawing.Size(143, 22);
            this.MarksMenuItem.Text = "Марки";
            // 
            // ModelsMenuItem
            // 
            this.ModelsMenuItem.Name = "ModelsMenuItem";
            this.ModelsMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ModelsMenuItem.Text = "Модели";
            // 
            // TypesMenuItem
            // 
            this.TypesMenuItem.Name = "TypesMenuItem";
            this.TypesMenuItem.Size = new System.Drawing.Size(143, 22);
            this.TypesMenuItem.Text = "Типы кузова";
            // 
            // WoksMenuItem
            // 
            this.WoksMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkCategoryMenuItem,
            this.WorksMenuItem,
            this.WorkersMenuItem});
            this.WoksMenuItem.Name = "WoksMenuItem";
            this.WoksMenuItem.Size = new System.Drawing.Size(170, 22);
            this.WoksMenuItem.Text = "Работы";
            // 
            // WorkCategoryMenuItem
            // 
            this.WorkCategoryMenuItem.Name = "WorkCategoryMenuItem";
            this.WorkCategoryMenuItem.Size = new System.Drawing.Size(166, 22);
            this.WorkCategoryMenuItem.Text = "Категории работ";
            // 
            // WorksMenuItem
            // 
            this.WorksMenuItem.Name = "WorksMenuItem";
            this.WorksMenuItem.Size = new System.Drawing.Size(166, 22);
            this.WorksMenuItem.Text = "Работы";
            // 
            // WorkersMenuItem
            // 
            this.WorkersMenuItem.Name = "WorkersMenuItem";
            this.WorkersMenuItem.Size = new System.Drawing.Size(166, 22);
            this.WorkersMenuItem.Text = "Работники";
            // 
            // OrdersMenuItem
            // 
            this.OrdersMenuItem.Name = "OrdersMenuItem";
            this.OrdersMenuItem.Size = new System.Drawing.Size(170, 22);
            this.OrdersMenuItem.Text = "Заказы";
            // 
            // ClientsMenuItem
            // 
            this.ClientsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientMenuItem,
            this.AutoClientMenuItem});
            this.ClientsMenuItem.Name = "ClientsMenuItem";
            this.ClientsMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ClientsMenuItem.Text = "Клиенты";
            // 
            // ClientMenuItem
            // 
            this.ClientMenuItem.Name = "ClientMenuItem";
            this.ClientMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ClientMenuItem.Text = "Клиенты";
            // 
            // AutoClientMenuItem
            // 
            this.AutoClientMenuItem.Name = "AutoClientMenuItem";
            this.AutoClientMenuItem.Size = new System.Drawing.Size(144, 22);
            this.AutoClientMenuItem.Text = "Автомобили";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolCountUncompleteOrders});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1348, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(215, 17);
            this.toolStripStatusLabel1.Text = "Количество не выполненных заказов:";
            // 
            // toolCountUncompleteOrders
            // 
            this.toolCountUncompleteOrders.Name = "toolCountUncompleteOrders";
            this.toolCountUncompleteOrders.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1324, 285);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmbWorker
            // 
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(94, 357);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(267, 21);
            this.cmbWorker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Мастер:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добваить заказ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Удалить заказ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Формирование заказа:";
            // 
            // groupAuto
            // 
            this.groupAuto.Controls.Add(this.txtSelectedAuto);
            this.groupAuto.Controls.Add(this.label4);
            this.groupAuto.Controls.Add(this.txtSearchValue);
            this.groupAuto.Controls.Add(this.label2);
            this.groupAuto.Controls.Add(this.txtSearch);
            this.groupAuto.Controls.Add(this.butSearchAuto);
            this.groupAuto.Controls.Add(this.rdoPassportNum);
            this.groupAuto.Controls.Add(this.rdoLastName);
            this.groupAuto.Controls.Add(this.rdoNumberAuto);
            this.groupAuto.Location = new System.Drawing.Point(12, 384);
            this.groupAuto.Name = "groupAuto";
            this.groupAuto.Size = new System.Drawing.Size(526, 179);
            this.groupAuto.TabIndex = 10;
            this.groupAuto.TabStop = false;
            this.groupAuto.Text = "Автомобиль";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(19, 120);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(100, 20);
            this.txtSearchValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Значение:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(361, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // butSearchAuto
            // 
            this.butSearchAuto.Location = new System.Drawing.Point(207, 117);
            this.butSearchAuto.Name = "butSearchAuto";
            this.butSearchAuto.Size = new System.Drawing.Size(126, 23);
            this.butSearchAuto.TabIndex = 3;
            this.butSearchAuto.Text = "Найти";
            this.butSearchAuto.UseVisualStyleBackColor = true;
            // 
            // rdoPassportNum
            // 
            this.rdoPassportNum.AutoSize = true;
            this.rdoPassportNum.Location = new System.Drawing.Point(224, 29);
            this.rdoPassportNum.Name = "rdoPassportNum";
            this.rdoPassportNum.Size = new System.Drawing.Size(109, 17);
            this.rdoPassportNum.TabIndex = 2;
            this.rdoPassportNum.TabStop = true;
            this.rdoPassportNum.Text = "Номер паспорта";
            this.rdoPassportNum.UseVisualStyleBackColor = true;
            // 
            // rdoLastName
            // 
            this.rdoLastName.AutoSize = true;
            this.rdoLastName.Location = new System.Drawing.Point(87, 29);
            this.rdoLastName.Name = "rdoLastName";
            this.rdoLastName.Size = new System.Drawing.Size(131, 17);
            this.rdoLastName.TabIndex = 1;
            this.rdoLastName.TabStop = true;
            this.rdoLastName.Text = "Фамилия владельца";
            this.rdoLastName.UseVisualStyleBackColor = true;
            // 
            // rdoNumberAuto
            // 
            this.rdoNumberAuto.AutoSize = true;
            this.rdoNumberAuto.Location = new System.Drawing.Point(19, 29);
            this.rdoNumberAuto.Name = "rdoNumberAuto";
            this.rdoNumberAuto.Size = new System.Drawing.Size(62, 17);
            this.rdoNumberAuto.TabIndex = 0;
            this.rdoNumberAuto.TabStop = true;
            this.rdoNumberAuto.Text = "По ГРЗ";
            this.rdoNumberAuto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выбранный автомобиль:";
            // 
            // txtSelectedAuto
            // 
            this.txtSelectedAuto.Enabled = false;
            this.txtSelectedAuto.Location = new System.Drawing.Point(159, 88);
            this.txtSelectedAuto.Name = "txtSelectedAuto";
            this.txtSelectedAuto.Size = new System.Drawing.Size(361, 20);
            this.txtSelectedAuto.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 628);
            this.Controls.Add(this.groupAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосервис";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupAuto.ResumeLayout(false);
            this.groupAuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TypesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WoksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoClientMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolCountUncompleteOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupAuto;
        private System.Windows.Forms.RadioButton rdoPassportNum;
        private System.Windows.Forms.RadioButton rdoLastName;
        private System.Windows.Forms.RadioButton rdoNumberAuto;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button butSearchAuto;
        private System.Windows.Forms.TextBox txtSelectedAuto;
        private System.Windows.Forms.Label label4;
    }
}

