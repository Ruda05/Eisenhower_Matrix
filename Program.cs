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
            display.DisplayQuestion("Input task title: ");
            string userInputTitle = input.GetTitle();
            display.DisplayQuestion("Input deadline in format MM-DD: ");
            string userInputDeadline = input.GetDeadline();
            display.DisplayQuestion("Is this task already done? Y/N: ");
            string userInputMark = input.GetMark();
            Console.WriteLine(userInputTitle);
            Console.WriteLine(userInputDeadline);
            Console.WriteLine(userInputMark);
        }
    }
}