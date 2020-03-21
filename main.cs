using System;
using System.Timers;
using System.Threading;

class MainClass {
	public static decimal restartDelay;
  public static void Main (string[] args) 
	{
	

			int[,] array = new int[10, 10];

			array = PopGrid (array);

//im trying to get user input to tell the code how fast to loop(store the value of an integer)
// MR W: You should be able to figure that out from the code below.
//yea it looks a lot better now thanks a lot



Console.WriteLine("How many times?");
Console.WriteLine("Enter choice: ");
string input = Console.ReadLine();

int numberOfLoops = Int32.Parse(input);

Console.WriteLine("How FAST?");
Console.WriteLine("Enter choice: ");
string speed = Console.ReadLine();

int restartDelay = Int32.Parse(speed);
//float restartDelayy = 1 / restartDelay;


for(int i = 1; i < numberOfLoops; i++)
{

  PrintGrid(array); 

  array = NextGen(array); // get the next array

  Thread.Sleep(TimeSpan.FromSeconds(1/restartDelay)); // sleep for one sec

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