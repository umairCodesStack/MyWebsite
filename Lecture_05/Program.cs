using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Lecture_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //dynamic str= "hello";
            //var str1 = "how";
            //int len=str1.Length;
            //int len= str.Length;
            //Console.WriteLine(len);
               


            //Data Adapter
            string conectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;";
            SqlConnection con=new SqlConnection(conectString);
            con.Open();
            string query = $"delete  from Product Where ProductId='1';";
            SqlCommand cmd=new SqlCommand(query, con);
            int x= cmd.ExecuteNonQuery();   
            Console.WriteLine(x);   
            
            //string insertQuery = "insert into Product(ProductName,ProductDescription) values(@n,@d);";
            //SqlCommand insertCommand= new SqlCommand(insertQuery, con);
            //SqlParameter nameParameter = new SqlParameter("@n",SqlDbType.VarChar,50, "ProductName");
            //SqlParameter discrParameter = new SqlParameter("@d",SqlDbType.VarChar,50, "ProductDescription");
            //insertCommand.Parameters.Add(nameParameter);
            //insertCommand.Parameters.Add (discrParameter);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //adapter.InsertCommand = insertCommand;

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows) 
            //{
            //    Console.WriteLine($"{row[0]},{row[1]},{row[2]}");
            //}

            ////Insert new Data
            //DataRow dataRow=dataTable.NewRow();
            //dataRow[1] = "Charger";
            //dataRow[2] = "Android";
            //dataTable.Rows.Add(dataRow);    
            //DataRow dataRow2=dataTable.NewRow();
            //dataRow[1] = "Mouse";
            //dataRow[2] = "PC_item";
            //dataTable.Rows.Add(dataRow2);

            //adapter.Update(dataTable);//reflect all changes back into DB

        }
    }
}
