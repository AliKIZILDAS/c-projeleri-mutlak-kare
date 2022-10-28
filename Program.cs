using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split(" ");
             int[] dizi=new int[s.Length];
            for (int i = 0; i < dizi.Count(); i++)
            {              
                dizi[i]=int.Parse((s[i]));              
            }
            int kucukToplam=0 ;
            double buyukToplam=0;
           
            for (int i = 0; i < s.Count(); i++)
            {
                if (dizi[i]<67)
                {                    
                    kucukToplam+=(67-dizi[i]);                    
                }
                else
                {
                   buyukToplam+=Math.Pow((dizi[i]-67),2);
                }                                
            }
            Console.WriteLine(kucukToplam+" "+buyukToplam);
        }
    }
}