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
                AddBothNumbers(FirstNumber, LastNumber);
            }
            Console.WriteLine("Total count of ints" + ListOfInts.Sum());
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


        public void FindFirstDigit(string inputText)
        {
            if (InputText != null)
            {
                string retVal = string.Join(string.Empty, Regex.Matches(inputText, @"\d+").OfType<Match>().Select(m => m.Value));
                //string retVal = Regex.Match(inputText, @"\d+").Value;
                Console.WriteLine(retVal);
                char firstWord = retVal[0];
                FirstNumber = firstWord.ToString();
              
                //Console.WriteLine("First number: " + FirstNumber);
            }
            return;
        }


        public void FindLastDigit(string inputText)
        {

            string retVal = string.Join(string.Empty, Regex.Matches(inputText, @"\d+").OfType<Match>().Select(m => m.Value));

           //string retVal = Regex.Match(inputText, @"\d+").Value;
            Console.WriteLine(retVal);
            
            char lastWord = retVal.Last();
            LastNumber = lastWord.ToString();

            //Console.WriteLine("Last number: " + LastNumber);
        }

        public void AddBothNumbers (string firstNumber, string lastNumber)
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
            
        }
    }
}
