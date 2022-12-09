using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] rastgeleSayilar = new int[10];
            int enBuyukPuan = 0;
            int enBuyukPuan_index = 0;
            for(int i = 0; i<rastgeleSayilar.Length;i++)
            {
                rastgeleSayilar[i] = rnd.Next(1,10);
            }
            int tahminSayi;
            Console.Write("Oyuncu Sayısını Giriniz : ");
            int oyuncuSayisi = Convert.ToInt32(Console.ReadLine());
            int[] puan = new int[oyuncuSayisi];
            byte oyuncu = 0;

            Console.Clear();

            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {   
                while(true)
                {
                    Console.WriteLine($"{i + 1}. Soru\n**************************");
                    Console.Write($"{oyuncu + 1}.Oyuncu Tahminizi Giriniz : ");
                    
                    tahminSayi = Convert.ToInt32(Console.ReadLine());

                    if (rastgeleSayilar[i] == tahminSayi)
                    {
                        Console.WriteLine("Doğru Tahmin Ettiniz");
                        puan[oyuncu] += 10;
                    }
                    else
                    {
                        if (rastgeleSayilar[i] > tahminSayi)
                        {
                            puan[oyuncu] += 10 - (rastgeleSayilar[i] - tahminSayi);
                        }

                        else
                        {
                            puan[oyuncu] += 10 - (tahminSayi - rastgeleSayilar[i]);
                        }

                        Console.WriteLine("Yanlış Tahmin Ettiniz");
                    }

                    Console.Clear();

                    if (oyuncu == (oyuncuSayisi - 1))
                    {
                        for (int s = 0; s < oyuncuSayisi; s++)
                        {
                            Console.WriteLine($"{s + 1}. Oyuncunun Puanı : {puan[s]}");

                        }
                        Console.Write("Devam Etmek İçin Herhangi Bir Tuşa Basınız ...");
                        Console.ReadKey();
                        Console.Clear();
                        oyuncu = 0;
                        break;
                    }
                    else
                    {
                        oyuncu++;
                    }
                }
                
            }   
            for(int i = 0; i<oyuncuSayisi; i++)
            {
                
                if (puan[i] > enBuyukPuan)
                {
                    enBuyukPuan = puan[i];
                    enBuyukPuan_index = i;
                }
            }
            for (int s = 0; s < oyuncuSayisi; s++)
            {
                Console.WriteLine($"{s + 1}. Oyuncunun Puanı : {puan[s]}");

            }
            Console.Write($"Kazanan Oyuncu {enBuyukPuan_index+1}. Oyuncu Tebrikler !!");
            Console.ReadKey();
        }
    }
}
