using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public delegate void PageGetEventHandler(object sender, PageGetEventArgs e);
    public delegate void PagesFactoryRefreshEventHandler(object sender, EventArgs e);

    public class PagesFactory
    {
        private static readonly Dictionary<Type, IPageObject> pagesDictionary = new Dictionary<Type, IPageObject>();
        private static PagesFactory _instance;

        public static T GetPage<T>() where T : class, IPageObject
        {
            var isFound = pagesDictionary.ContainsKey(typeof (T));
            if (isFound)
            {
                OnPageGet(Instance, new PageGetEventArgs() { PageObject = pagesDictionary[typeof(T)] as T });
                return pagesDictionary[typeof (T)] as T;
            }

            try
            {
                var page = Assembly.GetExecutingAssembly().CreateInstance(typeof (T).ToString()) as T;
                pagesDictionary.Add(typeof (T), page);
                OnPageGet(Instance, new PageGetEventArgs() { PageObject = pagesDictionary[typeof(T)] as T });

                return page;
            }
            catch (Exception e)
            {
                throw new PageNotFoundException(typeof (T), e);
            }
        }
        public static List<IApplicationPage> GetHistoryPages()
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                           .Where(type => type.FullName.Contains("History") && type.FullName.Contains("Page")
                                          && !type.FullName.Contains("Settings") && typeof(IApplicationPage).IsAssignableFrom(type))
                           .Select(type => Assembly.GetExecutingAssembly().CreateInstance(type.FullName) as IApplicationPage)
                           .ToList();
        }
        internal static IPageObject GetPage(Type pageType)
        {
            var isInitialized = pagesDictionary.ContainsKey(pageType);
            if (isInitialized)
            {
                OnPageGet(Instance, new PageGetEventArgs() { PageObject = pagesDictionary[pageType]});
                return pagesDictionary[pageType];
            }

            try
            {
                var page = Assembly.GetExecutingAssembly().CreateInstance(pageType.ToString()) as IPageObject;
                pagesDictionary.Add(pageType, page);
                OnPageGet(Instance, new PageGetEventArgs() { PageObject = pagesDictionary[pageType]});

                return page;
            }
            catch (Exception e)
            {
                throw new PageNotFoundException(pageType, e);
            }
        }

        public static PagesFactory Instance
        {
            get { return _instance ?? (_instance = new PagesFactory()); }
        }

        public static void RefreshFactory()
        {
            _instance = new PagesFactory();
        }

        public static event PageGetEventHandler PageGetEvent;
        public event PagesFactoryRefreshEventHandler PagesFactoryRefreshed;

        private static void OnPageGet(object sender, PageGetEventArgs eventArgs)
        {
            if (PageGetEvent != null)
                PageGetEvent(Instance, eventArgs);
        }

        private void OnLogIn(object sender, EventArgs eventArgs)
        {
            if (PagesFactoryRefreshed != null)
                PagesFactoryRefreshed(Instance, eventArgs);
        }
    }

    public class PageNotFoundException : Exception
    {
        private readonly Type _pageType;
        private const string MsgFormat = "Page of type {0} was not found in the current project";

        public PageNotFoundException(Type page, Exception inner)
            : base(inner.Message, inner)
        {
            _pageType = page;
        }

        public override string Message
        {
            get { return string.Format(MsgFormat, _pageType); }
        }
    }

    public class PageGetEventArgs : EventArgs
    {
        public IPageObject PageObject { get; set; }
    }
}