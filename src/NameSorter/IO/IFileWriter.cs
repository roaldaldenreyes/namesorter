using System.Collections.Generic;

namespace NameSorter.IO
{
    public interface IFileWriter
    {
        void WriteAllLines(string path, IEnumerable<string> lines);
    }
}
