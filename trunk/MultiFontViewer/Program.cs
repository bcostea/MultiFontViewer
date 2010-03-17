using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ndi;

namespace MultiFontViewer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AbstractApplicationContext appCtx = new AttributeApplicationContext("MultiFontViewer");
            MultiFontViewerForm mainForm = (MultiFontViewerForm) appCtx.GetComponent("mainForm");

            Application.Run(mainForm);

        }
    }
}
