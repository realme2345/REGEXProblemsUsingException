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
        public string Email;
        public static string Pattern = @"^([A-Za-z0-9]*\.[A-Za-z0-9]*)@([A-Za-z0-9]*)((\.(\w){2,3})+)$"; // this pattern used for validate the Email
        public REGEXExceptionHandling(string Email) // this method is used for validating Email
        {
            this.Email = Email;
        }
        public string ValidatingFirstName()
        {
            try
            {
                if (Regex.IsMatch(Email, Pattern))
                {
                    // Console.WriteLine("{0} is valid", Email);
                    return "Valid";
                }
                else
                {
                    //Console.WriteLine("{0} is not valid", Email);
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
