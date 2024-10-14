using System.ComponentModel;
using System.Threading.Channels;

namespace OOP_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adinizi giriniz: ");
            string adi = Console.ReadLine();

            Console.Write("Soyadinizi giriniz: ");
            string soyadi = Console.ReadLine();

            Console.Write("Boyunuzu giriniz: ");
            double boy = double.Parse(Console.ReadLine());

            Console.Write("Kilonuzu giriniz: ");
            double kilo = double.Parse(Console.ReadLine());

            double indeks = kilo / (boy * boy);
            Console.WriteLine("Vücut kitle indeksiniz: " + indeks);

            if (indeks < 18.5)
            {
                Console.WriteLine(adi + " Hanım/Bey kilonuz Zayıf aralığındadır.");
            }
            else if (18.5 <= indeks && indeks <= 24.9)
            {
                Console.WriteLine(adi + " Hanım/Bey kilonuz Normal Kilolu aralığındadır.");
            }
            else if (25.0 <= indeks && indeks <= 29.9)
            {
                Console.WriteLine(adi + " Hanım/Bey kilonuz Fazla Kilolu aralığındadır.");
            }
            else if (30.0 <= indeks && indeks <= 34.9)
            {
                Console.WriteLine(adi + " Hanım/Bey kilonuz Obez(1. derece obezite) aralığındadır.");
            }
            else if (35.0 <= indeks && indeks <= 39.9)
            {
                Console.WriteLine(adi + " Hanım/Bey kilonuz Aşırı Obez(2. derece obezite) aralığındadır.");
            }
            else if (indeks >= 40.0)
            {
                Console.WriteLine(adi + " Hanım/Bey kilonuz Morbid Obez(3. derece obezite) aralığındadır.");
            }
        }
    }
}