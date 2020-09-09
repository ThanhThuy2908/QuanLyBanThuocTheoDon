using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.XtraEditors;
using System.Configuration;

namespace QuanLyPhongKhamNhi
{

    class KetNoi
    {
        public static string today()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            if (int.Parse(day) < 10) day = "0" + day;
            if (int.Parse(month) < 10) month = "0" + month;
            return year + "-" + month + "-" + day;
        }
        public SqlConnection connection = new SqlConnection();

        public KetNoi()
        {
            try
            {
                connection.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
                connection.Open();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
    }
       
}
