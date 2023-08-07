using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class Input
    {
        public string GetTitle()
        {
            Console.Write("Input task title: ");
            var titleInput = Console.ReadLine();
            if (titleInput != null)
            {
                return titleInput;
            }
            else
            {
                return "No title";
            }

        }
    }
}
