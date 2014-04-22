using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace MatrixOfNumber.utilities
{
    class DataValidation
    {
        public DataValidation()
        {
        }

        public bool openUpCheck(string value)
        {
            try
            {
                //string src = "abcd";
                //string key = "2BB3B6E7519DB3278A839E077A8490E5A9378287";
                Encoding enc = Encoding.Unicode;

                if (!File.Exists("D:\\data"))
                {
                    refuseAll();
                    File.Create("D:\\data").Dispose();
                    TextWriter tw = new StreamWriter("D:\\data");
                    tw.WriteLine(EncryptText(value, enc));
                    tw.Close();
                    return true;
                }
                else
                {
                    StreamReader sr = new StreamReader("D:\\data");
                    string line = sr.ReadLine();

                    string encoded = EncryptText(value, enc);
                    if (encoded.Equals(line))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
            return false;
        }

        private bool refuseAll()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=IOWA;Initial Catalog=MatrixOfNumbers;Persist Security Info=True;User ID=sa;Password=123456";
            conn.Open();
            SqlCommand cmd = new SqlCommand("deleteAll", conn);
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

        private string EncryptText(string text, Encoding enc)
        {
            try
            {
                byte[] buffer = enc.GetBytes(text);
                SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
                return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
            return null;
        }

        public bool isEmpty(string text)
        {
            try
            {
                if (text.Equals(String.Empty))
                {
                    return true;
                }
                else
                {
                    if (text.Length <= 0)
                    {
                        return true;
                    }

                    if (text.Trim().Equals(String.Empty))
                    {
                        return true;
                    }

                    if (text.Trim().Equals(""))
                    {
                        return true;
                    }

                    if (text.Trim().Length <= 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
            return false;
        }

        public bool isFloat(string text)
        {
            try
            {
                float.Parse(text);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }            
        }

        public DateTime GetDateTimeFromSeconds(double seconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(seconds);
            DateTime baseDate = new DateTime(2010, 1, 1, 0, 0, 0);
            DateTime date = baseDate + ts;
            return date;
        }

        public double GetSecondsFromDateDiff(DateTime date)
        {
            DateTime baseDate=new DateTime(2010, 1, 1, 0, 0, 0);
            double secs = ((TimeSpan)(date - (baseDate))).TotalSeconds;
            return secs;
        }
    }
}
