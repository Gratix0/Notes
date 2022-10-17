try
{
    int pos = 1;
    FirstNote();

        while (!false)
        {
            Console.SetCursorPosition(0, pos);

            ConsoleKeyInfo key = Console.ReadKey();
            if (pos < 1)
            {
                pos = 1;
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                continue;
            }
            if (pos > 2)
            {
                pos = 2;
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                continue;
            } 
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

            if (key.Key == ConsoleKey.LeftArrow)
            {
                Cl();
                LeftNote0();
                continue;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 1)
                {
                Cl();
                    Console.WriteLine("Прийти в шарагу\n----------------");
                    Console.WriteLine("Описание: Кол-во пар узнаешь как придёшь");
                    Console.WriteLine("Дата: 07.02.2021");
                    
                    ConsoleKeyInfo ssecondkey = Console.ReadKey();
                    if (ssecondkey.Key == ConsoleKey.UpArrow)
                    {
                        Cl();
                        FirstNote();
                    }
                    continue;
                }

                if (pos == 2)
                {
                    Console.WriteLine("Непойти в шарагу\n----------------");
                    Console.WriteLine("Описание: Чонить придумаешб");
                    Console.WriteLine("Дата: 07.02.2021");
                    
                    ConsoleKeyInfo secondkey = Console.ReadKey();
                    if (secondkey.Key == ConsoleKey.UpArrow)
                    {
                        Cl();
                        FirstNote();
                    }
                }
            }
            Console.Clear();
            FirstNote();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
        }

        static void FirstNote()
        {
            Console.WriteLine("Выбрана дата 07.02.2021");
            Console.WriteLine("  1. Пойти в шарагу");
            Console.WriteLine("  2. Непойти в шарагу");
        }

        static void LeftNote0()
        {
            Console.WriteLine("Выбрана дата 06.02.2021");
            Console.WriteLine("  1. Шашлычокб");
            Console.WriteLine("  2. Купим кабачокб");
        }
    
        static void Cl()
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