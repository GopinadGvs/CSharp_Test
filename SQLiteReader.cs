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

// SELECT * FROM SheetInfo

// SELECT SheetName FROM SheetInfo

// SELECT * FROM SheetInfo WHERE SheetName = 'A0'

// SELECT count(*) FROM SheetInfo;

// SELECT MIN(SheetWidth) AS MinWidth FROM SheetInfo;

// INSERT INTO SheetInfo (SheetName, SheetWidth) VALUES ('A3', 40);

// UPDATE SheetInfo SET SheetWidth = 25 WHERE SheetName = 'A1';

// DELETE FROM SheetInfo WHERE SheetName = 'A2';