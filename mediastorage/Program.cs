using MediaStorage.Classes;
using System;

namespace MediaStorage
{
    class Program
    {
        static void Main(string[] args)
        {
          

            PlayList pl = new PlayList(name: "My play list");
         
            Console.WriteLine(pl.Name);

            Console.ReadLine();
        }
    }
}
