using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertGioia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From Nigeria");

            /*int age = 5;
            string string1 = "a";
            string string2 = "bird";
            string strin3 = "I eat pizza";
            char char1 = 'a';
            char char2 = 'b';
            char char3 = 'c';

            bool complete = false;
            bool incomplete = true;
            */



            //Conditionals
            //if elseif and else statement

            //bool complete = true;
            //bool started = true;
            //int x;
            //if (complete)
            //{
            //     x = 5;
            //}else if (started)
            //{
            //    x = 3;
            //}
            //else { x = 1; 
            //}

            //Loops
            List<string> collection = new List<string>() { "a", "b", "c" };
            for (int i=0; i<collection.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(collection[i]);
            }


            int ii = 3;
            while (ii > 0)
            {
                System.Diagnostics.Debug.WriteLine("Loading");
                ii--;
            }

            PrintHi();
            PrintHi();
            ExampleFunction();

            int x = 0;
            int valueb = 0;
            bool isGreater = (x > valueb) ? true : false;



         //   null coalese operator
            object obj = null;
            object obj2 = obj ?? new object();

        //sizeof()


        //operatoroverloading



        }

        static void PrintHi()
        {
            bool b = "abc" is string;
            System.Diagnostics.Debug.WriteLine(b);
            System.Diagnostics.Debug.WriteLine("Hi");
        }

        public static void ExampleFunction()
        {
            int number = 4;
            number++;
            int number2 = 8;
            number2--;
            System.Diagnostics.Debug.WriteLine("Haloo");
        }

        /*
        string s1 = "abc";
        object obj1 = s1;
        string s2 = obj1 as string;
        */



    }

    class Box
    {
        private int length;
        private int width;
        private int height;

        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        } 

        public int GetLength()
        {
            return length;
        }

        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.GetLength() + box2.GetLength(), box1.GetWidth() + box1.GetLength());
        }
    }
}
