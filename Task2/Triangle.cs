﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Triangle::draw() method.");
        }
    }
}