using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenerateStaticVinReports
{
    public static class Extensions 
    {

        public static bool WaitUntil(this IWebDriver driver, Func<IWebDriver, bool> expression, int timeOutSeconds = 10)
        {

            TimeSpan timeSpent = new TimeSpan();

            bool result = false;
            while (timeSpent.TotalSeconds < timeOutSeconds)
            {

                result = expression.Invoke(driver);

                if (result == true)
                {
                    break;
                }
                Thread.Sleep(timeOutSeconds);
                timeSpent = timeSpent.Add(new TimeSpan(0, 0, 0, 0, timeOutSeconds));

            }
            return result;

        }
    }
}
