 

//random number 
Random rand = new Random();
int num = rand.Next(1, 101);

int guess = 0;

while (true)
{
    Console.WriteLine("Guess a number between 1 and 100");
    int userInt = int.Parse(Console.ReadLine()); 
    guess++;
    if (userInt > num) 
    {
        Console.WriteLine("Guessed too high.");
    } 
    else if (userInt < num)
    {
        Console.WriteLine("Guessed too low");
    }
    else
    {
        Console.WriteLine($"You guessed it right! it took you {guess} tries!");
        break;
    }


}



