using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllReady.BrowserTest.Controls
{
    class DropDown
    {
        IWebDriver _driver;
        SelectElement _selectElement;

        public DropDown(IWebDriver driver, string id)
        {
            _driver = driver;
            _selectElement = new SelectElement(_driver.FindElement(By.Id(id)));
        }

        public void SelectByText(string text, bool partialMatch = false)
        {
            _selectElement.SelectByText(text, partialMatch);
        }

        public string GetLastItem()
        {
            return _selectElement.Options[_selectElement.Options.Count - 1].Text;
        }

        public void SelectLastItem()
        {
            _selectElement.SelectByIndex(_selectElement.Options.Count - 1);
        }
    }
}