using Auto.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.PageObjects
{
    [Binding]
    class SearchPage : Hook
    {
        private static By PriceRangeSlider1 = By.XPath("//span[contains(text(),'Add to cart')]");
        private static By PriceRangeSlider2 = By.XPath("//*[@id='layered_price_slider']/a[2]");
        private static By womenLink = By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a");

        private static By ProductImage = By.CssSelector("#best-sellers_block_right > div > ul > li:nth-child(2) > a > img");
        private static By ProductTitle = By.CssSelector("#best-sellers_block_right > div > ul > li:nth-child(2) > div > h5 > a");
        private static By ProductPrice = By.CssSelector("#best-sellers_block_right > div > ul > li:nth-child(2) > div > div > span");

        public string Verify_SearchPage()
        {
            return driver.Title;
        }
        public bool Verify_ProductImageIsDisplayed()
        {
            return driver.FindElement(ProductImage).Displayed;

        }
        public string Verify_ProductTitleIsSeen()
        {

            return driver.FindElement(ProductTitle).Text;

        }
        public string Verify_ProductPrice()
        {

            return driver.FindElement(ProductPrice).Text;

        }
        public void ClickProduct()
        {
            driver.FindElement(ProductImage).Click();

        }
        public string Verify_SpecificProductTitle()
        {
            return driver.Title;
        }

        public void Click_SummerDressLink(string linkname)

        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(womenLink)).Perform();
            // linkname = "Summer Dresses";
            driver.FindElement(By.XPath($"(//*[@title='{linkname}'])[1]")).Click();
           // driver.FindElement(By.XPath($"(//*[@text='{linkname}'])[1]")).Click();
        }
        public void Move_Slider1(double Amount)
        {
            //var element = driver.FindElement(PriceRangeSlider2);
            //var text = element.Size.Width;

            //var x = element.Size;
            ////System.out.println(x);

            //Actions action = new Actions(driver);
            //action.ClickAndHold(element).MoveByOffset(-120, 0).Release().Build().Perform();
            //x = element.Size;
            {
               // double Amount = 16; 
                By Slider1 = By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[1]");
                By PriceRange = By.XPath("//*[@id='layered_price_range']");

                var PriceText = driver.FindElement(PriceRange).Text.Split('-');

                if (PriceText.Length > 1)
                {
                    var MinPrice = Convert.ToDouble(PriceText[0].Replace('$', ' ').Trim());
                    var MaxPrice = Convert.ToDouble(PriceText[1].Replace('$', ' ').Trim());
                    var RangeIncrements = (MaxPrice - MinPrice) / 100;


                    double remainder = (Amount % RangeIncrements);

                    var difference = RangeIncrements - remainder;
                    double y = ((Amount - MinPrice + difference) / RangeIncrements);
                    int z = (int)(2.4 * y);
                    Actions actions = new Actions(driver);
                    actions.DragAndDropToOffset(driver.FindElement(Slider1), z, 0).Perform();
                }

            }
        }

    }
}