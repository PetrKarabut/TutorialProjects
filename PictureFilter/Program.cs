﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureFilter
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

            var windowForm = new Form1();
            var UIController = new UserInterfaceController();
            var transformer = new PictureTransformer();

            windowForm.UIController = UIController;
            UIController.WindowForm = windowForm;
            UIController.Transformer = transformer;
            transformer.UIController = UIController;

            transformer.Init();
            windowForm.Init();

            Application.Run(windowForm);
        }

        
    }
}
