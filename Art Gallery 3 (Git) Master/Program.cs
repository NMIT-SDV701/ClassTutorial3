using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Version_3_C
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsPainting.LoadPaintingForm = frmPainting.Run;
            clsPhotograph.LoadPhotographForm = frmPhotograph.Run;
            clsSculpture.LoadSculptureForm = frmSculpture.Run;
            Application.Run(frmMain.Instance);
        }
    }
}
