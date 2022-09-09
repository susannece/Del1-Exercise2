using System.Windows.Markup;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                var assignmentChoice = 0;
                try
                {
                    Console.Write("Enter assignment number or -1 for exit: ");
                    assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;

                        case 2:
                            RunExerciseTwo();
                            break;

                        case 3:
                            RunExerciseThree(); 
                            break;

                        case 4:
                            RunExerciseFour();
                            break;

                        case 5:
                            RunExerciseFive();
                            break;

                        case -1:
                            keepAlive = false;
                            break;
                            
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Default - That is not a valid assignment number!");
                            break;
                    } // End of switch
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                } //End of try
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Catch - There is something wrong in case: " + assignmentChoice);
                    Console.ResetColor();
                }
            } //End of while

        } //End of Main

        private static void RunExerciseOne()
        {
             var firstName = "Susanne";
             var lastName = "Cederholm";
             Console.WriteLine("Hello " + firstName + " " + lastName + "! I'm glad to inform you that you are the test subject of my very first assignment! ");
        }

        private static void RunExerciseTwo()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);
            DateTime yesterday = today.AddDays(-1);
            Console.WriteLine("Todays date is " + today);
            Console.WriteLine("Tomorrow date is " + tomorrow);
            Console.WriteLine("Yesterdays date was " + yesterday);
            Console.WriteLine("------------------ ");
            Console.WriteLine("Todays date is " + today.ToString("dd MMMM yyyy"));
            Console.WriteLine("Tomorrow date is " + tomorrow.ToString("dd MMMM yyyy"));
            Console.WriteLine("Yesterdays date was " + yesterday.ToString("dd MMMM yyyy"));
        }

        private static void RunExerciseThree()
        {
            Console.WriteLine("Enter your first name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            var lastName = Console.ReadLine();
            var name = firstName + " " + lastName;
            Console.WriteLine(name);
        }

        private static void RunExerciseFour()
        {
            String str = "The quick fox Jumped Over the DOG";
            Console.WriteLine(str);
            String manipulated = str.ToLower();
            Console.WriteLine(manipulated);
            manipulated = char.ToUpper(manipulated[0]) + manipulated.Substring(1);
            Console.WriteLine(manipulated);
        }

        private static void RunExerciseFive()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            Console.WriteLine(str);
            String newString = str.Substring(65);
            Console.WriteLine(newString);
            newString = newString.Remove(3, 4);
            Console.WriteLine(newString);
            String strToAdd = "6,7,8,9,10";
            //newString = newString.

        }

    } //End of class
} //End of namespace