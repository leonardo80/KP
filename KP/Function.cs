using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Function
    {
        public static string separator(string price)
        {
            double result = Convert.ToDouble(price);
            CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");
            return result.ToString("N0", culture);
        }

        public static string getMonth(string x)
        {
            string month="";
            if (x == "01") month = "Januari";
            if (x == "02") month = "Februari";
            if (x == "03") month = "Maret";
            if (x == "04") month = "April";
            if (x == "05") month = "Mei";
            if (x == "06") month = "Juni";
            if (x == "07") month = "July";
            if (x == "08") month = "Agustus";
            if (x == "09") month = "September";
            if (x == "10") month = "Oktober";
            if (x == "11") month = "November";
            if (x == "12") month = "Desember";
            return month;
        }
    }
}
