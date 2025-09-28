using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BukinTK.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double f = ((Math.Cos(x * x) + Math.Sin(y * y)) / (Math.Sin(y) + 1)) - ((x * y - 12) / (15 + Math.Cos(x)));
            f = Math.Round(f, 3);
            return f;
        }
    }
}
