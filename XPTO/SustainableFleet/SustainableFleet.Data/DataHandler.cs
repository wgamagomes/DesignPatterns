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
        private void Insert(Tuple<string, SqlParameter[]> tuple, SqlConnection conn)
        {
            SqlCommand myCommand = new SqlCommand(tuple.Item1, conn);
            myCommand.Parameters.AddRange(tuple.Item2);
            myCommand.ExecuteNonQuery();
        }

        public void Insert(string filePath, int len, Func<string[], Tuple<string, SqlParameter[]>> mapper)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                Tuple<string, SqlParameter[]> result = null;

                foreach (var csvRow in CsvReader.Reader(filePath))
                {
                    try
                    {
                        if (csvRow.Length != len)
                            throw new Exception("len error");

                        result = mapper(csvRow);

                        Insert(result, conn);
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }
        }
    }
}
