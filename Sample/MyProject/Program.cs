﻿using System;
using NBitcoin;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World! " + new Key().GetWif(Network.Main));
        }
    }
}
