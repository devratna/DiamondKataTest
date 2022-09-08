
namespace ConsoleApplication
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("User enters a Letter between A and Z ");
            char user_letter = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            int letterNumber = GetLetterNum(user_letter);
            var diamond = ConstructDiamond(letterNumber);
            ConstructReverseDiamond(letterNumber, diamond);

        }


        // Get Character List
        public static char[] GetCharList()
        {

            char[] letterList = new char[26]
           {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
           };
            return letterList;

        }

        // Get Letter Number
        public static int GetLetterNum(char inputChar)
        {

            int letter_number = 0;
            var letterList = GetCharList();
            string[] diamond = new string[52];
            for (int i = 0; i < letterList.Length; i++)
            {
                if (letterList[i] == inputChar)
                {
                    letter_number = i;
                    break;
                }
            }

            return letter_number;
        }

        //construct diamond

        public static string[] ConstructDiamond(int letterNumber)
        {
            var letterList = GetCharList();
            string[] diamond = new string[52];


            for (int i = 0; i <= letterNumber; i++)
            {
                //add initial spaces
                for (int j = 0; j < letterNumber - i; j++)
                {
                    diamond[i] += " ";
                }

                //add letter (first time)
                diamond[i] += letterList[i];

                //add space between letters
                if (letterList[i] != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        diamond[i] += " ";
                    }
                    //add letter (second time)
                    diamond[i] += letterList[i];
                }
                // Draw the first part of the diamond as it's composing.
                Console.WriteLine(diamond[i]);
            }
            return diamond;
        }

        // Construct Reverse Diamond
        public static void ConstructReverseDiamond(int letterNumber, string[] diamond)
        {

            for (int i = letterNumber - 1; i >= 0; i--)
            {
                // Draw the second part of the diamond
                // Writing the diamondArray in reverse order.
                Console.WriteLine(diamond[i]);
            }

            // Mark a pause
            Console.ReadKey();
        }

    }
}