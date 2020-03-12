using System;

class MainClass {
  public static void Main (string[] args) 
	{
			int[,] array = new int[10, 10];

      //array[0,0] = 5;
			array = PopGrid (array);
      

      PrintGrid(array);

      PrintGrid(NextGen(array));



  }
  
  public static int[,] NextGen(int[,] array)
  {

    int[,] nextGenArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 1; i < array.GetLength(0)-1;  i ++)
		{
			
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
          
          Console.WriteLine("number of neighbours is: " + neighbourCount);

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
  }

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