using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SustainableFleet.Data
{
    public class DataHandler
    {
        private string _connectionString;

        public DataHandler(string connectionString)
        {
            _connectionString = connectionString;
        }
        private void Insert(string query, SqlConnection conn)
        {
            SqlCommand myCommand = new SqlCommand(query, conn);
            myCommand.ExecuteNonQuery();
        }

        public void Insert(string filePath, int len, Func<string[], string> mapper)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var query = "";

                foreach (var csvRow in CsvReader.Reader(filePath))
                {
                    try
                    {
                        if (csvRow.Length != len)
                            throw new Exception("len error");

                         query = mapper(csvRow);

                        Insert(query, conn);
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }
        }
    }
}
