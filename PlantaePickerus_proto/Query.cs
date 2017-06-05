using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantaePickerus_proto
{
    class Query
    {
        private string dbPath = @"C:\Users\Public\PlantaePickerus\PPdatabase.db";
        private bool querySuccess = false;
                
        public Query(string performQuery)
        {
            //
            //SQLite database connection
            string connectionString = " Data Source = " + dbPath + "; Version=3; ";
            using (SQLiteConnection dbCon = new SQLiteConnection(connectionString))
            {
                try
                {
                    //open connection
                    dbCon.Open();

                    //perform Query:
                    using (SQLiteCommand command = new SQLiteCommand(performQuery, dbCon))
                    {
                        command.ExecuteNonQuery();
                    }

                    //close connection
                    dbCon.Close();

                    querySuccess = true;

                }
                catch (Exception)
                {
                    throw;
                }
                //end of: exceptions handling

            } //end of: "using" >> object disposed

            //END: SQLite database connection
            //
        }

        public bool success()
        {
            return this.querySuccess;
        }


    }
}
