using Note;
using Notes;
try
{
    int pos = 1;
    Note.Notes.FirstNote();

    while (!false)
    {
        Console.SetCursorPosition(0, pos);

        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.UpArrow && pos < 3)
        {
            --pos;
        }
        if (key.Key == ConsoleKey.DownArrow && pos > 0)
        {
            ++pos;
        }
        if (pos > 2)
        {
            pos = 2;
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            continue;
        }
        if (pos < 1)
        {
            pos = 1;
            Console.SetCursorPosition(0, pos);

            continue;
        }

        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }

        if (key.Key == ConsoleKey.LeftArrow)
        {
            while (!false)
            {
                Console.SetCursorPosition(0, pos);

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && pos < 3)
                {
                    --pos;
                }
                if (key.Key == ConsoleKey.DownArrow && pos > 0)
                {
                    ++pos;
                }
                if (pos > 2)
                {
                    pos = 2;
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    continue;
                }
                if (pos < 1)
                {
                    pos = 1;
                    Console.SetCursorPosition(0, pos);

                    continue;
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
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
                            Note.Notes.FirstNote();
                        }
                        continue;
                    }

                    if (pos == 2)
                    {
                        Cl();
                        Console.WriteLine("Непойти в шарагу\n----------------");
                        Console.WriteLine("Описание: Чонить придумаешб");
                        Console.WriteLine("Дата: 07.02.2021");

                        ConsoleKeyInfo secondkey = Console.ReadKey();
                        if (secondkey.Key == ConsoleKey.UpArrow)
                        {
                            Cl();
                            Note.Notes.FirstNote();
                        }
                    }
                }
                Console.Clear();
                Note.Notes.FirstNote();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
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
                        Note.Notes.FirstNote();
                    }
                    continue;
                }

                if (pos == 2)
                {
                    Cl();
                    Console.WriteLine("Непойти в шарагу\n----------------");
                    Console.WriteLine("Описание: Чонить придумаешб");
                    Console.WriteLine("Дата: 07.02.2021");

                    ConsoleKeyInfo secondkey = Console.ReadKey();
                    if (secondkey.Key == ConsoleKey.UpArrow)
                    {
                        Cl();
                        Note.Notes.FirstNote();
                    }
                }
            }
            Console.Clear();
            Note.Notes.FirstNote();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
        }

        static void Cl()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }

    }
}


catch (Exception)
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);

    Console.WriteLine("\n\n\n\n\n\n\nТы что-то сломал");
    Console.ReadLine();
}