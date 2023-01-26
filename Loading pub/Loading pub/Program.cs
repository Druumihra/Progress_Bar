Console.Clear();
Console.WriteLine("Pick what prime number you want");
int pickedNumber = Convert.ToInt32(Console.ReadLine());



PrimeFinder.ProgressEvent += (count) =>
{
    int percentage = (int)((double)count / pickedNumber * 100.0);
    switch (percentage)
    {
        case < 10:
            Console.SetCursorPosition(0, 3);
            Console.Write("[----------]");
            break;
        case < 20:
            Console.SetCursorPosition(0, 3);
            Console.Write("[#---------]");
            break;
        case < 30:
            Console.SetCursorPosition(0, 3);
            Console.Write("[##--------]");
            break;
        case < 40:
            Console.SetCursorPosition(0, 3);
            Console.Write("[###-------]");
            break;
        case < 50:
            Console.SetCursorPosition(0, 3);
            Console.Write("[####------]");
            break;
        case < 60:
            Console.SetCursorPosition(0, 3);
            Console.Write("[#####-----]");
            break;
        case < 70:
            Console.SetCursorPosition(0, 3);
            Console.Write("[######----]");
            break;
        case < 80:
            Console.SetCursorPosition(0, 3);
            Console.Write("[#######---]");
            break;
        case < 90:
            Console.SetCursorPosition(0, 3);
            Console.Write("[########--]");
            break;
        case < 100:
            Console.SetCursorPosition(0, 3);
            Console.Write("[#########-]");
            break;
        case 100:
            Console.SetCursorPosition(0, 3);
            Console.Write("[##########]");
            break;

    }
};

int result = PrimeFinder.FindPrime(pickedNumber);
Console.SetCursorPosition(0, 4);
Console.WriteLine($"Result: {result}");

