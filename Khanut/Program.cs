internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter Ashxatavardz -");
       int ashVardz=Convert.ToInt32(Console.ReadLine());
        double ekHark = (ashVardz * 21) / 100;
        Console.WriteLine($"Ekamtayin harky kkazmi`{ekHark} amd,");
        double socVchar = (ashVardz * 4.5) / 100;
        Console.WriteLine($"Socialakan vchary`{socVchar} amd,");
        double droshmVchar = (ashVardz * 1.5) / 100;
        Console.WriteLine($"Zincarayoghneri Apahovagrutyan Himnadrami droshmanshani vchary `{droshmVchar} amd ,");
        double maqur = ashVardz - ekHark - socVchar - droshmVchar;
        Console.WriteLine($"Maqur mnacord `{maqur} amd:");

    }
}