using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEXProblemsWithExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName =null;
            Console.WriteLine("Welcome to the REGEX problems with Exception");
            REGEXExceptionHandling regex = new REGEXExceptionHandling(firstName);
            regex.ValidatingFirstName();
        }
    }
}
