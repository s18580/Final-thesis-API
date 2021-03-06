using System.Collections.Generic;

namespace Final_thesis_api.Models
{
    public class Address
    {
        public int IdAddress { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? PostCode { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public int IdOwner { get; set; }

        public Customer Customer { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<DeliveriesAddresses> DeliveriesAddresses { get; set; }
    }
}
