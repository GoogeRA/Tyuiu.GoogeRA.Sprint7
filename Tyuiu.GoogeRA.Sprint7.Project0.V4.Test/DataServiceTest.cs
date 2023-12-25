using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint7.Project0.V4.Lib;
using System.IO;

namespace Tyuiu.GoogeRA.Sprint7.Project0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService service = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\Test2.csv";

            string[,] controlTable = new string[,] { { "1", "2", "3" }, 
                                                     { "4", "5", "6" }, 
                                                     { "7", "8", "9" } };
            string[,] table = service.LoadFromFileData(path);

            CollectionAssert.AreEqual(controlTable, table);
        }
    }
}
