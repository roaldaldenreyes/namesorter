using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter.Models
{
    public sealed class PersonName
    {
        public string LastName { get; }
        public IReadOnlyList<string> GivenNames { get; }

        public PersonName(string lastName, IEnumerable<string> givenNames)
        {
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            GivenNames = (givenNames ?? throw new ArgumentNullException(nameof(givenNames))).ToArray();
            if (GivenNames.Count == 0) throw new ArgumentException("At least one given name is required", nameof(givenNames));
        }

        public override string ToString()
        {
            return string.Join(" ", GivenNames) + " " + LastName;
        }
    }
}
