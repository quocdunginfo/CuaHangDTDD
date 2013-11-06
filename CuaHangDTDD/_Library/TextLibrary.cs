using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;

namespace CuaHangDTDD._Library
{
    public class TextLibrary
    {
        public static string HTML_Strip(string data)
        {
            return Regex.Replace(data, @"<(.|\n)*?>", string.Empty);
        }
        public static string GetSHA1HashData(string data)
        {
            if (data == null) data = "";
            //chu HOA
            return FormsAuthentication.HashPasswordForStoringInConfigFile(data, "SHA1");
        }
        public static int ToInt(String input)
        {
            int re=0;
            if (Int32.TryParse(input, out re))
            {
                return re;
            }
            return 0;
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
        public static string Unicode_Substring(string text, int length)
        {
            var bytes = Encoding.UTF8.GetBytes(text);
            var result = Encoding.UTF8.GetString(bytes, 0, Math.Min(bytes.Length, length));

            while ('\uFFFD' == result[result.Length - 1])
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }
    }
}