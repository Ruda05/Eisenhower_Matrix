using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Eisenhower_Matrix
{
    internal class ToDoMatrix
    {
        Dictionary<string, ToDoQuarter> ToDoQuarters = new Dictionary<string, ToDoQuarter>();
        //- 'IU' means that todoQuarter contains important todoItems & urgent
        //- 'IN' means that todoQuarter contains important todoItems & not urgent
        //- 'NU' means that todoQuarter contains not important todoItems & urgent
        //- 'NN' means that todoQuarter contains not important & not urgent todoItems

        public ToDoMatrix()
        {
            ToDoQuarters.Add("IU", new ToDoQuarter());
            ToDoQuarters.Add("IN", new ToDoQuarter());
            ToDoQuarters.Add("NU", new ToDoQuarter());
            ToDoQuarters.Add("NN", new ToDoQuarter());

            //Eisenhower_Matrix { "IU": <List>, "IN": <List>}
            //,"IU"[0]
        }

        public void GetQuarters()
        {
            // Returns a private filed* todoQuarters*.
        }

        public void GetQuarter(string status)
        {
            // Returns a chosen* TodoQuarter*object from a map *todoQuarters *.
            // Status should be one of the possible statuses('IU', 'IN', 'NU', 'NN').
        }

        public void AddItem(string title, DateTime deadline, bool isImportant)
        {
            // Adds new item to dictionary* todoQuarters* using adequate key.You should use method * AddItem* from * TodoQuarter* class.
            // This method should be overloaded so as to accept two parameters only.In that case, isImportant should be `false` by default.
            //ToDoQuarters[importance].AddItem
        }

        public string EstimateUrgency(string userInputDeadline, string deadline, bool isImportant)
        {
            string dateFormat = "dd-MM";
            DateTime parsedDate;

            // Próba sparsowania daty
            if (DateTime.TryParseExact(userInputDeadline, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine("Your deadline is: " + parsedDate.ToString("dd-MM"));
                
            }
            else
            {
                Console.WriteLine("Wrong format of date.");
            }

            DateTime dateTime = DateTime.Now;
            TimeSpan dateDiff = parsedDate - dateTime;
            Console.WriteLine($"Today is {dateTime.ToString("dd-MM")}");
            Console.WriteLine($"You have {dateDiff.ToString("dd")} days to your deadline");
            int daysDifference = (int)dateDiff.TotalDays;
            
            if (daysDifference <= 3 && isImportant == true)
            {
                return "ImportantUrgent (IU)";
            }
            if (daysDifference > 3 && isImportant == true)
            { 
                return "ImportantNotUrgent (IN)"; 
            }
            if (daysDifference <= 3 && isImportant == false)
            {
                return "NotImportantUrgent (NU)";
            }
            else
            {
                return "NotImportantNotUrgent (NN)";
            }

            //string dateDiffDays = dateDiff.ToString("dd");
            //dateDiff.ToString("dd");

            //Console.WriteLine(dateDiff);
            //Console.WriteLine(dateDiff.ToString("dd"));
            //Console.WriteLine(dateTime.ToString("dd.MM.yyyy"));
            //Console.WriteLine(parsedDate.ToString("dd.MM.yyyy"));
            //        IU IN NU NN

        }

        public void ArchiveItems()
        {
            // Removes all *TodoItem* objects with a parameter* isDone* set to *true* from list *todoItems*
            // in every element of dictionary *todoQuarters*
        }

        public override string ToString()
        {
            //  Returns a todoQuarters list (an Eisenhower todoMatrix) formatted to string.
            // return $"[{IsDone}] {Deadline} {Title}";

            //StringBuilder stringBuilder = new StringBuilder();

            //stringBuilder.AppendLine("TodoMatrix Keys:");
            //foreach (string quarterKey in ToDoQuarters.Keys)
            //{
            //    stringBuilder.AppendLine(quarterKey);
            //}

            //return stringBuilder.ToString();

            StringBuilder tableBuilder = new StringBuilder();

            tableBuilder.AppendLine("    |            URGENT              |           NOT URGENT           |");
            tableBuilder.AppendLine("  --|--------------------------------|--------------------------------|--");
            tableBuilder.AppendLine("    | 1. [ ] 9-6  go to the doctor   |                                |");
            tableBuilder.AppendLine("    | 2. [x] 11-6 submit assignment  |                                |");
            tableBuilder.AppendLine("  I |                                |                                |");
            tableBuilder.AppendLine("  M |                                |                                |");
            tableBuilder.AppendLine("  P |                                |                                |");
            tableBuilder.AppendLine("  O |                                |                                |");
            tableBuilder.AppendLine("  R |                                |                                |");
            tableBuilder.AppendLine("  T |                                |                                |");
            tableBuilder.AppendLine("  A |                                |                                |");
            tableBuilder.AppendLine("  N |                                |                                |");
            tableBuilder.AppendLine("  T |                                |                                |");
            tableBuilder.AppendLine("    |                                |                                |");
            tableBuilder.AppendLine("    |                                |                                |");
            tableBuilder.AppendLine("  --|--------------------------------|--------------------------------|--");
            tableBuilder.AppendLine("  N |                                |                                |");
            tableBuilder.AppendLine("  O |                                |                                |");
            tableBuilder.AppendLine("  T |                                |                                |");
            tableBuilder.AppendLine("    |                                |                                |");
            tableBuilder.AppendLine("  I |                                |                                |");
            tableBuilder.AppendLine("  M |                                |                                |");
            tableBuilder.AppendLine("  P |                                |                                |");
            tableBuilder.AppendLine("  O |                                |                                |");
            tableBuilder.AppendLine("  R |                                |                                |");
            tableBuilder.AppendLine("  T |                                |                                |");
            tableBuilder.AppendLine("  A |                                |                                |");
            tableBuilder.AppendLine("  N |                                |                                |");
            tableBuilder.AppendLine("  T |                                |                                |");
            tableBuilder.AppendLine("  --|--------------------------------|--------------------------------|--");

            return tableBuilder.ToString();

        }

        internal string? EstimateUrgency(string userInputDeadline1, string userInputDeadline2, Func<string, bool> isImportant)
        {
            throw new NotImplementedException();
        }
    }
}