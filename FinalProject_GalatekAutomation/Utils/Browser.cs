﻿using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.Utils
{
    public class Browser
    {
         public static IWebDriver GetDriver(WebBrowsers browserType)
        {
            switch (browserType)
            {                
                case WebBrowsers.Chrome:
                    {
                        var options = new OpenQA.Selenium.Chrome.ChromeOptions();
                        
                        if (FrameworkConstants.startMaximized)
                        {
                            options.AddArgument("--start-maximized");
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            options.AddArgument("headless");
                        }
                        if (FrameworkConstants.ignoreCertErr)
                        {
                            options.AddArgument("ignore-certificate-errors");
                        }
                        options.AddArgument("no-sandbox");
                        
                        var proxy = new Proxy
                        {
                            HttpProxy = FrameworkConstants.browserProxy,
                            IsAutoDetect = false
                        };
                        if (FrameworkConstants.useProxy)
                        {
                            options.Proxy = proxy;
                        }
                        
                        return new OpenQA.Selenium.Chrome.ChromeDriver(options);
                    }
                case WebBrowsers.Firefox:
                    {
                        var firefoxOptions = new FirefoxOptions();
                        List<string> optionList = new List<string>();
                        if (FrameworkConstants.startHeadless)
                        {
                            optionList.Add("--headless");
                        }
                        if (FrameworkConstants.ignoreCertErr)
                        {
                            optionList.Add("--ignore-certificate-errors");
                        }
                        firefoxOptions.AddArguments(optionList);
                        FirefoxProfile fProfile = new FirefoxProfile();

                        if (FrameworkConstants.startWithExtension)
                        {
                            fProfile.AddExtension(FrameworkConstants.GetExtensionName(browserType));
                        }
                        firefoxOptions.Profile = fProfile;
                        
                        return new FirefoxDriver(firefoxOptions);
                    }
                case WebBrowsers.Edge:
                    {
                        
                        var edgeOptions = new EdgeOptions();
                        if (FrameworkConstants.startMaximized)
                        {
                            edgeOptions.AddArgument("--start-maximized");
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            edgeOptions.AddArgument("headless");
                        }
                        if (FrameworkConstants.startWithExtension)
                        {
                            edgeOptions.AddExtension(FrameworkConstants.GetExtensionName(browserType));
                        }
                        
                        return new EdgeDriver(edgeOptions);
                    }
                default:
                    {
                        
                        throw new BrowserTypeException(browserType.ToString());
                    }

            }
        }
              
        public static IWebDriver GetDriver()
        {
            WebBrowsers cfgBrowser;
            switch (FrameworkConstants.configBrowser.ToUpper())
            {
                case "FIREFOX":
                    {
                        cfgBrowser = WebBrowsers.Firefox;
                        break;
                    }
                case "CHROME":
                    {
                        cfgBrowser = WebBrowsers.Chrome;
                        break;
                    }
                case "EDGE":
                    {
                        cfgBrowser = WebBrowsers.Edge;
                        break;
                    }
                default:
                    {
                        throw new BrowserTypeException(String.Format("Browser {0} not supported", FrameworkConstants.configBrowser));
                    }
            }

            return GetDriver(cfgBrowser);
        }
    }

    public enum WebBrowsers
    {
        Chrome,
        Firefox,
        Edge
    }
}