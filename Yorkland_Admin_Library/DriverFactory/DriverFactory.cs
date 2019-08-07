using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yorkland_Admin_Library.DriverFactory
{
    public class DriverFactory 
    {
        private DriverManager driverManager;

        public DriverManager getDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driverManager = new ChromeDriverManager();
                    break;
                case "FireFox":
                    driverManager = new FireFoxDriverManager();
                    break;
                case "IE":
                    driverManager = new IEDriverManager();
                    break;
                default:
                    driverManager = new ChromeDriverManager();
                    break;
            }
            return driverManager;
        }
    }
}
