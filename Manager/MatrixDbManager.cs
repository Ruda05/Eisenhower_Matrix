using Eisenhower_Matrix.Model;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Eisenhower_Matrix.Manager;

public class MatrixDbManager
{
   
    public string? connectionString => ConfigurationManager.AppSettings["connectionString"];
    private IToDoItemDao toDoItemDao;
    public MatrixDbManager()
    {
        toDoItemDao = new ToDoItemDao(connectionString);
    }
    public void AddItem()
    {
        toDoItemDao.Add(new ToDoItem("Radek", DateTime.Now));
    }

    public void UpdateItem()
    {
        //ToDoItem toDoItem = toDoItemDao.Get(1); // getting an item with index 1.
        //toDoItemDao.Update(toDoItem);
    }

    public bool TestConnection()
    {
        using var connection = new SqlConnection(connectionString);

        try
        {
            connection.Open();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }
}
