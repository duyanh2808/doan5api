using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAL
{
    public class products
    {
        DataContext db = new DataContext();

        public DataTable getall()
        {
            DataTable dt = db.connect("EXEC pro_all");
            return dt;
        }
        /*public DataTable getone(int id)
        {

        }*/
    }
}
