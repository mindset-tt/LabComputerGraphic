using LabComputerGraphic.Week1;
using LabComputerGraphic.Week2;
using LabComputerGraphic.Week3_4_5;
using LabComputerGraphic.Week6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabComputerGraphic
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
            Application.Run(new Week1_Lab());
            Application.Run(new Homework());
            Application.Run(new Week2_Lab());
            Application.Run(new Week3_Lab());
            Application.Run(new Week3_2_Lab());
            Application.Run(new Week3_3());
            Application.Run(new Week4_1());
            Application.Run(new Week4_2());
            Application.Run(new Week4_3());
            Application.Run(new Week5_1());
            Application.Run(new Week5_2());
            Application.Run(new Week5_3());
            Application.Run(new Week5_4());
            Application.Run(new Week6_1());
            Application.Run(new Week6_2());
        }
    }
}
