using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class Role
    {
        public int IdRole { get; set; }
        public string Name { get; set; }

        public ICollection<RoleAssignment> RoleAssignments { get; set; }
    }
}
