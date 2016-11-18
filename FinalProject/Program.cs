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
        var arrayCount = 0;
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

            foreach (string optionList in list) //*Foreach loop to list formatted option list*
            {
                Console.Write("Please choose an option (1-5):\n {0}\n", optionList);
            }

            // read the user's input and then create what case it falls

            string strx = Console.ReadLine();	// read user's input	

            var optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {
                        Console.Write("Enter the item number:");
                        string newItemStr = Console.ReadLine();
                        inventory[arrayCount].itemIDNo = int.Parse(newItemStr);

                        Console.Write("Enter item description:");
                        string newItemDescription = Console.ReadLine();
                        inventory[arrayCount].sDescription = newItemDescription;

                        Console.Write("Enter item price:");
                        string newItemPrice = Console.ReadLine();
                        inventory[arrayCount].dblPricePerItem = double.Parse(newItemPrice);

                        Console.Write("Enter quantity of item:");
                        string newItemQuantityStr = Console.ReadLine();
                        inventory[arrayCount].iQuantityOnHand = int.Parse(newItemQuantityStr);

                        Console.Write("Enter our cost per item:");
                        string newItemOurCostStr = Console.ReadLine();
                        inventory[arrayCount].dblOurCostPerItem = double.Parse(newItemOurCostStr);

                        //***THIS LINE MIGHT NOT WORK***
                        inventory[arrayCount].dblValueOfItem = inventory[arrayCount].iQuantityOnHand * inventory[arrayCount].dblPricePerItem;

                        arrayCount++;
                        break;
                    }

                case 2: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        for (int x = 0; x < arrayCount; x++)
                        {
                            if (inventory[x].itemIDNo == chgid)
                            {
                                fFound = true;
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
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        for (int x = 0; x < arrayCount; x++)
                        {
                            if (inventory[x].itemIDNo == newid)
                           { 
                                fDeleted = true;
                                // delete the item if you found it
                                // reset the count to show a new count for your list 
                                //(Note: your list is now reduced by one item)								
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
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it

                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if (strresp == "y")
                        {
                            doNotEnd = false; //*using Boolean from While loop to end program*
                                              //optx=0;	//as long as it is not 5, the process is not breaking	
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
}