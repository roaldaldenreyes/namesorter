using System.Linq;
using NameSorter.Models;
using NameSorter.Sorting;
using Xunit;

namespace NameSorter.Tests
{
    public class SortingTests
    {
        [Fact]
        public void Sort_ByLastNameThenGivenNames()
        {
            var names = new[]
            {
                new PersonName("Alvarez", new[] { "Marin" }),
                new PersonName("Archer", new[] { "Adonis", "Julius" }),
                new PersonName("Bentley", new[] { "Beau", "Tristan" }),
                new PersonName("Clarke", new[] { "Hunter", "Uriah", "Mathew" }),
                new PersonName("Gardner", new[] { "Leo" })
            };

            var sorter = new NameSorterService();
            var sorted = sorter.Sort(names).ToArray();

            Assert.Equal("Alvarez", sorted[0].LastName);
            Assert.Equal("Archer", sorted[1].LastName);
            Assert.Equal("Bentley", sorted[2].LastName);
        }
    }
}
