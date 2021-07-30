using System;

namespace MoreDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            var myString = "C# list fundamentals ";
            Console.WriteLine(StringExercise(myString));

        }

        public static string StringExercise(string myString) 
        {
            // return all charachters in uppercase
            // trim off leading or trailing soaces frin myString
            // replace letter 'L' and 'T' with '*'
            // find index of letter N and delete chars after it 
            // return the result


            var firstIter = myString.ToUpper().Trim().Replace('T', '*').Replace('L', '*');

            int indexOfString = firstIter.IndexOf('N');

            var finalString = firstIter.Remove(indexOfString + 1);

            Console.WriteLine(finalString);


            //Console.WriteLine(myString);

            //Console.WriteLine(myString.ToUpper());

            //Console.WriteLine(myString.Trim());

            //Console.WriteLine(myString.Replace('T', '*'));
            //Console.WriteLine(myString.Replace('L', '*'));

            //Console.WriteLine(myString.IndexOf('N');

            return myString;
        }
    }   

}
