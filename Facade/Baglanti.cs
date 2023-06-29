using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Facade
{
    
    public class Baglanti
    {
        public static readonly SqlConnection conn = new SqlConnection("Server=.;Database=Hastane;Trusted_Connection=True;");
    }
}
