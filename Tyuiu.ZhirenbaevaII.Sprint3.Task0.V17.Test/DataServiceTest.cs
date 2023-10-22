using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint3.Task0.V17.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.709, ds.GetSumSeries(1, 10));

        }
    }
}
