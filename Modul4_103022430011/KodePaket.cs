using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022430011
{
    public class KodePaket {
        private string[] daftarNama = {
            "Basic", "Standard", "Premium", "Unlimited", "Gaming", "Streaming", "Family", "Business", "Student", "Traveler"
        };

        private string[] daftarKode = {
            "P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P210"
        };

        public string getKodePaket(string namaPaket)
        {
            for (int i = 0; i < daftarNama.Length; i++)
            {
                if (daftarNama[i].Equals(namaPaket))
                {
                    return daftarKode[i];
                }
            }
            return "Kode tidak ditemukan";
        }
    }
}
