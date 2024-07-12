using System.Globalization;
using System.Text.RegularExpressions;

namespace Project.Net8.Constants
{
    public static class FormatMoney
    {
        public static string ConvertToMoney(dynamic money)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (money == 0 || !regex.IsMatch(money.ToString()))
            {
                return "0";
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN"); 
            return money.ToString("#,###", cul.NumberFormat);
        }
    }
}