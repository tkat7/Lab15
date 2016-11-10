using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> countries = new List<string>();
            while (true)
            {
                
                Console.Write("Option 1: Display the countries\nOption 2: Add a country\nOption 3: Remove a country\nOption 4: End\nSelect an option: ");
                Boolean check = true;
                String input= "0";
                while (check == true)
                {
                    input = Console.ReadLine();
                    if (input == "1" || input == "2" || input == "3" || input == "4")
                    {
                        check = false;
                    }
                }

                    if (input == "1")
                    {
                        Console.Write("Here are the Countries on file: ");
                        foreach (String s in countries)
                        {
                            Console.Write(s + "  ");
                        }
                        Console.WriteLine();
                    }
                    else if (input == "2")
                    {
                        Console.Write("What Country would you like to add: ");
                        countries.Add(Console.ReadLine());
                        Console.WriteLine();
                    }
                    
                    else if (input == "3")
                {
                    Console.Write("Which Country would you like to remove: ");
                      countries.Remove(Console.ReadLine());
                }
                    else if (input == "4")
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                }
            }
        }
    }

