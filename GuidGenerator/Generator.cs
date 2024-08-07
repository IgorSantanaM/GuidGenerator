using System;
using System.IO;

namespace GuidGenerator
{
    public static class Generator
    {
        public static void GuidGenerate(int times)
        {
            string filePath = "X:\your\path\here.txt";

            for (int i = 0; i < times; i++)
            {
                Guid guid = Guid.NewGuid();
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(guid);
                }
            }
        }
    }
}
