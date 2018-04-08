//NOTE:  This class file can only be used once sp_configure has been modified to reflect triggered events
//TO DO:
//Full integration by end of phase 2.  Will require some heavy modifications to database.
//Rebuild stored procedure?

using System;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using System.Text.RegularExpressions;


namespace WindowsChatApplication
{
    public static class CLRTrigger
    {
        [SqlTrigger(Name = @"MessageAudit", Target = "[dbo].[Messages]", Event = "FOR INSERT, UPDATE, DELETE")]
        public static void updateFromDB()
        {
            // <summary>
            // Authors: Christopher Rupert, 
            // This will be used to check against the database to determine if:
            // The database has recently had a new entry inserted
            // OR,
            // IF the database has had an update or delete to a record.
            // </summary>


            string strConnect = ConfigurationManager.ConnectionStrings["ChatAppConnectionString"].ToString();

            // Set contextual trigger for sql connection.
            SqlTriggerContext triggContext = SqlContext.TriggerContext;

            // Define pipe
            SqlPipe pipe = SqlContext.Pipe;

            // Flexible switch statement:
            switch (triggContext.TriggerAction)
            {
                case TriggerAction.Insert:
                    // Retrieve the connection string and use it forward;
                    // NOTE: This can be used along side a data access layer class.
                    using (SqlConnection connection = new SqlConnection(@"context connection=true"))
                    {
                        // Bring in Data Access Layer class script for quick distribution
                        var sqlOut = DAL.ExecStoredProcedure("GetMessages", null);
                        
                        //DataTableReader dr = sqlOut.CreateDataReader();
                        
                    }
                    break;
            }


        }
        
    }
}
