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
    public partial class ucLogActivity : UserControl
    {
        public ucLogActivity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
        private void getdata()
        {
            string sql = $"SELECT * FROM log INNER JOIN [user] ON log.user_id = [user].id WHERE waktu between '{dtEXP.Value.ToString("yyyy-MM-dd")}' AND '{dtEXP.Value.ToString("yyyy-MM-dd")} 23:59:59'ORDER BY log.id DESC";
            DataTable dt = Connect.getData(sql);
            Console.WriteLine(dt.Rows.Count);
            gdKelolaObat.DataSource = dt;
            gdKelolaObat.Columns[0].Visible = false;
            
        }

        private void ucLogActivity_Load(object sender, EventArgs e)
        {
            dtEXP.Value = DateTime.Now;
            getdata();
        }
    }
}
