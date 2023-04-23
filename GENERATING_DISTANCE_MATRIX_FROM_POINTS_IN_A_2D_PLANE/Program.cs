using System;

namespace GENERATING_DISTANCE_MATRIX_FROM_POINTS_IN_A_2D_PLANE
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] euclideanSpace = GenerateSpace();

            ShowSpace(euclideanSpace);

            double[,] distanceMatrix = DistanceMatrixProductor(euclideanSpace);

            ShowMatrix(distanceMatrix);

        }

        static double[,] GenerateSpace() //space generator
        {
            Random random = new Random();

            Console.Write("Please Enter Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[,] EuclideanSpace = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                EuclideanSpace[i, 0] = random.NextDouble() * width;
                EuclideanSpace[i, 1] = random.NextDouble() * height;
            }

            return EuclideanSpace;

        }

        static void ShowSpace(double[,] givenSpace) //random points
        {
            Console.WriteLine("\n\n*****************************************************************************\n\n");
            for (int i = 0; i < givenSpace.GetLength(0); i++)
            {
                
                Console.WriteLine($"X:{givenSpace[i, 0].ToString("F")}   Y:{givenSpace[i, 1].ToString("F")}");
                           
            }

            Console.WriteLine("\n\n*****************************************************************************\n\n");
        }

        static double[,] DistanceMatrixProductor(double[,] givenSpace)  
        {
            double[,] distanceMatrix = new double[givenSpace.GetLength(0), givenSpace.GetLength(0)];

            for (int s = 0; s < givenSpace.GetLength(0); s++)
            {
                for (int p = 0; p < givenSpace.GetLength(0); p++)
                {
                    //distance formula:
                    double temp = Math.Sqrt(Math.Pow(givenSpace[s, 0] - givenSpace[p, 0], 2) + Math.Pow(givenSpace[p, 1] - givenSpace[p, 1], 2));
                    distanceMatrix[s, p] = temp;
                }
            }


            return distanceMatrix;
        }

        static void ShowMatrix(double[,] givenMatrix) //the method that shows distance matrix table
        {
            int k = 0;
            
            while (k < givenMatrix.GetLength(0)) {
                Console.Write("   ");
                Console.Write(k);
                Console.Write("    ");
                k++;
                if (k == givenMatrix.GetLength(0))
                {
                    Console.WriteLine();
                }
                  }
            for (int i= 0;i<givenMatrix.GetLength(0); i++)
            {
                Console.Write(i);
                Console.Write("|");
                for (int j=0; j < givenMatrix.GetLength(0); j++)
                {
                    Console.Write($"{givenMatrix[i, j].ToString("F")}\t");
                } 
                Console.WriteLine();  
            }
            Console.WriteLine("\n\n*****************************************************************************\n\n");

        }
    } 
}
