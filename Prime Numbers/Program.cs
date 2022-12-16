class App
{
    public static void Main()
    {
        // read parameters
        Console.WriteLine("Enter Start Number");
        int start = validateInteger(Console.ReadLine());
        Console.WriteLine("Enter End Number");
        int end = validateInteger(Console.ReadLine());

        if (start == -1 || end == -1)
        { // check on validation
            Console.WriteLine("Invalid Parameters");
        }

        // main loop
        for (int i = start; i < end; i++)
        {
            bool numIsPrime = numberIsPrime(i);

            if (numIsPrime)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

    // validate int function => returns -1 on failure
    public static int validateInteger(string number)
    {
        if (int.TryParse(number, out int intVal) && intVal <= int.MaxValue)
        {
            return intVal;
        }

        return -1;
    }

    // determines if given number is prime
    public static bool numberIsPrime(int number)
    {
        if(number == 1)
        {
            return false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}