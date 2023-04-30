namespace THAW8_MaulanaMA
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.cmbPlayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPM = new System.Windows.Forms.Label();
            this.lblGO = new System.Windows.Forms.Label();
            this.lblCR = new System.Windows.Forms.Label();
            this.lblCY = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.cmbTeam2 = new System.Windows.Forms.ComboBox();
            this.cmbTeam1 = new System.Windows.Forms.ComboBox();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.DGV3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchToolStripMenuItem
            // 
            this.showMatchToolStripMenuItem.Name = "showMatchToolStripMenuItem";
            this.showMatchToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.showMatchToolStripMenuItem.Text = " Show Match Details";
            this.showMatchToolStripMenuItem.Click += new System.EventHandler(this.showMatchToolStripMenuItem_Click);
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(24, 16);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(121, 24);
            this.cmbTeam.TabIndex = 1;
            this.cmbTeam.SelectedIndexChanged += new System.EventHandler(this.cmbTeam_SelectedIndexChanged);
            // 
            // cmbPlayer
            // 
            this.cmbPlayer.FormattingEnabled = true;
            this.cmbPlayer.Location = new System.Drawing.Point(244, 16);
            this.cmbPlayer.Name = "cmbPlayer";
            this.cmbPlayer.Size = new System.Drawing.Size(121, 24);
            this.cmbPlayer.TabIndex = 2;
            this.cmbPlayer.SelectedIndexChanged += new System.EventHandler(this.cmbPlayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yellow Card";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Red Card";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Goal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Penalty Miss";
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Location = new System.Drawing.Point(133, 344);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(119, 16);
            this.lblPM.TabIndex = 20;
            this.lblPM.Text = "________________";
            // 
            // lblGO
            // 
            this.lblGO.AutoSize = true;
            this.lblGO.Location = new System.Drawing.Point(133, 304);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(119, 16);
            this.lblGO.TabIndex = 18;
            this.lblGO.Text = "________________";
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Location = new System.Drawing.Point(133, 261);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(119, 16);
            this.lblCR.TabIndex = 17;
            this.lblCR.Text = "________________";
            // 
            // lblCY
            // 
            this.lblCY.AutoSize = true;
            this.lblCY.Location = new System.Drawing.Point(133, 217);
            this.lblCY.Name = "lblCY";
            this.lblCY.Size = new System.Drawing.Size(119, 16);
            this.lblCY.TabIndex = 16;
            this.lblCY.Text = "________________";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Location = new System.Drawing.Point(133, 178);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(119, 16);
            this.lblNation.TabIndex = 15;
            this.lblNation.Text = "________________";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(133, 137);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(119, 16);
            this.lblPos.TabIndex = 14;
            this.lblPos.Text = "________________";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(133, 97);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(119, 16);
            this.lblTeam.TabIndex = 13;
            this.lblTeam.Text = "________________";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(133, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 16);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "________________";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lblPM);
            this.panel1.Controls.Add(this.lblGO);
            this.panel1.Controls.Add(this.lblCR);
            this.panel1.Controls.Add(this.lblCY);
            this.panel1.Controls.Add(this.lblNation);
            this.panel1.Controls.Add(this.lblPos);
            this.panel1.Controls.Add(this.lblTeam);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbPlayer);
            this.panel1.Controls.Add(this.cmbTeam);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 423);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(133, 381);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(119, 16);
            this.lblNum.TabIndex = 22;
            this.lblNum.Text = "________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Player Number";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.DGV3);
            this.panel2.Controls.Add(this.DGV2);
            this.panel2.Controls.Add(this.DGV1);
            this.panel2.Controls.Add(this.cmbTeam2);
            this.panel2.Controls.Add(this.cmbTeam1);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 406);
            this.panel2.TabIndex = 23;
            this.panel2.Visible = false;
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(36, 68);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(240, 150);
            this.DGV1.TabIndex = 25;
            // 
            // cmbTeam2
            // 
            this.cmbTeam2.FormattingEnabled = true;
            this.cmbTeam2.Location = new System.Drawing.Point(334, 16);
            this.cmbTeam2.Name = "cmbTeam2";
            this.cmbTeam2.Size = new System.Drawing.Size(121, 24);
            this.cmbTeam2.TabIndex = 24;
            this.cmbTeam2.SelectedIndexChanged += new System.EventHandler(this.cmbTeam2_SelectedIndexChanged);
            // 
            // cmbTeam1
            // 
            this.cmbTeam1.FormattingEnabled = true;
            this.cmbTeam1.Location = new System.Drawing.Point(36, 16);
            this.cmbTeam1.Name = "cmbTeam1";
            this.cmbTeam1.Size = new System.Drawing.Size(121, 24);
            this.cmbTeam1.TabIndex = 24;
            this.cmbTeam1.SelectedIndexChanged += new System.EventHandler(this.cmbTeam1_SelectedIndexChanged);
            // 
            // DGV2
            // 
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(334, 68);
            this.DGV2.Name = "DGV2";
            this.DGV2.RowHeadersWidth = 51;
            this.DGV2.RowTemplate.Height = 24;
            this.DGV2.Size = new System.Drawing.Size(240, 150);
            this.DGV2.TabIndex = 26;
            // 
            // DGV3
            // 
            this.DGV3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV3.Location = new System.Drawing.Point(36, 242);
            this.DGV3.Name = "DGV3";
            this.DGV3.RowHeadersWidth = 51;
            this.DGV3.RowTemplate.Height = 24;
            this.DGV3.Size = new System.Drawing.Size(724, 150);
            this.DGV3.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.ComboBox cmbPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.Label lblGO;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.Label lblCY;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTeam2;
        private System.Windows.Forms.ComboBox cmbTeam1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridView DGV3;
    }
}

