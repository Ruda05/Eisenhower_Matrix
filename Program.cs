using Eisenhower_Matrix;
using Microsoft.VisualBasic;
using System.Globalization;

var input = new Input();
var display = new Display();
ToDoMatrix toDoMatrix = new ToDoMatrix();

bool isActive = true;
while (isActive)
{
    display.DisplayQuestion("Input task title: ");
    string userInputTitle = input.GetTitle();
    display.DisplayQuestion("Input deadline in format DD-MM: ");
    var deadline = input.GetDeadline();
    display.DisplayQuestion("Is your task important? (Y/N)");
    string importanceStatusINPUT = input.GetImportanceStatus();
    //display.DisplayQuestion("Is this task already done? Y/N: ");
    //Console.WriteLine($"Your task is already done:{input.IsDone(input.GetStatus())}");
    toDoMatrix.AddItem(userInputTitle, deadline, importanceStatusINPUT == "important");

    display.DisplayQuestion("Do you want to add next task? [Y/N]");
    string nextTask = Console.ReadLine();
    isActive = nextTask == "Y";
}




Console.WriteLine(toDoMatrix.ToString());
