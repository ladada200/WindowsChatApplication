///
/// this are the libraries we're using.
/// It's easier to have these libraries than to build all the .Net OBJECTS from scratch
///
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// This is the namespace.  It tells us where the class is available from.  
/// Usually all classes in a project have the same namespace 
/// </summary>
namespace WindowsChatApplication
{
    /// <summary>
    /// public - This class is available from other classes/pieces of code
    /// class - declares a grouped piece of code.  In this case - an Object
    /// Message - we have created a new DataType.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// this is where I will be defining all the attributes
        /// </summary>
        public int Id { get; set; } // this is the id.   It can be set or get
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }

        /// <summary>
        /// this is an empty constructor.  It will allow us to initialize a new "Message" object
        /// </summary>
        public Message()
        {

        }

        /// <summary>
        /// This is a constructor to return a single Message object
        /// It accepts an Id -> gets the data from the DataBase -> and return back a full Message Object
        /// </summary>
        /// <param name="Id"></param>
        public Message(int Id)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>(); // creating a new List object
            sqlParams.Add(new SqlParameter("Id", Id)); // adding the Id parameter to the list object


            // I'm creating a table, and calling the "ExecStoredProcedure" method from the DAL class
            // This method returns a datatable
            DataTable dtMessage = DAL.ExecStoredProcedure("GetMessageById", sqlParams);

            // We need to make sure the returned table is not null, and that there are rows in this table.  
            // Since Id is unique, there should be only one row.
            if (dtMessage != null && dtMessage.Rows.Count == 1)
            {
                // This is to make things simpler to read
                DataRow row = dtMessage.Rows[0];

                // here I assign all the objects attributes
                this.Id = Convert.ToInt32(row["Id"]);
                this.UserId = Convert.ToInt32(row["UserId"]);
                this.Created = Convert.ToDateTime(row["Created"]);
                this.Content = row["Content"].ToString();
            }

            // becasue this is a constructor, there is no need for a return statement.
        }
    }
}