using System.Collections.Generic;
using System.IO;

namespace NameSorter.IO
{
    public class FileReader : IFileReader
    {
        public IEnumerable<string> ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
