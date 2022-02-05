﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEXProblemsWithExceptionHandling
{
    public class REGEXExceptionHandling
    {
        public string FirstName;
        public static string Pattern = "^[A-Z][A-Z a-z]{3,}$"; // this pattern used for validate the name
        public REGEXExceptionHandling(string firstName) // this method is used for validating first name
        {
            this.FirstName = firstName;
        }
        public string ValidatingFirstName()
        {
            try
            {
                if (Regex.IsMatch(FirstName, Pattern))
                {
                    //Console.WriteLine("{0} is valid", FirstName);
                    return "Valid";
                }
                else
                {
                    //Console.WriteLine("{0} is not valid", FirstName);
                    return "NotValid";
                }
            }
            catch (ArgumentNullException ex)
            {
                return ex.Message + "please Enter a valid name";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }    
            //The End
        }
    }
}
