namespace Eisenhower_Matrix.View;

internal class Display
{
    public void DisplayQuestion(string givenQuestion)
    {
        Console.Write(givenQuestion);
    }

    public void DisplayStatus(int importanceStatus)
    {
        Console.WriteLine(importanceStatus);
        
    }
    static void DisplayMatrix(
        string cell1,
        string cell2,
        string cell3,
        string cell4
    )
    {
        Console.WriteLine("╔═══════════════════════════════════════════════╗");
        Console.WriteLine($"║{cell1}              ║       {cell2}          ║");
        Console.WriteLine("╠═══════════════════════════════════════════════╣");
        Console.WriteLine($"║{cell3}              ║       {cell4}          ║");
        Console.WriteLine("╚═══════════════════════════════════════════════╝");
    }

    internal void DisplayMatrix(ToDoQuarter importantUrgent, ToDoQuarter importantNotUrgent, ToDoQuarter notImportantUrgent, ToDoQuarter notImportantNotUrgent)
    {
        throw new NotImplementedException();
    }

    
}
