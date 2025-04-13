// See https://aka.ms/new-console-template for more information
using System;
using tpmodul8_103022300078;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();

        // satuannya diubah duls
        config.UbahSatuan();  

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        bool suhuNormal = false;
        if (config.satuan_suhu == "celcius")
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        else if (config.satuan_suhu == "fahrenheit")
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;

        bool hariAman = hariDemam < config.batas_hari_deman;

        if (suhuNormal && hariAman)
            Console.WriteLine(config.pesan_diterima);
        else
            Console.WriteLine(config.pesan_ditolak);
    }
}

