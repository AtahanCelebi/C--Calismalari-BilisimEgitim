using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.netEx
{
    internal class categoryManager : IManager<Category>
    {
        SqlConnection conn;  // bağlantı
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand cmd;   // kayıt ekle-silme-güncelleme için kullancak
        public categoryManager()
        {
            conn=new SqlConnection();
            conn.ConnectionString = "Server=DESKTOP-74OJSGD;Database=catoDeneme;Trusted_Connection=True;";


        }

        public void Add(Category obj)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "Insert Into category(categoryName) Values(@cName)";
            cmd.Parameters.AddWithValue("@cName", obj.categoryName);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "Delete from category Where categoryId=cId)";
            cmd.Parameters.AddWithValue("@cId", id);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetAll()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("Select * from category", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }

    
}
