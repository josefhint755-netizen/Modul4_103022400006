using System;
using System.Collections.Generic;
using System.Text;


    public class KodePaket
    {
        public string getKodePaket(string namaPaket)
        {
            Dictionary<string, string> tabelKodePaket = new Dictionary<string, string>
            {
                {"Basic", "P201"},
                {"Standard", "P202"},
                { "Premium", "P203" },
                { "Unlimited", "P204" },
                { "Gaming", "P205"},
                { "Streaming", "P206" },
                {"Family", "P207" },
                { "Business", "P208"},
                { "Student", "P209"},
                { "Traveler", "P210"},
            };

                if (tabelKodePaket.ContainsKey(namaPaket))
                    return tabelKodePaket[namaPaket];
                else
                    return "Kode paket tidak ditemukan";
        }
    }

