using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView
{
    public class PageInitialSetup<T> where T: class, IApplicationPage
    {
        RotemWebNavigator navigator = new RotemWebNavigator();
        /// <summary>
        /// This dictionary stores pairs of "Property Name" of T, and its "Value" at the time where class generated.
        /// </summary>
        private readonly Dictionary<string, string> _initiSetup = new Dictionary<string, string>();

        public void StoreInitialSetup()
        {
            var page = PagesFactory.GetPage<T>();

            if (DriverManager.Driver.Url != page.PageUrl.ToString())
                throw new ArgumentException(@"Current web page view does not correspond to the requested settings page url, check for URL mismatch");
            
            var properties = page.GetType().GetProperties();
            var settingsFields = properties.Where(p => p.PropertyType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ISettingsField<>)));
            if (navigator.GetActiveHouse() == (House)8)
                settingsFields = settingsFields.Where(s => s.Name != "GrowingZones");
            foreach (PropertyInfo settingsField in settingsFields)
            {
                var propValue = settingsField.GetValue(page, null) as ISettingsField<ISystemInputMethod>;
                if (propValue != null) _initiSetup.Add(propValue.Name, propValue.CurrentValue);
            }
        }

        private ISettingsField<ISystemInputMethod> GetSettingsFieldByName(string name)
        {
            var page = PagesFactory.GetPage<T>();

            if (DriverManager.Driver.Url != page.PageUrl.ToString())
                throw new ArgumentException(@"Current web page view does not correspond to the requested settings page url, check for URL mismatch");

            var properties = page.GetType().GetProperties();
            var settingsFields = properties.Where(p => p.PropertyType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ISettingsField<>)));

            return
                settingsFields.Select(
                    settingsField => settingsField.GetValue(page, null) as ISettingsField<ISystemInputMethod>)
                    .FirstOrDefault(field => field != null && field.Name == name);
        }

        public void RestoreInitialSetup()
        {
            foreach (var settingsField in _initiSetup)
            {
                var field = GetSettingsFieldByName(settingsField.Key);
                if (field.CurrentValue != _initiSetup[settingsField.Key])
                    field.SetValue(_initiSetup[settingsField.Key]);
            }
        }
    }
}
