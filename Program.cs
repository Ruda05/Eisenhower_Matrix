using Eisenhower_Matrix.Manager;
using Eisenhower_Matrix.Model;
using Eisenhower_Matrix.View;

namespace Eisenhower_Matrix
{

    internal class Program
    {
        public static string SelectedQuarter { get; private set; } = "IU";
        public static int SelectedTask { get; private set; } = 2;
        public static void Main(string[] args)
        {
            var manager = new MatrixDbManager();

            Console.WriteLine(manager.TestConnection());
            var input = new Input();
            var display = new Display();

            string currentOption = "T";

            /*
            var testItem = new ToDoItem("greg", DateTime.Now.AddDays(5));
            Console.WriteLine(testItem.IsDone);
            testItem.Mark();
            Console.WriteLine(testItem.IsDone);
            Console.WriteLine(testItem.Deadline);
            Console.WriteLine(testItem.Title);
            testItem.MakeImportant();
            Console.WriteLine(testItem.IsImportant);
            Console.WriteLine(testItem.Id);
            testItem.Id = 1;
            manager.UpdateItem(testItem);
            Add item - adding item to the database - Test
            manager.AddItem(testItem);
            */

            bool isActive = true;
            while (isActive)
            {

                ToDoMatrix toDoMatrix = new ToDoMatrix();
                var userList = manager.GetAllItems();
                foreach (var item in userList)
                {
                    toDoMatrix.AddItem(item.Title, item.Deadline, item.IsImportant);
                }

                if (currentOption == "T")
                {
                    Console.Clear();
                    Console.WriteLine(toDoMatrix.ToString());
                    display.DisplayQuestion("Select an option:\n[A]dd\n[D]elete\n[Q]uit\nYour choice: ");
                    currentOption = Console.ReadLine().ToUpper();
                   
                    if (currentOption == "Q")
                    {
                        isActive = false;
                    }
                }
                else if (currentOption == "A")
                {
                    Console.Clear();
                    display.DisplayQuestion("Input task title: ");
                    string userInputTitle = input.GetTitle();
                    display.DisplayQuestion("Input deadline in format DD-MM: ");
                    var deadline = input.GetDeadline();
                    display.DisplayQuestion("Is your task important? (Y/N)");
                    string importanceStatusInput = input.GetImportanceStatus();
                    bool isImportant = input.IsImportant(importanceStatusInput);
                    ToDoItem newItem = new(userInputTitle, deadline);
                    if (isImportant) newItem.MakeImportant();
                    manager.AddItem(newItem);
                    display.DisplayQuestion("Do you want to add next task? [Y/N]");
                    string? nextTask = Console.ReadLine();
                    if (nextTask == "Y")
                    {
                        currentOption = "A";
                    }
                    else
                    {
                        currentOption = "T";
                    }

                }
                else if (currentOption == "D")
                {
                    display.DisplayQuestion("Which task to delete?\nSelect group [1-4]:");
                    string groupToDelete = Console.ReadLine();
                    string groupMark;
                    switch (groupToDelete)
                    {
                        case "1":
                            groupMark = "IU";
                            break;
                        case "2":
                            groupMark = "IN";
                            break;
                        case "3":
                            groupMark = "NU";
                            break;
                        case "4":
                            groupMark = "NN";
                            break;
                        default:
                            groupMark = " ";
                            break;
                    }
                    display.DisplayQuestion("Select task number:");
                    string taskToDelete = Console.ReadLine();

                    currentOption = "T";
                }
            }
            Console.Clear();
            display.DisplayQuestion("Thank you for using our Application.\nSee you soon!\n\nCreated (2023) by:\nRadosław Rocławski\nGrzegorz Łabojko\n\n\n\n");
        }
    }
}