using System.Threading.Channels;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jonathan";
            int age = 31;
            double avg = 108.7;
            decimal bankAccount = 108.72m;
            char initial = 'S';
            bool isMarried = true;

            //Console.WriteLine($"Name: {myName}\nAge: {age}\nAvg. Account: {avg}\nMoney: {bankAccount}\nInitial: {initial}\nIsMarried: {isMarried}");
            Console.WriteLine($"My name is {myName}, I am {age} years old. I spent {bankAccount} dollars on dinner last night with my wife celebrating our anniversary.");
        }
    }
}