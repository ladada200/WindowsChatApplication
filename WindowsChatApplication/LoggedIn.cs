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
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsChatApplication
{
    public partial class LoggedIn : Form
    {
        public LoggedIn()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoggedIn_KeyDown);
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true; //make the textbot not useable.
            string[] words = new string[] { "be nice.", "Don't hurt them", "Wow!", "- The meme lord", "Code Monkey" }; //flavor text
            Random rnd = new Random();
            int listTot = words.Length; //predefine
            int outNum = rnd.Next(0, listTot); //random integer
            lblStatusLabel.Text = "Logged in as: " + Properties.Settings.Default.UserName;
            this.Text = "Inner Chat";
            sendMessage.passMessage(" has entered the chat. " + words[outNum].ToString());
            txtMsgSend.Text = "";

            string fName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() + "\\logs\\";

            if (Directory.Exists(fName))
            {
                //Get all files in folder if DB Exists.
                string[] fileEntries = Directory.GetFiles(fName);
                //Load the last log file.
                if (fileEntries.Length > 0)
                {
                    string[] fileContents = File.ReadAllLines(fileEntries[fileEntries.Length - 1].ToString());
                    foreach (string fileLine in fileContents)
                    {
                        lstAllMessages2.Items.Add(fileLine.ToString()); //We keep this hidden.  It's hacky, but it works...
                        textBox1.AppendText(fileLine.ToString() + "\n");
                    }
                }

            }
            else
            {
                Directory.CreateDirectory(fName);
            }//End if
            TimerGetMessage.Start();

        }

        private void LoggedIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            sendMessage.passMessage(" has left the chat. ");
            Application.Exit();
        }

        private void LoggedIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("http://crupert.com");
            }
            if (e.KeyCode.ToString() == "Enter")
            {
                sendMessage.passMessage(": " + txtMsgSend.Text);
                txtMsgSend.Text = "";
            }
        }

        private void f1AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://crupert.com");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = string.Empty;
            Properties.Settings.Default.Password = string.Empty;
            Properties.Settings.Default.Save();
            this.Show();

            //this.Close();
            this.Dispose();
            Application.Exit();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMsgSend.Text != null && txtMsgSend.Text != "" && txtMsgSend.Text != " " && txtMsgSend.Text.Equals("") == false)
            {
                sendMessage.passMessage(": " + txtMsgSend.Text); //Add the colon to our message the lazy way.
                txtMsgSend.Text = ""; //Clean-up the text box.
            }

        }

        private void TimerGetMessage_Tick(object sender, EventArgs e)
        {
            var allMessages = DAL.ExecStoredProcedure("TopMessage_CR");
            foreach (DataRow row in allMessages.Rows)
            {
                //Determine if last message received is the newest
                if (textBox1.Lines.Length == 0 || row["Content"].ToString() != lstAllMessages2.Items[lstAllMessages2.Items.Count - 1].ToString())
                {
                    textBox1.AppendText(row["Content"].ToString() + "\n"); //Log it into the table if it is.
                    lstAllMessages2.Items.Add(row["Content"].ToString());
                    string LogName = DateTime.Now.ToString("yyyy-MM-dd"); //convert date
                    string fName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() + "\\logs\\" + LogName + ".log";
                    using (System.IO.StreamWriter file = System.IO.File.AppendText(@fName))
                    {
                        file.WriteLine(row["Content"].ToString());
                    }
                }
            }

        }

    }
}