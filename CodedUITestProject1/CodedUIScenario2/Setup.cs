using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIScenario2
{
    class Setup
    {
        ApplicationUnderTest appExe;
        public static WinWindow auTest;
        public void runApplication(String fullPath)
        {
            appExe = ApplicationUnderTest.Launch(fullPath);
            auTest = new WinWindow(appExe);
        }

        public void closeApplication()
        {
            appExe.Close();
        }
    }
}
