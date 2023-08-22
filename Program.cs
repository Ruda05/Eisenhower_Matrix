using Eisenhower_Matrix;
using Microsoft.VisualBasic;
using System.Globalization;


Console.WriteLine("Hello, Eisenhower!");
ToDoItem todoItem = new ToDoItem();
var input = new Input();
var display = new Display();
var toDoMatrix = new ToDoMatrix();
var importantUrgent = new ToDoQuarter();
var notImportantUrgent = new ToDoQuarter();
var importantNotUrgent = new ToDoQuarter();
var notImportantNotUrgent = new ToDoQuarter();
display.DisplayQuestion("Input task title: ");
string userInputTitle = input.GetTitle();
display.DisplayQuestion("Input deadline in format DD-MM: ");
string userInputDeadline = input.GetDeadline();
display.DisplayQuestion("Is your task important? (Y/N)");
string importanceStatusINPUT = input.GetImportanceStatus();
Console.WriteLine(toDoMatrix.EstimateUrgency(userInputDeadline, userInputDeadline, input.IsImportant(importanceStatusINPUT)));
//display.DisplayQuestion("Is this task already done? Y/N: ");
//string userInputMark = input.GetMark();
//display.DisplayQuestion("Select task group: \n" +
//                        "1] Important and Urgent\n" +
//                       "2] Important but Not urgent\n" +
//                       "3] Not important but Urgent\n" +
//                       "4] Not important and Not urgent\n" +
//                       "Your choice: ");


importantUrgent.AddItem(userInputTitle, userInputDeadline);
Console.WriteLine("Important and Urgent:");
Console.WriteLine(importantUrgent);
Console.WriteLine("Important but Not urgent:");
Console.WriteLine(importantNotUrgent);
Console.WriteLine("Not important but Urgent:");
Console.WriteLine(notImportantUrgent);
Console.WriteLine("Not important and Not urgent:");
Console.WriteLine(notImportantNotUrgent);

//display.DisplayMatrix(importantUrgent, importantNotUrgent, notImportantUrgent, notImportantNotUrgent);
//var newMatrix = new ToDoMatrix();
//Console.WriteLine(newMatrix);
var matrix = new ToDoMatrix();
//matrix.AddItem(userInputTitle, deadline, importance);
//Console.WriteLine(matrix.ToString());
