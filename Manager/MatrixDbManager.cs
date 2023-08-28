using Eisenhower_Matrix.Model;
using System.Configuration;

namespace Eisenhower_Matrix.Manager;

public class MatrixDbManager
{
    private string connectionString => ConfigurationManager.AppSettings["connectionString"];
    private IToDoItemDao toDoItemDao;

    public void AddItem()
    {
        toDoItemDao.Add(new ToDoItem("Shopping Center", DateTime.Now));
    }

    public void UpdateItem()
    {
        ToDoItem toDoItem = toDoItemDao.Get(1); // getting an item with index 1.
        toDoItemDao.Update(toDoItem);
    }
}
