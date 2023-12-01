using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Day1Processor
    {
        string[] InputText;

        //public void Talk()
        //{
        //    Console.WriteLine("Test from talk");
        //}

        public void ProcessData()
        {
            GetDataFromFile();
            ReadTextFromArray();
        }

        void GetDataFromFile()
        {
            string filePath = "@/../input.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist: {0} ", filePath); 
                return;
            }
            string[] textFromFile = File.ReadAllLines(filePath);
            InputText = textFromFile;

        }

        void ReadTextFromArray()
        {
           if (InputText != null)
            {
                foreach (string line in InputText)
                {
                    Console.WriteLine(line);
                }
            }
            return;   
            
        }
        // Find first digit and last digit then combine
        //This method currently returns all numbers
        public void FindFirstDigit()
        {
            if (InputText != null)
            {
                foreach (string line in InputText)
                {
                    var firstNumber = (line.SkipWhile(x => !char.IsDigit(x))
                                                     .TakeWhile(x => char.IsDigit(x))
                                                     .ToArray());

                    //var firstNumber = new(line.TakeWhile(char.IsDigit).ToArray());
                    Console.WriteLine(firstNumber);
                }
            }
            return;
        }


    }
}
