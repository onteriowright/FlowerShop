using System;

namespace FlowerShop
{
  public class Rose : IMothersDay
  {
    public string Name { get; set; }
    public double StemLength { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string Water_Schedule { get; set; }
    public bool Thorny { get; set; }
    public string Fragrant { get; set; }

    public override string ToString()
    {
      return $"A fanciful {Fragrant} rose that cost {Cost}";
    }

  }
}