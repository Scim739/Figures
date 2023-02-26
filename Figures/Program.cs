namespace Figures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Circle Circle = new Circle();
            Rectangle Rectangle = new Rectangle();
            Shape[] Figures = {Circle, Rectangle};
            foreach (Shape i in Figures)
            {
                i.Draw();
            }
        }
    }
}
