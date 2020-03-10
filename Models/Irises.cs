using System;

namespace FlowerShop
{
  public class Irises : IBirthdayFlowers
  {
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string Water_Schedule { get; set; }
    public bool Thorny { get; set; }
    public string Fragrant { get; set; }

    public override string ToString()
    {
      return $"A fanciful {Color} irises that cost {Cost}";
    }
  }
}