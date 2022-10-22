using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.netEx
{
    internal class branManager : IManager<Brand>
    {
        SqlConnection conn;  // bağlantı
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand cmd;   // kayıt ekle-silme-güncelleme için kullancak


        public branManager()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=DESKTOP-74OJSGD;Database=catoDeneme;Trusted_Connection=True;";
        }

        public void Add(Brand obj)
        {
            cmd = new SqlCommand();
         
            cmd.CommandText = "Insert Into brands(brandName) Values(@name)";
            cmd.Parameters.AddWithValue("@name", obj.brandName);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery(); 
            conn.Close();
        }

        public void Delete(int id)
        {
            //tablolar ilişkili olduğu için foreign key ilişkisi Cascade olmalı
            cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM brands WHERE brandId=@id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetAll()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("Select * from brands", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }


    }
}
