using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class StackGeneric<T>
    {
        private T[] Dizi { get; set; }
        private int sonElemaninIndisNumarasi;

        public StackGeneric()
        {
            Dizi = new T[100];
            sonElemaninIndisNumarasi = 0;
        }

        public void Push(T item)
        {
            Dizi[sonElemaninIndisNumarasi] = item;
            sonElemaninIndisNumarasi++;
        }

        public T Pop()
        {
            var element = Dizi[sonElemaninIndisNumarasi];
            Dizi[sonElemaninIndisNumarasi] = default(T);
            sonElemaninIndisNumarasi--; ;
            return element;
        }

    }

//Generic olmadan
    //public class StackString
    //{
    //    private string[] Dizi { get; set; }
    //    private int sonElemaninIndisNumarasi;

    //    public StackString()
    //    {
    //        Dizi = new string[100];
    //        sonElemaninIndisNumarasi = 0;
    //    }

    //    public void Push(string item)
    //    {
    //        Dizi[sonElemaninIndisNumarasi] = item;
    //        sonElemaninIndisNumarasi++;
    //    }

    //    public string Pop()
    //    {
    //        sonElemaninIndisNumarasi--; ;

    //        var element = Dizi[sonElemaninIndisNumarasi];
    //        Dizi[sonElemaninIndisNumarasi] = "";
    //        return element;
    //    }

    //}

    //public class StackInt
    //{
    //    private int[] Dizi { get; set; }
    //    private int sonElemaninIndisNumarasi;

    //    public StackInt()
    //    {
    //        Dizi = new int[100];
    //        sonElemaninIndisNumarasi = 0;
    //    }

    //    public void Push(int item)
    //    {
    //        Dizi[sonElemaninIndisNumarasi] = item;
    //        sonElemaninIndisNumarasi++;
    //    }

    //    public int Pop()
    //    {
    //        sonElemaninIndisNumarasi--; ;

    //        var element = Dizi[sonElemaninIndisNumarasi];
    //        Dizi[sonElemaninIndisNumarasi] = 0;
    //        return element;
    //    }

    //}
}
