using System;
using System.Collections.Generic;
using System.Text;


namespace Dllplugin
{
    class UserDll
    {
        public static string Attack(string url)
        { //方法名称

            string expResult = string.Empty;

            expResult = "test";

            Console.WriteLine(url + "|testetstetst");


            return expResult;
        }
    }
}
