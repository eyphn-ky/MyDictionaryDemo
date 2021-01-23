using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ilPlaka = new MyDictionary<int, string>();
            ilPlaka.Add(1, "Adana");
            ilPlaka.Add(34, "İstanbul");
            ilPlaka.Add(36, "Kars");
            ilPlaka.Add(44, "Malatya");



            Console.WriteLine("Eleman Sayısı : " +ilPlaka.Count);             
            ilPlaka.GetAll();
            Console.ReadLine();




        }
        
    }
}
