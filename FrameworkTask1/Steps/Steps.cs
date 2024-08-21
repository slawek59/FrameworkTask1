using FrameworkTask1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace FrameworkTask1.Steps
{
	public class Steps
	{
		public void ClickThrough(IWebDriver driver)
		{
			Pages.MainPage mainPage = new Pages.MainPage(driver);
			mainPage.OpenPage();
			
			Actions actions = new Actions(driver);

			mainPage.GetCloseCookiesButtonElement().Click();

			mainPage.GetAddToEstimateButtonElement().Click();

			actions.MoveToElement(mainPage.GetComputeEngineButtonElement()).Click().Perform();

			mainPage.GetNumberOfInstancesIncrementElement().Click();
			mainPage.GetNumberOfInstancesIncrementElement().Click();
			mainPage.GetNumberOfInstancesIncrementElement().Click();

			actions.MoveToElement(mainPage.GetMachineTypeElement()).Click().Perform();
			actions.MoveToElement(mainPage.Get_machineTypeSelectOptionElement()).Click().Perform();
			actions.MoveToElement(mainPage.Get_addGPUsButtonElement()).Click().Perform();
			actions.MoveToElement(mainPage.Get_GPUModelElement()).Click().Perform();
			actions.MoveToElement(mainPage.Get_GPUModelSelectOptionElement()).Click().Perform();
			
			actions.MoveToElement(mainPage.Get_localSSDElement()).Click().Perform();
			mainPage.Get_localSSDSelectOptionElement().Click();
			
			actions.MoveToElement(mainPage.Get_regionElement()).Click().Perform();
			mainPage.Get_regionSelectOptionElement().Click();
			
			actions.MoveToElement(mainPage.Get_shareButtonElement()).Click().Perform();
			
			mainPage.Get_openEstimateSummaryButtonElement().Click();
			
			driver.Url = mainPage.CostEstimateSummaryPageUrl();
		}
	}
}