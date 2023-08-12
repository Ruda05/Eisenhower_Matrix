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
        private string? Deadline { get; set; }
        private bool IsDone { get; set; } = false;

        public string CreateToDoItem(string title, string deadline)
        {
            Title = title;
            Deadline = deadline;
            return ToString();
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
