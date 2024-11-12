using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace LoginTo
{
    internal class TextFile
    {
        public string? username { get; set; }
        public string? password { get; set; }
        public string? name { get; set; }
        public string? birthPlace { get; set; }
        public string? phoneNumber { get; set; }
        public bool isVerified { get; set; }
        public string[] DataForUser { get; set; }

        public string[] GetData(string NameForSearch)
        {
                string path = $"Users/UserDB.txt";

                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            string[] Array = new string[4];
                            Array = line.Split(';');

                            if (Array[0] == NameForSearch)
                            {
                                DataForUser = Array;
                                return Array;
                            }

                            line = reader.ReadLine();
                        }
                    }
                return null;
            
        }

        public string SaveTxtFiles() // REGISTER CHECK DATA!!!!!!!
        {
            bool isPasswordOkay = false;
            string? path = $"Users/UserDB.txt";
            try 
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.Write($"{username};");

                    if (password != null && password.Length == 5)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            char c = password[i];
                            bool isAlphaBet = Regex.IsMatch(c.ToString(), "[a-z]", RegexOptions.IgnoreCase);
                            if (!isAlphaBet)
                            {
                                MessageBox.Show("Password must be 5 char lentgh and Aa-Zz symbols");
                            }
                            else { isPasswordOkay = true; }
                        }
                        if (isPasswordOkay)
                        {
                            writer.Write($"{password};");
                        }
                    }
                    else { MessageBox.Show("Password must be 5 char lentgh and Aa-Zz symbols"); }

                    writer.Write($"{name};");
                    writer.Write($"{birthPlace};");
                    writer.Write($"{phoneNumber}\n");

                    
                }
                if (isPasswordOkay) { return $"Registred successfully! {username}"; }
                else { return "Password should not be zero "; }
            }
            catch (Exception)
            {
                return "Directory error";
            }
        }

        public string LoginTxtFiles() // LOG IN
        {
            string? path = $"Users/UserDB.txt";

            bool isUserCorrect = false;
            bool isPasswordCorrect = false;

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line = reader.ReadLine();

                    if (username == "") { return "username can't be null"; }
                    else if (password == "") { return "password can't be null"; }

                    while (line != null)
                    {
                        string[] Array = new string[4];
                        Array = line.Split(';');

                        if (Array[0] == username) { isUserCorrect = true; }
                        if (Array[1] == password) 
                        {
                            isPasswordCorrect = true;
                        }
                        line = reader.ReadLine();
                    }
                    if (isUserCorrect && isPasswordCorrect)
                    {
                        isVerified = true;
                        return $"Acces Granted for you, {username}";
                    }
                    else if (!isUserCorrect)
                    {
                        return "Can't find username with this name";
                    }
                    else if (!isPasswordCorrect)
                    {
                        return "Something goes wrong, check your Nickname and Password\nForget password?";
                    }                   
                }

            }

            catch (Exception)
            {
                return "Directory error";
            }
            return "Something goes wrong";
        }

        public void ChangePassword()
        {

            string[] Array = DataForUser;

            string OriginalString = "";

            for (int i = 0; i < Array.Length; i++)
            {
                if (i != Array.Length - 1) { OriginalString += Array[i] + ";"; }
                else { OriginalString += Array[i]; }
            }
            OriginalString += "\n";
            Array[1] = Array[1] + "Abc";
            string strToReplace = "";

            for(int i = 0; i < Array.Length; i++) 
                {
                    if(i != Array.Length - 1) { strToReplace += Array[i] + ";"; }
                    else {  strToReplace += Array[i]; }
                }
            strToReplace += "\n";
            string path = $"Users/UserDB.txt";

            string text = File.ReadAllText(path);

            text = text.Replace(OriginalString, strToReplace);

            File.WriteAllText(path, text);

        }

    }

}
