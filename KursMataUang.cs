// 9. Kurs Mata Uang

using System;

public class KursMataUang
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("=============KURS MATA UANG==========");
        Console.WriteLine ("=====per 14 April 2024 pukul 06.00 WIB=====");
        Console.WriteLine ("Silahkan pilih konversi mata uang yang sesuai:");
        Console.WriteLine ("1. Rupiah Indonesia (Rp) >> Dollar Amerika (USD)");
        Console.WriteLine ("2. Dollar Amerika (USD) >> Rupiah Indonesia (Rp)");
        Console.WriteLine ("3. Rupiah Indonesia (Rp) >> Ringgit Malaysia (RM)");
        Console.WriteLine ("4. Ringgit Malaysia (RM) >> Rupiah Indonesia (Rp)");
        Console.WriteLine ("5. Rupiah Indonesia (Rp) >> Dollar Singapura (SGD)");
        Console.WriteLine ("6. Dollar Singapura (SGD) >> Rupiah Indonesia (Rp)");
        Console.Write ("Masukkan pilihan Anda (1/2/3/4/5/6): ");
        int pilihan = Convert.ToInt32(Console.ReadLine());
        
        
        
        switch (pilihan){
            case 1 :
            Console.WriteLine ("===Kurs Rupiah Indonesia (Rp) >> Dollar Amerika (USD)===");
            Console.Write ("Masukkan nilai mata uang: ");
            double rpUsd = Convert.ToDouble(Console.ReadLine());
            rupiahUSD(rpUsd);
            break;
            
            case 2 :
            Console.WriteLine ("===Dollar Amerika (USD) >> Rupiah Indonesia (Rp)===");
            Console.Write ("Masukkan nilai mata uang: ");
            double usdRp = Convert.ToDouble(Console.ReadLine());
            dollarUSRp(usdRp);
            break;
            
            case 3 :
            Console.WriteLine ("===Rupiah Indonesia (Rp) >> Ringgit Malaysia (RM)===");
            Console.Write ("Masukkan nilai mata uang: ");
            double rpRM = Convert.ToDouble(Console.ReadLine());
            rupiahRinggit(rpRM);
            break;
            
            case 4 :
            Console.WriteLine ("===Ringgit Malaysia (RM) >> Rupiah Indonesia===");
            Console.Write ("Masukkan nilai mata uang: ");
            double rmRp = Convert.ToDouble(Console.ReadLine());
            ringgitRp(rmRp);
            break;
            
            case 5 :
            Console.WriteLine ("===Rupiah Indonesia (Rp) >> Dollar Singapura (SGD)===");
            Console.Write ("Masukkan nilai mata uang: ");
            double rpSGD = Convert.ToDouble(Console.ReadLine());
            rupiahSingapura(rpSGD);
            break;
            
            case 6 :
            Console.WriteLine ("===Dollar Singapura (SGD) >> Rupiah Indonesia (Rp)===");
            Console.Write ("Masukkan nilai mata uang: ");
            double sgdRp = Convert.ToDouble(Console.ReadLine());
            dollarSGRp(sgdRp);
            break;
            
            default :
            Console.WriteLine ("pilihan tidak valid! silahkan pilih 1/2/3/4/5/6");
            break;
        }
    }
    
    static void rupiahUSD (double rupiah){
        double dollar = rupiah * 0.000062;
        Console.WriteLine ($"kurs dari Rp{rupiah} adalah USD{dollar}");
    }
    
    static void dollarUSRp (double dollar){
        double rupiah = dollar * 16117.80;
        Console.WriteLine ($"kurs dari USD{dollar} adalah Rp{rupiah}");
    }
    
    static void rupiahRinggit (double rupiah){
        double ringgit = rupiah * 0.00030;
        Console.WriteLine ($"kurs dari Rp{rupiah} adalah RM{ringgit}");
    }
    
    static void ringgitRp (double ringgit){
        double rupiah = ringgit * 3378.99;
        Console.WriteLine ($"kurs dari RM{ringgit} adalah Rp{rupiah}");
    }
    
    static void rupiahSingapura (double rupiah){
        double dollar = rupiah * 0.000084;
        Console.WriteLine ($"kurs dari Rp{rupiah} adalah SGD{dollar}");
    }
    
    static void dollarSGRp (double dollar){
        double rupiah = dollar * 11863.71;
        Console.WriteLine ($"kurs dari SGD{dollar} adalah Rp{rupiah}");
    }
}