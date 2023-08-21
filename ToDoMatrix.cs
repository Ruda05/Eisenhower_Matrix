using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        }

        public string EstimateUrgency(DateTime deadline, bool isImportant) 
        {
            return "";
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

            tableBuilder.AppendLine(@"
    |            URGENT              |           NOT URGENT           |
  --|--------------------------------|--------------------------------|--
");

            // You can insert your data here using placeholders
            tableBuilder.AppendLine("    | 1. [ ] 9-6  go to the doctor   |                                |");
            tableBuilder.AppendLine("    | 2. [x] 11-6 submit assignment  |                                |");
            // Add more rows as needed

            tableBuilder.AppendLine(@"
  --|--------------------------------|--------------------------------|--
");

            // Insert more data here for the second section of the table
            // Add more rows as needed

            tableBuilder.AppendLine(@"
  --|--------------------------------|--------------------------------|--");

            return tableBuilder.ToString();

        }
    }
}