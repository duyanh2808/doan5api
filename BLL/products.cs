using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;

namespace BLL
{
    public class products
    {
        public int id_id_pro { get; set; }
        public int id_type { get; set; }
        public string description_pro { get; set; }
        public string name_pro { get; set; }
        public float unit_price { get; set; }
        public float promotion_price { get; set; }
        public string image_pro { get; set; }
        public string unit { get; set; }
        public string new_pro { get; set; }
        public List<products> getlist(DataTable tb)
        {
            List<products> ds = new List<products>();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                products tg = new products();
                tg.id_id_pro = int.Parse(tb.Rows[i][0].ToString());
                tg.name_pro = tb.Rows[i][1].ToString();
                tg.id_type = int.Parse(tb.Rows[i][2].ToString());
                tg.description_pro = tb.Rows[i][3].ToString();
                tg.unit_price = float.Parse(tb.Rows[i][4].ToString());
                tg.promotion_price = float.Parse(tb.Rows[i][5].ToString());
                tg.image_pro = tb.Rows[i][6].ToString();
                tg.unit = tb.Rows[i][7].ToString();
                tg.new_pro = tb.Rows[i][8].ToString();
                ds.Add(tg);
            }
            return ds;
        }
        DAL.products pr = new DAL.products();

        public List<products> getall()
        {
            DataTable dt = pr.getall();
            List<products> ds = getlist(dt);
            return ds;
        }
    }

 }
