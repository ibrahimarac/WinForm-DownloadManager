using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Classes
{
    public class Helper
    {
        public static string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        //insert update delete
        public static int ExecuteNonQuery(string OleDbstr)
        {
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand cmd = new OleDbCommand(OleDbstr, con);
            int numRows = 0;
            try
            {
                con.Open();
                numRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return numRows;
        }

        //select
        public static OleDbDataReader ExecuteReader(string OleDbstr)
        {
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand cmd = new OleDbCommand(OleDbstr, con);
            OleDbDataReader reader = null;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                throw ex;
            }
            return reader;
        }

        //DataTable Çözümü
        public static DataTable ExecuteDataTable(string OleDbstr)
        {
            DataTable tbl = new DataTable();

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand cmd = new OleDbCommand(OleDbstr, con);
            OleDbDataReader reader = null;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return tbl;

        }
    }
}
