using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseClass._Library
{
    public class ValidateLibrary
    {
        public static Boolean is_valid_email(String email)
        {
            if (!email.Contains("@") || email.Count(ch => ch== '@') > 1)
            {
                return false;
            }
            String after = email.Substring(email.IndexOf("@"));
            if (!after.Contains("."))
            {
                return false;
            }
            return true;
        }
    }
}