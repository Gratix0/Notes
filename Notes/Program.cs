using Notes;
using System;
using System.Runtime.InteropServices;

try
{
    int pos = 1;
    Menu();

        while (pos > 0 && pos < 10)
        {
            Console.SetCursorPosition(0, pos);

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 1)
                {
                cl();
                    Console.WriteLine("Это заметка 07.02.21");
                    continue;
                }
                //if (pos == 5)
                //{
                //cl();

                //Note newRec = new Note();
                //Console.WriteLine("Enter date");
                //newRec.date = Console.ReadLine();
                //cl();
                //Console.WriteLine("Enter Record");
                //newRec.text = Console.ReadLine();    
                //cl();

                //Console.WriteLine("text record\n -----------------------------------------------------------------\n\n");
                //Console.WriteLine(newRec.text);
                //Console.WriteLine("------------------------------------------------------------------");
                //Console.WriteLine(newRec.date);

               

                //continue;

                //}
            }
            Console.Clear();

            Menu();

            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
        }

        static void Menu()
        {
            Console.WriteLine("Выберите дату");
            Console.WriteLine("  1. 07.02.21");
            Console.WriteLine("  2. 08.02.21");
            Console.WriteLine("  3. 11.02.21");
            Console.WriteLine("  4. 11.04.21");
            Console.WriteLine("  5. " );
            Console.WriteLine("  Добавить заметку");
        }
    
        static void cl()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }
    }

catch(Exception)
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);

    Console.WriteLine("\n\n\n\n\n\n\nТы что-то сломал");
    Console.ReadLine();
}