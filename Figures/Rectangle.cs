using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rectangle : Shape
    {
        int[,] Rectangle_Points = { { 0,1 }, { 1,0 }, { 2, 3 }, { 3, 2 } };

        public override void Draw()
        {
            Console.WriteLine("  @@@@@@@@@@@@@@@ ");
            Console.WriteLine("  @@@@@@@@@@@@@@@ ");
            Console.WriteLine("  @@@@@@@@@@@@@@@ ");
            Console.WriteLine("  @@@@@@@@@@@@@@@ ");
        }

        public override void equals()
        {
        
        }
    }
}
