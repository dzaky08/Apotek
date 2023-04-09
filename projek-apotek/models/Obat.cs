using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_apotek
{
    internal class Obat
    {
        public int id { get; set; }
        public string kode_obat { get; set; }
        public string nama_obat { get; set; }
        public DateTime expired_date { get; set; }
        public long jumlah { get; set; }
        public long harga { get; set; }

        public int AddData(Obat obat)
        {
            string sql = "INSERT INTO obat(kode_obat, nama_obat, expired_date, jumlah, harga) values(@kode_obat, @nama_obat, @expired_date, @jumlah, @harga)";
            var args = new Dictionary<string, object>
            {
                {"@id", obat.id},
                {"@kode_obat", obat.kode_obat },
                {"@nama_obat", obat.nama_obat },
                {"@expired_date", obat.expired_date.ToString("yyyy-MM-dd") },
                {"@jumlah", obat.jumlah },
                {"@harga", obat.harga },
            };

            int n = Connect.executeWrite(sql, args);
            return n;
        }
        public int editData(Obat obat)
        {
            string sql = "UPDATE obat SET kode_obat = @kode_obat, nama_obat = @nama_obat, expired_date = @expired_date, jumlah = @jumlah, harga = @harga WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", obat.id },
                {"@kode_obat", obat.kode_obat },
                {"@nama_obat", obat.nama_obat },
                {"@expired_date", obat.expired_date.ToString("yyyy-MM-dd") },
                {"@jumlah", obat.jumlah },
                {"@harga", obat.harga },
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }
        public int deleteData(Obat obat)
        {
            string sql = "DELETE FROM obat WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", obat.id },
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }
        public void getData(String search, DataGridView dg)
        {
            string sql = $"SELECT * FROM obat {(String.IsNullOrEmpty(search) ?  "" : $"WHERE nama_obat LIKE '%{search}%' OR kode_obat LIKE '%{search}%' ")}ORDER BY id DESC";
            var data = Connect.getData(sql);
            dg.DataSource = data;
        }

    }
}
 