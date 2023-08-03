using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class ToDoItem
    {
        private string? Title { get; set; }
        private DateTime Deadline { get; set; }
        private bool IsDone { get; set; } = false;

        public string CreateToDoItem(string title, DateTime deadline)
        {
            Title = title;
            Deadline = deadline;
            return "title";
        }

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


        public string GetDeadline()
        {
            // input provides only day and month - year is firmed to 2023
            Console.Write("Input deadline in format MM-DD: ");
            var deadlineInput = Console.ReadLine();
            if (deadlineInput != null)
            {
                return deadlineInput;
            }
            else
            {
                return "No deadline";
            }
        }

        public void Mark()
        {
            IsDone = true;
        }

        public void Unmark()
        {
            IsDone = false;
        }

        public override string ToString()
        {
            return $"[{IsDone}] {Deadline} {Title}";
        }


    }
}
