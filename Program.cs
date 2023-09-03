using Eisenhower_Matrix.Manager;
using Eisenhower_Matrix.Model;

namespace Eisenhower_Matrix
{

    internal class Program
    {
       // public static string SelectedQuarter { get; private set; } = "IU";
       // public static int SelectedTask { get; private set; } = 1;
        public static void Main(string[] args)
        {
            var manager = new MatrixDbManager();

            Console.WriteLine(manager.TestConnection());
            var testItem = new ToDoItem("Radek", DateTime.Now.AddDays(7));
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
            //Add item - adding item to the database - Test
            //manager.AddItem(testItem);



            //var input = new Input();
            //var display = new Display();
            //ToDoMatrix toDoMatrix = new ToDoMatrix();
            //string currentOption = "T";

            //bool isActive = true;
            //while (isActive)
            //{
            //    if (currentOption == "T")
            //    {
            //        Console.Clear();
            //        Console.WriteLine(toDoMatrix.ToString());
            //        display.DisplayQuestion("Select an option:\n[A]dd\n[D]elete\n[Q]uit\nYour choice: ");
            //        currentOption = Console.ReadLine();
            //        if (currentOption == "Q") 
            //        { 
            //            isActive = false;
            //        }
            //    }
            //    else if (currentOption == "A")
            //    {
            //        Console.Clear();
            //        display.DisplayQuestion("Input task title: ");
            //        string userInputTitle = input.GetTitle();
            //        display.DisplayQuestion("Input deadline in format DD-MM: ");
            //        var deadline = input.GetDeadline();
            //        display.DisplayQuestion("Is your task important? (Y/N)");
            //        string importanceStatusInput = input.GetImportanceStatus();
            //        bool isImportant = input.IsImportant(importanceStatusInput);
            //        toDoMatrix.AddItem(userInputTitle, deadline, isImportant);
            //        display.DisplayQuestion("Do you want to add next task? [Y/N]");
            //        string nextTask = Console.ReadLine();
            //        if (nextTask == "Y")
            //        {
            //            currentOption = "A";
            //        }
            //        else
            //        {
            //            currentOption = "T";
            //        }

            //    }
            //    else if (currentOption == "D") 
            //    {
            //        display.DisplayQuestion("Which task to delete?\nSelect group [1-4]:");
            //        string groupToDelete = Console.ReadLine();
            //        string groupMark;
            //        switch (groupToDelete)
            //        {
            //            case "1":
            //                groupMark = "IU";
            //                break;
            //            case "2":
            //                groupMark = "IN";
            //                break;
            //            case "3":
            //                groupMark = "NU";
            //                break;
            //            case "4":
            //                groupMark = "NN";
            //                break;
            //            default:
            //                groupMark = " ";
            //                break;
            //        }
            //        display.DisplayQuestion("Select task number:");
            //        string taskToDelete = Console.ReadLine();

            //        currentOption = "T";
            //    }
            //}
            //Console.Clear();
            //display.DisplayQuestion("Thank you for using our Application.\nSee you soon!\n\nCreated (2023) by:\nRadosław Rocławski\nGrzegorz Łabojko\n\n\n\n");
        }
    }
}