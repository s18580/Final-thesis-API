﻿using Final_thesis_api.Models.DictionaryModels;

namespace Final_thesis_api.Models
{
    public class Service
    {
        public int IdService { get; set; }
        public double Price { get; set; }
        public int IdLink { get; set; }
        public int? IdServiceName { get; set; }

        public OrderItem OrderItem { get; set; }
        public Valuation Valuation { get; set; }
        public ServiceName ServiceName { get; set; }
    }
}