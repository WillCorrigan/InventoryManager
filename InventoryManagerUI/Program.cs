﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerUI
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

            // Initialise the database connections
            InventoryManagerLibrary.GlobalConfig.InitialiseConnections(true, true);

            Application.Run(new DashboardForm());

            // TODO - Update to Dashboard Start
        }
    }
}
