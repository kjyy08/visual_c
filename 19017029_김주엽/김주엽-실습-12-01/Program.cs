using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace 김주엽_실습_12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbDataReader reader;
            string connectionString = @"provider=Microsoft.ACE.OLEDB.12.0;"
                            + "data source=" + System.Environment.CurrentDirectory + @"\ADOTest.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            string strCmd = "select * from phone";
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = connection;
            cmd.CommandText = strCmd;

            connection.Open();
            reader = cmd.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
                Console.Write("{0} ", reader.GetName(i));
            Console.WriteLine();
            while(reader.Read())
            {
                Console.WriteLine(reader[0] + " | " + reader[1] + " | " + reader[2] + " | " + reader[3] + " | ");
            }
        }
    }
}
