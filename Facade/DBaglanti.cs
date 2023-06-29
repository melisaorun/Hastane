using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facade
{
    internal class DBaglanti
    {
       public static readonly SqlConnection conn = new SqlConnection("Server=.;Database=Hastane;Trusted_Connection=True;");

        public static bool exec(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                    return komut.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State != ConnectionState.Closed)
                {
                    komut.Connection.Close();
                }
            }
            return true;
        }
    }

    
}
