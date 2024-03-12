﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box add(Box box1 , Box box2)
        {
            int l = box1.Length + box2.Length;
            int b = box1.Breadth + box2.Breadth;

            return new Box(l, b);
        }
    }

    class TestClass
    {
        static void Main()
        {
            Console.Write("Enter length of Box 1: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Enter length of Box 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Enter breadth of Box 1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Enter breadth of Box 2: ");
            int b2 = int.Parse(Console.ReadLine());

            Box box1 = new Box(l1, b1);
            Box box2 = new Box(l2, b2);

            Box box3 = Box.add(box1, box2);

            Console.WriteLine($"Box3 length is {box3.Length} and Box3 breadth is {box3.Breadth}");
            Console.Read();
        }
    }
}
