using System;

namespace Capstone_Pig_Latin_Try_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = GetUserInputLower("Enter your pig latin phrase!");
            string[] sentence = ConvertToStringArray(userInput);


            foreach (var word in sentence)
            {
                string newWord = RemoveApostrophe(word);
                bool startswithVowel = StartsWithVowel(newWord);

                if (startswithVowel)
                {
                    Console.Write($"{newWord}way ");
                }
                else
                {
                    int vowelIndex = FindFirstVowelIndex(newWord);
                    string firstHalfWord = newWord.Substring(0, vowelIndex);
                    string secondHalfWord = newWord.Remove(0, vowelIndex);
                    string finalWord = $"{secondHalfWord}{firstHalfWord}ay ";
                    Console.Write(finalWord);
                }

            }
        }

        static string GetUserInputLower(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            input.ToLower();
            return input;
        }

        static int FindFirstVowelIndex(string word)
        {

            for (int i = 0; i < word.Length; i++)
            {
                bool isVowel = CheckVowel(word[i]);
                if (isVowel == true)
                {
                    return i;

                }
            }
            return 0;
        }


        static string[] ConvertToStringArray(string userInput)
        {
            return userInput.Split(' ');
        }

        static bool CheckVowel(char input)
        {
            string vowels = "aeiou";
            foreach (var v in vowels)
            {
                if (v == input)
                {
                    return true;
                }
            }
            return false;
        }
        static bool StartsWithVowel(string word)
        {
            bool isVowel = CheckVowel(word[0]);
            if (isVowel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string RemoveApostrophe(string word)
        {
            if (word.Contains('\''))
            {
                return word.Replace("\'", string.Empty);
            }
            else
            {
                return word;
            }

        }



    }

}

