using System.Net.Http.Headers;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SilinEV.Sprint5.Task3.V22.Lib
{
    public class DataService : ISprint5Task3V22
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            double a = Math.Round(Math.Pow(1 - x, 2) / (-3 * x), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(a));
            }

            return Convert.ToString(Math.Round(Math.Pow(1 - x, 2) / (-3 * x), 3));
        }
    }
}
