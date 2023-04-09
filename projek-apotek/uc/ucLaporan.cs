using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_apotek.uc
{
    public partial class ucLaporan : UserControl
    {
        public ucLaporan()
        {
            InitializeComponent();
        }

        private void ucLaporan_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Name = "pendapatan";
        }
        private void loadLaporan()
        {
            string sql = $@"SELECT tgl_transaksi as ['tgl_transaksi'], SUM(total_bayar) as ['jumlah pendapatan] FROM transaksi WHERE tgl_transaksi BETWEEN '{dtTglMulai.Value.ToString("yyyy-MM-dd")}' AND '{dtTglAkhir.Value.ToString("yyyy-MM-dd")} 23:59:59' GROUP BY tgl_transaksi";
            var data = Connect.getData(sql);
            gdLaporan.DataSource = data;
            chart1.Series[0].Points.Clear();
            if(data.Rows.Count < 1)
            
                return;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                chart1.Series[0].Points.AddXY(Convert.ToDateTime(data.Rows[i][0].ToString()).ToString("yyyy-MM-dd"), Convert.ToDouble(data.Rows[i][1].ToString()));
                }
            

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            loadLaporan();
        }
    }
}
