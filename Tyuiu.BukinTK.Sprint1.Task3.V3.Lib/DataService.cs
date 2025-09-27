using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BukinTK.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double length, double width, double height)
        {
            double res = length * width * height;
            res = Math.Round(res, 3);
            return res;
        }
    }
}
