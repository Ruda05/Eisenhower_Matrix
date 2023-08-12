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
        ToDoItem todoItem = new ToDoItem();

        public ToDoQuarter()
        {
            List<string> ToDoQuarter = new List<string>();
        }

        public void AddItem(string title, string deadline)
        {
            Console.WriteLine("title: " + title + "deadline: " + deadline);
            var toDoItem = todoItem.CreateToDoItem(title, deadline);
            Console.WriteLine(toDoItem.ToString());
            ToDoItems.Add(toDoItem);
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ToDo Items:");
            for (int i = 0; i < ToDoItems.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {ToDoItems[i]}");
            }
            return sb.ToString();
        }

    }
}
