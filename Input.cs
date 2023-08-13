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
            var titleInput = Console.ReadLine();
            
            if (titleInput != "")
            {
                return titleInput;
            }
            else
            {
                return "No title";
            }

        }


        public string GetDeadline()
        {
            // input provides only day and month - year is firmed to 2023
            var deadlineInput = Console.ReadLine();
            if (deadlineInput != null)
            {
                return $"2023-{deadlineInput}";
            }
            else
            {
                return "No deadline";
            }
        }

        public string GetMark()
        {
            var markInput = Console.ReadLine();
            if (markInput != null)
            {
                return markInput;
            }
            else if (markInput == "Y")
            {
                return "X";
            }
            else if (markInput == "N")
            {
                return " ";
            }
            else
            {
                return "No mark";
            }
        }

        //public int GetImportanceUrgency()
        //{
        //    int importanceUrgency = Convert.ToInt32(Console.ReadLine());

        //    switch (importanceUrgency)
        //    {
        //        case 1:
        //            Console.WriteLine("Your task is important and urgent");
        //            break;
        //        case 2:
        //            Console.WriteLine("Your task is important and but not urgent");
        //            break;
        //        case 3:
        //            Console.WriteLine("Your task is not important but urgent");
        //            break;
        //        case 4:
        //            Console.WriteLine("Your task is not important and not urgent");
        //            break;
        //    }

        //}
    }
}
