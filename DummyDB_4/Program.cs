using System;
using System.Collections.Generic;
using System.IO;

namespace DummyDB_4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите имя файла: ");
            string fileName = Console.ReadLine();
            Console.Clear();
            string jsonPath = $"..\\..\\..\\Schema\\{fileName}.json";
            Scheme scheme = Scheme.ReadJsonFile(jsonPath);
            Table table = CsvParser.CsvParse(scheme, fileName);
            Console.SetCursorPosition(0, 0);
            foreach (SchemeColumn key in table.Lines[0].Data.Keys)
            {
                Console.Write(key.Name + " ");
            }
            foreach (Line line in table.Lines)
            {
                Console.WriteLine(string.Join(" ", line.Data.Values));
            }
        }
    }
}
