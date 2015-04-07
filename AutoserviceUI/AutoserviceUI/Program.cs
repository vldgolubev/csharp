﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoserviceCore;

namespace AutoserviceUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessageService service = new MessageService();
            Main mainManage = new AutoserviceCore.Main();
            MainPresenter presenter = new MainPresenter(form,service,mainManage);
            Application.Run(form);
        }
    }
}
