using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    class Method_Storage
    {
        public string OptionFilter(List<string> options, string message, string answer)
        {
            if (options.Contains(answer) == false)
            {
                while (true)
                {
                    Console.WriteLine(message);
                    answer = Convert.ToString(Console.ReadLine());
                    try
                    {
                        options.Contains(answer);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Esta opción no es válida!");
                    }
                }
            }

            return answer;
        }

        public int RUT_Check(int RUT)
        {
            while (true)
            {
                if (RUT < 10000000 || RUT > 100000000)
                {
                    Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                    Console.WriteLine("Sin puntos ni guión");
                    RUT = 0;
                    
                    while (true)
                    {
                        try
                        {
                            RUT = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (InvalidCastException e)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lo que ha dado no es un RUT válido");
                            Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            return RUT;
        }

        public void Messages(string key)
        {
            if (key == "RUT Check")
            {
                Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                Console.WriteLine("Sin puntos ni guión");
            }
        }
    }
}
