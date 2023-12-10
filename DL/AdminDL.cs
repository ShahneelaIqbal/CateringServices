using BA.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BA.DL
{
    public class AdminDL
    {
        public static List<MenuServices> serviceList = new List<MenuServices>();

        public static void addIntoList(MenuServices s)
        {
            serviceList.Add(s);
        }

        public static MenuServices isExists(MenuServices s)
        {
            foreach (MenuServices storeUser in serviceList)
            {
                if (s.menuServiceName == storeUser.menuServiceName && s.menuServiceCode == storeUser.menuServiceCode)
                {
                    return storeUser;
                }
            }
            return null;
        }

        public static List<MenuServices> readData(string path)
        {
            if (File.Exists(path))
            {
                serviceList = new List<MenuServices>();

                StreamReader fileVariable = new StreamReader(path);
                string record;
               
                while ((record = fileVariable.ReadLine()) != null)
                {
                    var values = record.Split(',');

                    string menuServiceName = values[0];
                    string menuServiceCode = values[1];
                    MenuServices service = new MenuServices(menuServiceName, menuServiceCode);
                    addIntoList(service);
                }
                fileVariable.Close();
                return serviceList;
            }
            return null;
        }

      
    }
}
