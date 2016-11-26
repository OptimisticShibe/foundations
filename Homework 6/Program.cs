//Assignment #6

//Copy this block into your Visual Studio.

// Review and Redo this code line by line at home.  

// Place comments on each line and describe what the code is doing

using System;

namespace ConsoleApplication1
{
    public struct Pet //Creating a "Pet" struct to make "creating pets" more efficient and less redundant
    {
        public string Name; 
        public string TypeOfPet; //both strings named public to ensure full access
    }

    class Program
    {
        static void Main()
        {
            var numberOfPets = 0; //create array counter variable--start it at zero
            var pets = new Pet[10]; //instantiating the struct by creating a "new" one

            while (true) //while loop to keep the console open
             {
                Console.Write("A)dd D)elete L)ist pets:"); //listing choices to user
                var choice = Console.ReadLine(); //Keeps console open

                switch (choice) //setting switch for user to choose what they want to do
                {
                    case "A":
                    case "a": //First code block for "add." Listed twice to account for if user capitalises the letter
                        {
                            Console.Write("Name :"); //asking user for pet name
                            var name = Console.ReadLine(); //reading user response and storing as variable

                            Console.Write("Type of pet :"); //asking user for pet species
                            var typeOfPet = Console.ReadLine(); //reading user response and storing as variable

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name; //using the array counter "numberOfPets" this stores the name into the array
                            pets[numberOfPets].TypeOfPet = typeOfPet; //same as above but with pet species

                            numberOfPets++; //add 1 to the array counter since a new entry has been input
                            break; //break out of the switch--return to the beginning of the while loop
                        }

                    case "D":
                    case "d": //Code block for deleting pet entries
                        {
                            if (numberOfPets == 0) //exception handler in case user tries to delete pets when array is empty
                            {
                                Console.WriteLine("No pets"); //Kind message informing user they messed up
                                break; //returns to beginning of while loop
                            }

                            for (var index = 0; index < numberOfPets; index++) //Loop to list pets
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                                //(above) placeholders and formatting to list pets on console
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets); //prompt user to choose a pet entry

                            var petNumberToDelete = Console.ReadLine(); //Store user's choice as a variable
                            var indexToDelete = int.Parse(petNumberToDelete); //Convert user choice into int data type

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++) //for loop to shorten array at correct position
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1]; //cannot "edit" array so much as shift data over to overrite.
                            }

                            // We have one less pet
                            numberOfPets--; //reduce array counter by 1 to keep accurate track of number of entries

                            break; //return to beginning of while loop
                        }

                    case "L":
                    case "l": //code for "list" option
                        {
                            if (numberOfPets == 0) //exception handler if no pets
                            {
                                Console.WriteLine("No pets"); //brief message telling sad user that they have no pets :(
                            }

                            for (int index = 0; index < numberOfPets; index++) //For loop to list formatted list of pets
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                                //(above) formatted + place holders to list pets
                            }

                            break; //return to while loop
                        }
                    default: //necessary default option in case user enters anything other than a viable chioce
                        {
                            Console.WriteLine("Invalid option [{0}]", choice); //Tells user that their entry was invalid
                            break; //return to while loop
                        }
                }
            }
        }
    }
}