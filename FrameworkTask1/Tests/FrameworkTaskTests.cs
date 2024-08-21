using FluentAssertions;
using FrameworkTask1.Driver;
using FrameworkTask1.Steps;
using FrameworkTask1.Pages;
using OpenQA.Selenium;

namespace FrameworkTask1.Tests
{
    [TestClass]
    public class FrameworkTaskTests
    {
        [TestMethod]
        [DataRow("")]
        //[DataRow("Firefox")]
        public void TestWithChrome_PassDefaultValue_SummaryMatchesValuesFromInput(string browser)
        {
			IWebDriver driver = DriverInstance.GetInstance(browser);

			Steps.Steps steps = new Steps.Steps();

            steps.ClickThrough(driver);

			CostEstimateSummaryPage summaryPage = new CostEstimateSummaryPage(driver);

            summaryPage.GetNumberOfInstancesFromSummary().Should().Be("4");
            summaryPage.GetMachineTypeFromSummary().Should().Be("n1-standard-8, vCPUs: 8, RAM: 30 GB");
            summaryPage.GetGPUButtonValueFromSummary().Should().Be("true");
            summaryPage.GetGPUModelFromSummary().Should().Be("NVIDIA V100");
            summaryPage.GetLocalSSDFromSummary().Should().Be("2x375 GB");
            summaryPage.GetRegionFromSummary().Should().Be("Netherlands (europe-west4)");

			driver.Quit();
        }
        
        [TestMethod]
        [DataRow("Edge")]
        public void TestWithEdge_PassDefaultValue_SummaryMatchesValuesFromInput(string browser)
        {
			IWebDriver driver = DriverInstance.GetInstance(browser);

			Steps.Steps steps = new Steps.Steps();

            steps.ClickThrough(driver);

			CostEstimateSummaryPage summaryPage = new CostEstimateSummaryPage(driver);

            summaryPage.GetNumberOfInstancesFromSummary().Should().Be("4");
            summaryPage.GetMachineTypeFromSummary().Should().Be("n1-standard-8, vCPUs: 8, RAM: 30 GB");
            summaryPage.GetGPUButtonValueFromSummary().Should().Be("true");
            summaryPage.GetGPUModelFromSummary().Should().Be("NVIDIA V100");
            summaryPage.GetLocalSSDFromSummary().Should().Be("2x375 GB");
            summaryPage.GetRegionFromSummary().Should().Be("Netherlands (europe-west4)");

			driver.Quit();
        }
    }
}