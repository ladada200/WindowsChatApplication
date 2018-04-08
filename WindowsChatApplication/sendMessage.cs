using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsChatApplication
{
    public static class sendMessage
    {
        /// <summary>
        ///     Got bored, frustrated, annoyed with writing the List<SqlParameter></SqlParameter> Stuff.
        ///     Decided it would be easier/faster to just make a class file and load it with methods.
        ///     No objects in here yet, but that may change as necessity facilitates.
        /// </summary>
        /// <param name="content"></param>
        /// 

        //Private structure
        private static void sendContent(string content)
        {
            var macAddr =
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

            List<SqlParameter> msgParam = new List<SqlParameter>();

            msgParam.Add(new SqlParameter("content", content));
            msgParam.Add(new SqlParameter("userId", Properties.Settings.Default.UserName));
            msgParam.Add(new SqlParameter("machineId", macAddr));
            var sqlOut = DAL.ExecStoredProcedure("InsertMessage_CR", msgParam);
        }//End method

        public static void passMessage(string content)
        {
            //Public modification
            sendMessage.sendContent(content);
        }   
    }
}
