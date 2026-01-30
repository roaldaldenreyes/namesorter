using System;
using System.IO;
using System.Linq;
using NameSorter.IO;
using NameSorter.Parsing;
using NameSorter.Sorting;

namespace NameSorter
{
    internal static class Program
    {
        private const string OutputFile = "sorted-names-list.txt";

        private static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: name-sorter <input-file-path>");
                return 1;
            }

            var inputPath = args[0];
            if (!File.Exists(inputPath))
            {
                Console.Error.WriteLine($"Input file not found: {inputPath}");
                return 2;
            }

            try
            {
                IFileReader reader = new FileReader();
                var lines = reader.ReadAllLines(inputPath)
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .ToArray();

                var parser = new NameParser();
                var persons = lines.Select(parser.Parse)
                    .ToArray();

                INameSorter sorter = new NameSorterService();
                var sorted = sorter.Sort(persons);

                foreach (var p in sorted)
                {
                    Console.WriteLine(p);
                }

                IFileWriter writer = new FileWriter();
                writer.WriteAllLines(OutputFile, sorted.Select(p => p.ToString()));

                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                return 10;
            }
        }
    }
}
