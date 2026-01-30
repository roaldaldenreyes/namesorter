using System;
using NameSorter.Models;
using NameSorter.Parsing;
using Xunit;

namespace NameSorter.Tests
{
    public class NameParserTests
    {
        [Fact]
        public void Parse_SimpleName_SetsGivenAndLast()
        {
            var parser = new NameParser();
            var p = parser.Parse("Janet Parsons");

            Assert.Equal("Parsons", p.LastName);
            Assert.Single(p.GivenNames);
            Assert.Equal("Janet", p.GivenNames[0]);
        }

        [Fact]
        public void Parse_MultiGivenNames_PreservesOrder()
        {
            var parser = new NameParser();
            var p = parser.Parse("Adonis Julius Archer");

            Assert.Equal("Archer", p.LastName);
            Assert.Equal(2, p.GivenNames.Count);
            Assert.Equal("Adonis", p.GivenNames[0]);
            Assert.Equal("Julius", p.GivenNames[1]);
        }

        [Fact]
        public void Parse_Invalid_Throws()
        {
            var parser = new NameParser();
            Assert.Throws<FormatException>(() => parser.Parse("SingleNameOnly"));
        }
    }
}
