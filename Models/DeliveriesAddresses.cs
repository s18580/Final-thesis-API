namespace Final_thesis_api.Models
{
    public class DeliveriesAddresses
    {
        public int IdAddress { get; set; }
        public int IdLink { get; set; }

        public Address Address { get; set; }
        public Order Order { get; set; }
        public Supply Supply { get; set; }
    }
}