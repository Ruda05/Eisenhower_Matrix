using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Eisenhower_Matrix.Model;

public class ToDoItemDao : IToDoItemDao
{
    private readonly string? connectionString;
    public ToDoItemDao(string connectionString)
    {
        this.connectionString = connectionString;
    }
    public void Add(ToDoItem toDoItem)
    {
        const string addItemCommand = @"INSERT INTO todoitems (title, deadline, important, completed) 
                                               VALUES (@title, @deadline, @important, @completed)";
        try
        {
            using var connection = new SqlConnection(connectionString);
            var cmd = new SqlCommand(addItemCommand, connection);
            cmd.Parameters.AddWithValue("@title", toDoItem.Title);
            cmd.Parameters.AddWithValue("@deadline", toDoItem.Deadline.ToString("yyyy-MM-dd"));
            int isImportantValue = toDoItem.IsImportant ? 1 : 0;
            int isDoneValue = toDoItem.IsDone ? 1 : 0;
            cmd.Parameters.AddWithValue("@important", isImportantValue);
            cmd.Parameters.AddWithValue("@completed", isDoneValue);

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            cmd.ExecuteScalar();
        }
        catch (SqlException e)
        {
            throw new RuntimeWrappedException(e);
        }
    }
    public void Update(ToDoItem toDoItem)
    {
        const string updateItemCommand = @"UPDATE todoitems SET title = @title, 
                                                                deadline = @deadline, 
                                                                important = @important, 
                                                                completed = @completed 
                                                            WHERE id = @itemId";
        try
        {
            using var connection = new SqlConnection(connectionString);
            var cmd = new SqlCommand(updateItemCommand, connection);

            cmd.Parameters.AddWithValue("@itemId", toDoItem.Id);
            cmd.Parameters.AddWithValue("@title", toDoItem.Title);
            cmd.Parameters.AddWithValue("@deadline", toDoItem.Deadline.ToString("yyyy-MM-dd"));
            int isImportantValue = toDoItem.IsImportant ? 1 : 0;
            int isDoneValue = toDoItem.IsDone ? 1 : 0;
            cmd.Parameters.AddWithValue("@important", isImportantValue);
            cmd.Parameters.AddWithValue("@completed", isDoneValue);

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            cmd.ExecuteScalar();
        }
        catch (SqlException)
        {
            throw;
        }
    }
    public bool Delete(int id)
    {
        const string deleteItemCommand = @"DELETE FROM todoitem WHERE id = @itemId";
        try
        {
            using var connection = new SqlConnection(connectionString);
            var cmd = new SqlCommand(deleteItemCommand, connection);

            cmd.Parameters.AddWithValue("@itemId", id);

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            cmd.ExecuteScalar();
            return true;
        }
        catch (SqlException)
        {
            return false;
            throw;
        }
        
    }
    public List<ToDoItem> GetAll()
    {
        throw new NotImplementedException();
    }

}
