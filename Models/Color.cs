namespace Final_thesis_api.Models
{
    public class Color
    {
        public int IdColor { get; set; }
        public string Name { get; set; }
        public int IdLink { get; set; }
        public bool IsForCover { get; set; }

        public OrderItem OrderItem { get; set; }
        public Valuation Valuation { get; set; }
    }
}
