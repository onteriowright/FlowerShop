using System;
using System.Collections.Generic;

namespace FlowerShop
{
  public class FlowerShop
  {
    public List<Rose> Roses = new List<Rose>();
    public List<Irises> Irises = new List<Irises>();
    public List<SunFlower> Sunflowers = new List<SunFlower>();
    public List<Tulip> Tulips = new List<Tulip>();
    public List<IMothersDay> MakeMothersDayArrangement()
    {
      List<IMothersDay> MothersDayFlowers = new List<IMothersDay>();
      MothersDayFlowers.Add(new Rose());
      MothersDayFlowers.Add(new Rose());
      MothersDayFlowers.Add(new Tulip());
      MothersDayFlowers.Add(new Tulip());
      MothersDayFlowers.Add(new Tulip());

      return MothersDayFlowers;
    }
    public List<IBirthdayFlowers> IBirthdayMakeBirthdayArrangement()
    {
      List<IBirthdayFlowers> BirthdayFlowers = new List<IBirthdayFlowers>();
      BirthdayFlowers.Add(new SunFlower());
      BirthdayFlowers.Add(new SunFlower());
      BirthdayFlowers.Add(new Irises());
      BirthdayFlowers.Add(new Irises());
      BirthdayFlowers.Add(new Irises());

      return BirthdayFlowers;
    }
    public List<IGetWell> IGetWellArrangement()
    {
      List<IGetWell> GetWellFlowers = new List<IGetWell>();
      GetWellFlowers.Add(new SnapDragon());

      return GetWellFlowers;
    }
  }
}