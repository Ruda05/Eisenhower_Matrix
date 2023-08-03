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

        public void GetQuarter(String status)
        {
            // Returns a chosen* TodoQuarter*object from a map *todoQuarters *.
            // Status should be one of the possible statuses('IU', 'IN', 'NU', 'NN').
        }

        public void AddItem(String title, DateTime deadline, bool isImportant)
        {
            // A dds new item to dictionary* todoQuarters* using adequate key.You should use method * AddItem* from * TodoQuarter* class.
            // This method should be overloaded so as to accept two parameters only.In that case, isImportant should be `false` by default.
        }

        public void AddItemsFromFile(string fileName)
        {
            //Reads data from* fileName.csv* file and appends*TodoItem * objects to attributes*todoItems * in the properly *TodoQuarter * objects.
            //Every item is written in a separate line the following format:

            //`title | day - month | is_important`

            //If* isImportant* is equal to false then last element is an empty string.
            //Otherwise the last element is an arbitrary string.
            //If the last element of line is an empty string, *isImportant * is equal to false -
            // it means that the item should be assigned to a not important TODO quarter.
            // Otherwise item should be assign to an important TODO quarter.
        }

        public void SaveItemsToFile(string fileName)
        {
            // Writes all details about TODO items to* fileName.csv* file
            // Every item is written in a separate line the following format:

            // `title | day - month | is_important`

            // If* IsImportant*contains false then the last element of line should be an empty string.
            // Otherwise last element is an arbitrary string.
        }

        public void ArchiveItems()
        {
            // Removes all *TodoItem* objects with a parameter* isDone* set to *true* from list *todoItems*
            // in every element of dictionary *todoQuarters*
        }

        public override string ToString()
        {
            return $"[{IsDone}] {Deadline} {Title}";
        }
    }
}