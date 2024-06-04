using System.Collections;

namespace Sube1.CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add(1);
            //al.Add("Ahmet");
            //al.Add(true);
            //al.Add("Ahmet");
            //al.Add(true);
            //al.Add("Ahmet");
            //al.Add(true);
            //al.Add("Ahmet");
            //al.Add(true);
            //al.Add(true);
            //al.Capacity = al.Count;
            //Console.WriteLine($"Capacity:{al.Capacity}\nCount:{al.Count}");

            //Sayı giriniz:10
            //Tamam/devam?devam
            //Sayı giriniz:20
            //Tamam/devam?tamam

            //var lst = new ArrayList();
            //do
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    lst.Add(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Tamam/Devam");
            //} while (Console.ReadLine().ToLower() == "d");

            //Console.WriteLine($"Girilen Sayıların Toplamı:{SayiTopla(lst)}");

            //int sayi = 10;//STACK
            //object number = sayi;//HEAP int->object : Boxing
            //int sayi2 = (int)number;//object->int: Unboxing

            //var lst = new ArrayList();
            //lst.Add(10);
            //lst.Add(20);
            //Console.WriteLine((int)lst[0] + (int)lst[1]);

            //var dizi = new int[2];//Type Safe
            //dizi[0] = 10;
            //dizi[1] = 20;
            //Console.WriteLine(dizi[0] + dizi[1]);

            var liste = new List<int>();
            liste.Add(10);
            liste.Add(20);
            Console.WriteLine(liste[0] + liste[1]);

            var t = new Test<int, string>();
            t.Veri1 = 10;
            t.Veri2 = 20;
            t.Veri3 = "Ali";

            var t1 = new Test<int, byte>();
            t1.Veri1 = 1;
            t1.Veri2 = 2;

        }

        public static int SayiTopla(ArrayList lst)
        {
            int sonuc = 0;
            foreach (var item in lst)
            {
                sonuc += (int)item;
            }
            return sonuc;
        }
    }

    //Generic Yapılar
    class Test<T, U> where T : struct
                     where U : class   //Generic Constraints
    {
        public T Veri1 { get; set; }
        public T Veri2 { get; set; }
        public U Veri3 { get; set; }
    }
}