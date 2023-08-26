using Eisenhower_Matrix;
using Microsoft.VisualBasic;
using System.Globalization;

var input = new Input();
var display = new Display();
ToDoMatrix toDoMatrix = new ToDoMatrix();

bool isActive = true;
while (isActive)
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
    isActive = nextTask == "Y";
}

Console.Clear();
Console.WriteLine(toDoMatrix.ToString());