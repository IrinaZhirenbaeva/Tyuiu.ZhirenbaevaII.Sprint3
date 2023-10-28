using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint3.Task5.V10.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startvalue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopvalue2 = 10;

            double res = ds.GetSumSumSeries(x, startvalue1, startValue2, stopValue1, stopvalue2);

            double wait = 20685;
            Assert.AreEqual(wait, res);
        }
    }
}
