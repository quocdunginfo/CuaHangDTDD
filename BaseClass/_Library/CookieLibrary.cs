using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace BaseClass._Library
{
    public class CookieLibrary
    {
        public static HttpCookie Base64Encode(HttpCookie input)
        {
            HttpCookie tmp = new HttpCookie(input.Name);
            tmp.Expires = input.Expires;
            foreach (String key in input.Values.AllKeys)
            {
                //copy value
                tmp[key] = input[key];
                //process
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(tmp[key]);
                string encoded = System.Convert.ToBase64String(bytes);
                tmp[key] = encoded;
            }
            return tmp;
        }
        public static HttpCookie Base64Decode(HttpCookie input)
        {
            HttpCookie tmp = new HttpCookie(input.Name);
            tmp.Expires = input.Expires;
            foreach (String key in input.Values.AllKeys)
            {
                //copy value
                tmp[key] = input[key];
                //process
                byte[] bytes = System.Convert.FromBase64String(tmp[key]);
                string decoded = System.Text.Encoding.UTF8.GetString(bytes);
                tmp[key] = decoded;
            }
            return tmp;
        }
    }
}