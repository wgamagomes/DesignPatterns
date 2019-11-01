using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SustainableFleet.Cmd
{
    public class VehicleAlertHistoryMapper
    {
        public static Tuple<string, SqlParameter[]> Mapper(string[] splited)
        {
            var datetimeConcated = splited[17] + " " + splited[18];
            DateTime? datetime = datetimeConcated == "- -" ? null : (DateTime?)DateTime.Parse(datetimeConcated);

            var datetimeformated = datetime == null ? null : ((DateTime)(datetime)).ToString();

            SqlParameter param = new System.Data.SqlClient.SqlParameter();
            param.ParameterName = "@Data";


            param.Value = (datetimeConcated == "- -" ? null : (DateTime?)DateTime.Parse(datetimeConcated));

            param.Value = param.Value ?? DBNull.Value;

            var sqlParameters = new SqlParameter[] { param };


            var query = $@"INSERT INTO [dbo].[VehicleAlertHistory]
           ([Guid]
           ,[Plate]
           ,[Prefix]
           ,[DriverName]
           ,[CPF]
           ,[BusinessUnit]
           ,[Event]
           ,[Level]
           ,[Threshold]
           ,[Overspeed]
           ,[Duration]
           ,[ReferencePoint]
           ,[Category]
           ,[Highway]
           ,[City]
           ,[State]
           ,[Lat]
           ,[Long]
           ,[DateTime]
           ,[Status]
           ,[Assigned])
     VALUES
           ('{Guid.NewGuid().ToString()}'  
           ,'{splited[0]}'
           ,'{splited[1]}'
           ,'{splited[2]}'
           ,'{splited[3]}'
           ,'{splited[4]}'
           ,'{splited[5]}'
           ,'{splited[6]}'
           ,'{splited[7]}'
           ,'{splited[8]}'
           ,'{splited[9]}'
           ,'{splited[10]}'
           ,'{splited[11]}'
           ,'{splited[12]}'
           ,'{splited[13]}'
           ,'{splited[14]}'
           ,'{splited[15]}'
           ,'{splited[16]}'
           ,@Data
           ,'{splited[19]}'
           ,'{splited[20]}')";

            return new Tuple<string, SqlParameter[]>(query, sqlParameters);

        }
    }
}
