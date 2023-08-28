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
}
