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
            clsPainting.LoadPaintingForm = new clsPainting.LoadPaintingFormDelegate(frmPainting.Run);
            clsPhotograph.LoadPhotographForm = new clsPhotograph.LoadPhotographFormDelegate(frmPhotograph.Run);
            clsSculpture.LoadSculptureForm = new clsSculpture.LoadSculptureFormDelegate(frmSculpture.Run);
            Application.Run(frmMain.Instance);
        }
    }
}
