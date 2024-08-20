using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom10_ShopQuanAo
{
    internal class DBConnect
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DOA5QPDJ;Initial Catalog=DATA_QUANAO;Integrated Security=True");

            public DBConnect()
            {

            }
            public void Open()
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

            }
            public void Close()
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            public int getNonQuery(string sql)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                int kq = cmd.ExecuteNonQuery();
                conn.Close();

                return kq;
            }

            public object getScalar(string sql)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object kq = cmd.ExecuteScalar();
                conn.Close();
                return kq;
            }

            public DataTable getTable(string sql)
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(ds);
                return ds.Tables[0];
            }



    }
}
