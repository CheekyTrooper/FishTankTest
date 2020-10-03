using FishTank.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank.Interfaces
{
    public interface IFish
    {
        string FishName { get; set; }
        FishTypes FishType { get; set; }
        double FoodRequired { get; set; }
    }
}
