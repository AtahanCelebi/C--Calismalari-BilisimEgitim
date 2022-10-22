using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.netEx
{
    internal class productManager : IManager<Product>
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand cmd;
        public productManager()
        {
            
            conn = new SqlConnection();
            conn.ConnectionString = "Server=DESKTOP-74OJSGD;Database=catoDeneme;Trusted_Connection=True;";



        }
        public void Add(Product obj)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "Insert Into product(productName,categoryId,brandId) Values(@pName,@cId,@bId)";
            cmd.Parameters.AddWithValue("@pName", obj.productName);
            cmd.Parameters.AddWithValue("@cId", obj.categoryId);
            cmd.Parameters.AddWithValue("@bId", obj.brandId);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery(); 
            conn.Close();
        }

        public void Delete(int id)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "DELETE product WHERE productId=@pID";
            cmd.Parameters.AddWithValue("@pID", id);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetAll()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("Select * from product", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
