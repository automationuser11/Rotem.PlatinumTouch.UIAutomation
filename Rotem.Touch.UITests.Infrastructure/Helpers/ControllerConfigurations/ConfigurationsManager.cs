using System;
using System.Collections.Generic;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations
{
    public class ConfigurationsManager
    {
        public static RotemWebNavigator navigator = new RotemWebNavigator();
        public static IControllerConfiguration ActiveConfiguration
        {
            get
            {
                switch (ConfigurationManagerHelper.ControllerType)
                {
                    case "BroilerPrecision":
                        _activeConfiguration = _activeConfiguration ?? new BroilerPrecisionConfiguration();
                        break;
                    case "BroilerStandard":
                        _activeConfiguration = _activeConfiguration ?? new BroilerStandardConfiguration();
                        break;
                    case "BreederPrecisionBasicFeeding":
                        _activeConfiguration = _activeConfiguration ?? new BreederPrecisionBasicFeedingConfiguration();
                        break;
                    case "BreederPrecisionAdvancedFeeding":
                        _activeConfiguration = _activeConfiguration ?? new BreederPrecisionAdvancedFeedingConfiguration();
                        break;
                    case "BreederStandardBasicFeeding":
                        _activeConfiguration = _activeConfiguration ?? new BreederStandardBasicFeedingConfiguration();
                        break;
                    case "BreederStandardAdvancedFeeding":
                        _activeConfiguration = _activeConfiguration ?? new BreederStandardAdvancedFeedingConfiguration();
                        break;
                    case "LayerPrecision":
                        _activeConfiguration = _activeConfiguration ?? new LayerPrecisionConfiguration();
                        break;
                    case "PigsPrecisionRoom":
                        _activeConfiguration = _activeConfiguration ?? new PigsPrecisionRoomConfiguration();
                        break;
                }
                return _activeConfiguration;
            }
        }
        private static IControllerConfiguration _activeConfiguration;
        private static bool IsPageContainsTable(IApplicationPage page)
        {
            var type = page.GetType();
            var interfaces = type.GetInterfaces();
            if (interfaces.Contains(typeof(ITablePage))) return true;

            try
            {
                var gArgs = type.GetGenericArguments();
                var types = new List<Type>();
                foreach (var gType in gArgs)
                {
                    types.AddRange(gType.GetInterfaces());
                }

                return types.Any(interfaceItem => interfaceItem == typeof(ITablePage));

            }
            catch (NotSupportedException)
            {
                return false;
            }
        }

        internal static List<ITableColumn> GetTableSetup(IApplicationPage page)
        {
            if (!ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(page.GetType()))
                throw new KeyNotFoundException(string.Format("Page named: {0} is not part of the fixed-setup pages collection or does not contains table element.", page));

            if (!IsPageContainsTable(page))
                throw new ArgumentException("Page does not implements ITablePage interface.");

            return ActiveConfiguration.FixedPagesSetupDictionary[page.GetType()].TableColumns.ToList();
        }
        internal static List<string> GetPageTitles(IApplicationPage page)
        {
            if (!ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(page.GetType()))
                throw new KeyNotFoundException(string.Format("Page named: {0} is not part of the fixed-setup table collection or does not contains any titles.", page));

            return ActiveConfiguration.FixedPagesSetupDictionary[page.GetType()].PageTitles.ToList();
        }

        internal static bool IsPageExist<T>() where T : IApplicationPage
        {
            return ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(typeof(T));
        }
        internal static bool IsPageExist(IApplicationPage page)
        {
            return ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(page.GetType());
        }

        internal static bool IsTabPageExist<T>() where T : IMetadataDependentPageObject
        {
            return ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(typeof(T));
        }

        internal static IEnumerable<string> GetTabsNames<T>() where T : ITabsPage
        {
            var setup = GetPageSetup<T>();
            return setup.TabsCollection;
        }
        internal static IEnumerable<string> GetTabsNames(ITabsPage tabsPage)
        {
            var setup = GetPageSetup(tabsPage);
            return setup.TabsCollection;
        }
        internal static bool IsTabPageExist(IApplicationPage page)
        {
            return ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(page.GetType());
        }

        internal static ControllerPageSetup GetPageSetup<T>() where T : IApplicationPage
        {
            if (!ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(typeof(T)))
            {
                if (!ActiveConfiguration.PagesSetupDictionary.ContainsKey(typeof(T)))
                    throw new KeyNotFoundException(string.Format("Page named: {0} is not part of the fixed-setup pages collection or does not contains table element.", typeof(T)));
                else
                    return ActiveConfiguration.PagesSetupDictionary[typeof(T)];
            }

             return ActiveConfiguration.FixedPagesSetupDictionary[typeof(T)];
        }
        internal static ControllerPageSetup GetPageSetup(IApplicationPage page)
        {
            if (!ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(page.GetType()))
            {
                if (!ActiveConfiguration.PagesSetupDictionary.ContainsKey(page.GetType()))
                    throw new KeyNotFoundException(string.Format("Page named: {0} is not part of the fixed-setup pages collection or does not contains table element.", page.GetType()));
                else
                    return ActiveConfiguration.PagesSetupDictionary[page.GetType()];
            }

            return ActiveConfiguration.FixedPagesSetupDictionary[page.GetType()];
        }

        internal static ControllerPageSetup GetTabPageSetup<T>() where T : IMetadataDependentPageObject
        {
            if (!ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(typeof(T)))
            {
                if (!ActiveConfiguration.PagesSetupDictionary.ContainsKey(typeof(T)))
                    throw new KeyNotFoundException(string.Format("Page named: {0} is not part of the fixed-setup pages collection or does not contains table element.", typeof(T)));
                return ActiveConfiguration.PagesSetupDictionary[typeof(T)];
            }

            return ActiveConfiguration.FixedPagesSetupDictionary[typeof(T)];
        }
        internal static ControllerPageSetup GetTabPageSetup(IApplicationPageTab page)
        {
            if (!ActiveConfiguration.FixedPagesSetupDictionary.ContainsKey(page.GetType()))
            {
                if (!ActiveConfiguration.PagesSetupDictionary.ContainsKey(page.GetType()))
                    throw new KeyNotFoundException(string.Format("Page named: {0} is not part of the fixed-setup pages collection or does not contains table element.", page.GetType()));
                else
                    return ActiveConfiguration.PagesSetupDictionary[page.GetType()];
            }

            return ActiveConfiguration.FixedPagesSetupDictionary[page.GetType()];
        }

        internal static int GetTabColumnsCount<T>() where T : IMetadataDependentPageObject
        {
            var setup = GetTabPageSetup<T>();
            return setup.TableColumns.Count();
        }
        internal static int GetColumnsCount(IApplicationPage page)
        {
            var setup = GetPageSetup(page);
            return setup.TableColumns.Count();
        }
        internal static TableHeader GetTabTableHeader<T>() where T : IMetadataDependentPageObject
        {
            var setup = GetTabPageSetup<T>();
            return new TableHeader(setup.TableColumns);
        }
        internal static TableHeader GetTableHeader(IApplicationPage page)
        {
            var setup = GetPageSetup(page);
            return new TableHeader(setup.TableColumns);
        }
        internal static ISystemInputMethod GetTabInputMethod<T>(ITableColumn column) where T : IMetadataDependentPageObject
        {
            var setup = GetTabPageSetup<T>();
            return setup.TableColumns.First(col => col.Group == (column.Group == "0" ? null : column.Group) && col.DisplayName == column.DisplayName).InputMethod;
        }
        internal static ISystemInputMethod GetInputMethod(IApplicationPage page, ITableColumn column)
        {
            try
            {
                var setup = GetPageSetup(page);
                return setup.TableColumns.First(col => col.Group == (column.Group == "0" ? null : column.Group) && col.DisplayName == column.DisplayName).InputMethod;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception(string.Format("There is no input method for {0} column. The error is: {1}.", column.DisplayName, ex.Message));
            }
        }
        internal static IEnumerable<string> GetRegionsCollection<T>() where T : IApplicationPage
        {
            var setup = GetPageSetup<T>();
            return setup.SettingsPageTitles;
        }
        internal static IEnumerable<string> GetRegionsCollection(IApplicationPage page)
        {
            var setup = GetPageSetup(page);
            return setup.SettingsPageTitles;
        }
        public static IEnumerable<string> GetPageTitles<T>() where T : IApplicationPage
        {
            var setup = GetPageSetup<T>();
            return setup.PageTitles;
        }

        public static TableHeader GetTableHeader<T>() where T : IApplicationPage
        {
            var setup = GetPageSetup<T>();
            return new TableHeader(setup.TableColumns);
        }

        public static ISystemInputMethod GetInputMethod<T>(ITableColumn column) where T : IApplicationPage
        {
            try
            {
                var setup = GetPageSetup<T>();
                return setup.TableColumns.First(col => col.Group == (column.Group == "0" ? null : column.Group) && col.DisplayName == column.DisplayName).InputMethod;
            }
            catch (Exception)
            {
                throw new Exception(string.Format("There is no input method for {0} column.", column.DisplayName));
            }
        }

        public static IEnumerable<string> GetSettingsPageTitles<T>() where T : IApplicationPage
        {
            var setup = GetPageSetup<T>();
            return setup.SettingsPageTitles;
        }
        public static IEnumerable<string> GetSettingsPageTitles(IApplicationPage page)
        {
            var setup = GetPageSetup(page);
            return setup.SettingsPageTitles;
        }
        public static int GetColumnsCount<T>() where T : IApplicationPage
        {
            var setup = GetPageSetup<T>();
            return setup.TableColumns.Count();
        }
    }
}
