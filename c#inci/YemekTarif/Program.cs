using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarif
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string dosya_yolu = @"C:\Users\inciy\Desktop\yemek tarifi.txt";
                int malzemeMiktar;
                Yemek yemek = new Yemek();
                Console.Write("Yemeğin adını giriniz: ");
                yemek.yemekAdi = Console.ReadLine().ToUpper();
                Console.Write("Yemeğin Malzeme adedini giriniz: ");
                malzemeMiktar = int.Parse(Console.ReadLine());
                for (int i = 1; i < malzemeMiktar + 1; i++)
                {
                    Console.Write(i + ".Malzeme = ");
                    yemek.yemekTarifi += "\n"+i+"." + Console.ReadLine();
                }

                FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(yemek.yemekAdi);
                sw.Write(yemek.yemekTarifi);
                sw.Write("\n**************");
                sw.Flush();
                sw.Close();
                fs.Close();
                
                Console.Write("Başka tarif girecek misiniz ?(e/h): ");
                String onay = Console.ReadLine().ToLower();
                if (onay == "h")
                {
                    break;
                }
                else
                {
                    continue;
                }
                Console.ReadLine();
            }
               
            
            
        }
    }
}
