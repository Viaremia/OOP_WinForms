using System;
using System.IO;

namespace OOP3_WindowsForms
{
    class SaveMatrix
    {
        public void Save(string[,] arr, string path)
        {
            StreamWriter sw = new StreamWriter(path, false);
            for (int i = 0; i < arr.GetLength(0); i++) // 6
            {
                for (int j = 0; j < arr.GetLength(1); j++) // 5
                {
                    sw.Write(arr[i, j] + "\t");
                }
                sw.Write("\n");
            }
            sw.Close();
        }
    }
}
