using System;

namespace SustainableFleet.Data
{
    public class DieselConsumptionMapper
    {
        public static string Mapper(string[] splited)
        {

            


            string d1, d2, d3, d4;


            d1 = DateTime.TryParse(splited[4], out DateTime data1) ? data1.ToString() : "";
            d2 = DateTime.TryParse(splited[5], out DateTime data2) ? data2.ToString() : "";
            d3 = DateTime.TryParse(splited[8], out DateTime data3) ? data3.ToString() : "";
            d4 = DateTime.TryParse(splited[9], out DateTime data4) ? data4.ToString() : "";




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
           ,'{d1}'
           ,'{d2}'
           ,'{splited[6]}'
           ,{splited[7]}
           ,'{d3}'
           ,'{d4}'
           ,'{splited[10]}'
           ,'{splited[11]}'
           ,'{splited[12]}'
           ,'{splited[13]}'
           ,'{splited[14]}'
           ,{splited[15]}
           ,{splited[16]}
           ,{splited[17]}
           ,{splited[18]})";

            return query;
        }
    }
}
