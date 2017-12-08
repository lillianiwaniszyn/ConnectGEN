using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Global_Data

    {
        public static Boolean LoginScreenButtonVisibility;
        public string[] existing_Usernames = new string[100]; //{ "liwanisz", "Lillian", "cora", "Cora", "Cora1" };
        public string[] passwords = new string[100]; //{ "1234", "3245", "0000", "1111", "3333" };
        //public string currentUser = "Cora1"; //hard coded... change later
        public static string currentUserStatic;
        public string[] profilePicPath = new string[100]; //paths to everyone's profile pictures
        public string[,] contacts = new string[100, 100]; //2d arrays in c# are different than Java, FYI
        public string currentProfilePic;
        public string[] lastnames = new string[100];
        public string[] firstnames = new string[100];
        public string[] checks = new string[100];
        public string[] homescreenContacts = new string[100];
        public string[] homescreenNames = new string[100];
        public bool[] homescreenNotifs = new bool[100];
        // Set to English as default.
        public static string languageChosen = "English";
        // Boolean for messages.
        public static Boolean sentCora;
        public static Boolean sentKarla1;
        public static Boolean sentLiwanisz;
        public static Boolean sentMalikBrown;
        public static Boolean sentSimon22;
        public static Boolean sentJazmine;
        public static Boolean addSimone; 

        public Global_Data()
        {
            homescreenContacts[0] = "images/blankpp.png";
            homescreenContacts[1] = "images/headshot.jpg";
            homescreenContacts[2] = "images/jazmineBrown.png";
            homescreenContacts[3] = "images/malikBrown.jpg";
            homescreenContacts[4] = "images/kid1.png";
            homescreenContacts[5] = "images/headshot.jpg";
            homescreenContacts[6] = "images/joaquinSimmons.jpg";
            homescreenContacts[7] = "images/blankpp.png";
            homescreenNames[0] = " ";
            homescreenNames[1] = "Lillian Iwaniszyn";
            homescreenNames[2] = "Jasmine Brown";
            homescreenNames[3] = "Malik Brown";
            homescreenNames[4] = "Alex Simmons";
            homescreenNames[5] = "Jack Brown";
            homescreenNames[6] = "Joaquin Simmons";
            homescreenNames[7] = " ";

            homescreenNotifs[0] = false;
            homescreenNotifs[1] = false;
            homescreenNotifs[2] = true; 
            homescreenNotifs[3] = false;
            homescreenNotifs[4] = false;
            homescreenNotifs[5] = false;
            homescreenNotifs[6] = false;
            homescreenNotifs[7] = false;


            existing_Usernames[0] = "liwanisz";
            existing_Usernames[1] = "Karla1";
            existing_Usernames[2] = "cora";
            existing_Usernames[3] = "Simon22";
            existing_Usernames[4] = "MalikBrown";
            existing_Usernames[5] = "Simonee";
            existing_Usernames[6] = "SimoneSS";
            existing_Usernames[7] = "FakeSimone";
            existing_Usernames[8] = "SelectedSimone";
            passwords[0] = "1234";
            passwords[1] = "3245";
            passwords[2] = "0000";
            passwords[3] = "1111";
            passwords[4] = "3333";
            passwords[5] = "1233";
            passwords[6] = "1111";
            firstnames[0] = "Lillian";
            firstnames[1] = "Karla";
            firstnames[2] = "Cora";
            firstnames[3] = "Simon";
            firstnames[4] = "Malik";
            firstnames[5] = "Simone";
            firstnames[6] = "Simone";
            firstnames[7] = "Simonella";
            firstnames[8] = "Simone";
            lastnames[0] = "Iwaniszyn";
            lastnames[1] = "Juego";
            lastnames[2] = "Brown";
            lastnames[3] = "Cowell";
            lastnames[4] = "Brown";
            lastnames[5] = "Brown";
            lastnames[6] = "Simmons";
            lastnames[7] = "Al";
            lastnames[8] = "Simmons";
            contacts[0, 0] = "Karla1"; //this shows us that Karla is in Lillian's contacts
            contacts[0, 1] = "Simon22"; // simon is also Lillian's friend
            contacts[1, 0] = "liwanisz"; // lillian is Karla's friend
            contacts[3, 0] = "liwnaisz"; //lillian is simons friend
            contacts[4, 0] = "cora"; //Cora is Malik's Friend 
            profilePicPath[0] = "images/headshot.jpg";
            profilePicPath[1] = "images/KarlaJuego.jpg";
            profilePicPath[2] = "images/coraBrown.jpg";
            profilePicPath[3] = "images/simon.jpg";
            profilePicPath[4] = "images/malikBrown.jpg";
            profilePicPath[5] = "images/simone.jpg";
            profilePicPath[6] = "images/cimoneSimmons.jpeg";
            profilePicPath[7] = "images/headshot.jpg";
            profilePicPath[8] = "images/cimoneSimmons.jpeg";

            checks[0] = "images/plus.png";
            checks[1] = "images/plus.png";
            checks[2] = "images/plus.png";
            checks[3] = "images/plus.png";
            checks[4] = "images/plus.png";
            checks[5] = "images/plus.png";
            checks[6] = "images/plus.png";
            checks[7] = "images/plus.png";
            checks[8] = "images/checkmark.png";
        }

        public static void InitializeLanguage(string chosen)
        {
            languageChosen = chosen;
        }

    }

}