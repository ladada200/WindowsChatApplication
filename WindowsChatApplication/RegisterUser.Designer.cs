namespace WindowsChatApplication
{
    partial class RegisterUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reqEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reqPass = new System.Windows.Forms.Label();
            this.reqPassConfirm = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.mtbPassConfirm = new System.Windows.Forms.MaskedTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrorString = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reqEmail
            // 
            this.reqEmail.AutoSize = true;
            this.reqEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqEmail.ForeColor = System.Drawing.Color.Red;
            this.reqEmail.Location = new System.Drawing.Point(354, 52);
            this.reqEmail.Name = "reqEmail";
            this.reqEmail.Size = new System.Drawing.Size(67, 13);
            this.reqEmail.TabIndex = 0;
            this.reqEmail.Text = "* Required";
            this.reqEmail.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Confirm Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reqPass
            // 
            this.reqPass.AutoSize = true;
            this.reqPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqPass.ForeColor = System.Drawing.Color.Red;
            this.reqPass.Location = new System.Drawing.Point(354, 103);
            this.reqPass.Name = "reqPass";
            this.reqPass.Size = new System.Drawing.Size(67, 13);
            this.reqPass.TabIndex = 4;
            this.reqPass.Text = "* Required";
            this.reqPass.Visible = false;
            // 
            // reqPassConfirm
            // 
            this.reqPassConfirm.AutoSize = true;
            this.reqPassConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqPassConfirm.ForeColor = System.Drawing.Color.Red;
            this.reqPassConfirm.Location = new System.Drawing.Point(354, 135);
            this.reqPassConfirm.Name = "reqPassConfirm";
            this.reqPassConfirm.Size = new System.Drawing.Size(67, 13);
            this.reqPassConfirm.TabIndex = 5;
            this.reqPassConfirm.Text = "* Required";
            this.reqPassConfirm.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(119, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // mtbPass
            // 
            this.mtbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPass.Location = new System.Drawing.Point(119, 98);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.Size = new System.Drawing.Size(229, 22);
            this.mtbPass.TabIndex = 1;
            // 
            // mtbPassConfirm
            // 
            this.mtbPassConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPassConfirm.Location = new System.Drawing.Point(119, 130);
            this.mtbPassConfirm.Name = "mtbPassConfirm";
            this.mtbPassConfirm.Size = new System.Drawing.Size(229, 22);
            this.mtbPassConfirm.TabIndex = 2;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(237, 287);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(111, 34);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "S&ubmit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Register New User:";
            // 
            // lblErrorString
            // 
            this.lblErrorString.AutoSize = true;
            this.lblErrorString.ForeColor = System.Drawing.Color.Red;
            this.lblErrorString.Location = new System.Drawing.Point(119, 76);
            this.lblErrorString.Name = "lblErrorString";
            this.lblErrorString.Size = new System.Drawing.Size(127, 13);
            this.lblErrorString.TabIndex = 11;
            this.lblErrorString.Text = "Passwords do not Match!";
            this.lblErrorString.Visible = false;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFName.Location = new System.Drawing.Point(119, 208);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(229, 22);
            this.txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtLName.Location = new System.Drawing.Point(119, 236);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(229, 22);
            this.txtLName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "&First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "&Last Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 96);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 333);
            this.label6.MaximumSize = new System.Drawing.Size(400, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "By Clicking Submit you agree to our Privacy Policy and it\'s Terms of Use";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(228, 356);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Privacy Policy";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(152, 356);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(70, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Terms of Use";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "|";
            // 
            // RegisterUser
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblErrorString);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.mtbPassConfirm);
            this.Controls.Add(this.mtbPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.reqPassConfirm);
            this.Controls.Add(this.reqPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reqEmail);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reqEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label reqPass;
        private System.Windows.Forms.Label reqPassConfirm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.MaskedTextBox mtbPassConfirm;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblErrorString;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label8;
    }
}