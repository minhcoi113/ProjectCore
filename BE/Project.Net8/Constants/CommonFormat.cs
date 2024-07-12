namespace Project.Net8.Constants;

public class CommonFormat
{
    public static string GenerateNewRandomDigit()
    {
        Random generator = new Random();
        String data = generator.Next(0, 1000000).ToString("D6");
        if (data.Distinct().Count() == 1)
        {
            data = GenerateNewRandomDigit();
        }
        return data;
    }
}