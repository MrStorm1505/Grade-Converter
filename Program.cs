using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Welcome to Grade Converter!");
        Console.WriteLine("Please write the numerical grade you want to convert: ");
        Console.WriteLine("(Grades go from 0 to 100)");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        if (grade <= 100 && grade >= 0)
        {
            Console.WriteLine("Thanks! Now, please select the system you want to convert it to");
            Console.WriteLine("1- Alphabet system");
            Console.WriteLine("2- Spanish system");
            string input2 = Console.ReadLine();
            int system = int.Parse(input2);
            if (system == 1)
            {
                Console.WriteLine("Alphabet system selected");
                Console.WriteLine("The grade is equivalent to: ");
                if (grade <= 100 && grade > 92)
                {
                    Console.WriteLine("A+");
                }
                else if (grade <= 92 && grade > 89)
                {
                    Console.WriteLine("A");
                }
                else if (grade <= 89 && grade > 86)
                {
                    Console.WriteLine("B+");
                }
                else if (grade <= 86 && grade > 82)
                {
                    Console.WriteLine("B");
                }
                else if (grade <= 82 && grade > 79)
                {
                    Console.WriteLine("B-");
                }
                else if (grade <= 79 && grade > 76)
                {
                    Console.WriteLine("C+");
                }
                else if (grade <= 76 && grade > 72)
                {
                    Console.WriteLine("C");
                }
                else if (grade <= 72 && grade > 69)
                {
                    Console.WriteLine("C-");
                }
                else if (grade <= 69 && grade > 66)
                {
                    Console.WriteLine("D+");
                }
                else if (grade <= 66 && grade > 62)
                {
                    Console.WriteLine("D");
                }
                else if (grade <= 62 && grade > 59)
                {
                    Console.WriteLine("D-");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            else if (system == 2)
            {
                Console.WriteLine("Spanish system selected");
                Console.WriteLine("The grade is equivalent to: ");
                if (grade <= 100 && grade > 92)
                {
                    Console.WriteLine("Sobresaliente Alto");
                }
                else if (grade <= 92 && grade > 89)
                {
                    Console.WriteLine("Sobresaliente");
                }
                else if (grade <= 89 && grade > 86)
                {
                    Console.WriteLine("Notable Alto");
                }
                else if (grade <= 86 && grade > 82)
                {
                    Console.WriteLine("Notable");
                }
                else if (grade <= 82 && grade > 79)
                {
                    Console.WriteLine("Notable Bajo");
                }
                else if (grade <= 79 && grade > 76)
                {
                    Console.WriteLine("Bien");
                }
                else if (grade <= 76 && grade > 72)
                {
                    Console.WriteLine("Suficiente");
                }
                else if (grade <= 72 && grade > 69)
                {
                    Console.WriteLine("Suficiente Bajo");
                }
                else
                {
                    Console.WriteLine("Insuficiente");
                }
            }
            else
            {
               Console.WriteLine("ERROR! That's not a valid system"); 
            }
        }
        else
        {
            Console.WriteLine("ERROR! That's not a valid grade");
        }

    }

}   