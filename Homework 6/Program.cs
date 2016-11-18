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
            var numberOfPets = 0;
            var pets = new Pet[10];

            while (true)
             {
                Console.Write("A)dd D)elete L)ist pets:");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                    case "a":
                        {
                            Console.Write("Name :");
                            var name = Console.ReadLine();

                            Console.Write("Type of pet :");
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;
                            pets[numberOfPets].TypeOfPet = typeOfPet;

                            numberOfPets++;
                            break;
                        }

                    case "D":
                    case "d":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");
                                break;
                            }

                            for (var index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets);

                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete);

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--;

                            break;
                        }

                    case "L":
                    case "l":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");
                            }

                            for (int index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}