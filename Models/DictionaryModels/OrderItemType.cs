using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class OrderItemType
    {
        public int IdOrderItemType { get; set; }
        public string Name { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
