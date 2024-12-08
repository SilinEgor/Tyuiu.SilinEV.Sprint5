using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SilinEV.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            return File.ReadAllText(path).Replace("сс", "с");
        }
    }
}
