namespace WindowsChatApplication
{
    partial class LoggedIn
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsgSend = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstAllMessages2 = new System.Windows.Forms.ListBox();
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSbot = new System.Windows.Forms.StatusStrip();
            this.lblStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerGetMessage = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msTop.SuspendLayout();
            this.sSbot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(653, 362);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "S&end";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsgSend
            // 
            this.txtMsgSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsgSend.Location = new System.Drawing.Point(12, 362);
            this.txtMsgSend.Multiline = true;
            this.txtMsgSend.Name = "txtMsgSend";
            this.txtMsgSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsgSend.Size = new System.Drawing.Size(635, 75);
            this.txtMsgSend.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstAllMessages2
            // 
            this.lstAllMessages2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAllMessages2.FormattingEnabled = true;
            this.lstAllMessages2.Location = new System.Drawing.Point(12, 56);
            this.lstAllMessages2.Name = "lstAllMessages2";
            this.lstAllMessages2.ScrollAlwaysVisible = true;
            this.lstAllMessages2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstAllMessages2.Size = new System.Drawing.Size(250, 43);
            this.lstAllMessages2.TabIndex = 3;
            // 
            // msTop
            // 
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(764, 24);
            this.msTop.TabIndex = 4;
            this.msTop.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "L&ogout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "He&lp";
            // 
            // f1AboutToolStripMenuItem
            // 
            this.f1AboutToolStripMenuItem.Name = "f1AboutToolStripMenuItem";
            this.f1AboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.f1AboutToolStripMenuItem.Text = "F1 &About";
            this.f1AboutToolStripMenuItem.Click += new System.EventHandler(this.f1AboutToolStripMenuItem_Click);
            // 
            // sSbot
            // 
            this.sSbot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusLabel});
            this.sSbot.Location = new System.Drawing.Point(0, 440);
            this.sSbot.Name = "sSbot";
            this.sSbot.Size = new System.Drawing.Size(764, 22);
            this.sSbot.TabIndex = 5;
            this.sSbot.Text = "statusStrip1";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.lblStatusLabel.Text = "Ready";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chat Room:";
            // 
            // TimerGetMessage
            // 
            this.TimerGetMessage.Interval = 500;
            this.TimerGetMessage.Tick += new System.EventHandler(this.TimerGetMessage_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(740, 303);
            this.textBox1.TabIndex = 8;
            // 
            // LoggedIn
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sSbot);
            this.Controls.Add(this.lstAllMessages2);
            this.Controls.Add(this.txtMsgSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.msTop);
            this.MainMenuStrip = this.msTop;
            this.MinimumSize = new System.Drawing.Size(780, 501);
            this.Name = "LoggedIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoggedIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggedIn_FormClosing);
            this.Load += new System.EventHandler(this.LoggedIn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoggedIn_KeyDown);
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.sSbot.ResumeLayout(false);
            this.sSbot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsgSend;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lstAllMessages2;
        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sSbot;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f1AboutToolStripMenuItem;
        private System.Windows.Forms.Timer TimerGetMessage;
        private System.Windows.Forms.TextBox textBox1;
    }
}