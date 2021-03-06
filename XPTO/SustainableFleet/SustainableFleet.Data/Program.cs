﻿using System;
using System.Globalization;
using System.Threading;

namespace SustainableFleet.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("pt-br");
            Thread.CurrentThread.CurrentCulture = ci;

            //var file = @"C:\Users\wellington.gomes\Desktop\POC Abril\Alertas\Nova pasta\abril\Historico_Alerta_1309.csv";

            //DataHandler dataHandler = new DataHandler(@"Server=NT-03338\SQLEXPRESS;Database=AmbevSustainableFleet;Trusted_Connection=True;");

            //dataHandler.Insert(file, 21, VehicleAlertHistoryMapper.Mapper);


            var file = @"C:\Users\wellington.gomes\Desktop\POC Abril\Consumos\2019-04-14.csv";

            DataHandler dataHandler = new DataHandler(@"Server=NT-03338\SQLEXPRESS;Database=AmbevSustainableFleet;Trusted_Connection=True;");

            dataHandler.Insert(file, 19, DieselConsumptionMapper.Mapper);
        }
    }


   
}
