using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tema_T1_BorcaDarius;

namespace Tema_T1_BorcaDarius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            
            comboBoxPlayers.Items.Add("--Select a player--");

            foreach (var player in Data.Players)
            {
                comboBoxPlayers.Items.Add(player.Name);
            }

            comboBoxPlayers.SelectedIndex = 0;
        }

        private void comboBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlayerName = comboBoxPlayers.SelectedItem.ToString();

            var selectedPlayer = Data.Players.Find(p => p.Name == selectedPlayerName);

            if (selectedPlayer != null)
            {
                
                labelTeam.Text = $"Team: {selectedPlayer.Team}";
                labelPosition.Text = $"Position: {selectedPlayer.Position}";

                
                labelLastPoints.Text = $"Last game points: {selectedPlayer.LastPoints}";
                labelLastRebounds.Text = $"Last game rebounds: {selectedPlayer.LastRebounds}";
                labelLastAssists.Text = $"Last game assists: {selectedPlayer.LastAssists}";

                
                axWindowsMediaPlayer.URL = selectedPlayer.VideoPath;
                axWindowsMediaPlayer.Ctlcontrols.play();
                axWindowsMediaPlayer.stretchToFit = true;

                pictureBoxPlayer.Image = Image.FromFile(selectedPlayer.ImagePath);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelLastPoints_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}