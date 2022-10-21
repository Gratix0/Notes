try
{
    int noteCount = 0;
    int pos = 1;
    
        do
        {
            if (noteCount == 0)
            {
                while (!false)
                {
                    Console.Clear();
                    Note.Notes.FirstNote();
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    
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
                        noteCount--;
                        break;
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        noteCount++;
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

                            ConsoleKeyInfo ssecondKey = Console.ReadKey();
                            if (ssecondKey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.FirstNote();
                            } continue;
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
                }
            }

            if (noteCount == -1)
            {
                while (!false)
                {
                    do
                    {
                        Cl();
                        Note.Notes.Noteminus1();
                    } while (false);

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
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
                        Console.WriteLine("->"); continue;
                    }

                    if (pos < 1)
                    {
                        pos = 1;
                        Console.SetCursorPosition(0, pos); continue;
                    }

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        noteCount--; break;
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        noteCount++; break;
                    }

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (pos == 1)
                        {
                            Cl();
                            Console.WriteLine("Шашлычокб\n----------------");
                            Console.WriteLine("Описание: Зайти в пятёрочку купить курочку");
                            Console.WriteLine("Дата: 06.02.2021");

                            ConsoleKeyInfo ssecondkey = Console.ReadKey();
                            if (ssecondkey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.Noteminus1();
                            } continue;
                        }

                        if (pos == 2)
                        {
                            Cl();
                            Console.WriteLine("Купим кабачокб\n----------------");
                            Console.WriteLine("Описание: Ну что сказать... Купи ");
                            Console.WriteLine("Дата: 06.02.2021");

                            ConsoleKeyInfo secondkey = Console.ReadKey();
                            if (secondkey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.Noteminus1();
                            }
                        }
                    }


                }
            }

            if (noteCount == -2)
            {
                while (!false)
                {
                    do
                    {
                        Cl();
                        Note.Notes.Noteminus2();
                    } while (false);

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow && pos < 3)
                    {
                        pos++;
                    }

                    if (key.Key == ConsoleKey.DownArrow && pos > 0)
                    {
                        pos++;
                    }

                    if (pos < 1 || pos > 1)
                    {
                        pos = 1;
                        Console.SetCursorPosition(0, pos); continue;
                    }

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        noteCount--;
                        break;
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        noteCount++;
                        break;
                    }

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (pos == 1)
                        {
                            Cl();
                            Console.WriteLine(
                                "Дорогой дневник, сегодня я испытал такую боль и унижение...\n----------------");
                            Console.WriteLine("Описание: Суецыд");
                            Console.WriteLine("Дата: 05.02.2021");

                            ConsoleKeyInfo ssecondkey = Console.ReadKey();
                            if (ssecondkey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.Noteminus2();
                            }
                            continue;
                        }
                    }
                }
            }

            if (noteCount == 1)
            {
                while (!false)
                {
                    do
                    {
                        Cl();
                        Note.Notes.NotePlus1();
                    } while (false);

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
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
                        Console.WriteLine("->"); continue;
                    }

                    if (pos < 1)
                    {
                        pos = 1;
                        Console.SetCursorPosition(0, pos); continue;
                    }

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        noteCount--;
                        break;
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        noteCount++;
                        break;
                    }

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (pos == 1)
                        {
                            Cl();
                            Console.WriteLine("Ну допустим запись тут\n----------------");
                            Console.WriteLine("Описание: Есть такое дело");
                            Console.WriteLine("Дата: 08.02.2021");

                            ConsoleKeyInfo ssecondkey = Console.ReadKey();
                            if (ssecondkey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.NotePlus1();
                            } continue;
                        }

                        if (pos == 2)
                        {
                            Cl();
                            Console.WriteLine("И тут\n----------------");
                            Console.WriteLine("Описание: И тут есть такое дело");
                            Console.WriteLine("Дата: 08.02.2021");

                            ConsoleKeyInfo ssecondkey = Console.ReadKey();
                            if (ssecondkey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.NotePlus1();
                            }
                            continue;
                        }
                    }
                }
            }

            if (noteCount == 2)
            {
                while (!false)
                {
                    do
                    {
                        Cl();
                        Note.Notes.NotePlus2();
                    } while (false);

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
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
                        Console.SetCursorPosition(0, pos); continue;
                    }

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        noteCount--;
                        break;
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        noteCount++;
                        break;
                    }

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (pos == 1)
                        {
                            Cl();
                            Console.WriteLine("Сдать практическую №4\n----------------");
                            Console.WriteLine("Описание: Сдамб");
                            Console.WriteLine("Дата: 09.02.2021");

                            ConsoleKeyInfo ssecondkey = Console.ReadKey();
                            if (ssecondkey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.NotePlus2();
                            } continue;
                        }

                        if (pos == 2)
                        {
                            Cl();
                            Console.WriteLine("Придумать алгаритм добавления новой записи\n----------------");
                            Console.WriteLine("Описание: Когда-нибудь сделаю");
                            Console.WriteLine("Дата: 09.02.2021");

                            ConsoleKeyInfo ssecondkey = Console.ReadKey();
                            if (ssecondkey.Key == ConsoleKey.UpArrow)
                            {
                                Cl();
                                Note.Notes.NotePlus2();
                            }
                            continue;
                        }
                    }
                }
            }

            if (noteCount > 2 )
            {
                noteCount = 2;
            }
            if (noteCount < -2 )
            {
                noteCount = -2;
            }
            static void Cl()
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
            }
        } while (noteCount > -2 || noteCount < 2);
    
} 
catch (Exception)
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("\n\n\n\n\n\n\nТы что-то сломал");
}