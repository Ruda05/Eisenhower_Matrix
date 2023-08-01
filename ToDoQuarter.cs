using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class ToDoQuarter
    {
        
        // creates empty list named ToDoItems with strings containing description of ToDoItems objects
        private List<string> ToDoItems = new List<string>();

        public ToDoQuarter()
        {
            List<string> ToDoQuarter = new List<string>();
        }

        public AddItem(string title, DateTime deadline)
        {
            var toDoItem = new ToDoItem(string title, DateTime deadline);
            ToDoItems.Add(ToDoItem);
        }

        public void RemoveItem(int index)
        {
            // Removes *TodoItem* object using *index* of list *todoItems*
        }
        public void ArchiveItems()
        {
            // Removes all *TodoItem* objects with a parameter* isDone* set to *true* from list *todoItems*.
        }

        public void GetItem(int index)
        {
            // Returns* TodoItem* object from *index* of list* todoItems*.
        }

        public void GetItems()
        {
            // Returns private field *todoItems*.
        }

        public ToString()
        {
            return $"[{IsDone}] {Deadline} {Title}";
        }

    }
}
