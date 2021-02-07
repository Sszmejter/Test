using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace project1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Navigate().GoToUrl("https://test-env-1.mobile-test.ticos-systems.cloud/ou-select");
            webDriver.FindElement(By.XPath("/html/body[@class='mat-typography']/app-root/div/div/app-organization-unit-selection/div/mat-card[@class='mat-card mat-focus-indicator organization-unit-card pointer'][1]/b")).Click();
            webDriver.FindElement(By.XPath("/html/body[@class='mat-typography']/app-root/div/div/ticket-choose/div/div[1]/div[2]/ticket-choose-one-card/mat-card[@class='mat-card mat-focus-indicator choose-card']/div[@class='to-right']/button[@class='mat-focus-indicator mat-icon-button mat-button-base']/span[@class='mat-button-wrapper']/mat-icon[@class='mat-icon notranslate to-right align-icon pointer material-icons mat-icon-no-color']")).Click();
            webDriver.FindElement(By.XPath("/html/body[@class='mat-typography']/app-root/div/div/ticket-choose/div/div[@class='next-button-holder']/button[@class='mat-focus-indicator button-buy mat-raised-button mat-button-base mat-primary']")).Click();
            webDriver.FindElement(By.XPath("/html/body[@class='mat-typography']/app-root/div/div/ticket-buying-flow/slots[@class='ng-star-inserted']/mat-card[@class='mat-card mat-focus-indicator reservation-search-card']/div/p/mat-form-field[@class='mat-form-field search-field ng-tns-c56-0 mat-primary mat-form-field-type-mat-input mat-form-field-appearance-fill mat-form-field-can-float mat-form-field-has-label ng-untouched ng-pristine ng-valid mat-form-field-should-float']/div[@class='mat-form-field-wrapper ng-tns-c56-0']/div[@class='mat-form-field-flex ng-tns-c56-0']/div[@class='mat-form-field-suffix ng-tns-c56-0 ng-star-inserted']/mat-datepicker-toggle[@class='mat-datepicker-toggle ng-tns-c56-0']/button[@class='mat-focus-indicator mat-icon-button mat-button-base']")).Click();
            webDriver.FindElement(By.XPath("/html/body[@class='mat-typography']/div[@class='cdk-overlay-container']/div[@class='cdk-overlay-connected-position-bounding-box']/div[@id='cdk-overlay-7']/mat-datepicker-content[@class='mat-datepicker-content ng-tns-c113-8 ng-trigger ng-trigger-transformPanel mat-primary ng-star-inserted']/mat-calendar[@id='mat-datepicker-0']/div[@class='mat-calendar-content']/mat-month-view[@class='ng-star-inserted']/table[@class='mat-calendar-table']/tbody[@class='mat-calendar-body']/tr[@class='ng-star-inserted'][3]/td[@class='mat-calendar-body-cell ng-star-inserted'][3]/div[@class='mat-calendar-body-cell-content mat-focus-indicator']")).Click();
        }
    }
}