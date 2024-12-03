using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yıldız Oluşturma
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.ReadKey();
            #endregion

            #region Alt Alta 10 Yıldız Oluşturma, Her Satırda 10 Adet Yıldız Olsun.
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            //Console.ReadKey();
            #endregion

            #region Dik Üçgen
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region Ters Dik Üçgen        
            //for (int i = 5; i >= 1; i--) 
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region Üçgen Simetrisi
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }
            for (int k = 4; k >=1; k--)
            {
                for (int l = 0; l <=k; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } 
            Console.ReadKey();
            #endregion

            #region Piramit
            int star = 5;
            for (int i = 1; i <  star; i++)
            {
                for (int i   = 0; i < length; i++)
                {

                }
            }
           
            
                
           
            #endregion
        }

    }
}
