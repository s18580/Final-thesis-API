using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class FileStatus
    {
        public int IdFileStatus { get; set; }
        public string Name { get; set; }

        public ICollection<File> Files { get; set; }
    }
}
