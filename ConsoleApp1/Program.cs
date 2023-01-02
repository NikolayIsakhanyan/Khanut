internal class Program
{
    private static void Main(string[] args)
    {
        double sum ;
      //  Console.Write( "nermutsel tiv= ");
        double y = Convert.ToDouble(Console.ReadLine());
        string gorts;
        gorts = Console.ReadLine();
       // Console.Write( "nermutsel tiv= ");
        double x = Convert.ToDouble(Console.ReadLine());
        switch (gorts)
        {
            case "+":
                sum = x + y;
                Console.WriteLine(sum);
                break;
            case "-":
                sum = x - y;
                Console.WriteLine(sum);
                break;
            case "*":
                sum = x * y;
                Console.WriteLine(sum);
                break;
            case "/":
                try
                {
                sum = x / y;
                    Console.WriteLine(sum);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Message);
                    
                }
                finally
                {Console.WriteLine("nermucel 0 ic baci urish tiv");   
                }
            
                break;
            default:
                Console.WriteLine("katarel 4 gortsoghutyun");
                break;
        }



    }


}