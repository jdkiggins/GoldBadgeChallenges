using System;
using System.Collections.Generic;
using Badge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BadgeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void BadgeRepository_CreateBadge_ShouldReturnDictionaryWithBadge()
            {
                BadgeRepository badgeRepo = new BadgeRepository();
                Dictionary<int, List<string>> testDictionary = badgeRepo.GetDictionary();
                List<string> testList = new List<string>();
                testList.Add("testString");

                badgeRepo.CreateBadge(1, testList);

                var expected = 1;
                var actual = testDictionary.Count;

                Assert.AreEqual(expected, actual);
            }
    }
}
