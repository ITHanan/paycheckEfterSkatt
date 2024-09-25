namespace paycheckEfterSkatt
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Skapa en Console App som skriver ut Lön efter skatt (vi måste ha en klass
            //och måste skriva in alla värde själva via terminal för att kunna kalkulera)

            Console.WriteLine("Enter your Paycheck with the skatt. ");

            // tagit imot värde från terminalet
            string paycheckInnanskattsomString = Console.ReadLine()!;
            Console.WriteLine(paycheckInnanskattsomString);

            // till siffra
            int paycheckInnanskatt = Convert.ToInt32(paycheckInnanskattsomString); 


            Console.WriteLine("Enter skatt in  % ");
            string skattsomString = Console.ReadLine()!;
            Console.WriteLine(skattsomString);
            int skatt = Convert.ToInt32(skattsomString);




            CalculatPaycheckSkatt mycalculatPaycheckSkatt01 = new CalculatPaycheckSkatt();
            mycalculatPaycheckSkatt01.CalculatPaycheckEfterSkatt(paycheckInnanskatt, skatt); 



        }
    }
}
