namespace Tema_T1_BorcaDarius
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxPlayers = new ComboBox();
            labelLastPoints = new Label();
            labelLastRebounds = new Label();
            labelLastAssists = new Label();
            pictureBoxLogo = new PictureBox();
            labelTeam = new Label();
            labelPosition = new Label();
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            Date = new TextBox();
            pictureBoxPlayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPlayers
            // 
            comboBoxPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlayers.FormattingEnabled = true;
            comboBoxPlayers.Location = new Point(20, 20);
            comboBoxPlayers.Name = "comboBoxPlayers";
            comboBoxPlayers.Size = new Size(300, 28);
            comboBoxPlayers.TabIndex = 0;
            comboBoxPlayers.SelectedIndexChanged += comboBoxPlayers_SelectedIndexChanged;
            // 
            // labelLastPoints
            // 
            labelLastPoints.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastPoints.Location = new Point(20, 150);
            labelLastPoints.Name = "labelLastPoints";
            labelLastPoints.Size = new Size(200, 30);
            labelLastPoints.TabIndex = 2;
            labelLastPoints.Text = "Last game points:";
            labelLastPoints.Click += labelLastPoints_Click;
            // 
            // labelLastRebounds
            // 
            labelLastRebounds.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastRebounds.Location = new Point(20, 190);
            labelLastRebounds.Name = "labelLastRebounds";
            labelLastRebounds.Size = new Size(200, 30);
            labelLastRebounds.TabIndex = 3;
            labelLastRebounds.Text = "Last game rebounds: ";
            // 
            // labelLastAssists
            // 
            labelLastAssists.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastAssists.Location = new Point(20, 230);
            labelLastAssists.Name = "labelLastAssists";
            labelLastAssists.Size = new Size(200, 30);
            labelLastAssists.TabIndex = 4;
            labelLastAssists.Text = "Last game assists: ";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.nba_logo;
            pictureBoxLogo.Location = new Point(426, -304);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(1054, 893);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTeam
            // 
            labelTeam.Location = new Point(20, 70);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new Size(300, 30);
            labelTeam.TabIndex = 7;
            labelTeam.Text = "Team:";
            // 
            // labelPosition
            // 
            labelPosition.Location = new Point(20, 110);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(300, 30);
            labelPosition.TabIndex = 8;
            labelPosition.Text = "Position:";
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(11, 280);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(1240, 600);
            axWindowsMediaPlayer.TabIndex = 9;
            // 
            // Date
            // 
            Date.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.Location = new Point(341, 20);
            Date.Name = "Date";
            Date.Size = new Size(249, 31);
            Date.TabIndex = 10;
            Date.Text = "Application date: 05.04.2024";
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Location = new Point(226, 57);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(299, 217);
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPlayer.TabIndex = 11;
            pictureBoxPlayer.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 913);
            Controls.Add(pictureBoxPlayer);
            Controls.Add(Date);
            Controls.Add(axWindowsMediaPlayer);
            Controls.Add(labelPosition);
            Controls.Add(labelTeam);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelLastAssists);
            Controls.Add(labelLastRebounds);
            Controls.Add(labelLastPoints);
            Controls.Add(comboBoxPlayers);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NBA Aplication";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPlayers;
        private Label labelLastPoints;
        private Label labelLastRebounds;
        private Label labelLastAssists;
        private PictureBox pictureBoxLogo;
        private Label labelTeam;
        private Label labelPosition;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private TextBox Date;
        private PictureBox pictureBoxPlayer;
    }
}
