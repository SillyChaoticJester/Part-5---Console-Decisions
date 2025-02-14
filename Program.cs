namespace Part_5___Console_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notes
            //Symbols for If/Else If/Else Statements:
            //
            // == - Equals
            // < - Less Than
            // > - Greater Than
            // <= - Less Than or Equal To
            // >= - Greater Than or Equal To
            // != - Not Equal To
            // && - And
            // || - Or
            // ! - Not

            // If Statements only work if a condition is true
            // Else If Statements only work if the previous If Statement was false, but its own condition was true
            // Else Statements only work if none of the following conditions were true

            int grade, guessNum, guessCheck, radius;

            Console.WriteLine("What was your grade for that project you did?");
            grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 80)
            {
                Console.WriteLine("Good Job!");
            }
            else if (grade <= 80)
            {
                Console.WriteLine("Study Harder next time!");
            }
            Console.WriteLine("Guess what number I am thinking of?");
            guessNum = Convert.ToInt32(Console.ReadLine());
            if (guessNum == 12)
            {
                Console.WriteLine("You've guessed it!");
            }
            Console.WriteLine("Give me a Radius, and I will give you a Diameter");
            radius = Convert.ToInt32(Console.ReadLine());
            if (radius >= 1)
            {
                Console.WriteLine("The diameter would be " + (radius * 2));
            }
            else if (radius == 0)
            {
                Console.WriteLine("You would have a dot");
            }
            else
            {
                Console.WriteLine("Negative Radii or Non-Numbers are Illegal!");
            }

        }
    }
}
