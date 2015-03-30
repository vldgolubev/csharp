﻿namespace AutoserviceUI
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
            this.menu.SuspendLayout();
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
            this.WoksMenuItem});
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
            this.MarksMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MarksMenuItem.Text = "Марки";
            // 
            // ModelsMenuItem
            // 
            this.ModelsMenuItem.Name = "ModelsMenuItem";
            this.ModelsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ModelsMenuItem.Text = "Модели";
            // 
            // TypesMenuItem
            // 
            this.TypesMenuItem.Name = "TypesMenuItem";
            this.TypesMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 262);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосервис";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
    }
}

