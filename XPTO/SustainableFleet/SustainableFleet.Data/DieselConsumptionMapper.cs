using System;
using System.Data.SqlClient;

namespace SustainableFleet.Data
{
    public class DieselConsumptionMapper
    {
        public static Tuple<string, SqlParameter[]> Mapper(string[] splited)
        {
            DateTime? d1, d2, d3, d4;

            //d1 = DateTime.TryParse(splited[4], out DateTime data1) ? data1.ToString() : "";
            //d2 = DateTime.TryParse(splited[5], out DateTime data2) ? data2.ToString() : "";
            //d3 = DateTime.TryParse(splited[8], out DateTime data3) ? data3.ToString() : "";
            //d4 = DateTime.TryParse(splited[9], out DateTime data4) ? data4.ToString() : "";

            d1 = DateTime.TryParse(splited[4], out DateTime data1) ? (DateTime?)data1 : null;
            d2 = DateTime.TryParse(splited[5], out DateTime data2) ? (DateTime?)data2 : null;
            d3 = DateTime.TryParse(splited[8], out DateTime data3) ? (DateTime?)data3 : null;
            d4 = DateTime.TryParse(splited[9], out DateTime data4) ? (DateTime?)data4 : null;


            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@d1";
            param1.Value = d1;
            param1.Value = param1.Value ?? DBNull.Value;


            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@d2";
            param2.Value = d2;
            param2.Value = param2.Value ?? DBNull.Value;

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@d3";
            param3.Value = d3;
            param3.Value = param3.Value ?? DBNull.Value;

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@d4";
            param4.Value = d4;
            param4.Value = param4.Value ?? DBNull.Value;


            var sqlParameters = new SqlParameter[] {
           param1,
           param2,
           param3,
           param4
            };


            var query = $@"INSERT INTO [dbo].[DieselConsumption]
           ([Uuid]
           ,[VehicleId]
           ,[UoVehicleId]
           ,[StartDate]
           ,[EndDate]
           ,[VehicleState]
           ,[Duration]
           ,[CreationDate]
           ,[ChangeDate]
           ,[StartLat]
           ,[StartLong]
           ,[EndLat]
           ,[EndLong]
           ,[Threshold]
           ,[Consumption]
           ,[TravelledDistance]
           ,[InitialOdometer]
           ,[FinalOdometer])
     VALUES
           ('{splited[0]}'           
           ,{splited[2]}
           ,{splited[3]}
           ,@d1
           ,@d2
           ,'{splited[6]}'
           ,{splited[7]}
           ,@d3
           ,@d4
           ,'{splited[10]}'
           ,'{splited[11]}'
           ,'{splited[12]}'
           ,'{splited[13]}'
           ,'{splited[14]}'
           ,{splited[15]}
           ,{splited[16]}
           ,{splited[17]}
           ,{splited[18]})";

            return new Tuple<string, SqlParameter[]>(query, sqlParameters);
        }
    }
}
