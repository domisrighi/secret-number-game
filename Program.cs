Random randomNumber = new Random();
int secretNumber = randomNumber.Next(1, 101);

do {
    Console.Write("Type a number between 1 and 100: ");

    int guess = int.Parse(Console.ReadLine()!);

    switch (guess.CompareTo(secretNumber))
    {
        case 0:
            Console.WriteLine("Congratulations! You got the number right!");
            break;
        case -1:
            Console.WriteLine("The number is bigger!");
            break;
        case 1:
            Console.WriteLine("The number is smaller!");
            break;
    }

    if (guess == secretNumber)
        break;

} while (true);