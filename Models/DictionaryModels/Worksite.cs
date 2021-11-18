﻿using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class Worksite
    {
        public int IdWorksite { get; set; }
        public string Name { get; set; }

        public ICollection<Worker> Workers { get; set; }
    }
}
