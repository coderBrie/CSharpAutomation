using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;



namespace Stifel_Automation_Project
{
    public class FormFillTests : IDisposable
    {
        private IWebDriver driver;

        public FormFillTests()
        {
            // Initialize the WebDriver (ChromeDriver in this case)
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Fact]
        public void FillOutLoginForm()
        {
            // Step 1: Navigate to the Stifel home page
            driver.Navigate().GoToUrl("http://www.stifel.com/");

            // Step 2: Locate the login link and click on it
            IWebElement loginLink = driver.FindElement(By.LinkText("Log In"));
            loginLink.Click();

            // Step 3: Wait for the login page to load
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10000));
            wait.Until(driver => driver.FindElement(By.Id("user_id")).Displayed);

            // Step 4: Find the login form fields and fill them out
            IWebElement userIdField = driver.FindElement(By.Id("user_id"));
            userIdField.SendKeys("YourLoginID"); // Replace with your actual login ID

            //root cause : Logic Error found - password auto fill is being skipped//
            //testing potentencial solutions from stack overflow//
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100000);
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("YourPassword"); // Replace with your actual password

            // Step 5: Submit the login form
            IWebElement submitButton = driver.FindElement(By.CssSelector("input[type='submit']"));
            submitButton.Click();

            // Step 6: Wait for the next page to load or some other element that indicates a successful login
            //  add an appropriate condition here to wait for a specific element or page title.

            // Example: wait.Until(driver => driver.FindElement(By.CssSelector(".confirmation-message")).Displayed);

            // Step 7: Assert that the login was successful or that the expected element is displayed
            // Example: Assert.True(driver.Title.Contains("Dashboard"));

            // customize the above wait and assert based on the behavior of the website(use source code).
        }


        public void Dispose()
        {
            // Close the browser and release resources
            driver.Quit();
        }
    }

    
}




