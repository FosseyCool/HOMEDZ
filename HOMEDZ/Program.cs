using System;
using DZ;

namespace HOMEDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var communication = new Communication();
            communication.Dialog();
            communication.RemoveAllBooking();
        }
    }
}