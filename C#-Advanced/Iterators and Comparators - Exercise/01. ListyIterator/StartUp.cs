﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split();
            ListyIterator<string> list = null;


            while (command[0]!= "END")
            {
                try
                {
                    
                    var commandTwo = command[0];
                    switch (commandTwo)
                    {
                        case "Create":
                            List<string> elements = command.Skip(1).ToList();
                            list = new ListyIterator<string>(elements);
                            break;
                        case "Move":
                            Console.WriteLine(list.Move());
                            break;
                        case "Print":
                            list.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(list.HasNext());
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
