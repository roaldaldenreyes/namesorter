using System.Collections.Generic;
using System.IO;

namespace NameSorter.IO
{
    public class FileWriter : IFileWriter
    {
        public void WriteAllLines(string path, IEnumerable<string> lines)
        {
            File.WriteAllLines(path, lines);
        }
    }
}
