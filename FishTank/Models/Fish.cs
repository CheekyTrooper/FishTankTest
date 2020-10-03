using FishTank.Enums;
using FishTank.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank.Models
{
    public class Fish : IFish
    {
        public string FishName { get; set; }
        public FishTypes FishType { get; set; }
        public double FoodRequired { get; set; }
    }
}
