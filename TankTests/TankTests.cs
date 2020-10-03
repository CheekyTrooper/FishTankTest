using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;
using FishTank.Enums;
using FishTank.Models;
using System.Collections.Generic;

namespace FishTankTests
{
    [TestClass]
    public class TankTests
    {
        [TestMethod]
        public void CheckFishAddedToTank()
        {
            //Populated from UI
            string fishName = "Fishy McFishman";
            FishTypes fishType = FishTypes.GoldFish;

            Fish fishToAdd = new Fish
            {
                FishName = fishName,
                FishType = fishType
            };

            Tank tank = new Tank();

            tank.AddFishToTank(fishToAdd);

            List<Fish> fishInTheTank = tank.fishInTank;
            Assert.IsNotNull(fishInTheTank, $"There are {fishInTheTank.Count} fish in the tank.");
        }

        [TestMethod]
        public void CheckFoodRequiredPopulates()
        {
            //Populated from UI
            string fishName = "Fishy McFishman";
            FishTypes fishType = FishTypes.GoldFish;

            Fish fishToAdd = new Fish
            {
                FishName = fishName,
                FishType = fishType
            };

            Tank tank = new Tank();

            tank.AddFishToTank(fishToAdd);

            double expected = 0.1;
            double actual = tank.fishInTank[0].FoodRequired;
            Assert.AreEqual(expected, actual, 0.001, "Fish Food not Correctly Setup");
        }

        [TestMethod]
        public void CheckFeedProducesCorrectAmount()
        {
            /*Angel Fish = 0.2, Babel Fish = 0.3
             Expected output = 5*/
            Tank tank = new Tank();

            List<Fish> fishesToAdd = new List<Fish>()
            {
                new Fish
                {
                FishName = "Fish One",
                FishType = FishTypes.AngelFish
                },
                new Fish
                {
                FishName = "Fish Two",
                FishType = FishTypes.BabelFish
                }
            };

            foreach(Fish fish in fishesToAdd)
            {
                tank.AddFishToTank(fish);
            }

            double expected = 0.5;
            double actual = tank.Feed();

            Assert.AreEqual(expected, actual, "Incorrect Amount Of Food Displayed");
        }
    }
}
