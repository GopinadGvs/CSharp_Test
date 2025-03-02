using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CSharp_Test
{
    internal class SQLiteReader
    {
        public static void TestSQLiteReader()
        {
            string dbPath = @"C:\Users\gopin\OneDrive\Desktop\MyTest.db";

            string connectionString = $"Data Source={dbPath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                DataTable dataTable = new DataTable();

                string query = "SELECT * FROM SheetInfo";

                SQLiteCommand sQLiteCommand = connection.CreateCommand();
                sQLiteCommand.CommandText = query;
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sQLiteCommand);
                adapter.Fill(dataTable);

                // Print column headers
                foreach (DataColumn column in dataTable.Columns)
                {
                    Debug.Print(column.ColumnName + "\t");
                }

                // Print rows
                foreach (DataRow item in dataTable.Rows)
                {
                    foreach (var item1 in item.ItemArray)
                    {
                        Debug.Print(item1 + "\t");
                    }
                }

                connection.Close();
            }
        }
    }
}