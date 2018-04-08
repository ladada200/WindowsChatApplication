using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsChatApplication
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
            btnLogin.MouseEnter += new EventHandler(btnLogin_MouseEnter);
            btnLogin.MouseLeave += new EventHandler(btnLogin_MouseLeave);
        }

        int x = 0;
        int y = 0;

        void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.BackgroundImage = new Bitmap(icons.buttonDefault);
        }


        void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            this.btnLogin.BackgroundImage = new Bitmap(icons.buttonHover);
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin.BackgroundImage = new Bitmap(icons.buttonActive);
            string usrEmail = txtEmail.Text, usrPass = txtPass.Text;
            string sqlRetEmail = "", sqlRetPass = "";

            try
            {
                if (usrEmail == null || usrPass == null || usrEmail == "" || usrPass == "")
                {
                    //throw new Exception("No inputs detected.");

                }//End if

                List<SqlParameter> Parameters = new List<SqlParameter>();
                Parameters.Add(new SqlParameter("Email", usrEmail));
                Parameters.Add(new SqlParameter("Password", usrPass));
                var sqlOut = DAL.ExecStoredProcedure("Login", Parameters);
                DataTable dt = sqlOut;

                foreach (DataRow row in sqlOut.Rows)
                {
                    sqlRetEmail = row["Email"].ToString();
                    sqlRetPass = row["Password"].ToString();
                }//End loop


                if (sqlRetEmail == usrEmail.ToString() && sqlRetPass == usrPass.ToString())
                {
                    if (chkRememberMe.Checked)
                    {
                        //Variables to store in Windows UAC for later user.
                        Properties.Settings.Default.UserName = usrEmail;
                        Properties.Settings.Default.Password = usrPass;
                        Properties.Settings.Default.Save();

                        //Prepare two pre-encrypted strings for later use.
                        string encryptedString = StringCipher.Encrypt(usrEmail, usrPass);
                        string encryptedPass = StringCipher.Encrypt(usrPass, usrPass);

                        string[] saveToFileLines = { encryptedString, encryptedPass, StringCipher.Encrypt("preferred", usrPass) };

                        //Look for AppData\Roaming folder.
                        string fName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() + "\\resources\\";

                        //MessageBox.Show(fName + usrEmail.ToString().Split('@')[0] + ".usr");      //Used for testing

                        //Determine if file and directory exists.
                        if (!File.Exists(@fName + usrEmail.ToString().Split('@')[0] + ".usr"))
                        {
                            //Does just the directory exist?
                            if (!Directory.Exists(@fName))
                            {
                                //Create if not.
                                Directory.CreateDirectory(@fName);
                            }//End If

                            //Prepare and deliver directory.
                            System.IO.File.WriteAllLines(fName + usrEmail.ToString().Split('@')[0] + ".usr", saveToFileLines);
                            System.IO.File.Encrypt(fName + usrEmail.ToString().Split('@')[0] + ".usr");
                        }//End If

                    }
                    LoggedIn clientForm = new LoggedIn();
                    clientForm.Show();
                    this.Hide();

                } //End If
                else
                {
                    lblInvLogin.Text = "Invalid Login";
                    lblInvLogin.Visible = true;
                    if (x == 2)
                    {
                        lblInvLogin.Text = "Invalid Login; Access has been locked for 5 minutes.";
                        txtEmail.Enabled = false;
                        txtPass.Enabled = false;
                        btnLogin.Enabled = false;
                        y = 0;
                        timer1.Enabled = true;
                        timer1.Start();
                        x = 0;
                    }
                    else
                    {
                        x++;
                    }
                }//End if
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }


        }//End button click function

        private static void funcMethod(IDataRecord record)
        {
            MessageBox.Show(String.Format("{0}, {1}", record[1], record[2]));
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            lblInvLogin.Visible = false;
            //On Startup, check the resources directory for anything where a .usr file exists.
            //If a .usr file exists check for the term 'Preferred'
            //If found, login using that information
            string fName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() + "\\resources\\";

            //Check for UAC stored username / Password will be included by default.

            if (Properties.Settings.Default.UserName != string.Empty)
            {

                //Redundant file-check to confirm if user-file was made.  If so; use stored function and file for less DB table poll.
                if (Directory.Exists(fName))
                {
                    //Get all files in folder if DB Exists.
                    string[] fileEntries = Directory.GetFiles(fName);
                    foreach (string filename in fileEntries)
                    {
                        if (processFile(filename))
                        {
                            //If true; log in user using File as 'quick authentication'
                            LoggedIn clientForm = new LoggedIn();
                            clientForm.Show();
                            //Hide the main-screen
                            this.WindowState = FormWindowState.Minimized;
                            this.ShowInTaskbar = false;

                        }//End if
                    }//End loop
                }//End if
            }//End if

        }

        public static bool processFile(string path)
        {
            bool output = false;
            var outline = "";
            //deconstructed string.
            string envUNameFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() + "\\resources\\" + Properties.Settings.Default.UserName.Split('@')[0] + ".usr";
            //Search for file where filename is same as Username split.
            if (envUNameFile == path)
            {
                //function redundancy; only look for last known file if it's file-name is same as cut of stored userName
                foreach (var line in File.ReadLines(path))
                {
                    outline = StringCipher.Decrypt(line, Properties.Settings.Default.Password);
                    if (outline.Contains("preferred"))
                    {
                        output = true;
                    }
                }
            }

            if (output == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//End processFile function

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Use function to determine if 5 minutes has passed.
            if (y >= 300)
            {
                txtEmail.Enabled = true;
                txtPass.Enabled = true;
                btnLogin.Enabled = true;
                timer1.Enabled = false;
                timer1.Stop();
            }
            else
            {
                y++;
            }


        }//End timerTick

        private void lnklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUser clientForm = new RegisterUser();
            clientForm.Show();
        }
    }
}