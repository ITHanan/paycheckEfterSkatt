
namespace paycheckEfterSkatt
{
    public class CalculatPaycheckSkatt
    {
       public void CalculatPaycheckEfterSkatt(int paycheckInnanskatt,int skatt)
        { // here I can calculat tax 
            double paycheckefterskatt = paycheckInnanskatt * (100 - skatt) / 100;
            Console.WriteLine($"Hear you can see your paycheck efter skatt  {paycheckefterskatt}");
        }
      

    }
}
