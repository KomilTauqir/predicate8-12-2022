using OpenQA.Selenium;

namespace TestProject6
{
    internal class Form
    {
        private WebDriver driver;

        public Form(WebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickAgree()
        {
            driver.FindElement(By.CssSelector("[for=agree]")).Click();
        }

        internal void ClickState()
        {
            driver.FindElement(By.CssSelector("[aria-haspopup=listbox]")).Click();
        }

        internal void ClickSubmit()
        {
            //driver.FindElement(By.XPath("//*[contains(text(),'submit')]")).Click();
        }

        internal void SelectState()
        {

            System.Threading.Thread.Sleep(1000); System.Threading.Thread.Sleep(1000); System.Threading.Thread.Sleep(1000);
           // driver.FindElement(By.CssSelector("[for=agree]")).Click();
        }

        internal void SetEmail(string email)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
        }

        internal void SetName(String name)
        {
            driver.FindElement(By.Id("name")).SendKeys(name);
        }
    }
}