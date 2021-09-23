using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class Connection
    {
     
           public static SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbYazOkulu;Integrated Security=True");
           
        
    }
}
