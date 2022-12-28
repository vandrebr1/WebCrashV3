using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace WebCrash.WebScraping
{
    public class Main
    {
        public void Configurar()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            var driver = new ChromeDriver();
        }
    }
}
