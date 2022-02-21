﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_MiniKindle
{
    public delegate void FlipPageHandler(bool dir);

    public delegate void RefresherDel();

    public delegate void BookMkHandler(int p);

    public delegate string DisplayPageHandler();

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
            Application.Run(new LibraryView());
        }
    }
}
