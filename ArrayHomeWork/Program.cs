using System;

namespace ArrayHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region second
            int[] Arr = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int trys = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                int trys1 = 0;
                while (trys <= 30)
                {
                    Console.WriteLine("enter a number from 1-10");
                    int x = int.Parse(Console.ReadLine());


                    if (Array.IndexOf(Arr, x) == i)
                    {
                        Console.WriteLine("good");
                        Console.WriteLine("you successded after{0}", trys1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                        trys += 1;
                        trys1 += 1;
                        continue;
                    }

                }
                
                    Console.WriteLine("all general trys {0}", trys);
            }
            #endregion

            //#region third
            //int[,] Arr2 = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 4, 3, 5, 2, 6 }, { 8, 9, 7, 2, 5, } , { 5, 3, 4, 6, 1 } };
            //Console.WriteLine("enter number");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 0; i < Arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr2.GetLength(1); j++)
            //    {
            //        if (Arr2[i, j] == x)
            //        {
            //            Console.WriteLine("the number in row {0} and Colum {1}", i, j);
            //        }

            //    }
            //}
            //#region question Fourth
            //int[,] Arr2 = new int[10, 10];
            //for (int i = 0; i < Arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr2.GetLength(1); j++)
            //    {
            //        Arr2[i, j] = (i + 1) * (j + 1);
            //        Console.Write(Arr2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //#endregion



            //#region question six
            //int[,,] ihatemylifeArray = new int[2, 2, 2];
            //for (int i = 0; i < ihatemylifeArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ihatemylifeArray.GetLength(1); j++)
            //    {
            //        for (int r = 0; r < ihatemylifeArray.GetLength(1); r++)
            //        {
            //            Console.WriteLine("enter number from 1 - 10");
            //            int x = int.Parse(Console.ReadLine());
            //            ihatemylifeArray[i, j, r] = x;

            //        }
            //    }
            //}

            //for (int i = 0; i < ihatemylifeArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ihatemylifeArray.GetLength(1); j++)
            //    {
            //        for (int r = 0; r < ihatemylifeArray.GetLength(1); r++)
            //        {
            //            Console.WriteLine(ihatemylifeArray[i, j, r]);

            //        }
            //    }
            //}




            //#endregion




            #region seven
            //int[,] Arr3 = new int[6, 4];
            //string star = "*";
            //for (int i = 0; i < Arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr3.GetLength(1); j++)
            //    {
            //        Console.Write(star);
            //    }
            //    Console.WriteLine();
            //}



            #region eight
            int[][]kaboom = new int[3][];
            kaboom[0] = new int[2];
            kaboom[1] = new int[2];
            kaboom[2] = new int[2];
            for (int i = 0; i < kaboom.Length; i++)
            {
                for (int j = 0; j < kaboom[i].Length; j++)
                {
                    Console.WriteLine("enter number");
                    kaboom[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < kaboom.Length; i++)
            {
                for (int j = 0; j < kaboom[i].Length; j++)
                {
                    Console.WriteLine(kaboom[i][j]);
                  
                }
            }





            #endregion

            #endregion



        }
    }
}
