using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject6
{
    internal class PlanetTile
    {
        public string name;
        public IWebElement tile;
       



        public PlanetTile(IWebElement planettile)
        {
            tile = planettile;
            name = planettile.FindElement(By.ClassName("name")).Text;
        }
        internal void ClicktTile() 
        {
            tile.FindElement(By.TagName("button")).Click();
            Thread.Sleep(1000);
            return;

        }
        internal void checknameandClick(IWebElement item)
        {
            item.FindElement(By.TagName("button")).Click();
            Thread.Sleep(1000);
            return;

        }
        internal string popupmsgmethod(WebDriver driver)
        {
            var popup = driver.FindElement(By.ClassName("mr-auto"));
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => popup.Displayed);
            return popup.Text;
        }




    }
}