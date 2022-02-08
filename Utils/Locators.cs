using System;
using System.Collections.Generic;
using System.Text;

namespace EbayDemo.Utils
{
    class Locators
    {
        public static int timeCount = 2000;
        public static String homePageUrl = "https://www.rokomari.com";
        public static String fbLoginPageTitle = "Log in to Facebook | Facebook";

        //homePageTests
        public const String deals = "/html/body/header/div/nav/div/div[1]/ul/li[1]/a";
        public const String customerServiceId = "/html/body/header/div/nav/div/div[1]/ul/li[2]/a";
        public const String dealsText = "/html/body/header/div/nav/div/div[1]/ul/li[3]/a";
        public const String customerServicesText = "/html/body/header/div/nav/div/div[1]/ul/li[4]/a";
        public const String sellingPath = "/html/body/header/div/nav/div/div[1]/ul/li[5]/a";
        public const String sellText = "/html/body/header/div/nav/div/div[1]/ul/li[6]/a";
        public const String electronicsText = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[1]/a";
        public const String fashionPath = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[2]/a";
        public const String fashionText = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[3]/a";
        public const String healthAndBeautyPath = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[4]/a";
        public const String healthAndBeautyText = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[5]/a";
        public const String homeAndGardenPath = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[6]/a";
        public const String homeAndGardenText = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[7]/a";
        public const String sportsPath = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[8]/a";
        public const String sportsText = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[9]/a";
        public const String collectiblesAndArtPagePath = "/html/body/header/div/nav/div/div[2]/div/div/div/ul[1]/li[10]/a";

        //popular categories
        public const String sneakers = "//*[@id='destinations_list1']/ul/li[1]";
        public const String koreanBeauty = "//*[@id='destinations_list1']/ul/li[2]";
        public const String wristWatches = "//*[@id='destinations_list1']/ul/li[3]";
        public const String fishing = "//*[@id='destinations_list1']/ul/li[4]";
        public const String collectibles = "//*[@id='destinations_list1']/ul/li[5]";
        public const String smartPhones = "//*[@id='destinations_list1']/ul/li[6]";
        public const String popularSell = "//*[@id='destinations_list1']/ul/li[7]";

        public const String sneakersUrl = "https://www.ebay.com/b/Retail-Campaign/bn_7116433159";
        public const String koreanBeautyUrl = "https://www.ebay.com/b/Korean-Health-and-Beauty/bn_7116437158";
        public const String wristWatchesUrl = "https://www.ebay.com/b/Wristwatches/31387/bn_2408451";
        public const String fishingUrl = "https://www.ebay.com/b/Fishing-Equipment-Supplies/1492/bn_1851047";
        public const String collectiblesUrl = "https://www.ebay.com/b/Collectibles-Art/bn_7000259855";
        public const String smartPhonesUrl = "https://www.ebay.com/b/Cell-Phones-Smart-Watches-Accessories/15032/bn_1865441";
        public const String popularSellUrl = "https://export.ebay.com/ru/";

        //Sell
        public const String startSellingPageUrl = "https://www.ebay.com/sl/sell";
        public const String learnToSellPageUrl = "https://pages.ebay.com/seller-center/get-started/selling-basics.html";
        public const String affiliatesPageUrl = "https://partnernetwork.ebay.com/";

        //Search Product

        public const String searchBox = "//*[@id='gh-ac']";
        public const String searchBtn = "//*[@id='gh-btn']";
        public const String searchPageTextPath = "//*[@id='mainContent']/div[1]/div/div[2]/div[1]/div[1]/h1/span[2]";
        public const String searchPageText = "mobile";
        public const String categories = "gh-cat";
        public const String categoryNameHealthAndBeauty = "//*[@id='gh-cat']/option[20]";

        //Sign In
        public const String signIn = "Sign in";
    }
}
