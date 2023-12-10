using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZhirenbaevaII.Sprint3.Task1.V23.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 204049.946;

            Assert.AreEqual(wait, res);
        }
    }
}
        
    

