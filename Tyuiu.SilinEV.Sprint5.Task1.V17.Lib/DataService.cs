using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SilinEV.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string a = "";

            for (int i = startValue; i <= stopValue; i++)
            {
                a += Convert.ToString(2 * i - 4 + ((2 * i - 1) / (Math.Sin(i) + 1))) + Environment.NewLine;
            }

            return a;
        }
    }
}
