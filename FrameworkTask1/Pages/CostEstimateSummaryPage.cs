using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTask1.Pages
{
	public class CostEstimateSummaryPage
	{
		private readonly IWebDriver _driver;

		public CostEstimateSummaryPage(IWebDriver driver)
		{
			_driver = driver;
		}

		private readonly By _numberOfInstances = By.XPath("//span[contains(.,'Number of Instances')]/span[2]");

		private readonly By _machineType = By.XPath("//span[contains(.,'Machine type')]/span[2]");

		private readonly By _addGPUsButton = By.XPath("//span[contains(.,'Add GPUs')]/span[2]");

		private readonly By _GPUModel = By.XPath("//span[contains(.,'GPU Model')]/span[2]");

		private readonly By _localSSD = By.XPath("//span[contains(.,'Local SSD')]/span[2]");

		private readonly By _region = By.XPath("//span[contains(.,'Region')]/span[2]");

		public string GetNumberOfInstancesFromSummary() => _driver.FindElement(_numberOfInstances).Text.ToString();
		public string GetMachineTypeFromSummary() => _driver.FindElement(_machineType).Text;
		public string GetGPUButtonValueFromSummary() => _driver.FindElement(_addGPUsButton).Text;
		public string GetGPUModelFromSummary() => _driver.FindElement(_GPUModel).Text;
		public string GetLocalSSDFromSummary() => _driver.FindElement(_localSSD).Text;
		public string GetRegionFromSummary() => _driver.FindElement(_region).Text;

	}
}

