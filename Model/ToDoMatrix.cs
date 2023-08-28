using System.Text;
using Eisenhower_Matrix.Model;

namespace Eisenhower_Matrix
{
    public class ToDoMatrix

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

        public static void GetQuarters()
        {
            // Returns a private filed* todoQuarters*.
        }

        public void GetQuarter(string status)
        {
            // Returns a chosen* TodoQuarter*object from a map *todoQuarters *.
            // Status should be one of the possible statuses('IU', 'IN', 'NU', 'NN').
            // return ToDoQuarters[status];
        }

        public void AddItem(string title, DateTime deadline, bool isImportant)
        {
            
            string quarterKey = EstimateUrgency(deadline, isImportant);
            ToDoQuarters[quarterKey].AddItem(title, deadline);


            // Adds new item to dictionary* todoQuarters* using adequate key.You should use method * AddItem* from * TodoQuarter* class.
            // This method should be overloaded so as to accept two parameters only.In that case, isImportant should be `false` by default.
            //ToDoQuarters[importance].AddItem
        }

        public string EstimateUrgency(DateTime deadline, bool isImportant)
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan dateDiff = deadline - dateTime;
            int daysDifference = (int)dateDiff.TotalDays;
            
            if (daysDifference <= 3 && isImportant == true)
            {
                return "IU";
            }
            else if (daysDifference > 3 && isImportant == true)
            { 
                return "IN"; 
            }
            else if (daysDifference <= 3 && isImportant == false)
            {
                return "NU";
            } 
            return "NN";
            
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
            string displayKey;
            int groupIndex = 1;

            foreach (var quarter in ToDoQuarters)
            {
                string key = quarter.Key;
                switch (key)
                {
                    case "IU":
                        displayKey = "Important & Urgent";
                        break;
                    case "IN":
                        displayKey = "Important & Not Urgent";
                        break;
                    case "NU":
                        displayKey = "Not Important & Urgent";
                        break;
                    case "NN":
                        displayKey = "Not Important & Not Urgent";
                        break;
                    default:
                        displayKey = " ";
                        break;
                }


                ToDoQuarter toDoQuarter = quarter.Value;
                tableBuilder.AppendLine($"{groupIndex}] {displayKey}\n");
                groupIndex++;

                int taskIndex = 1;

                foreach (ToDoItem item in toDoQuarter.GetItems())
                {
                    string line;
                    if (taskIndex == 1)
                    {
                        line = $"\t{taskIndex}. {item.ToString()}";
                        line = $"\u001b[31m{line}\u001b[0m"; // ANSI escape code for red text color
                    }
                    else
                    {
                        line = $"\t{taskIndex}. {item.ToString()}";
                    }
                    tableBuilder.AppendLine(line);
                    taskIndex++;
                }
            }
            
       
            //tableBuilder.AppendLine("    |            URGENT              |           NOT URGENT           |");
            //tableBuilder.AppendLine("  --|--------------------------------|--------------------------------|--");
            //tableBuilder.AppendLine("    | 1. [ ] 9-6  go to the doctor   |                                |");
            //tableBuilder.AppendLine("    | 2. [x] 11-6 submit assignment  |                                |");
            //tableBuilder.AppendLine("  I |                                |                                |");
            //tableBuilder.AppendLine("  M |                                |                                |");
            //tableBuilder.AppendLine("  P |                                |                                |");
            //tableBuilder.AppendLine("  O |                                |                                |");
            //tableBuilder.AppendLine("  R |                                |                                |");
            //tableBuilder.AppendLine("  T |                                |                                |");
            //tableBuilder.AppendLine("  A |                                |                                |");
            //tableBuilder.AppendLine("  N |                                |                                |");
            //tableBuilder.AppendLine("  T |                                |                                |");
            //tableBuilder.AppendLine("    |                                |                                |");
            //tableBuilder.AppendLine("    |                                |                                |");
            //tableBuilder.AppendLine("  --|--------------------------------|--------------------------------|--");
            //tableBuilder.AppendLine("  N |                                |                                |");
            //tableBuilder.AppendLine("  O |                                |                                |");
            //tableBuilder.AppendLine("  T |                                |                                |");
            //tableBuilder.AppendLine("    |                                |                                |");
            //tableBuilder.AppendLine("  I |                                |                                |");
            //tableBuilder.AppendLine("  M |                                |                                |");
            //tableBuilder.AppendLine("  P |                                |                                |");
            //tableBuilder.AppendLine("  O |                                |                                |");
            //tableBuilder.AppendLine("  R |                                |                                |");
            //tableBuilder.AppendLine("  T |                                |                                |");
            //tableBuilder.AppendLine("  A |                                |                                |");
            //tableBuilder.AppendLine("  N |                                |                                |");
            //tableBuilder.AppendLine("  T |                                |                                |");
            //tableBuilder.AppendLine("  --|--------------------------------|--------------------------------|--");

            return tableBuilder.ToString();

        }

        internal string? EstimateUrgency(string userInputDeadline1, string userInputDeadline2, Func<string, bool> isImportant)
        {
            throw new NotImplementedException();
        }
    }
}