using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
         [TestMethod]
        public void TestMethod1()
        {
            List<String> lNews;
            Scenario1 objSc1 = new Scenario1(BrowserType.Chrome);
            objSc1.setup("https://news.google.com");
            lNews = objSc1.getAllNews();
            foreach (String item in lNews)
            {                
                Console.WriteLine(item);
            }
            objSc1.teardown();

        }

        [TestMethod]
        public void TestMethod2()
        {
            List<String> liveSports;
            Scenario1 objSc1 = new Scenario1(BrowserType.Chrome);
            objSc1.setup("https://sports.betway.com/en/sports");
            liveSports = objSc1.getAllLiveSports();
            foreach (String item in liveSports)
            {
                Console.WriteLine(item);
            }
            objSc1.teardown();

        }
    }
}
