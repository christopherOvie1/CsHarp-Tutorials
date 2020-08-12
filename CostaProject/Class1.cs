using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace CostaProject
{
    [TestClass]
    public class Class1
    {
        public static Assembly solution = Assembly.GetExecutingAssembly();
        public Configuration config = ConfigurationManager.OpenExeConfiguration(solution.ManifestModule.Assembly.Location);
        [TestMethod]
public void TestConfig()
        {

          var name= config.AppSettings.Settings["Url"].Value;
            Console.WriteLine(name);
        }

    }
}
