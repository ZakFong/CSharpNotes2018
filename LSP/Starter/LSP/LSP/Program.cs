﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public class Square : Rectangle
    {
        private int _height;
        private int _width;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value; _width = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value; _height = value;
            }
        }
    }

    public class LSPBehavior
    {
        public static void Method(Rectangle s)
        {
            s.Height = 8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Height = 5;
            LSPBehavior.Method(square);

            Console.WriteLine($"Square Width={square.Width} Height={square.Height}");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

        }

    }
}
