using FishTank.Enums;
using FishTank.Models;
using System;
using System.Collections.Generic;

namespace FishTank
{
    public class Tank
    {
        public List<Fish> fishInTank = new List<Fish>();


        public void AddFishToTank (Fish fishToAdd)
        {
            var foodRequiredForFish = GetAmountFishFoodNeeded(fishToAdd.FishType);

            fishInTank.Add(new Fish {
                FishName = fishToAdd.FishName,
                FishType = fishToAdd.FishType,
                FoodRequired = foodRequiredForFish
            });
        }

        public double Feed()
        {
            double totalFoodRequired = 0;

            foreach(Fish fish in fishInTank)
            {
                double foodRequired = GetAmountFishFoodNeeded(fish.FishType);

                totalFoodRequired += foodRequired;
            }

            return totalFoodRequired;
        }


        #region Helpers
        private double GetAmountFishFoodNeeded (FishTypes fishType)
        {
            switch(fishType)
            {
                case FishTypes.GoldFish:
                    return 0.1;
                case FishTypes.AngelFish:
                    return 0.2;
                case FishTypes.BabelFish:
                    return 0.3;
            }

            return 0;
        }

        #endregion

    }
}
