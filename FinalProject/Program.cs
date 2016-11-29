// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory

{
    public static void Main()
    {
        // use an integer to keep track of the count of items in your inventory					
        int arrayCount = 0;
        // create an array of your ItemData struct
        ItemData[] inventory = new ItemData[10];


        // use a never ending loop that shows the user what options they can select 
        Boolean doNotEnd = true; //*boolean variable to control quit*
        while (doNotEnd == true)
        {
            Console.ReadLine(); //*Keeping the console open*
                                // as long as no one Quits, continue the inventory update

            // in that loop, show what user can select from the list
            string[] list = new string[5]; //*Putting options into a string array*

            list[0] = "1. Add an item";
            list[1] = "2. Change an item";
            list[2] = "3. Delete an item";
            list[3] = "4. List all items in database";
            list[4] = "5. Quit";

            Console.Write("Please choose an option (1-5):\n");

            foreach (string optionList in list) //*Foreach loop to list formatted option list*
            {
                Console.Write("{0}\n", optionList);
            }

            // read the user's input and then create what case it falls

            string strx = Console.ReadLine();	// read user's input	

            var optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {
                        if (arrayCount >= 100) //Prevents user from adding too many items
                        {
                            Console.WriteLine("Inventory database cannot exceed 100 items. Please remove or change an existing item before adding more.");
                            break;
                        }
                        Console.Write("Enter the item number:");
                        string newItemStr = Console.ReadLine();
                        inventory[arrayCount].itemIDNo = int.Parse(newItemStr);

                        Console.Write("Enter item description:");
                        string newItemDescription = Console.ReadLine();
                        inventory[arrayCount].sDescription = newItemDescription;

                        Console.Write("Enter item price: $");
                        string newItemPrice = Console.ReadLine();
                        inventory[arrayCount].dblPricePerItem = double.Parse(newItemPrice);

                        Console.Write("Enter quantity of item:");
                        string newItemQuantityStr = Console.ReadLine();
                        inventory[arrayCount].iQuantityOnHand = int.Parse(newItemQuantityStr);

                        Console.Write("Enter our cost per item: $");
                        string newItemOurCostStr = Console.ReadLine();
                        inventory[arrayCount].dblOurCostPerItem = double.Parse(newItemOurCostStr);

                        
                        inventory[arrayCount].dblValueOfItem = inventory[arrayCount].iQuantityOnHand * inventory[arrayCount].dblPricePerItem;

                        arrayCount++;
                        break;
                    }

                case 2: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No: ");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;



                        for (int x = 0; x < arrayCount; x++)
                        {
                            if (inventory[x].itemIDNo == chgid)
                            {
                                fFound = true;
                                string[] changeList = new string[5]; //thinking I should just copy the "add" function
                                //except with an array replacement feature to implement the "change" instead of just adding

                                changeList[0] = "1. Order Number";
                                changeList[1] = "2. Item Description";
                                changeList[2] = "3. Price per item";
                                changeList[3] = "4. Quantity on hand";
                                changeList[4] = "5. Cost per item";

                                Console.Write("What would you like to change? (1-5)\n");

                                foreach (string choice in changeList) //*Foreach loop to list formatted option list*
                                {
                                    Console.Write("{0}\n", choice);
                                }

                                string rox = Console.ReadLine();   // read user's input	

                                var roxi = int.Parse(rox); // convert the given string to integer to match our case types shown below

                                Console.WriteLine(); // provide an extra blank line on screen

                                switch (roxi) //VARIABLES may not work (might be gloabl??)
                                {
                                    case 1: //change item number
                                        {
                                            Console.Write("Enter the item number:");
                                            string newItemStr = Console.ReadLine();
                                            inventory[x].itemIDNo = int.Parse(newItemStr);

                                            break;
                                        }
                                    case 2: //change description
                                        {
                                            Console.Write("Enter item description:");
                                            string newItemDescription = Console.ReadLine();
                                            inventory[x].sDescription = newItemDescription;

                                            break;
                                        }
                                    case 3: //change price
                                        {
                                            Console.Write("Enter item price: $");
                                            string newItemPrice = Console.ReadLine();
                                            inventory[x].dblPricePerItem = double.Parse(newItemPrice);

                                            break;
                                        }
                                    case 4: //change Quantity
                                        {
                                            Console.Write("Enter quantity of item:");
                                            string newItemQuantityStr = Console.ReadLine();
                                            inventory[x].iQuantityOnHand = int.Parse(newItemQuantityStr);

                                            break;
                                        }
                                    case 5: //change cost
                                        {
                                            Console.Write("Enter our cost per item: $");
                                            string newItemOurCostStr = Console.ReadLine();
                                            inventory[x].dblOurCostPerItem = double.Parse(newItemOurCostStr);

                                            break;
                                        }
                                    default:
                                        {
                                            Console.Write("Please select a valid option.");
                                            break;
                                        }

                                       
                                        

                                }
                                /*arrayCount--;
                                for (; x < arrayCount; x++)
                                {
                                    inventory[x] = inventory[x + 1];
                                }*/

                                // code to show what has to happen if the item in the list is found
                                // reset the count to show a new count for your list 
                                // (Note: your list is now increased by one item)
                            }
                        }

                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }

                        break;
                    }

                case 3: //delete items in the list if this option is selected
                    {
                        if (arrayCount == 0)
                        {
                            Console.WriteLine("No items stored.");
                            break;
                        }
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        for (int x = 0; x < arrayCount; x++) //searches for position of item in array
                        {
                            if (inventory[x].itemIDNo == newid) //when item's spot in array found, run this code
                           { 
                                fDeleted = true;
                                // delete the item if you found it
                                // reset the count to show a new count for your list 
                                arrayCount--; //(Note: your list is now reduced by one item)	
                                for (; x < arrayCount; x++) //This replaces the old array with the new array, starting by moving the old item
                                {                           //to the left one (essentially deleting it) 
                                    inventory[x] = inventory[x + 1];
                                }
                                break;
                            }
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item deleted");
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", newid);
                        }

                        break;
                    }

                case 4: //list all items in current database if this option is selected
                    {
                        //Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        //Console.WriteLine("-----  7------  15--------------------  37-----  44---  49----  55-----");
                        string columns = String.Format("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10}",
                            "Item#", "ItemID", "Descr.", "Price", "QOH", "Cost", "Value");
                        string lines = String.Format("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10}",
                            "-----", "------", "-------", "-----", "---", "----", "-----");
                        Console.WriteLine(columns);
                        Console.WriteLine(lines);
                        for (int y = 0; y < arrayCount; y++)
                        {
                            string listing = String.Format("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10}\n",
                            y +1, inventory[y].itemIDNo, inventory[y].sDescription, inventory[y].dblPricePerItem, inventory[y].iQuantityOnHand,
                            inventory[y].dblOurCostPerItem, inventory[y].dblValueOfItem);
                            Console.Write(listing);
                            
                            // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                        }
                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if (strresp == "y")
                        {
                            doNotEnd = false; //*using Boolean from While loop to end program*
                                             
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }
        }
    }
}