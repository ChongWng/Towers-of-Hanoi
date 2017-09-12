/*
 * Class: Program
 * Created by: S.G.Dacey
 * Modified by:	Chong Wang
 * Date: 27/10/2016
 * Description: The main entry point for the application. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers_of_Hanoi
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
            Application.Run(new MainForm());
        }
    }
}
