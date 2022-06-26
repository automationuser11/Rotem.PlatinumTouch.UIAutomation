using System;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public static class Waits
    {
        public static void Wait(int seconds)
        {
            Thread.Sleep(seconds*1000); // convert seconds to miliseconds
        }

        public static void RetrySteadySupressExceptions(Action action, int retryIntervalMs = 250, int steadyStateMs = 250, int retryCount = 5)
        {
            TimeSpan retryInterval = TimeSpan.FromMilliseconds(retryIntervalMs);
            TimeSpan steadyState = steadyStateMs > 0 ? TimeSpan.FromMilliseconds(steadyStateMs) : TimeSpan.MinValue;

            Exception lastException = null;

            for (int retry = 0; retry < retryCount; retry++)
            {
                try
                {
                    if (retry > 0)
                    {
                        Thread.Sleep(retryInterval);
                    }

                    action();

                    if (steadyState != TimeSpan.MaxValue)
                    {
                        bool steadyStateReached = false;
                        var steadyStateCount = steadyState.TotalMilliseconds/retryInterval.TotalMilliseconds;
                        for (int retrySteady = 0; retrySteady < steadyStateCount; retrySteady++)
                        {
                            if (retrySteady > 0)
                            {
                                Thread.Sleep(retryInterval);
                            }

                            action();
                            steadyStateReached = true;
                        }

                        if (steadyStateReached)
                        {
                            lastException = null;
                            break;
                        }
                    }
                    else
                    {
                        lastException = null;
                        break;
                    }

                }
                catch (Exception exception)
                {
                    lastException = exception;
                }
            }

            if (lastException != null)
            {
                throw lastException;
            }
        }

        public static void WaitUntil(Func<bool> until, int retry = 5)
        {
            for (var i = 0; i < retry; i++)
            {
                if (until())
                    return;
                Thread.Sleep(200);
            }

            var message = String.Format("WaitUntil failed ({0}) after trying {1} times.", until, retry);
            throw new Exception(message);
        }

        public static void WaitUntil(Func<bool> until, TimeSpan timeout)
        {
            DateTime endTime = DateTime.Now.Add(timeout);
            while (DateTime.Now < endTime)
            {
                if (until())
                    return;
                Thread.Sleep(200);
            }

            // Checking one last time because Haim said so.
            if (until())
            {
                return;
            }

            var message = String.Format("WaitUntil failed ({0}) after waiting {1} seconds.", until, timeout);
            throw new Exception(message);
        }

        public static void WaitUntilAndReAssure(Func<bool> until, TimeSpan timeout, TimeSpan timeToValidateAfterwards)
        {
            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start) <= timeout)
            {
                WaitUntil(until, timeout);
                Thread.Sleep(timeToValidateAfterwards);
                if (until())
                {
                    return;
                }
            }
            var message = String.Format("WaitUntil failed ({0}) after waiting {1} seconds.", until, timeout);
            throw new Exception(message);
        }

        public static void WaitForAjax(IWebDriver session)
        {
            try
            {
                var jsDriver = (IJavaScriptExecutor) session;

                for (int i = 0; i < Timeouts.Small; i++)
                {
                    Object numberOfAjaxConnections = jsDriver.ExecuteScript("return jQuery.active");
                    // return should be a number
                    if (numberOfAjaxConnections is Int64)
                    {
                        var n = (Int64) numberOfAjaxConnections;
                        if (n == 0L)
                            break;
                    }
                    Wait(2);
                }
            }
            catch
            {
                Console.WriteLine("Session browser does not implement interface IJavascriptExecutor");
                throw; // should not stop the exception, so that it stops the tests
            }
        }

        public static void WaitUntilAngularIsBootstrapped(IWebDriver session)
        {
            try
            {
                var jsDriver = (IJavaScriptExecutor) session;

                for (int i = 0; i < Timeouts.Small; i++)
                {
                    Object isBootstrapped = jsDriver.ExecuteScript("return $(\"body\").injector() === 'undefined'");
                    // return should be a boolean
                    if (isBootstrapped is bool)
                    {
                        var n = (bool) isBootstrapped;
                        if (n)
                            break;
                    }
                    Wait(2);
                }
            }
            catch
            {
                Console.WriteLine("Session browser does not implement interface IJavascriptExecutor");
                throw; // should not stop the exception, so that it stops the tests
            }
        }

        public static T DoUntilCancelled<T>(Func<T> func, CancellationToken token)
        {
            var task = Task.Run(func, token);
            task.Wait(token);
            return task.Result;
        }
    }
}
