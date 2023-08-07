using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class Display
    {
        public void InputTitle()
        {
            Console.Write("Input task title: ");
        }

        public void InputDeadline()
        {
            Console.Write("Input deadline in format MM-DD: ");
        }
    }
}
