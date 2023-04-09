using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_apotek
{
    internal class LoginSession
    {
        public static int id;
        public static string username;
        public static string password;
        public static string nama;
        public static string tipe;
        public static void insertLog(string aktifitas)
        {
            string sql = "INSERT INTO log values(@waktu, @aktifitas, @user_id)";
            var args = new Dictionary<string, object>()
            {
                {"@waktu", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},
                {"@aktifitas", aktifitas},
                {"@user_id", LoginSession.id }
            };
            int n = Connect.executeWrite(sql, args);
            MessageBox.Show(n.ToString());
        }
    }
}
