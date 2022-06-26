using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface IApplicationPage : IPageObject
    {
        Uri PageUrl { get; }
        string Name { get; }
        IEnumerable<string> Titles { get; }

        string SubMenu { get; }
        string MenuName { get; }
    }

    public class ApplicationPageService
    {
        public static IEnumerable<string> Titles
        {
            get
            {
                DriverManager.Driver.WaitForPageContainerToLoaded(1);
                List<string> titles = new List<string>
                {
                    DriverManager.Driver.FindElement(By.Id("data-page-main-heading")).Text
                };

                try
                {
                    var subTitle = DriverManager.Driver.FindElement(By.Id("data-page-sec-heading")).Text;
                    if (subTitle != string.Empty)
                    {
                        titles.Add(subTitle);
                    }
                }
                catch (Exception)
                {
                }

                return titles;
            }
        }
    }
}
