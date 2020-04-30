using System;
using System.Collections.Generic;

namespace ClassmatesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

                Console.WriteLine("Pick a student to learn more about them!");
                Console.WriteLine("----------------------------------------");

                List<string> students = new List<string>() { "James", "Sam", "Thomas", "Rosie", "Hannah" };

                int counter = 1;

                foreach (string name in students)
                {
                    Console.Write(counter + "." + name + "  ");

                    counter++;


                }

                Console.WriteLine();

                string student = "";

                string again = "";

                int studentIndex = 0;


                while (true)
                {

                    string input = Console.ReadLine();

                    Console.WriteLine();

                    bool isName = CheckIfName(input, students);

                    bool isNum = true;

                    int studentNum = 0;


                    bool numMatch = true;

                    if (isName)
                    {

                        Console.WriteLine($"You've chosen {input}!");

                        Console.WriteLine();

                        student = input;

                        studentIndex = students.IndexOf(student);

                        break;
                    }
                    else
                    {
                        isNum = int.TryParse(input, out studentNum);


                        if (isNum)
                        {


                            numMatch = CheckIfNum(studentNum, students);

                            if (numMatch)
                            {
                                

                                try
                                {
                                    student = students[studentNum - 1];
                                }
                                catch (ArgumentOutOfRangeException)
                                {
                                    Console.WriteLine("Please enter a valid student or student number");
                                    Console.WriteLine();
                                    continue;
                                }

                                studentIndex = studentNum - 1;

                                Console.WriteLine($"You've chosen {student}!");
                                Console.WriteLine();


                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid student or student number");
                                Console.WriteLine();


                            }

                        }
                        else
                        {
                            Console.WriteLine("Please enter a vaild student or student number");
                            Console.WriteLine();
                        }
                    }

                }

                

                Dictionary<int, string> hometowns = new Dictionary<int, string>();

                hometowns.Add(0, "Rochester");
                hometowns.Add(1, "Rochester Hills");
                hometowns.Add(2, "Troy");
                hometowns.Add(3, "Detroit");
                hometowns.Add(4, "Lansing");

                Dictionary<int, string> foods = new Dictionary<int, string>();

                foods.Add(0, "Steak");
                foods.Add(1, "Grilled Cheese");
                foods.Add(2, "Pizza");
                foods.Add(3, "Fried Chicken");
                foods.Add(4, "Tacos");

                Dictionary<int, string> colors = new Dictionary<int, string>();

                colors.Add(0, "Black");
                colors.Add(1, "Orange");
                colors.Add(2, "Blue");
                colors.Add(3, "Red");
                colors.Add(4, "Purple");

                while (true)
                {
                    Console.WriteLine($"What would you like to know about {student}? Choose Hometown, Favorite Food, or Favorite Color:");
                    Console.WriteLine();

                    while (true)
                    {

                        string choice = Console.ReadLine();
                        Console.WriteLine();

                        if (choice == "Hometown")
                        {
                            Console.WriteLine($"{student}'s hometown is {hometowns[studentIndex]}.");
                            Console.WriteLine();
                            break;
                        }
                        else if (choice == "Favorite Food")
                        {
                            Console.WriteLine($"{student}'s favorite food is {foods[studentIndex]}.");
                            Console.WriteLine();
                            break;
                        }
                        else if (choice == "Favorite Color")
                        {
                            Console.WriteLine($"{student}'s favorite color is {colors[studentIndex]}.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either Hometown, Favorite Food, or Favorite Color:");
                            Console.WriteLine();
                            continue;
                        }

                    }

                    Console.WriteLine($"Type 1 to learn more about {student}, 2 to pick a different student, or anything else to exit:");
                    Console.WriteLine();

                    again = Console.ReadLine();
                    Console.WriteLine();

                    if (again == "1")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }

                if(again == "2")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }


            Console.WriteLine("Goodbye!");



        }

        public static bool CheckIfName(string input, List<string> students)
        {
            bool match = false;

            foreach(string name in students)
            {
                match = input == name;

                if (match)
                {
                    break;
                }

            }

            return match;
        }

        public static bool CheckIfNum(int input, List<string> students)
        {
            bool match = false;

            while (true)
            {
               
                
                if(input >= 0 && input <= students.Count)
                    {
                        match = true;
                        
                        break;
                    }
                    match = false;

                break;
                
               


            }
            return match;

        }
    }
}
