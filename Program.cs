using Eisenhower_Matrix;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Eisenhower_Matrix
{

    internal class Program
    {
        static void Main()
        {
            var input = new Input();
            var display = new Display();
            ToDoMatrix toDoMatrix = new ToDoMatrix();
            string currentOption = "T";

            bool isActive = true;
            while (isActive)
            {
                if (currentOption == "T")
                {
                    Console.Clear();
                    Console.WriteLine(toDoMatrix.ToString());
                    display.DisplayQuestion("Select an option:\n[A] Add\n[Q] Quit\nYour choice: ");
                    currentOption = Console.ReadLine();
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
                    toDoMatrix.AddItem(userInputTitle, deadline, isImportant);
                    display.DisplayQuestion("Do you want to add next task? [Y/N]");
                    string nextTask = Console.ReadLine();
                    if (nextTask == "Y")
                    {
                        currentOption = "A";
                    }
                    else
                    {
                        currentOption = "T";
                    }

                }
            }
            Console.Clear();
            display.DisplayQuestion("Thank you for using our Application.\nSee you soon!\n\nCreated (2023) by:\nRadosław Rocławski\nGrzegorz Łabojko\n\n\n\n");
        }
    }
}