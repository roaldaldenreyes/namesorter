using NameSorter.Models;

namespace NameSorter.Parsing
{
    public interface INameParser
    {
        PersonName Parse(string rawName);
    }
}
