namespace secondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            char selection = ' ';

            do
            {
                Console.WriteLine("P - Print Numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Search for the number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("\n Enter Your Selection: ");

                selection = char.ToUpper(char.Parse(Console.ReadLine()));



                switch (selection)
                {
                    case 'P':
                        if (Numbers.Count == 0)
                        {
                            Console.WriteLine("[ ] - The list is empty!");
                        }
                        else

                        {
                            for (int i = 0; i < Numbers.Count - 1; i++)  
                            {
                                for (int j = 0; j < Numbers.Count - i - 1; j++)  
                                {
                                    if (Numbers[j] > Numbers[j + 1])
                                    { 
                                        int temp = Numbers[j];
                                        Numbers[j] = Numbers[j + 1];
                                        Numbers[j + 1] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Numbers in the list  : ");
                            Console.Write("[ ");

                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                Console.Write(Numbers[i]);

                                if (i < Numbers.Count - 1)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write(" ]");
                        }
                        Console.WriteLine("---------");
                        break;

                    case 'A':
                        Console.Write("Enter a number to add to list : ");
                        string input = Console.ReadLine();

                        bool isNumber = true;
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (!char.IsDigit(input[i]))
                            {
                                isNumber = false;
                                break;
                            }
                        }

                        if (isNumber)
                        {
                            int number = int.Parse(input);
                            if (Numbers.Contains(number))
                            {
                                Console.WriteLine("The number is already exist in the list");
                            }
                            else
                            {
                                Numbers.Add(number);
                                Console.WriteLine($"Number {number} added to the list.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case 'M':
                        if (Numbers.Count == 0)
                        {
                            Console.WriteLine("[ ] - The list is empty!");
                        }
                        else
                        {
                            double sum = 0;
                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                sum += Numbers[i];
                            }
                            double avrg = sum / Numbers.Count;
                            Console.WriteLine($"The mean of the numbers is  {avrg}");
                        }
                        break;

                    case 'S':
                        if (Numbers.Count == 0)
                        {
                            Console.WriteLine("[ ] - The list is empty!");
                        }
                        else
                        {
                            int minNumber = Numbers[0];
                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                if (Numbers[i] < minNumber)
                                {
                                    minNumber = Numbers[i];
                                }

                            }
                            Console.WriteLine($"The smallest number is {minNumber}");
                        }
                        break;

                    case 'L':
                        if (Numbers.Count == 0)
                        {
                            Console.WriteLine("[ ] - The list is empty!");
                        }
                        else
                        {
                            int maxNumber = Numbers[0];
                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                if (Numbers[i] > maxNumber)
                                {
                                    maxNumber = Numbers[i];
                                }
                            }
                            Console.WriteLine($"The largest number is {maxNumber}");
                        }
                        break;
                    case 'F':
                        Console.WriteLine("Enter the number you need to search : ");
                        string searchInput = Console.ReadLine();
                        bool isNum = true;

                        for (int i = 0; i < searchInput.Length; i++)
                        {
                            if (!char.IsDigit(searchInput[i]))
                            {
                                isNum = false;
                                break;
                            }
                        }

                        if (isNum)
                        {
                            int searchNumber = Convert.ToInt32(searchInput);
                            bool isFound = false;

                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                if (Numbers[i] == searchNumber)
                                {

                                    Console.WriteLine($"Number {searchNumber} is at index {i}");
                                    isFound = true;
                                    break;
                                }
                            }
                            if (!isFound)
                            {
                                Console.WriteLine($"Number {searchNumber} is not in the list");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, Make sure the value is correct!");
                        }

                        break;

                    case 'C':
                        Console.WriteLine("Are you sure you want to clear the list [Y or N] ? ");

                        bool isConfirm = false;
                        string userOption = Console.ReadLine().ToUpper();

                        switch (userOption)
                        {
                            case "Y":
                                isConfirm = true;
                                break;
                            case "N":
                                isConfirm = false;
                                break;
                        }
                        if (isConfirm)
                        {
                            Numbers.Clear();
                            Console.WriteLine("All Numbers have been cleared from the list succssefully!");
                        }
                        else
                        {
                            Console.WriteLine("The clearing process has been cancelled.");
                        }


                        break;

                }
            } while (selection != 'Q');
            Console.WriteLine("Good bye");
        }
    }
}






