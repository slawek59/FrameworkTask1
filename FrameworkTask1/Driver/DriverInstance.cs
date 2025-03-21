﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace FrameworkTask1.Driver
{
	public static class DriverInstance
	{
		public static IWebDriver GetInstance(string browser = "")
		{
			IWebDriver driver;
			switch (browser)
			{
				case "Edge":
					driver = new EdgeDriver();
					driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
					driver.Manage().Window.Maximize();
					break;

				default:
					driver = new ChromeDriver();
					driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
					driver.Manage().Window.Maximize();
					break;
			}
			return driver;
		}
	}
}