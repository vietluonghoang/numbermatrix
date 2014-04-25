using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MatrixOfNumber.entities;

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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            return conn;
        }

        private bool isMatrixExisted(string date)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0x5C63326EA8FE5D4BEA3993EE060D420805D3871B", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@date", date));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private bool isMatrixExisted(int mID)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0x0528B47FF8C838E234766BE87EB946D491A26943", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", mID));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool CreateNewMatrix(string date)
        {
            if (isMatrixExisted(date))
            {
                return false;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0x6C19805101D1D669B2E9BA781D0364D8F181CBF8", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@date", date));

                int rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataSet GetNumberByDate(string date)
        {
            if (!isMatrixExisted(date))
            {
                return null;
            }
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0xEE9FB7922FF90EE5289A02C326221F59FD6E3B60", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@date", date));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public DataSet GetSummaryByDate(string date)
        {
            if (!isMatrixExisted(date))
            {
                return null;
            }
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0xAEC155590515ECEA7114DD2C44E0C4C0AAB18FC4", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@date", date));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public bool AddNewNumber(string date, int kID, int nType, int nNumber, int nCoin)
        {
            if (!isMatrixExisted(date))
            {
                return false;
            }
            if (date==null||"".Equals(date) || kID <= 0 || nType < 0 || nType > 1 || nNumber < 0 || nNumber > 99 || nCoin <= 0)
            {
                return false;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0xE74A38DD1F48CF8D40A508DEB9BFAA4F1365959D", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@kID", kID));
                cmd.Parameters.Add(new SqlParameter("@nType", nType));
                cmd.Parameters.Add(new SqlParameter("@nNumber", nNumber));
                cmd.Parameters.Add(new SqlParameter("@nCoin", nCoin));
                int rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EditNumber(int nID, int mID, int kID, int nType, int nNumber, int nCoin)
        {
            if (!isMatrixExisted(mID))
            {
                return false;
            }
            if (mID<=0 || kID <= 0 || nType < 0 || nType > 1 || nNumber < 0 || nNumber > 99 || nCoin <= 0)
            {
                return false;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0x78E820B36D2D9209E2AEADA29312A77ED8944EFF", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mID", mID));
                cmd.Parameters.Add(new SqlParameter("@kID", kID));
                cmd.Parameters.Add(new SqlParameter("@nType", nType));
                cmd.Parameters.Add(new SqlParameter("@nNumber", nNumber));
                cmd.Parameters.Add(new SqlParameter("@nCoin", nCoin));
                cmd.Parameters.Add(new SqlParameter("@nID", nID));
                int rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataSet ViewNumberDetails(string date, int type, int number)
        {
            if (date == null || "".Equals(date) || type < 0 || type > 1 || number < 0 || number > 99 )
            {
                return null;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0xC1A85A147593329EB3FA7DF2169F1841A19ED805", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@nType", type));
                cmd.Parameters.Add(new SqlParameter("@nNumber", number));
                SqlDataAdapter adater = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adater.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataSet GetAllUsersByName(string name)
        {
            if (name.Contains("'"))
            {
                name = name.Replace("'", "\'");
            }
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0xA31081D6E1CEACE42E422F8F083BB43FFF72BC62", conn);
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
            SqlCommand cmd = new SqlCommand("_0xC11F856FAF031B6366B7A80A85575D92B80C7718", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", kID));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public bool AddNewCustomer(string blID, string bdID, string name, string contact, string balance)
        {
            if (blID.Contains("'") || bdID.Contains("'") || name.Contains("'") || contact.Contains("'") || balance.Contains("'"))
            {
                blID = blID.Replace("'", "\'");
                bdID = bdID.Replace("'", "\'");
                name = name.Replace("'", "\'");
                contact = contact.Replace("'", "\'");
                balance = balance.Replace("'", "\'");
            }
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0xA31081D6E1CEACE42E422F8F083BB43FFF72BC62", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@name", name));
            int rs = cmd.ExecuteNonQuery();
            if (rs > 0)
            {
                return false;
            }
            else
            {
                cmd = new SqlCommand("_0x99FE2A54A53B418F6C18E1622F6B94C1E7317B67", conn);
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

        public bool editCustomer(int kID, int blID, int bdID, string name, string contact, string balance)
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
            SqlCommand cmd = new SqlCommand("_0xC11F856FAF031B6366B7A80A85575D92B80C7718", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", kID));
            int rs = cmd.ExecuteNonQuery();
            if (rs > 0)
            {
                return false;
            }
            else
            {
                cmd = new SqlCommand("_0x4B708F61590164290B802B86C74A74CF2864C64A", conn);
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

        public DataSet GetUserHistoryByID(int kid, string from, string to)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0xEF764BA27A37B08323210DD3095708AC6EF242D5", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", kid));
            cmd.Parameters.Add(new SqlParameter("@startDate", from));
            cmd.Parameters.Add(new SqlParameter("@endDate", to));
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            ds.Tables.Add(tb);
            DataColumn col = new DataColumn("id", typeof(int));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("name", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("contact", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("oldLoBase", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("newLoBase", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("oldDeBase", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("newDeBase", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("oldBalance", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("newBalance", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("date", typeof(string));
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

        public DataSet GetLoBases()
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0xF50E76ED395AB44B7CA94F7F3940413873DF858D", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public bool CreateLoBase(string name, float coso)
        {
            if (name == null || "".Equals(name) || coso <= 0 )
            {
                return false;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0x9D179C376C3DFC6F5523717596D6F09A15F5A093", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@blName", name));
                cmd.Parameters.Add(new SqlParameter("@blBase", Math.Round(coso, 2)));
                int rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EditLoBase(int id, string name, float coso)
        {
            if (name == null || "".Equals(name) || coso <= 0)
            {
                return false;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0xE3AAA3771FEADA60F39A4346DE7BB2791C230A4D", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@blName", name));
                cmd.Parameters.Add(new SqlParameter("@blBase", Math.Round(coso, 2)));
                cmd.Parameters.Add(new SqlParameter("@blID", id));
                int rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataSet GetDeBases()
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0x55A67B7B1959BB180C83BA888B23000348D999B9", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public bool CreateDeBase(string name, float coso)
        {
            if (name == null || "".Equals(name) || coso <= 0)
            {
                return false;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0x288AE9A1CB904FA0E28D6DF8CC7428B0BC91881E", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@bdName", name));
                cmd.Parameters.Add(new SqlParameter("@bdBase", Math.Round(coso, 2)));
                int rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EditDeBase(int id, string name, float coso)
        {
            if (name == null || "".Equals(name) || coso <= 0)
            {
                return false;
            }
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0xE963EC92DC1515A89455430FADB535A3C215C689", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@bdName", name));
                cmd.Parameters.Add(new SqlParameter("@bdBase", Math.Round(coso, 2)));
                cmd.Parameters.Add(new SqlParameter("@bdID", id));
                int rs = cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataSet GetBaseHistoryByID(int type, int bid, string from, string to)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd=null;
            if (type == 0)
            {
                cmd = new SqlCommand("_0x097A173B2911C6AA916DB80E842CA479EC016DC8", conn);
            }
            else
            {
                cmd = new SqlCommand("_0x3A1579FE7C75BD14ED092AB90F18AD0BE8402191", conn);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", bid));
            cmd.Parameters.Add(new SqlParameter("@startDate", from));
            cmd.Parameters.Add(new SqlParameter("@endDate", to));
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            ds.Tables.Add(tb);
            DataColumn col = new DataColumn("hid", typeof(int));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("bid", typeof(int));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("bname", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("base", typeof(float));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("oldBaseName", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("newBaseName", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("oldBase", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("newBase", typeof(string));
            ds.Tables[0].Columns.Add(col);
            col = new DataColumn("date", typeof(string));
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
                row[8] = dv.GetDateTimeFromSeconds(double.Parse(dr[8].ToString()));

                ds.Tables[0].Rows.Add(row);
            }

            return ds;
        }

        public List<TypeNumber> getNumberType(DateTime date)
        {
            string datetime = String.Format("{0:d-M-yyyy}", date);
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0x25305CF24E12AE9A487726F813EF4FA65E08B9DD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@date", date));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            List<TypeNumber> lstNum=null;
            string[] title = { "Giải đặc biệt", "Giải nhất", "Giải nhì", "Giải ba", "Giải tư", "Giải năm", "Giải sáu", "Giải bảy" };
            if (ds.Tables[0].Rows.Count > 0)
            {
                Result result;
                string header = "KẾT QUẢ XỔ SỐ MIỀN BẮC NGÀY " + datetime;
                List<Prize> prz = new List<Prize>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    int i = int.Parse(row[1].ToString());

                    
                    Prize p = new Prize(title[i], row[2].ToString());
                    prz.Add(p);
                }
                result = new Result(datetime, header, prz);
                lstNum=result.getNumbers();
            }
            else
            {
                if ((DateTime.Now.Day - date.Day > 6 && DateTime.Now.Month == date.Month) 
                    || (DateTime.Now.Month > date.Month && ((DateTime.Now.Day + (30-date.Day))> 5)) 
                    || (DateTime.Now.Month < date.Month))
                {
                    return lstNum;
                }
                else
                {
                    GetDataFromWeb gdfw = new GetDataFromWeb();
                    Result result = gdfw.getResult(datetime);
                    lstNum = result.getNumbers();

                    foreach (Prize p in result.Prizes)
                    {
                        string res = p.Number;
                        int type = Array.IndexOf(title, p.Label);
                        cmd = new SqlCommand("_0x8717E176A570CC69C26D8636F31AEB0CCE91D48E", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@date", datetime));
                        cmd.Parameters.Add(new SqlParameter("@type", type));
                        cmd.Parameters.Add(new SqlParameter("@result", res));
                        int rs = cmd.ExecuteNonQuery();
                        if (rs <= 0)
                        {
                            return null;
                        }
                    }
                }
            }
            return lstNum;
        }

        public DataSet getResultByDate(DateTime date)
        {
            string datetime = String.Format("{0:d-M-yyyy}", date);
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0x25305CF24E12AE9A487726F813EF4FA65E08B9DD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@date", date));
            SqlDataAdapter adater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adater.Fill(ds);
            return ds;
        }

        public bool insertResult(Result result, DateTime date)
        {
            if (result.Prizes.Count < 1)
            {
                return false;
            }
            string datetime = String.Format("{0:d-M-yyyy}", date);
            string[] title = { "Giải đặc biệt", "Giải nhất", "Giải nhì", "Giải ba", "Giải tư", "Giải năm", "Giải sáu", "Giải bảy" };
            foreach (Prize p in result.Prizes)
            {
                string res = p.Number;
                int type = Array.IndexOf(title, p.Label);
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand("_0x8717E176A570CC69C26D8636F31AEB0CCE91D48E", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@date", datetime));
                cmd.Parameters.Add(new SqlParameter("@type", type));
                cmd.Parameters.Add(new SqlParameter("@result", res));
                int rs = cmd.ExecuteNonQuery();
                if (rs <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool refuseAll()
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand("_0xE8325BD3AD86A940F02D7DE4E59198B8737E60C1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int rs = cmd.ExecuteNonQuery();
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
