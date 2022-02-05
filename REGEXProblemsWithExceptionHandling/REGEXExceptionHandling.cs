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
        public string Password;
        public static string Numeric = @"^(?=.*[0-9])[A-Za-z0-9]{8,}$";
        // this pattern used for validate the Password
        public REGEXExceptionHandling(string password) // constructer
        {
            this.Password = password;
        }
        public string ValidatingUserRegistration() // this method used for the validating password with minimum eight characters
                                                   // with atleast one numeric
        {
            try
            {
                if (Regex.IsMatch(Password, UpperCase))
                {
                    return "Valid";
                }
                else
                {
                    return "InValid";
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
            ///The End
        }
    }
}
