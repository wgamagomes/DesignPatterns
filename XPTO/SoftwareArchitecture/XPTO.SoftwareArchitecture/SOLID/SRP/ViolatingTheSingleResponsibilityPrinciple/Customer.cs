using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace XPTO.SoftwareArchitecture.SOLID.SRP.ViolatingTheSingleResponsibilityPrinciple
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //This method clearly has more than one responsibility
        public string Add()
        {
            if(!Email.Contains("@"))
            return "Invalid email address";


            if (string.IsNullOrEmpty(Name))
                return "Invalid name";

            using (var conn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                conn.ConnectionString = "MyConnString";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Customer (name, email) VALUES(@name, @email)";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);

                conn.Open();
                cmd.ExecuteNonQuery();

            }

            var mail = new MailMessage("email@org.com", Email);
            mail.Subject = "Welcome";
            mail.Body = "Congrats you have been registered";

            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            client.Send(mail);
            return "succes";
        } 

    }
}
