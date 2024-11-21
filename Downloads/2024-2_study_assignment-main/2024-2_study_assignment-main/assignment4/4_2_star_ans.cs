using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);
            int[,] a = new int[radius * 2 , size + 2 * radius];
            
            for (int i = 0; i < radius * 2; i++)
            {
                for (int j = 0; j < 2 * radius; j++)
                {
                    if(i == 0)
                    {
                        a[i , j] = 1;
                    }
                    else if(i == radius * 2 - 1)
                    {
                        a[i , j] = 1;
                    }
                    
                    else if(j == 0)
                    {
                        a[i , j] = 1;
                    }
                    
                    else a[i , j] = 0;
                }
            }
            
            for (int i = 0; i < radius * 2; i++)
            {
                for (int j = radius * 2; j < 2 * radius + size; j++)
                {
                    if(i == (radius * 2) / 3)
                    {
                        a[i , j] = 1;
                    }
                    
                    else if(i == (2 * (radius * 2)) / 3)
                    {
                        a[i , j] = 1;
                    }
                    
                    else if(j == (size) / 3 + radius * 2)
                    {
                        a[i , j] = 1;
                    }
                    
                    else if(j == (size * 2) / 3 + radius * 2)
                    {
                        a[i , j] = 1;
                    }
                    
                    else a[i , j] = 0;
                }
            }
            
            for (int i = 0; i < radius * 2; i++)
            {
                for (int j = 0; j < 2 * radius + size; j++)
                {
                    if (a[i ,j] == 1)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/
