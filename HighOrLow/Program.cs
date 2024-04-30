 

//random number 
Random rand = new Random();
int num = rand.Next(1, 101);

//guess counter
int guess = 0;

while (true)
{
    //user first guess
    Console.WriteLine("Guess a number between 1 and 100");
    int userInt = int.Parse(Console.ReadLine());

    //validation
    if (userInt < 1 || userInt > 100)
    {
        Console.WriteLine("Invalid Input");
        continue;
    } 

    //counting everytime it loops with a valid guess
    guess++;

    //checking if guess is correct
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



