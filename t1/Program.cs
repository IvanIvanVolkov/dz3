int i, remainder = 0, newnum = 0;
        Console.WriteLine("Введите число: ");
        int uinput = Convert.ToInt32((Console.ReadLine()));
        for (i = uinput; i > 0; i = (i / 10))
        {
            remainder = i % 10;
            Console.Write(remainder);

            newnum = remainder;

        }


        if (newnum == uinput)
        {
            Console.WriteLine("Число {0} является палиндромом", uinput);
        }
        else
        {
            Console.WriteLine("Число - это не палиндром");
        }
        Console.WriteLine(uinput);
        Console.WriteLine(newnum);
        Console.ReadKey();
        
