using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using static FrameworkTask1.Pages.CostEstimateSummaryPage;

namespace FrameworkTask1.Pages
{
	public class MainPage
	{
		private readonly IWebDriver _driver; 

		private const string BASE_URL = "https://cloud.google.com/products/calculator/?hl=en";
		private readonly By _closeCookiesButton = By.XPath("//*[@class='glue-cookie-notification-bar__accept']");
		private readonly By _addToEstimateButton = By.XPath("//*[contains(text(),'Add to estimate')]");
		private readonly By _computeEngineButton = By.XPath("//div[@role='button' and ./h2[text()='Compute Engine']]");
		private readonly By _numberOfInstancesIncrement = By.XPath("//button[@aria-label='Increment']");
		private readonly By _machineType = By.XPath("//span[text()='n1-standard-4']");
		private readonly By _machineTypeSelectOption = By.XPath("//li[@data-value='n1-standard-8']");
		private readonly By _addGPUsButton = By.XPath("//button[@aria-label='Add GPUs']");
		private readonly By _GPUModel = By.XPath("//span[text()='NVIDIA T4']");
		private readonly By _GPUModelSelectOption = By.XPath("//li[@data-value='nvidia-tesla-v100']");
		private readonly By _localSSD = By.XPath("//span[text()='0']");
		private readonly By _localSSDSelectOption = By.XPath("//*[contains(text(),'2x375 GB')]/../..");
		private readonly By _region = By.XPath("//span[text()='Iowa (us-central1)']");
		private readonly By _regionSelectOption = By.XPath("//*[contains(text(),'Netherlands (europe-west4)')]/../..");
		private readonly By _shareButton = By.XPath("//button[@aria-label='Open Share Estimate dialog']");
		private readonly By _openEstimateSummaryButton = By.XPath("//a[@track-name='open estimate summary']");
		
		public void OpenPage() => _driver.Navigate().GoToUrl(BASE_URL);
		public MainPage(IWebDriver driver)
		{
			_driver = driver;
		}
		public IWebElement GetCloseCookiesButtonElement() => _driver.FindElement(_closeCookiesButton);
		public IWebElement GetAddToEstimateButtonElement() => _driver.FindElement(_addToEstimateButton);
		public IWebElement GetComputeEngineButtonElement() => _driver.FindElement(_computeEngineButton);
		public IWebElement GetNumberOfInstancesIncrementElement() => _driver.FindElement(_numberOfInstancesIncrement);
		public IWebElement GetMachineTypeElement() => _driver.FindElement(_machineType);
		public IWebElement Get_machineTypeSelectOptionElement() => _driver.FindElement(_machineTypeSelectOption);
		public IWebElement Get_addGPUsButtonElement() => _driver.FindElement(_addGPUsButton);
		public IWebElement Get_GPUModelElement() => _driver.FindElement(_GPUModel);
		public IWebElement Get_GPUModelSelectOptionElement() => _driver.FindElement(_GPUModelSelectOption);
		public IWebElement Get_localSSDElement() => _driver.FindElement(_localSSD);
		public IWebElement Get_localSSDSelectOptionElement() => _driver.FindElement(_localSSDSelectOption);
		public IWebElement Get_regionElement() => _driver.FindElement(_region);
		public IWebElement Get_regionSelectOptionElement() => _driver.FindElement(_regionSelectOption);
		public IWebElement Get_shareButtonElement() => _driver.FindElement(_shareButton);
		public IWebElement Get_openEstimateSummaryButtonElement() => _driver.FindElement(_openEstimateSummaryButton);
		public string CostEstimateSummaryPageUrl() => Get_openEstimateSummaryButtonElement().GetAttribute("href");
	}
}