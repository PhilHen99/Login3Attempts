using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*namespace Login
 {
    internal class Verify
    {
        static void Main(string[] args)
        {
            string username = "USER";
            string password = "PASS";
            string filepath = "logins.txt";

            Console.WriteLine(VerifyLogin(username, password,filepath));
            Console.ReadLine();
        }

        public static bool VerifyLogin(string username, string password, string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(@filepath);

            for(int i=0; i<lines.Length; i++)
            {
                string[] field = lines[i].Split(',');
                if (field[0].Equals(username) && field[1].Equals(password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
*/