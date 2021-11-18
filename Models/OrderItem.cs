using Final_thesis_api.Models.DictionaryModels;
using System;
using System.Collections.Generic;

namespace Final_thesis_api.Models
{
    public class OrderItem
    {
        public int IdOrderItem { get; set; }
        public int IdOrder { get; set; }
        public int Circulation { get; set; }
        public int? Capacity { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public DateTime? ExpectedCompletionDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string InsideFormat { get; set; }
        public string CoverFormat { get; set; }
        public int? IdSelectedValuation { get; set; }
        public int IdDeliveryType { get; set; }
        public int? IdBindingType { get; set; }
        public int IdOrderItemType { get; set; }

        public Order Order { get; set; }
        public OrderItemType OrderItemType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public BindingType BindingType { get; set; }
        public ICollection<Color> CoverColors { get; set; }
        public ICollection<Color> InsideColors { get; set; }
        public ICollection<Paper> CoverPapers { get; set; }
        public ICollection<Paper> InsidePapers { get; set; }
        public ICollection<Service> CoverServices { get; set; }
        public ICollection<Service> InsideServices { get; set; }
        public ICollection<Valuation> Valuations { get; set; }
        public ICollection<Supply> Supplies { get; set; }
        public ICollection<File> Files { get; set; }


    }
}