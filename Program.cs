using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Turbulence
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var controller = new FormController();
        }
    }
}
