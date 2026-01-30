using System.Collections.Generic;
using System.Linq;
using NameSorter.Models;

namespace NameSorter.Sorting
{
    public class NameSorterService : INameSorter
    {
        public IReadOnlyList<PersonName> Sort(IEnumerable<PersonName> names)
        {
            var list = names?.ToList() ?? new List<PersonName>();

            list.Sort((a, b) =>
            {
                var lastCompare = string.Compare(a.LastName, b.LastName, System.StringComparison.OrdinalIgnoreCase);
                if (lastCompare != 0) return lastCompare;

                // Compare given names lexicographically sequence-wise
                var ag = a.GivenNames;
                var bg = b.GivenNames;
                var min = System.Math.Min(ag.Count, bg.Count);
                for (int i = 0; i < min; i++)
                {
                    var cmp = string.Compare(ag[i], bg[i], System.StringComparison.OrdinalIgnoreCase);
                    if (cmp != 0) return cmp;
                }

                // If all equal up to min, shorter sequence comes first
                return ag.Count.CompareTo(bg.Count);
            });

            return list;
        }
    }
}
