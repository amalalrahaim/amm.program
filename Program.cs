using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ConsoleApp1ttt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool startProgram = true;

            while (startProgram)
            {
                string filePath = @"C:\Users\User\source\repos\ConsoleApp1ttt\ConsoleApp1ttt\ttt.txt";
                List<string> lines = File.ReadAllLines(filePath).ToList();
                Console.WriteLine();
                Console.WriteLine("this Is File For Teacher ..... ");
                Console.WriteLine(" Choose Operation");
                Console.WriteLine("1-Add Student 2-Update Student 3-student return 4-Display Student ,,, Enter any key to exit  ");
                string OC = Console.ReadLine();
                if (OC == "1")
                {
                    Console.WriteLine("Enter How many user you want ? :");
                    int InputCount = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < InputCount; i++)
                    {
                        Console.WriteLine("Enter ID :");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name :");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Class :");
                        string Class = Console.ReadLine();
                        Console.WriteLine("Enter Section :");
                        string Section = Console.ReadLine();
                        string x = ID.ToString() + ',' + Name + ',' + Class + ',' + Section;
                        lines.Add(x);
                        lines.Sort();
                        File.WriteAllLines(filePath, lines);
                        Console.WriteLine(" Add successfully ... !");
                    }
                }
                else if (OC == "2")
                {
                    Console.WriteLine("Enter ID for UPDET  :");
                    string UpdateID = Console.ReadLine();

                    foreach (var line in lines)
                    {
                        string[] arry = line.Split(',');
                        if (arry[0] == UpdateID)
                        {
                            lines.Remove(arry[0] + ',' + arry[1] + ',' + arry[2] + ',' + arry[3]);
                            Console.WriteLine("Enter Name :");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter Class :");
                            string Class = Console.ReadLine();
                            Console.WriteLine("Enter Section :");
                            string Section = Console.ReadLine();
                            arry[1] = Name;
                            arry[2] = Class;
                            arry[3] = Section;
                            string x = UpdateID + ',' + arry[1] + ',' + arry[2] + ',' + arry[3];
                            lines.Add(x);
                            lines.Sort();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine(" Update is successfully ...");
                            Console.WriteLine("ID:" + arry[0] + "\t NAME:" + arry[1] + "\t CLASS:" + arry[2] + "\t Section:" + arry[3]);
                            break;

                        }

                    }
                }
                else if (OC == "3")
                {
                    Console.WriteLine("Enter ID to search  :");
                    string UpdateID = Console.ReadLine();
                    foreach (var line in lines)
                    {
                        string[] arry = line.Split(',');

                        if (arry[0] == UpdateID)
                        {
                            Console.WriteLine("ID:" + arry[0] + "\t NAME:" + arry[1] + "\t CLASS:" + arry[2] + "\t Section:" + arry[3]);
                        }
                    }
                }
                else if (OC == "4")
                {
                    Console.WriteLine("Print the student list :");
                    foreach (string line in lines)
                    {
                        string[] arry = line.Split(',');
                        Console.WriteLine("ID:" + arry[0] + "\t NAME:" + arry[1] + "\t CLASS:" + arry[2] + "\t Section:" + arry[3]);
                    }
                }
                else
                {
                    Console.WriteLine("I Wish you a nice Day ... Bye :) ");
                    startProgram = false;
                }
            }


        }
    }
}