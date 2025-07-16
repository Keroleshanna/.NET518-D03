namespace Task01
{
    internal class Program
    {

        static void DisplayMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══ Main Menu ═══════════════════════╗");
            Console.WriteLine("║ P - Print numbers                  ║");
            Console.WriteLine("║ A - Add a number                   ║");
            Console.WriteLine("║ M - Display mean of the number     ║");
            Console.WriteLine("║ S - Display teh Smallest number    ║");
            Console.WriteLine("║ L - Display teh Largest number     ║");
            Console.WriteLine("║ F - Find a number                  ║");
            Console.WriteLine("║ C - Clear the whole list           ║");
            Console.WriteLine("║ R - Sort the list                  ║");
            Console.WriteLine("║ Q - Quit                           ║");
            Console.WriteLine("╚════════════════════════════════════╝");
        }
        static char ReadCharInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n==> : ");
            _ = char.TryParse(Console.ReadLine(), out char yourChoice);
            return char.ToUpper(yourChoice);
        }
        static void StartOutPut()
        {
            Console.WriteLine("╔════ Outbut ═══════════════════╗");
        }
        static void EndOutPut()
        {
            Console.WriteLine("╚═══════════════════════════════╝");
        }
        static void PrintNumbersOfList(List<int> ints)
        {
            if (ints.Count > 0)
            {

                StartOutPut();
                for (int i = 0; i < ints.Count; i++)
                {
                    Console.Write($"    {ints[i]}");
                }
                Console.Write("\n");
                EndOutPut();
            }
            else
            {
                StartOutPut();
                Console.WriteLine("Your list is Empity");
                EndOutPut();
            }
        }
        static void AddNewNumber(List<int> list)
        {
            Console.Write("Enter the number to add ==>  ");
            if (int.TryParse(Console.ReadLine(), out int addNewNumber))
            {
                int numberFound = -1;
                for (int i = 0; i < list.Count; i++)
                {
                    if (addNewNumber == list[i])
                    {
                        numberFound = addNewNumber;
                        break;
                    }
                }
                if (numberFound != addNewNumber)
                {
                    list.Add(addNewNumber);
                    StartOutPut();
                    Console.WriteLine($"         {addNewNumber} added");
                    EndOutPut();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    list.Add(addNewNumber);
                    StartOutPut();
                    Console.WriteLine($"Sorry this number found in your list!!");
                    EndOutPut();
                }
            }
        }
        static void TheMeanOfTheNumbers(List<int> list, ref int sum, ref double average)
        {
            for (int i = 0; i < list.Count; i++)
                sum += list[i];
            average = sum / list.Count;
        }
        static int TheSmallestNumber(List<int> myList)
        {
            int smallest = myList[0];
            if (myList.Count == 0)
            {
                StartOutPut();
                Console.WriteLine($"Unable to determine the smallest number - list is empty");
                EndOutPut();
            }
            else
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] <= smallest)
                        smallest = myList[i];

                }
            }
            return smallest;
        }
        static int TheLargestNumber(List<int> myList)
        {
            int largest = myList[0];
            if (myList.Count == 0)
            {
                StartOutPut();
                Console.WriteLine($"Unable to determine the smallest number - list is empty");
                EndOutPut();
            }
            else
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] >= largest)
                        largest = myList[i];

                }
            }
            return largest;
        }
        static int FindNumber(List<int> myList, int search)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == search)
                {
                    return i;
                }
            }
            return -1;
        }
        static void SortTheList(List<int> myList)
        {
            if (myList.Count > 0)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    for (int j = 0; j < myList.Count - 1; j++)
                    {
                        if (myList[i] < myList[j] + 1)
                        {
                            (myList[j], myList[i]) = (myList[i], myList[j]);
                        }
                    }
                }
                StartOutPut();
                Console.WriteLine("Done The List is Sorted now");
                EndOutPut();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                StartOutPut();
                Console.WriteLine("Sory your List is Empity");
                EndOutPut();
            }
        }




        static void Main(string[] args)
        {
            List<int> myList = [];
            char yourChoice;
            double averageOfList = 0;
            int smallest, largest, sumOfList = 0;

            do
            {
                DisplayMainMenu();
                yourChoice = ReadCharInput();
                Console.ForegroundColor = ConsoleColor.Green;

                switch (yourChoice)
                {
                    case 'P':
                        PrintNumbersOfList(myList);
                        break;
                    case 'A':
                        AddNewNumber(myList);
                        break;
                    case 'M':
                        if (myList.Count == 0)
                        {
                            StartOutPut();
                            Console.WriteLine("Unable to calculate the mean - no data");
                            EndOutPut();
                        }
                        else
                        {
                            TheMeanOfTheNumbers(myList, ref sumOfList, ref averageOfList);
                            StartOutPut();
                            Console.WriteLine($"  The average is {averageOfList}");
                            EndOutPut();

                        }
                        break;
                    case 'S':
                        smallest = TheSmallestNumber(myList);
                        StartOutPut();
                        Console.WriteLine($" The smallest number is {smallest}");
                        EndOutPut();
                        break;
                    case 'L':
                        largest = TheLargestNumber(myList);
                        StartOutPut();
                        Console.WriteLine($" The Largest number is {largest}");
                        EndOutPut();
                        break;
                    case 'Q':
                        Console.WriteLine("GoodBye");
                        break;
                    case 'F':
                        Console.WriteLine("Enter the number to search: ==> ");
                        if (int.TryParse(Console.ReadLine(), out int searchNumber))
                        {
                            int index = FindNumber(myList, searchNumber);
                            if (index == -1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                StartOutPut();
                                Console.WriteLine("Your number is not found!!");
                                EndOutPut();
                            }
                            else
                            {
                                StartOutPut();
                                Console.WriteLine($"Needed number in index {index}");
                                EndOutPut();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            StartOutPut();
                            Console.WriteLine("Your inbut not a number!!");
                            EndOutPut();
                        }
                        break;
                    case 'C':
                        myList.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        StartOutPut();
                        Console.WriteLine("  Your List is Empity now!! ");
                        EndOutPut();
                        break;
                    case 'R':
                        SortTheList(myList);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        StartOutPut();
                        Console.WriteLine("  Unknown selection, please try again  ");
                        EndOutPut();
                        break;
                }
            } while (yourChoice != 'q' && yourChoice != 'Q');
        }
    }
}