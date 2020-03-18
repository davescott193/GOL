using System;

class MainClass {
  public static void Main (string[] args) 
	{
			int[,] array = new int[10, 10];

//array[0,0] = 5;
			array = PopGrid (array);
      
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