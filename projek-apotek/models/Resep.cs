using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_apotek.models
{
    internal class Resep
    {
        public int id { get; set; }
        public string no_resep { get; set; }
        public DateTime tgl_resep { get; set; }
        public string nama_pasien { get; set; }
        public string nama_dokter{ get; set; }
        public string obat_resep{ get; set; }
        public int stok { get; set; }

        public int addData(Resep resep)
        {
            string sql = "INSERT INTO resep(no_resep, tgl_resep, nama_pasien, nama_dokter, obat_resep, stok) values(@no_resep, @tgl_resep, @nama_pasien, @nama_dokter, @obat_resep, @stok)";
            var args = new Dictionary<string, object>
            {
                {"@no_resep", resep.no_resep},
                {"@tgl_resep", resep.tgl_resep.ToString("yyyy-MM-dd HH:mm:ss") },
                {"@nama_pasien", resep.nama_pasien },
                {"@nama_dokter", resep.nama_dokter },
                {"@obat_resep", resep.obat_resep },
                {"@stok", resep.stok},
            };

            int n = Connect.executeWrite(sql, args);
            return n;
        }

        public int editData(Resep resep)
        {
            string sql = "UPDATE obat SET no_resep = @no_resep, tgl_resep = @tgl_resep, nama_pasien = @nama_pasien, nama_dokter = @nama_dokter, obat_resep = @obat_resep, stok=@stok WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", resep.id },
                {"@no_resep", resep.no_resep },
                {"@tgl_resep", resep.tgl_resep.ToString("yyyy-MM-dd HH:mm:ss") },
                {"@nama_pasien", resep.nama_pasien },
                {"@nama_dokter", resep.nama_dokter },
                {"@obat_resep", resep.obat_resep },
                {"@stok", resep.stok },
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }
        public int deleteData(Resep resep)
        {
            string sql = "DELETE FROM resep WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", resep.id },
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }
        public void getData(String search, DataGridView dg)
        {
            string sql = $"SELECT * FROM resep {(String.IsNullOrEmpty(search) ? "" : $"WHERE no_resep Like '%(search)%'")}ORDER BY id DESC";
            var data = Connect.getData(sql);
            dg.DataSource = data;
        }
    }
}
