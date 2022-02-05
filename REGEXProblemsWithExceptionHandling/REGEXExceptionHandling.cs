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
        public string Mobile;
        public static string MobileNum = @"^([\+][0-9]{2}\s*[0-9]{10})$";
        // this pattern used for validate the Mobile Number
        public REGEXExceptionHandling(string mobileNumber) // constructer
        {
            this.Mobile = mobileNumber;
        }
        public string ValidatingUserRegistration()
        {
            try
            {
                if (Regex.IsMatch(Mobile, MobileNum))
                {
                    return "Valid";
                }
                else
                {
                    return "NotValid";
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
