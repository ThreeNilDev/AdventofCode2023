using System.Text.RegularExpressions;

namespace Day1
{
    internal class Day1Processor
    {
        string[] InputText;
        string FirstNumber;
        string LastNumber;
        List<Int32> ListOfInts = new List<Int32>();


        public void ProcessData()
        {
            GetDataFromFile();
            foreach (string line in InputText)
            {
                FindFirstDigit(line);
                FindLastDigit(line);
                CombineBothNumbers(FirstNumber, LastNumber);
            }
            Console.WriteLine("Total count of ints: " + ListOfInts.Sum());
            return;
            //ReadTextFromArray();
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
            return;
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

        void ConvertWordsToInt(string inputText)
        {
            List<string> list = new List<string>();
            list.Add("zero");
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.Add("five");
            list.Add("six");
            list.Add("seven");
            list.Add("eight");
            list.Add("nine");
            list.Add("ten");

            //string retVal = inputText.Replace(inputText,)
        }


        void FindFirstDigit(string inputText)
        {
           
                //Find all ints
            string retVal = string.Join(string.Empty, Regex.Matches(inputText, @"\d+").OfType<Match>().Select(m => m.Value));
            FirstNumber = retVal[0].ToString();
            //char firstWord = retVal[0];
                //FirstNumber = firstWord.ToString();
            return;
        }


        void FindLastDigit(string inputText)
        {

            string retVal = string.Join(string.Empty, Regex.Matches(inputText, @"\d+").OfType<Match>().Select(m => m.Value));

           //string retVal = Regex.Match(inputText, @"\d+").Value;
            Console.WriteLine(retVal);

            LastNumber = retVal.Last().ToString();
            return;
            //Console.WriteLine("Last number: " + LastNumber);
        }

        void CombineBothNumbers (string firstNumber, string lastNumber)
        {
            string bothNumbers = firstNumber + lastNumber;
            try
            {
                int retVal = Int32.Parse(bothNumbers.ToString());
                ListOfInts.Add(retVal);
                //Console.WriteLine(retVal);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{bothNumbers}'");
            }
            return;
        }
    }
}
