using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SilinEV.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            return Convert.ToString(Math.Round((4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1), 3));
        }
    }
}
