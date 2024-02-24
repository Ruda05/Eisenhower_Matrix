using System.Text;
using Eisenhower_Matrix.Model;
using Eisenhower_Matrix.Test;

namespace Eisenhower_Matrix
{
    public class ToDoQuarter
    {

        public List<ToDoItem> ToDoItems;

        public ToDoQuarter()
        {
            ToDoItems = new List<ToDoItem>();
        }

        public void AddItem(int id, string title, DateTime deadline, bool isDone)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty or whitespace.");
            }

            if (deadline < DateTime.Today)
            {
                throw new ArgumentException("Deadline cannot be in the past.");
            }

            ToDoItems.Add(new ToDoItem(id, title, deadline, isDone));
        }

        public void RemoveItem(int index)
        {
            if (index < 0 || index >= ToDoItems.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            ToDoItems.RemoveAt(index);
        }
        public void ArchiveItems()
        {
            ToDoItems.RemoveAll(item => item.IsDone);
        }

        public ToDoItem GetItem(int index)
        {
            if (index < 0 || index >= ToDoItems.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            return ToDoItems[index];
        }

        public List<ToDoItem> GetItems()
        {
            return ToDoItems;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ToDoItems.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {ToDoItems[i]}");
            }
            return sb.ToString();
        }

    }
}
