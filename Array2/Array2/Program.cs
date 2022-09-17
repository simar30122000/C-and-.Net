using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array");
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            for (int i=0;i<10;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Select the Funtion to be Performed\n1-Elements in Descending order\n2-min and max Values\n3-Sum after adding all numbers");
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            switch (c)
            {
                case 1:
                    {
                        for(int i=0; i<10;i++)
                        {
                                d++;
                            for(int j = d; j < 10; j++)
                            {
                                int temp;
                                if (arr1[j] > arr1[i])
                                {
                                    temp = arr1[i];
                                    arr1[i] = arr1[j];
                                    arr1[j] = temp;
                                }
                            }
                        }
                       
                        foreach(int k in arr1)
                            {
                            Console.Write("reverse arra is "+ k +" ");
                            }
                        break;

                    }
                case 2:
                    {
                        int min = arr1[0], max = arr1[0];
                        for (int i = 0; i < 9; i++)
                        {
                          if(arr1[i+1]>arr1[i])
                            {
                                max = arr1[i + 1];
                            }
                            else
                            {
                                min = arr1[i + 1];
                            }
                        }
                         Console.Write("max and min values are " + max +" and "+ min);
                        
                        break;

                    }
                case 3:
                    {
                        
                        for (int i = 0; i < 10; i++)
                        {
                            d += arr1[i];
                        }
                        Console.Write("sum of elements are "+d);

                        break;
                    }
                    }

        }
    }
}
