class PrimeFinder
{
    public static event PrimeProgressEventHandler? ProgressEvent;

    public static int FindPrime(int pickedNumber)
    {
        int count = 0;
        int currentNumber = 1;

        while (count < pickedNumber){
            if (PrimeFinder.IsPrime(currentNumber)) {
                count++;
                ProgressEvent?.Invoke(count);
            }
            currentNumber++;
        }
        currentNumber--;

        return currentNumber;
    }

    private static bool IsPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;

        var limit = Math.Ceiling(Math.Sqrt(number));

        for (int i = 2; i <= limit; ++i)
            if (number % i == 0)
                return false;
        return true;

    }
}

public delegate void PrimeProgressEventHandler(int count);

