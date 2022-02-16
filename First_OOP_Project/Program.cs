using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_OOP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = ReadFile("values.csv");
            List<Person> people = new List<Person>();

            people = GetPeople(file);


        }
        /// <summary>
        /// Read from file and return lines
        /// </summary>
        /// <param name="filename">Path to file</param>
        /// <returns>String array of file lines</returns>
        static string[] ReadFile(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            return lines;
        }
        /// <summary>
        /// Get people from file
        /// </summary>
        /// <param name="file"></param>
        /// <returns>List of people</returns>
        static List<Person> GetPeople(string[] file)
        {
            Dictionary<int, List<string>> file_items = new Dictionary<int, List<string>>();

            //get items from file

            for (int i = 0; i < file.Length; i++) file_items.Add(i, GetItems(file[i]));
        }

        /// <summary>
        /// Get Items from line
        /// </summary>
        /// <param name="line"></param>
        /// <returns>List of items</returns>
        static List<string> GetItems(string line)
        {
            string current_word = "";
            List<string> items = new List<string>();

            foreach(char c in line)
            {
                if(c == ',')
                {
                    if(current_word != "")
                    {
                        items.Add(current_word);
                        current_word = "";
                    }
                }
                else
                {
                    current_word += c.ToString();
                }
            }
            //add item if exists
            if (current_word != "") items.Add(current_word);

            //return new instance of items list
            return new List<string>(items);
        }
    }
}
