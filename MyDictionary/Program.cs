using System;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionarys = new MyDictionary<int, string>();
            dictionarys.Add(0, "Başak");
            dictionarys.Add(1, "Selin");
            dictionarys.Add(2, "Batuhan");
            dictionarys.Add(3, "Yaren");

            Console.WriteLine("-----Listele-----");
            dictionarys.List();
           
        }
    }
}