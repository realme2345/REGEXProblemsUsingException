using System;
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
        public static string PasswordPattern = @"^[A-Za-z0-9]{8,}$";
        // this pattern used for validate the password
        public REGEXExceptionHandling(string password) // constructer
        {
            this.Password = password;
        }
        public string ValidatingUserRegistration()
        {
            try
            {
                if (Regex.IsMatch(Password, PasswordPattern))// this method used for the validating password with minimum eight characters 
                {
                    return "Valid";
                }
                else
                {
                    return "InValid";
                }
                //The End
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
