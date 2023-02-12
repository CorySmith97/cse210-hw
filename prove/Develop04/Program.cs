using System;
using System.Text;

class Program
{
    static void Main(string[] args)
        {
            string originalString = "This is a sentence that I want to replace random sections of";
            int stringLength = originalString.Length;
            int numberOfReplacements = 3;

            Random random = new Random();
            StringBuilder maskedString = new StringBuilder(originalString);

            for (int i = 0; i < numberOfReplacements; i++)
            {
                int startIndex = random.Next(0, stringLength - 1);
                int length = random.Next(1, stringLength - startIndex);
                string replacement = new string('_', length);

                maskedString.Remove(startIndex, length);
                maskedString.Insert(startIndex, replacement);
            }

            Console.WriteLine(maskedString.ToString());
        }
}