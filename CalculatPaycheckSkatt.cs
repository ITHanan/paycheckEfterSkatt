
namespace paycheckEfterSkatt
{
    public class CalculatPaycheckSkatt
    {
       public void CalculatPaycheckEfterSkatt(int paycheckInnanskatt,int skatt)
        { 
            double paycheckefterskatt = paycheckInnanskatt * (100 - skatt) / 100;
            Console.WriteLine($"Hear you can see your paycheck efter skatt  {paycheckefterskatt}");
        }
      

    }
}
