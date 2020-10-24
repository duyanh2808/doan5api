using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataContext
    {
        string str = @"Data Source=DESKTOP-OBM11D3\SQLEXPRESS;Initial Catalog=QLdungcuyte;Integrated Security=True";
        public DataTable connect(string st)
        {
            string strc = str;
            SqlConnection con = new SqlConnection(strc);
            SqlDataAdapter adap = new SqlDataAdapter(st, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;

        }
    }
}
