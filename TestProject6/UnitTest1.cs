using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject6
{
    [TestClass]
    public class UnitTest1
    {
       
        private WebDriver driver = new ChromeDriver();
        [TestInitialize]
        public void Initialize()
        {
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";
        
        }
        [TestMethod]
        public void explore_planet()
        {
          new Toolbar(driver).ClickPlanetsButton();
            string planetname = "Venus";
          var planetpage = new PlanetPage(driver);
           // planetpage.ExplorePlanet(planetname);
            PlanetTile mytile;
          mytile=planetpage.GetPlanet(planetname);
            mytile.ClicktTile();
            string text = mytile.popupmsgmethod(driver);
         //   string popupmsgtext= PlanetPage.PopupMsgMethodForPage(driver,planetname);
            
            Assert.AreEqual(expected: "Exploring Venus", actual: text);
        }
        [TestMethod]
        public void entername_clicksubmit()
        {

            new Toolbar(driver).ClickFormButton();

            var form = new Form(driver);

            form.SetName("Komil");
            form.SetEmail("komiltauqir@gmail.com");
            form.ClickAgree();
            form.ClickState();
            form.SelectState();
            form.ClickSubmit();
        }

        [TestMethod]

        public void checkbyradius()
        {
            new Toolbar(driver).ClickPlanetsButton();
            var planetpage = new PlanetPage(driver);
            PlanetTile mytile;
          //  mytile = planetpage.GetPlanetpredicate(tileelment => tileelment= driver.FindElement(By.ClassName("radius"))>10000000);
           // string text = mytile.popupmsgmethod(driver);
          //  Assert.AreEqual(expected: "Exploring Venus", actual: text);
        }

        [TestMethod]
        public void checkbyname()
        {
            string name = "earth";
            new Toolbar(driver).ClickPlanetsButton();
            var planetpage = new PlanetPage(driver);
            PlanetTile mytile;
            mytile = planetpage.GetPlanetpredicate(PT => PT.name.ToLower() == name);
            mytile.ClicktTile();
            string text = mytile.popupmsgmethod(driver);
            Assert.AreEqual(expected: "Exploring Earth", actual: text);
        }


       






        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

 
    }

}