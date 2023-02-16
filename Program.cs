using System;



namespace W4Rectangle
{
    class Program
    {
        public static Random Random;
        static void Main(string[] args)
        {
            Random= new Random();

            Rectangle r = new Rectangle();
            

            


            int Lenght = (r.GetLeng());
            int Width = (r.GetWid());

            Console.WriteLine("please give me the max whole number");
            int max = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Please give me the minimum whole number");
            int min = Convert.ToInt32(Console.ReadLine());

            MakeRectangle(min,max,out Lenght, out Width);

            Console.WriteLine(" this is max " + max + " this is min " + min + " this is lenght " + Lenght + " this is width " + Width);


            int Area = Utility.Area(Lenght, Width);
            int Per = Utility.Perimeter(Lenght, Width);
            Console.WriteLine("Lenght : " + Lenght);
            Console.WriteLine("Width : " + Width);
            Console.WriteLine("Area : " + Area);
            Console.WriteLine("Perimeter : " + Per);

        }

        static void MakeRectangle(int min , int max, out int L1, out int W2)
        {
            L1 = Random.Next(min, max);
            
            W2 = Random.Next(min, max);


        }
    }

    class Rectangle
    {
        int Leng = 0; 
        int Wid = 0;

        public int GetLeng()
        {
            return Leng;

        }
        public int GetWid()
        {
            return Wid;
        }
    }

    class Utility
    {
        public static int  Area(int L1,int W2)
        {
            return L1 * W2;
        }
        public static int Perimeter(int L1, int W2)
        {
            return 2 * (L1 + W2);

        }
    }
}