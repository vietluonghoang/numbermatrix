using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace MatrixOfNumber.utilities
{
    class DataConnection
    {
        private string connectionString = "Data Source=IOWA;Initial Catalog=MatrixOfNumbers;Persist Security Info=True;User ID=sa;Password=123456";
       
        public DataConnection()
        {

        }

        private SqlConnection getConnection()
        {
            SqlConnection conn=new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            return conn;
        }
        private bool isMatrixExisted(string date)
        {
            SqlConnection con = getConnection();
            return false;
        }

        public DataSet GetAllUsersByName(string name)
        {
            if (name.Contains("'"))
            {
                name=name.Replace("'", "\'");
            }
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("viewUserByName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@name", name));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public DataSet GetAllUsersByID(int kID)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("viewUserByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", kID));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public bool AddNewCustomer(string blID, string bdID, string name, string contact, string balance)
        {
            if (blID.Contains("'") ||bdID.Contains("'") ||name.Contains("'") || contact.Contains("'") || balance.Contains("'"))
            {
                blID = blID.Replace("'", "\'");
                bdID = bdID.Replace("'", "\'");
                name=name.Replace("'", "\'");
                contact = contact.Replace("'", "\'");
                balance = balance.Replace("'", "\'");
            }
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("viewUserByName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@name", name));
            int rs = cmd.ExecuteNonQuery();
            if (rs > 0)
            {
                return false;
            }
            else
            {
                cmd = new SqlCommand("createNewCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@blID", blID));
                cmd.Parameters.Add(new SqlParameter("@bdID", bdID));
                cmd.Parameters.Add(new SqlParameter("@kName", name));
                cmd.Parameters.Add(new SqlParameter("@kContact", contact));
                cmd.Parameters.Add(new SqlParameter("@kBalance", balance));
                rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool editCustomer(int kID,int blID,int bdID,string name,string contact,string balance)
        {
            if (blID <= 0 || bdID <= 0 || kID <= 0)
            {
                return false;
            }
            if (name.Contains("'") || contact.Contains("'") || balance.Contains("'"))
            {
                name = name.Replace("'", "\'");
                contact = contact.Replace("'", "\'");
                balance = balance.Replace("'", "\'");
            }
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("viewUserByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", kID));
            int rs = cmd.ExecuteNonQuery();
            if (rs > 0)
            {
                return false;
            }
            else
            {
                cmd = new SqlCommand("updateCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@kID", kID));
                cmd.Parameters.Add(new SqlParameter("@blID", blID));
                cmd.Parameters.Add(new SqlParameter("@bdID", bdID));
                cmd.Parameters.Add(new SqlParameter("@kName", name));
                cmd.Parameters.Add(new SqlParameter("@kContact", contact));
                cmd.Parameters.Add(new SqlParameter("@kBalance", balance));
                rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public DataSet GetLoBases()
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("getAllLoBase", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public DataSet GetDeBases()
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("getAllDeBase", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public DataSet GetUserHistoryByID(int kid,string from,string to)
        {            
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("viewUserHistoryByDate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", kid));
            cmd.Parameters.Add(new SqlParameter("@startDate", from));
            cmd.Parameters.Add(new SqlParameter("@endDate", to));
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            ds.Tables.Add(tb);
            DataColumn col=new DataColumn("id",typeof(int));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("name",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("contact",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("oldLoBase",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("newLoBase",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("oldDeBase",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("newDeBase",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("oldBalance",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("newBalance",typeof(string));
            ds.Tables[0].Columns.Add(col);
            col=new DataColumn("date",typeof(string));
            ds.Tables[0].Columns.Add(col);
            
            DataRow row;
            DataValidation dv = new DataValidation();
            while (dr.Read())
            {
                row = ds.Tables[0].NewRow();

                row[0] = dr[0];
                row[1] = dr[1];
                row[2] = dr[2];
                row[3] = dr[3];
                row[4] = dr[4];
                row[5] = dr[5];
                row[6] = dr[6];
                row[7] = dr[7];
                row[8] = dr[8];
                row[9] = dv.GetDateTimeFromSeconds(double.Parse(dr[9].ToString()));

                ds.Tables[0].Rows.Add(row);
            }

            return ds;
        }
    }
}
