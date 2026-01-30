using System.Collections.Generic;
using NameSorter.Models;

namespace NameSorter.Sorting
{
    public interface INameSorter
    {
        IReadOnlyList<PersonName> Sort(IEnumerable<PersonName> names);
    }
}
