namespace Eisenhower_Matrix
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Eisenhower!");
            ToDoItem todoItem = new ToDoItem();
            string zmienna = "sraczka";
            var input = new Input();
            var display = new Display();
            display.InputTitle();
            input.GetTitle();
            display.InputDeadline();
            input.GetDeadline();
            display.InputMark();
            input.GetMark();
            Console.WriteLine(input.titleInput);
            Console.WriteLine("dupa");
            Console.WriteLine(input.GetTitle());
            Console.WriteLine(zmienna);
        }
    }
}