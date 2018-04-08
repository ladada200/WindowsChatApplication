using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsChatApplication
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            string usrEmail, usrPass, usrPassConfirm;
            usrEmail = txtEmail.Text; usrPass = mtbPass.Text; usrPassConfirm = mtbPassConfirm.Text;
            string sqlRetEmail = "";

            if (usrEmail == null || usrEmail == "")
            {
                txtEmail.Focus();
                reqEmail.Visible = true;
            }
            else if (usrPass == null || usrPass == "")
            {
                mtbPass.Focus();
                reqPass.Visible = true;
            }
            else if (usrPassConfirm == null || usrPassConfirm == "")
            {
                mtbPassConfirm.Focus();
                reqPassConfirm.Visible = true;
            }
            else
            {
                Regex reg = new Regex(@"^[a-zA-Z0-9]{6,}@[a-zA-Z0-9]{3,}.[a-zA-Z0-9]{2,}$", RegexOptions.IgnoreCase);
                Regex regPass = new Regex(@"^[a-zA-Z0-9]{8,}$", RegexOptions.IgnoreCase);
                Match m = reg.Match(usrEmail);
                Match p = regPass.Match(usrPass);
                if (m.Success)
                {
                    //Check passwords now;
                    if (p.Success)
                    {
                        if (usrPass != usrPassConfirm)
                        {
                            lblErrorString.Text = "Passwords do not match!";
                            lblErrorString.Visible = true;
                        } else
                        {
                            //All is correct; send command through stored procedure;
                            //Form only handles introducing both passwords; only singular password is sent.

                            /* Send form to confirm that user does not exist in table. */
                            List<SqlParameter> Parameters = new List<SqlParameter>();
                            List<SqlParameter> Parameters2 = new List<SqlParameter>();

                            Parameters.Add(new SqlParameter("Email", usrEmail));

                            //Second Parameter list.
                            Parameters2.Add(new SqlParameter("Email", usrEmail));
                            Parameters2.Add(new SqlParameter("Password", usrPass));

                            var sqlOut = DAL.ExecStoredProcedure("VerifyEmail", Parameters);
                            DataTable dt = sqlOut;
                            

                            foreach (DataRow row in sqlOut.Rows)
                            {
                                sqlRetEmail = row["Email"].ToString();
                                
                            }
                            if (sqlRetEmail == usrEmail)
                            {
                                //If we confirm that the user already exists in the database;
                                //MessageBox.Show("User already exists in database.", "User already Exists");
                                lblErrorString.Text = "User with that email already exists!";
                                lblErrorString.Visible = true;
                            }
                            else
                            {
                                //Check if the user left the firstname or lastname empty
                                if (string.IsNullOrEmpty(txtFName.Text))
                                {
                                    Parameters2.Add(new SqlParameter("firstName", " "));
                                } else
                                {
                                    Parameters2.Add(new SqlParameter("firstName", txtFName.Text.ToString()));
                                }//End if

                                if (string.IsNullOrEmpty(txtLName.Text))
                                {
                                    Parameters2.Add(new SqlParameter("lastName", " "));
                                }
                                else
                                {
                                    Parameters2.Add(new SqlParameter("lastName", txtLName.Text.ToString()));
                                }//End if
                                sendEmail.sendMessage(usrEmail.ToString(), usrPass.ToString());
                                var sqlOut2 = DAL.ExecStoredProcedure("CreateUser", Parameters2);
                                this.Close();
                            }


                        }
                    } else
                    {
                        lblErrorString.Text = "Password must be at least 8 characters";
                        lblErrorString.Visible = true;
                    }
                }
                else
                {
                    lblErrorString.Text = "Invalid email address!";
                    lblErrorString.Visible = true;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://crupert.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://crupert.com");
            
        }
    }
}
