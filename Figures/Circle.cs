using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Circle : Shape
    {
        int[] Circle_Points = { 0, 0 };
        public override void Draw()
        {
            Console.WriteLine("     @@@@@@    ");
            Console.WriteLine("    @@@@@@@@   ");
            Console.WriteLine("   @@@@@@@@@@  ");
            Console.WriteLine("  @@@@@@@@@@@@ ");
            Console.WriteLine("   @@@@@@@@@@  ");
            Console.WriteLine("    @@@@@@@@   ");
            Console.WriteLine("     @@@@@@     ");
        }

        public override void equals()
        {
        
        }
    }
}
