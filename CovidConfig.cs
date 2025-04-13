using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace tpmodul8_103022300078
{
    public class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        private const string filePath = "covid_config.json";

        public CovidConfig()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var config = JsonSerializer.Deserialize<CovidConfig>(json);
                satuan_suhu = config.satuan_suhu;
                batas_hari_deman = config.batas_hari_deman;
                pesan_ditolak = config.pesan_ditolak;
                pesan_diterima = config.pesan_diterima;
            }
            else
            {
                satuan_suhu = "celcius";
                batas_hari_deman = 14;
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            }
        }
        public void UbahSatuan()
        {
            satuan_suhu = satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
        }
    }
}



