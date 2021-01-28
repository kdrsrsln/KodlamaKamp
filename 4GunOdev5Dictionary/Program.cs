using System;
using System.Collections.Generic;

namespace _4GunOdev5Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<int,string> StudentList = new MyDictionary<int, string>();
            StudentList.Add(1,"Kadir");
            StudentList.Add(2,"Burak");


        }
    }
}
