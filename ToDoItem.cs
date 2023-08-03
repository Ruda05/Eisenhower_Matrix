using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class ToDoItem
    {
        private string Title { get; set; }
        private DateTime Deadline { get; set; }
        private bool IsDone { get; set; } = false;

        public ToDoItem(string title, DateTime deadline)
        {
            Title = title;
            Deadline = deadline;
        }

        public string GetTitle() 
        {
            string titleInput = Console.ReadLine();
            return titleInput;

        }


        public string GetDeadline()
        {
            string deadlineInput = Console.ReadLine();
            return deadlineInput;
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
