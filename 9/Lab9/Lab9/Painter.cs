using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal static class Painter
    {
        public static void Paint(IDraw obj)
        {
            obj.Draw();
        }
    }
}
