using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework.Core.Element
{
    public interface Button : Element
    {
        void Click();

        IWebElement getElement();
    }
}
