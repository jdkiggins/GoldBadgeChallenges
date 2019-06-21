using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekThreeChallenges_01;

namespace CafeTests
{
    [TestClass]
    public class CafeTests
    {
        public CafeRepository _cafeRepo;
        public CafeMenu _cafeContent;

        [TestInitialize]
        public void Arrange()
        {
            _cafeRepo = new CafeRepository();
            _cafeContent = new CafeMenu(11, "Pancakes", "Fluffy and Good", "Water, Milk, Eggs, Panckae Stuff", 10.88d);
        }

        [TestMethod]
        public void CafeMenuAddContentTest()
        {
            _cafeRepo.AddMenuItemToList(_cafeContent);

            int expected = 1;
            int actual = _cafeRepo.GetMenuItems().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
