using System;

namespace paycheckEfterSkatt
{
    public class Program
    {
        static void Main(string[] args)
        {
            // skriver ut Lön efter skatt 

            //This line prints a message to the console asking the user to input their gross paycheck (before tax).

            Console.WriteLine("Enter your Paycheck with the skatt. ");


            //Console.ReadLine() reads the user input as a string and stores it in paycheckInnanskattsomString.
            //Console.WriteLine(paycheckInnanskattsomString) prints the entered paycheck value back to the user.

           
           // This line converts the user input(which is a string) to an integer using Convert.ToInt32().
           // If the user enters something non-numeric, this could throw an exception.
            string paycheckInnanskattsomString = Console.ReadLine()!;
            Console.WriteLine(paycheckInnanskattsomString);

            // till siffra
            int paycheckInnanskatt = Convert.ToInt32(paycheckInnanskattsomString); 


            Console.WriteLine("Enter skatt in  % ");
            string skattsomString = Console.ReadLine()!;
            Console.WriteLine(skattsomString);
            int skatt = Convert.ToInt32(skattsomString);


            //create a new instance of the CalculatPaycheckSkatt class. This object (mycalculatPaycheckSkatt01)
            //is used to call the method CalculatPaycheckEfterSkatt.

            CalculatPaycheckSkatt mycalculatPaycheckSkatt01 = new CalculatPaycheckSkatt();
            mycalculatPaycheckSkatt01.CalculatPaycheckEfterSkatt(paycheckInnanskatt, skatt); 



        }
    }
}
