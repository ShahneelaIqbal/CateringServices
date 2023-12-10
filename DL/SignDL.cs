using BA.BL;
using BA.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.DL
{
    public class SignDL
    {
        public static List<SignIn> signList = new List<SignIn>();

        public static void addIntoList(SignIn s, string role)
        {
            s.setRole(role);
            signList.Add(s);
        }

        public static void clearList()
        {
            signList = new List<SignIn>();
        }

        public static int addServiceProviderIntoList(SignIn s)
        {
            if(signList.Count == 0)
            {
                return 0;
            }
            else
            {
                if(s.getUserName() == "")
                {
                    return 2;
                }
                else
                {
                    SignIn signup = isExists(s, "admin");
                    if(signup == null)
                    {
                        signList.Add(s);
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        public static SignIn isExists(SignIn s, string role)
        {
            foreach (SignIn storeUser in signList)
            {
                if (s.getUserName() == storeUser.getUserName() && s.getPassword() == storeUser.getPassword() && s.getRole() == role)
                {
                    return storeUser;
                }
            }
            return null;
        }

        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        public static bool readData(string path, string roles)
        {
            clearList();
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if(parseData(record, 3) == roles)
                    {
                        string name = parseData(record, 1);
                        string password = parseData(record, 2);
                        string role = parseData(record, 3);
                        SignIn user = new SignIn(name, password, role);
                        addIntoList(user, role);
                    }
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        public static int storeDataInFile(SignIn user, string path)
        {
            bool isExist = false;
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
                {
                    // Split the line into individual columns
                    string[] columns = lines[rowIndex].Split(',');

                    if (columns[0] == user.getUserName() && columns[2] == "admin")
                    {
                        isExist = true;
                        return 1;
                    }
                }
                if(!isExist)
                {
                    StreamWriter file = new StreamWriter(path, true);
                    file.WriteLine(user.getUserName() + "," + user.getPassword() + "," + user.getRole());
                    file.Flush();
                    file.Close();
                    return 2;
                }
            }
            return -1;      
        }
        // update password
        public static bool updatePassword(string loginUser, string newPassword, string pathSign)
        {
            if (File.Exists(pathSign))
            {
                string[] lines = File.ReadAllLines(pathSign);
                for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
                {
                    // Split the line into individual columns
                    string[] columns = lines[rowIndex].Split(',');

                    if (columns[0] == loginUser && columns[2] == "admin")
                    {
                        columns[1] = newPassword;
                        // Combine the updated columns back into a line
                        string updatedLine = string.Join(",", columns);

                        // Update the line in the lines array
                        lines[rowIndex] = updatedLine;
                        // Write the updated lines back to the CSV file
                        File.WriteAllLines(pathSign, lines);
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
