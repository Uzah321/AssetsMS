using System;
using System.Data;
using System.Data.SqlClient;

namespace AssetsMS
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;

        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        public ConnectionState State { get; internal set; }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            // Sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            Cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;

        }

        internal void SetData(SqlCommand cmd)
        {
            throw new NotImplementedException();
        }
    }


}
