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
    public class ServiceItemDL
    {
        public static List<ServiceItems> serviceItemsList = new List<ServiceItems>();
        public static List<ServiceItems> cartItemsList = new List<ServiceItems>();

        public static void addIntoList(ServiceItems s)
        {
            serviceItemsList.Add(s);
        }

        public static ServiceItems isExists(ServiceItems s)
        {
            foreach (ServiceItems storeUser in serviceItemsList)
            {
                if (s.getType() == storeUser.getType() && s.getName() == storeUser.getName() && s.getPrice() == storeUser.getPrice())
                {
                    return storeUser;
                }
            }
            return null;
        }

        public static List<ServiceItems> readData(string path, string categoryName)
        {
            if (File.Exists(path))
            {
                serviceItemsList = new List<ServiceItems>();
                StreamReader fileVariable = new StreamReader(path);
                string record;
                int id = 0;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    var values = record.Split(',');
                    if (categoryName == values[0])
                    {
                        string type = values[0];
                        string name = values[1];
                        string item = values[2];
                        string price = values[3];
                        ServiceItems service = new ServiceItems(id+1, type, name, item, price);
                        addIntoList(service);
                        id++;
                    }
                }
                fileVariable.Close();
                return serviceItemsList;
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
    
        // add food item
        public static bool addFoodItemList(List<ServiceItems> foodItemList)
        {
            if(foodItemList.Count > 0)
            {
                for (int i = 0; i < foodItemList.Count; i++)
                {
                    ServiceItems s = new ServiceItems(i+1, foodItemList[i].getType(), foodItemList[i].getName(), "", foodItemList[i].getPrice());
                    serviceItemsList.Add(s);
                    return true;
                }
            }
            return false;
        }

        public static bool addoneFoodItemList(ServiceItems foodItemList)
        {
            if (foodItemList.getName() != "")
            {
                ServiceItems s = new ServiceItems(1, foodItemList.getType(), foodItemList.getName(), "", foodItemList.getPrice());
                serviceItemsList.Add(s);
                return true;
            }

            return false;
        }

        // update food item
        public static bool updateFoodItem(ServiceItems foodItem)
        {
            if(foodItem != null)
            {
                ServiceItems templist = serviceItemsList.FindAll(x => x.getName() == foodItem.getName()).FirstOrDefault();
                templist.setPrice(foodItem.getPrice());
                return true;
            }
            return false;
        }

        // delete food item
        public static bool deleteFoodItem(ServiceItems foodItem)
        {
            if (foodItem != null)
            {
                serviceItemsList.Remove(foodItem);
                return true;
            }
            return false;
        }

        // food item add in file
        public static void writeDataInFile(List<ServiceItems> foodItemList, string pathFoodServicesItems)
        {
            if (File.Exists(pathFoodServicesItems))
            {
                for (int i = 0; i < foodItemList.Count; i++)
                {
                    string line = foodItemList[i].getType() + "," + foodItemList[i].getName() + "," + "" + "," + foodItemList[i].getPrice() + Environment.NewLine;
                    File.AppendAllText(pathFoodServicesItems, line);
                }
            }
        }

        public static void writeOneItemDataInFile(ServiceItems foodItem, string pathFoodServicesItems)
        {
            if (File.Exists(pathFoodServicesItems))
            {
                if(foodItem.getName() != "")
                {
                    string line = foodItem.getType() + "," + foodItem.getName() + "," + "" + "," + foodItem.getPrice() + Environment.NewLine;
                    File.AppendAllText(pathFoodServicesItems, line);
                }
            }
        }

        // update food item price in file
        public static bool updateDataInFile(ServiceItems foodItem, string pathFoodServicesItems)
        {
            if (File.Exists(pathFoodServicesItems))
            {
                if (foodItem != null)
                {
                    string[] lines = File.ReadAllLines(pathFoodServicesItems);
                    for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
                    {
                        // Split the line into individual columns
                        string[] columns = lines[rowIndex].Split(',');

                        if (columns[1] == foodItem.getName())
                        {
                            columns[3] = foodItem.getPrice();
                            // Combine the updated columns back into a line
                            string updatedLine = string.Join(",", columns);

                            // Update the line in the lines array
                            lines[rowIndex] = updatedLine;
                            // Write the updated lines back to the CSV file
                            File.WriteAllLines(pathFoodServicesItems, lines);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // delete food item in file
        public static bool deleteDataInFile(ServiceItems foodItem, string pathFoodServicesItems)
        {
            if (File.Exists(pathFoodServicesItems))
            {
                if (foodItem != null)
                {
                    string[] lines = File.ReadAllLines(pathFoodServicesItems);
                    for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
                    {
                        // Split the line into individual columns
                        string[] columns = lines[rowIndex].Split(',');

                        if (columns[1] == foodItem.getName())
                        {
                            // Remove the specified row from the lines array
                            List<string> updatedLines = lines.ToList();
                            updatedLines.RemoveAt(rowIndex);

                            // Write the updated lines back to the CSV file
                            File.WriteAllLines(pathFoodServicesItems, updatedLines.ToArray());

                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // add item to cart and fav item
        public static bool addItemtoCartandFav(int id, string type, string loginUser, string pathFavItems)
        {
            if(id == 1)
            {
                ServiceItems serviceItems = new ServiceItems();
                serviceItems = serviceItemsList.FindAll(x => x.getName() == "Basic package" && x.getPrice() != "" && x.getType() == type).FirstOrDefault();

                cartItemsList.Add(serviceItems);
                return true;
            }
            else if (id == 2)
            {
                ServiceItems serviceItems = new ServiceItems();
                serviceItems = serviceItemsList.FindAll(x => x.getName() == "Premium package" && x.getPrice() != "" && x.getType() == type).FirstOrDefault();

                cartItemsList.Add(serviceItems);
                //string line = loginUser + "," + serviceItems.getType() + "," + serviceItems.getName() + "," + serviceItems.getPrice() + Environment.NewLine;
                //File.AppendAllText(pathCartItems, line);
                return true;
            }
            else if (id == 11)
            {
                ServiceItems serviceItems = new ServiceItems();
                serviceItems = serviceItemsList.FindAll(x => x.getName() == "Basic package" && x.getPrice() != "" && x.getType() == type).FirstOrDefault();
                string line = loginUser + "," + serviceItems.getType() + "," + serviceItems.getName() + "," + serviceItems.getItem() + "," + serviceItems.getPrice() + Environment.NewLine;
                File.AppendAllText(pathFavItems, line);
                return true;
            }
            else if (id == 12)
            {
                ServiceItems serviceItems = new ServiceItems();
                serviceItems = serviceItemsList.FindAll(x => x.getName() == "Premium package" && x.getPrice() != "" && x.getType() == type).FirstOrDefault();
                string line = loginUser + "," + serviceItems.getType() + "," + serviceItems.getName() + "," + serviceItems.getItem() + "," + serviceItems.getPrice() + Environment.NewLine;
                File.AppendAllText(pathFavItems, line);
                return true;
            }
            return false;
        }

        // read fav item from file (for login user only)
        public static List<ServiceItems> readFavItemData(string path, string loginUser)
        {
            if (File.Exists(path))
            {
                serviceItemsList = new List<ServiceItems>();
                StreamReader fileVariable = new StreamReader(path);
                string record;
                int id = 0;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    var values = record.Split(',');
                    if (loginUser == values[0])
                    {
                        string type = values[1];
                        string name = values[2];
                        string item = values[3];
                        string price = values[4];
                        ServiceItems service = new ServiceItems(id + 1, type, name, item, price);
                        addIntoList(service);
                        id++;
                    }
                }
                fileVariable.Close();
                return serviceItemsList;
            }
            return null;
        }
    
        // add food item to cart
        public static bool addFoodItemtoCart(List<ServiceItems> foodItemList, string loginUser)
        {
            if (foodItemList.Count > 0)
            {
                for (int i = 0; i < foodItemList.Count; i++)
                {
                    ServiceItems s = new ServiceItems(i + 1, foodItemList[i].getType(), foodItemList[i].getName(), "", foodItemList[i].getPrice());
                    cartItemsList.Add(s);
                }
                return true;
            }
            return false;
        }
    
        // get cart items
        public static List<ServiceItems> getCartList()
        {
            if (cartItemsList.Count > 0)
            {
                return cartItemsList;
            }
            return null;
        }

        // confirm order
        public static bool ConfirmOrder(string loginUser, Order order, string pathOrder)
        {
            if (cartItemsList.Count > 0)
            {
                string line = loginUser + "," + "Total no of person" + "," + order.getTotalNoOfPerson() + "," + "Total Price" + "," + order.getTotalAmount() + 
                    ","+ "Order date" + "," + order.getOrderDate() +Environment.NewLine;
                File.AppendAllText(pathOrder, line);
                for (int i = 0; i < cartItemsList.Count; i++)
                {
                    string line1 = loginUser + "," + cartItemsList[i].getType() + "," + cartItemsList[i].getName() + "," + cartItemsList[i].getItem() + "," + cartItemsList[i].getPrice() + Environment.NewLine;                 
                    File.AppendAllText(pathOrder, line1);
                }
                return true;
            }
            return false;
        }

        // view order for admin
        public static List<Order> GetViewOrder(string pathOrder)
        {
            if (File.Exists(pathOrder))
            {
                string id = "";
                List<Order> orderList = new List<Order>();
               
                string[] lines = File.ReadAllLines(pathOrder);
                for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
                {
                    string[] columns = lines[rowIndex].Split(',');
                    List<ServiceItems> itemList = new List<ServiceItems>();
                    if (id != columns[0])
                    {
                        string name = columns[0];
                        int totalnoofperson = int.Parse(columns[2]);
                        int totalamount = int.Parse(columns[4]);
                        string orderDate = columns[6];
                        Order order = new Order(totalnoofperson, totalamount, rowIndex, orderDate, name);
                        id = columns[0];
                        string[] childLine = lines.Where(x => x.StartsWith(id.ToString())).ToArray();
                        for (int rowIndex2 = 1; rowIndex2 < childLine.Length; rowIndex2++)
                        {
                            string[] columns2 = childLine[rowIndex2].Split(',');
                            ServiceItems serviceItems = new ServiceItems(rowIndex2, columns2[1], columns2[2], "", columns2[4]);
                            itemList.Add(serviceItems);
                        }
                        order.setOrderItems(itemList);
                        orderList.Add(order);
                    }
                }
                  
                return orderList;
            }
            return null;
        }

        // update service
        public static bool UpdateServiceItem(string pathServicesItems, ServiceItems item)
        {
            if (File.Exists(pathServicesItems))
            {
                if (item != null)
                {
                    string[] lines = File.ReadAllLines(pathServicesItems);
                    for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
                    {
                        // Split the line into individual columns
                        string[] columns = lines[rowIndex].Split(',');

                        if (columns[0] == item.getType() && columns[1] == item.getName())
                        {
                            if(columns[3] != "")
                            {
                                columns[3] = item.getPrice();
                                // Combine the updated columns back into a line
                                string updatedLine = string.Join(",", columns);

                                // Update the line in the lines array
                                lines[rowIndex] = updatedLine;
                                // Write the updated lines back to the CSV file
                                File.WriteAllLines(pathServicesItems, lines);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }


        public static bool addItemtoCart(ServiceItems item, string type)
        {
            ServiceItems serviceItems = new ServiceItems();
            serviceItems = serviceItemsList.FindAll(x => x.getName() == item.getName() && x.getPrice() != "" && x.getType() == type).FirstOrDefault();

            cartItemsList.Add(serviceItems);
            return true;
        }
        public static bool addItemtoFav(ServiceItems item, string type, string loginUser, string pathFavItems)
        {
            string line = loginUser + "," + item.getType() + "," + item.getName() + "," + item.getItem() + "," + item.getPrice() + Environment.NewLine;
            File.AppendAllText(pathFavItems, line);
            return true;
        }

    }
}
