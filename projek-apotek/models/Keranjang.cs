﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projek_apotek.models
{
    internal class Keranjang
    {
        public string tipe_resep { get; set; }
        public string no_resep { get; set; }
        public string tgl_resep { get; set; }
        public string nama_pasien { get; set; }
        public string nama_dokter { get; set; }
        public string nama_obat { get; set; }
        public int obat_id { get; set; }
        public int resep_id { get; set; }
        public int user_id { get; set; }
        public int harga { get; set; }
        public int qty { get; set; }
        public int total_harga { get; set; }
    }
}
