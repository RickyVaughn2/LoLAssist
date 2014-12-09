namespace LoLAssist
{
    partial class frmMain
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
            this.btnGetSummonerID = new System.Windows.Forms.Button();
            this.lblSummonerID = new System.Windows.Forms.Label();
            this.txtJSONReply = new System.Windows.Forms.TextBox();
            this.txtSummonerName = new System.Windows.Forms.TextBox();
            this.btnGetRankedInfo = new System.Windows.Forms.Button();
            this.btnDLLGetID = new System.Windows.Forms.Button();
            this.btnAnnieRange = new System.Windows.Forms.Button();
            this.btnS4Kills = new System.Windows.Forms.Button();
            this.btnRecentGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetSummonerID
            // 
            this.btnGetSummonerID.Location = new System.Drawing.Point(30, 122);
            this.btnGetSummonerID.Name = "btnGetSummonerID";
            this.btnGetSummonerID.Size = new System.Drawing.Size(75, 23);
            this.btnGetSummonerID.TabIndex = 0;
            this.btnGetSummonerID.Text = "Get ID";
            this.btnGetSummonerID.UseVisualStyleBackColor = true;
            this.btnGetSummonerID.Click += new System.EventHandler(this.btnGetSummonerID_Click);
            // 
            // lblSummonerID
            // 
            this.lblSummonerID.AutoSize = true;
            this.lblSummonerID.Location = new System.Drawing.Point(145, 108);
            this.lblSummonerID.Name = "lblSummonerID";
            this.lblSummonerID.Size = new System.Drawing.Size(18, 13);
            this.lblSummonerID.TabIndex = 1;
            this.lblSummonerID.Text = "ID";
            // 
            // txtJSONReply
            // 
            this.txtJSONReply.Location = new System.Drawing.Point(148, 124);
            this.txtJSONReply.Multiline = true;
            this.txtJSONReply.Name = "txtJSONReply";
            this.txtJSONReply.Size = new System.Drawing.Size(684, 323);
            this.txtJSONReply.TabIndex = 2;
            // 
            // txtSummonerName
            // 
            this.txtSummonerName.Location = new System.Drawing.Point(42, 21);
            this.txtSummonerName.Name = "txtSummonerName";
            this.txtSummonerName.Size = new System.Drawing.Size(100, 20);
            this.txtSummonerName.TabIndex = 3;
            this.txtSummonerName.Text = "unseenhorror";
            // 
            // btnGetRankedInfo
            // 
            this.btnGetRankedInfo.Location = new System.Drawing.Point(30, 161);
            this.btnGetRankedInfo.Name = "btnGetRankedInfo";
            this.btnGetRankedInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetRankedInfo.TabIndex = 4;
            this.btnGetRankedInfo.Text = "Ranked Info";
            this.btnGetRankedInfo.UseVisualStyleBackColor = true;
            this.btnGetRankedInfo.Click += new System.EventHandler(this.btnGetRankedInfo_Click);
            // 
            // btnDLLGetID
            // 
            this.btnDLLGetID.Location = new System.Drawing.Point(30, 191);
            this.btnDLLGetID.Name = "btnDLLGetID";
            this.btnDLLGetID.Size = new System.Drawing.Size(75, 23);
            this.btnDLLGetID.TabIndex = 5;
            this.btnDLLGetID.Text = "New DLL Get ID";
            this.btnDLLGetID.UseVisualStyleBackColor = true;
            this.btnDLLGetID.Click += new System.EventHandler(this.btnDLLGetID_Click);
            // 
            // btnAnnieRange
            // 
            this.btnAnnieRange.Location = new System.Drawing.Point(30, 220);
            this.btnAnnieRange.Name = "btnAnnieRange";
            this.btnAnnieRange.Size = new System.Drawing.Size(75, 23);
            this.btnAnnieRange.TabIndex = 6;
            this.btnAnnieRange.Text = "Annie Range";
            this.btnAnnieRange.UseVisualStyleBackColor = true;
            this.btnAnnieRange.Click += new System.EventHandler(this.btnAnnieRange_Click);
            // 
            // btnS4Kills
            // 
            this.btnS4Kills.Location = new System.Drawing.Point(30, 249);
            this.btnS4Kills.Name = "btnS4Kills";
            this.btnS4Kills.Size = new System.Drawing.Size(75, 23);
            this.btnS4Kills.TabIndex = 7;
            this.btnS4Kills.Text = "S4 Kills";
            this.btnS4Kills.UseVisualStyleBackColor = true;
            this.btnS4Kills.Click += new System.EventHandler(this.btnS4Kills_Click);
            // 
            // btnRecentGames
            // 
            this.btnRecentGames.Location = new System.Drawing.Point(30, 278);
            this.btnRecentGames.Name = "btnRecentGames";
            this.btnRecentGames.Size = new System.Drawing.Size(75, 23);
            this.btnRecentGames.TabIndex = 8;
            this.btnRecentGames.Text = "Recent Games";
            this.btnRecentGames.UseVisualStyleBackColor = true;
            this.btnRecentGames.Click += new System.EventHandler(this.btnRecentGames_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 460);
            this.Controls.Add(this.btnRecentGames);
            this.Controls.Add(this.btnS4Kills);
            this.Controls.Add(this.btnAnnieRange);
            this.Controls.Add(this.btnDLLGetID);
            this.Controls.Add(this.btnGetRankedInfo);
            this.Controls.Add(this.txtSummonerName);
            this.Controls.Add(this.txtJSONReply);
            this.Controls.Add(this.lblSummonerID);
            this.Controls.Add(this.btnGetSummonerID);
            this.Name = "frmMain";
            this.Text = "KDA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSummonerID;
        private System.Windows.Forms.Label lblSummonerID;
        private System.Windows.Forms.TextBox txtJSONReply;
        private System.Windows.Forms.TextBox txtSummonerName;
        private System.Windows.Forms.Button btnGetRankedInfo;
        private System.Windows.Forms.Button btnDLLGetID;
        private System.Windows.Forms.Button btnAnnieRange;
        private System.Windows.Forms.Button btnS4Kills;
        private System.Windows.Forms.Button btnRecentGames;
    }
}

