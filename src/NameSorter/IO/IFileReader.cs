using System.Collections.Generic;

namespace NameSorter.IO
{
    public interface IFileReader
    {
        IEnumerable<string> ReadAllLines(string path);
    }
}
