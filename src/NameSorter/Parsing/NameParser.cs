using System;
using System.Linq;
using NameSorter.Models;

namespace NameSorter.Parsing
{
    public class NameParser : INameParser
    {
        public PersonName Parse(string rawName)
        {
            if (string.IsNullOrWhiteSpace(rawName)) throw new ArgumentException("Name cannot be empty", nameof(rawName));

            var parts = rawName.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2) throw new FormatException($"Invalid name '{rawName}'. Expect at least one given name and a last name.");

            var last = parts.Last();
            var given = parts.Take(parts.Length - 1);

            return new PersonName(last, given);
        }
    }
}
