namespace FlowerShop
{
  public class SnapDragon : IGetWell
  {
    public string Color { get; set; }
    public double StemLength { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string Water_Schedule { get; set; }
    public bool Thorny { get; set; }
    public string Fragrant { get; set; }

    public override string ToString()
    {
      return $"A fanciful {Color} snap dragon that cost {Cost}";
    }
  }
}