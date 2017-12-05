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
        public string[] profilePicPath = new string[100]; //paths to everyone's profile pictures
        public static string[,] contacts = new string[100, 100]; //2d arrays in c# are different than Java, FYI
        public static string currentProfilePic;
        public static string[] lastnames = new string [100];
        public static string[] firstnames = new string[100];
        // Set to English as default.
        public static string languageChosen = "English";

        public static void InitializeLanguage(string chosen)
        {
            languageChosen = chosen;
        }

        public Global_Data()
        {
            existing_Usernames[0] = "liwanisz";
            existing_Usernames[1] = "Karla1";
            existing_Usernames[2] = "cora";
            existing_Usernames[3] = "Simon22";
            existing_Usernames[4] = "MalikBrown";
            passwords[0] = "1234";
            passwords[1] = "3245";
            passwords[2] = "0000";
            passwords[3] = "1111";
            passwords[4] = "3333";
            firstnames[0] = "Lillian";
            firstnames[1] = "Karla";
            firstnames[2] = "Cora";
            firstnames[3] = "Simon";
            firstnames[4] = "Malik";
            lastnames[0] = "Iwaniszyn";
            lastnames[1] = "Juego";
            lastnames[2] = "Brown";
            lastnames[3] = "Cowell";
            lastnames[4] = "Brown";
            contacts[0, 0] = "Karla1"; //this shows us that Karla is in Lillian's contacts
            contacts[0, 1] = "Simon22"; // simon is also Lillian's friend
            contacts[1, 0] = "liwanisz"; // lillian is Karla's friend
            contacts[3, 0] = "liwnaisz"; //lillian is simons friend
            //profilePicPath[0] = "images/cimoneSimmons.jpeg";
            //profilePicPath[1] = "images/jazmineBrown.jpg";
            //profilePicPath[2] = "images/joaquinSimmons.png";
            //profilePicPath[3] = "images/coraBrown.jpg";
            //profilePicPath[4] = "images/malikBrown.jpg";
            
        }
    }


}
