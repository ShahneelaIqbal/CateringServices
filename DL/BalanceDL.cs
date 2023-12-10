using BA.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.DL
{
    public class BalanceDL
    {
        public static int readData(string path)
        {
            int amount = 0;
            if (File.Exists(path))
            {
                 StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    amount = int.Parse(record);
                }
                fileVariable.Close();
                return amount;
            }
            return amount;
        }
        
        public static bool storeDataInFile(int amount, string balancePath)
        {
            if(File.Exists(balancePath))
            {
                int balanceAmount = readData(balancePath);
                balanceAmount = balanceAmount + amount;

                string totalAmount = balanceAmount.ToString();
                File.WriteAllText(balancePath, totalAmount);
                return true;
            }
            return false;
        }




    }
}
