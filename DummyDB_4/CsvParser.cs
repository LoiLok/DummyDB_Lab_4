using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB_4
{
    public class CsvParser
    {
        public static Table CsvParse(Scheme schemeJson, string Name)
        {
            string[] lines = File.ReadAllLines($"..\\..\\..\\Data\\{Name}.csv");
            Table table = new Table();
            for(int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(";");
                if(values.Length != schemeJson.Columns.Count)
                {
                    throw new Exception($"Количество столбцов в файле {Name}.json и {Name}.csv должно совпадать");
                }
                Line line = FillLinesData(values, schemeJson);

                table.Lines.Add(line);
            }
            return table;
        }
        private static Line FillLinesData(string[] values, Scheme schemeJson)
        {
            Line line = new Line();
            for(int i = 0; i < values.Length; i++)
            {
                switch (schemeJson.Columns[i].Type)
                {
                    case "int":
                        if (!int.TryParse(values[i], out int valueInt))
                        {
                            throw new Exception($"Тип данных не сходится ({values[i]})");
                        }
                        line.Data.Add(schemeJson.Columns[i], valueInt);
                        break;
                    case "uint":
                        if (!uint.TryParse(values[i], out uint valueUint))
                        {
                            throw new Exception($"Тип данных не сходится ({values[i]})");
                        }
                        line.Data.Add(schemeJson.Columns[i], valueUint);
                        break;
                    case "datetime":
                        if (!DateTime.TryParse(values[i], out DateTime valueTime))
                        {
                            throw new Exception($"Тип данных не сходится ({values[i]})");
                        }
                        line.Data.Add(schemeJson.Columns[i], valueTime);
                        break;
                    default:
                        line.Data.Add(schemeJson.Columns[i], values[i]);
                        break;
                }
            }
            return line;
        }
    }
}
