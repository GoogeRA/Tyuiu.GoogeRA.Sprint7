using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.GoogeRA.Sprint7.Project0.V4.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string[] content = File.ReadAllLines(filePath);
            string[,] table = new string[content.Length, content[0].Split(';').Length];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = content[i].Split(';')[j];
                }
            }
            return table;
        }
    }
    
}
