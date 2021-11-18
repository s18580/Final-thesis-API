using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class MinimumRate
    {
        public int IdMinimumRate { get; set; }
        public double Price { get; set; }
        public int Circulation { get; set; }

        public ICollection<ServiceName> ServicesNames { get; set; }
    }
}
