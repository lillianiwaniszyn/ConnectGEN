using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Global_Data

    {
        public static string[] existing_Usernames = new string[100]; //{ "liwanisz", "Lillian", "cora", "Cora", "Cora1" };
        public static string[] passwords = new string[100]; //{ "1234", "3245", "0000", "1111", "3333" };
        public static string currentUser = "Cora1"; //hard coded... change later
        public static string[] profilePicPath = new string[100]; //paths to everyone's profile pictures
        public static string[,] contacts = new string[100, 100]; //2d arrays in c# are different than Java, FYI

    }


}
