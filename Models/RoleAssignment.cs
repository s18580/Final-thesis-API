using Final_thesis_api.Models.DictionaryModels;
using System.Collections.Generic;

namespace Final_thesis_api.Models
{
    public class RoleAssignment
    {
        public int IdRole { get; set; }
        public int IdWorker { get; set; }

        public Worker Worker { get; set; }
        public Role Role { get; set; }
    }
}
