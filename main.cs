using System;
using System.Timers;
using System.Threading;

class MainClass {
	public static double restartDelay;
  public static void Main (string[] args) 
 
	{
				int[,] array = new int[20, 20];

			array = PopGrid (array);

		Console.WriteLine ("Welcome to Conways Game of Life");
		Console.WriteLine ("This game works in stages called 'Generations'");
		Console.WriteLine ("With each new geneartion if a cell has no partner. it dies.");
		Console.WriteLine ("if it has 2 partners it is stable.");
		Console.WriteLine ("if it has 3 neighbours it will form a new cell in the next generation.");
	Console.WriteLine ("Type "Yes" if you would like to create your own sequence or type "Continue" if you want to use a randomized seed");
		
//im trying to get user input to tell the code how fast to loop(store the value of an integer)
// MR W: You should be able to figure that out from the code below.
//yea it looks a lot better now thanks a lot



Console.WriteLine("How many Generations do you wish to have?");
Console.WriteLine("Enter choice: ");
string input = Console.ReadLine();

int numberOfLoops = Int32.Parse(input);

Console.WriteLine("How FAST do you want the generations to appear?(Milliseconds (1second = 1000)");
Console.WriteLine("Enter choice: ");
string speed = Console.ReadLine();
int restartDelay = Int32.Parse(speed);
//float restartDelayy = 1 / restartDelay;


for(int i = 1; i < numberOfLoops; i++)
{

  PrintGrid(array); 

  array = NextGen(array); // get the next array

  Thread.Sleep(TimeSpan.FromMilliseconds(restartDelay)); // sleep for one sec

 // probably can't do this until for loop done. THere is no stop.
// Mr W: explore clearing the console



// the console weird characters is weird. I've seen it before. Can't remember why or the fix. Will let you know if I think of anything. Don't stress about it.

}

//The variables given for the grid sizes
      PrintGrid(array);

       PrintGrid(NextGen(array));


  }
  //Code that puts conways laws into the game
	//This also tells the game which is a 1 and 0
  public static int[,] NextGen(int[,] array)
  {

    int[,] nextGenArray = new int[array.GetLength(0), array.GetLength(1)];

    // go through columns
    for (int i = 1; i < array.GetLength(0)-1;  i ++)
		{
			// go through rows
			for (int j = 1; j < array.GetLength(1)-1; j++)
			{
		
          int neighbourCount = 0;
          if (array[i-1, j-1] == 1)
          {
            neighbourCount++;
          }
          if (array [i, j-1] == 1)
          {
            neighbourCount++;
          }if (array [i+1, j-1] == 1)
          {
            neighbourCount++;
          }if (array [i-1, j] == 1)
          {
            neighbourCount++;
          }if (array [i+1, j] == 1)
          {
            neighbourCount++;
          }if (array [i-1, j+1] == 1)
          {
            neighbourCount++;
          }if (array [i+1, j+1] == 1)
          {
            neighbourCount++;
          }
          
          //Console.WriteLine("number of neighbours is: " + neighbourCount);

// populate nextGenArray with decisions about whether cells are dead or alive

					if (neighbourCount < 2 || neighbourCount > 3)
					{
            nextGenArray [i,j] = 0;
          }else 
					{
							nextGenArray [i,j] = 1;
					}
      }
    }
		
		
		return nextGenArray;
  }
//The code that prints the game to the console
	public static void PrintGrid(int[,] array)
  {
		for (int i = 0; i < array.GetLength(0);  i ++)
		{
			
			for (int j = 0; j < array.GetLength(1); j++)
			{
					Console.Write (array[i,j]);
			}
			Console.WriteLine();
			
    }
		Console.WriteLine("----------");
  }
//Filling the grid with 1s and 0s
	public static int[,] PopGrid(int[,] array)
  {
		Random random = new Random();
		for (int i = 0; i < array.GetLength(0);  i ++)
		{
			
			for (int j = 0; j < array.GetLength(1); j++)
			{
					array[i,j] = random.Next(2) ;
			}
		
    }		
		
		return array;
  }
}