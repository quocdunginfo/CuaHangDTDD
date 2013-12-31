using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;

namespace BaseClass._Library
{
    public class TextLibrary
    {
        public static string HTML_Strip(string text)
        {
            System.Text.RegularExpressions.Regex rx = new System.Text.RegularExpressions.Regex("<[^>]*>");
            // replace all matches with empty string
            text = rx.Replace(text, "");
            return text;
        }
        public static string GetSHA1HashData(string data)
        {
            if (data == null) data = "";
            //chu HOA
            return FormsAuthentication.HashPasswordForStoringInConfigFile(data, "SHA1");
        }
        public static int ToInt(String input)
        {
            try
            {
                input = input.Trim();
                input = input.Replace(",", "");
                int re = 0;
                if (Int32.TryParse(input, out re))
                {
                    return re;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static String ToString(String input)
        {
            return input == null ? "" : input;
        }
        public static Boolean ToBoolean(String input)
        {
            if (input == null) return false;
            return input.Equals("1") ? true : false;
        }
        public static List<String> ToListString(String input, Char separator = ',')
        {
            return input.Split(separator).ToList();
        }
        public static List<int> ToListInt(String input, Char separator = ',')
        {
            string[] tmp= input.Split(separator);
            List<int> re = new List<int>();
            foreach (var item in tmp)
            {
                re.Add(ToInt(item));
            }
            return re;
        }
        public static string Unicode_Substring(string text, int length=200)
        {
            try
            {
                var bytes = Encoding.UTF8.GetBytes(text);
                var result = Encoding.UTF8.GetString(bytes, 0, Math.Min(bytes.Length, length));

                while ('\uFFFD' == result[result.Length - 1])
                {
                    result = result.Substring(0, result.Length - 1);
                }

                return result;
            }
            catch (Exception)
            {
                return text;
            }
        }
        public static DateTime ToDateTime(String input, out Boolean convert_ok, String format="dd/MM/yyyy")
        {
            if (input.Equals(""))
            {
                convert_ok = false;
                return new DateTime();
            }
            try
            {
                DateTime tmp = DateTime.ParseExact(input, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                convert_ok = true;
                return tmp;
            }
            catch (Exception ex)
            {
                convert_ok = false;
                return new DateTime();
            }
        }
        public static string ToCommaStringNumber(int input)
        {
            if (input == 0) return "0";
           else return input.ToString("#,#", CultureInfo.InvariantCulture);
        }

        public static string ToCommaStringNumber(long input)
        {
            if (input == 0) return "0";
            else return input.ToString("#,#", CultureInfo.InvariantCulture);
        }

        public static string DateTime_To_String(DateTime dt)
        {
            string kq = "";
            switch (dt.DayOfWeek.ToString())
            {
                case "Sunday": kq = "Chủ Nhật"; break;
                case "Monday": kq = "Thứ 2"; break;
                case "Tuesday": kq = "Thứ 3"; break;
                case "Wednesday": kq = "Thứ 4"; break;
                case "Thursday": kq = "Thứ 5"; break;
                case "Friday": kq = "Thứ 6"; break;
                case "Saturday": kq = "Thứ 7"; break;
                default: break;
            }

            return kq + " Ngày " + dt.ToString("dd/MM/yyyy");
        }
    }
}