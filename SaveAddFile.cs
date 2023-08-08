using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class SaveAddFile
    {
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
    }
}
