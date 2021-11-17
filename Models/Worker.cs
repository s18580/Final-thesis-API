using Final_thesis_api.Models.DictionaryModels;
using System.Collections.Generic;

namespace Final_thesis_api.Models
{
    public class Worker
    {
        public int IdWorker { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhonerNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PassHash { get; set; }
        public string Salt { get; set; }
        public int IdWorksite { get; set; }

        public Worksite Worksite { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Valuation> Valuations { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
