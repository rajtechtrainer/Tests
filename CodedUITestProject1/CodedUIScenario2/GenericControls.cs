using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIScenario2
{
    class GenericControls
    {

        public void clickButton(String btnName)
        {
            WinRadioButton button = new WinRadioButton();
            button.SearchProperties[WinButton.PropertyNames.Name] = btnName;
            if(button.Enabled)
            {
                Mouse.Click(button);
            }
            else
            {
                Assert.AreEqual(true, button.Enabled, "Button is Not Enabled");
            }            
        }

        public void setText(String strText)
        {
            WinWindow targetWindow = new WinWindow(Setup.auTest);
            targetWindow.SearchProperties.Add(WinWindow.PropertyNames.ControlName, "textBox1");
            WinEdit txtBox = new WinEdit(targetWindow);
            txtBox.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBox1";
            if (txtBox.Enabled)
            {
                Keyboard.SendKeys(txtBox, strText);
            }
            else
            {
                Assert.AreEqual(true, txtBox.Enabled, "TextBox is Not Enabled");
            }

        }

        public void setCheckBox()
        {
            //Setup.auTest.SetFocus();
            WinWindow targetWindow = new WinWindow(Setup.auTest);
            targetWindow.SearchProperties.Add(WinWindow.PropertyNames.ControlName, "chkCookie");
            targetWindow.SetFocus();
            WinCheckBox chkBox = new WinCheckBox(targetWindow);
            chkBox.DrawHighlight();
            chkBox.SearchProperties[WinWindow.PropertyNames.ControlName] = "chkCookie";
            Mouse.Click(chkBox);
        }

        public void setRadioButton()
        {
            WinRadioButton rButton = new WinRadioButton();
            rButton.SearchProperties[WinWindow.PropertyNames.ControlName] = "radioIE";
            Mouse.Click(rButton);
        }

    }
}
