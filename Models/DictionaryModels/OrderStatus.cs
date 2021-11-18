using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class OrderStatus
    {
        public int IdStatus { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
