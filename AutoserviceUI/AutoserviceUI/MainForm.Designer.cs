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
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1198, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1198, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 433);
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
    }
}

