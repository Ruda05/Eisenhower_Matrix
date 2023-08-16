using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class Display
    {
        public void DisplayQuestion(string givenQuestion)
        {
            Console.Write(givenQuestion);
        }

        public void DisplayMatrix(int importanceStatus)
        {
            Console.WriteLine(importanceStatus);
            
        }
      
    }
}
