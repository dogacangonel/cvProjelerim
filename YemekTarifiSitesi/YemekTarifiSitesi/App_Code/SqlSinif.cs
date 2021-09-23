using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SqlSinif
/// </summary>
public class SqlSinif
{
    public SqlConnection baglanti()
    {
        SqlConnection con=new SqlConnection( @"Data Source=.\SQLEXPRESS;Initial Catalog=DbYemekTarifi;Integrated Security=True");
        con.Open();
        return con;
    }
}