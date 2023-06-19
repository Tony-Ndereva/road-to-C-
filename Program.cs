using System;

namespace road_to_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            try
            {
                //string number = "12345";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
                int x = 1;
                int y = x++;
                Console.WriteLine("x: {0}, y:{1}", x, y);
            }
            catch (Exception)
            {
                Console.WriteLine("The number couldnt be converted to a byte");
            }
        }
    }
}

