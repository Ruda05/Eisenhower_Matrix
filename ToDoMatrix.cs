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

        public void TodoMatrix()
        {
            // Constructs a *TodoMatrix* object with map of all possible quarters
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
            // A dds new item to dictionary* todoQuarters* using adequate key.You should use method * AddItem* from * TodoQuarter* class.
            // This method should be overloaded so as to accept two parameters only.In that case, isImportant should be `false` by default.
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
            string table = @"
    |            URGENT              |           NOT URGENT           |
  --|--------------------------------|--------------------------------|--
    | 1. [ ] 9-6  go to the doctor   |                                |
    | 2. [x] 11-6 submit assignment  |                                |
  I |                                |                                |
  M |                                |                                |
  P |                                |                                |
  O |                                |                                |
  R |                                |                                |
  T |                                |                                |
  A |                                |                                |
  N |                                |                                |
  T |                                |                                |
    |                                |                                |
    |                                |                                |
  --|--------------------------------|--------------------------------|--
  N | 1. [ ] 14-6 buy a ticket       | 1. [x] 30-5 House of Cards     |
  O |                                |                                |
  T |                                |                                |
    |                                |                                |
  I |                                |                                |
  P |                                |                                |
  O |                                |                                |
  R |                                |                                |
  T |                                |                                |
  A |                                |                                |
  N |                                |                                |
  T |                                |                                |
  --|--------------------------------|--------------------------------|--
";
            return table;
        }
    }
}