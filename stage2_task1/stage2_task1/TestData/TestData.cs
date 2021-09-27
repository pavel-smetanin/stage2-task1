using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Configuration;
using NLog;

namespace stage2_task1
{
    public static class TestData
    {
        private static string file = ConfigurationManager.AppSettings.Get("testDataFile");
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void TestDataCard1(out string password, out string email, out string domain, out int indexDomain)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file); //Загрузка файла 
            logger.Info("Reading test data file: " + file);
            email = doc.GetElementsByTagName("Card1")[0].ChildNodes[0].InnerText; //чтение первого узла
            domain = doc.GetElementsByTagName("Card1")[0].ChildNodes[1].InnerText; //чтение второго узла
            indexDomain = int.Parse(doc.GetElementsByTagName("Card1")[0].ChildNodes[2].InnerText);
            password = doc.GetElementsByTagName("Card1")[0].ChildNodes[3].InnerText;
        }
        public static void TestDataCard2(out int num1, out int num2, out int num3)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file); //Загрузка файла 
            logger.Info("Reading test data file: " + file);
            num1 = int.Parse(doc.GetElementsByTagName("Card2")[0].ChildNodes[0].InnerText);
            num2 = int.Parse(doc.GetElementsByTagName("Card2")[0].ChildNodes[1].InnerText);
            num3 = int.Parse(doc.GetElementsByTagName("Card2")[0].ChildNodes[2].InnerText);
        }
    }
}
