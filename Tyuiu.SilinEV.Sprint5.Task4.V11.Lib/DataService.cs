using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SilinEV.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            double a = Convert.ToDouble(File.ReadAllText(path));

            return Math.Round(Math.Sin(a) + (a * a) / 2, 3);
        }
    }
}
