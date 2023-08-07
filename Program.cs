namespace Eisenhower_Matrix
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Eisenhower!");
            ToDoItem todoItem = new ToDoItem();
            var input = new Input();
            var display = new Display();
            display.InputTitle();
            input.GetTitle();
            display.InputDeadline();
            input.GetDeadline();
            display.InputMark();
            input.GetMark();
            Console.WriteLine(input.titleInput); // czemu titleinput musi być boolem?
            Console.WriteLine("dupa");

        }
    }
}