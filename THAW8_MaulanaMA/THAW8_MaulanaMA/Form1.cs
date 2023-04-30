using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THAW8_MaulanaMA
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectionString;
        string sqlQuery;
        DataTable dtTim = new DataTable();
        DataTable dtTim1 = new DataTable();
        DataTable dtTim2 = new DataTable();
        DataTable dtPemain = new DataTable();
        public Form1()
        {
            InitializeComponent();
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league;port=8111";//port diganti
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open();

            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim);
            cmbTeam.DataSource = dtTim;
            cmbTeam.ValueMember = "Team ID";
            cmbTeam.DisplayMember = "Team Name";

            
            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim1);
            cmbTeam1.DataSource = dtTim1;
            cmbTeam1.ValueMember = "Team ID";
            cmbTeam1.DisplayMember = "Team Name";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPemain.Clear();
            sqlQuery = $"select player_name as 'Player Name', player_id as 'Player ID' from player, team where team.team_id = player.team_id and '{cmbTeam.SelectedValue.ToString()}' = player.team_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            cmbPlayer.DataSource = dtPemain;
            cmbPlayer.ValueMember = "Player ID";
            cmbPlayer.DisplayMember = "Player Name";
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void cmbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void showMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            sqlQuery = $"SELECT player_name as 'Name',team_name as 'Team',playing_pos as 'Position',nation as 'Nationality',team_number as 'Number', sum(if(type = 'CY',1,0))as 'Yellow Card', sum(if(type = 'CR',1,0))as 'Red Card',sum(if(type = 'GO',1,0))as 'Goal', sum(if(type = 'PM',1,0))as 'Penalty Miss' FROM player INNER JOIN team ON player.team_id = team.team_id INNER JOIN nationality ON player.nationality_id = nationality.nationality_id INNER JOIN dmatch ON dmatch.player_id = player.player_id and dmatch.team_id = team.team_id WHERE player.player_id = '{cmbPlayer.SelectedValue.ToString()}'order by 1 asc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            string kuning = data.Rows[0]["Yellow Card"].ToString();
            string merah = data.Rows[0]["Red Card"].ToString();
            string gol = data.Rows[0]["Goal"].ToString();
            string miss = data.Rows[0]["Penalty Miss"].ToString();

            lblName.Text = data.Rows[0][0].ToString();
            lblTeam.Text = data.Rows[0][1].ToString();
            lblPos.Text = data.Rows[0][2].ToString();
            lblNation.Text = data.Rows[0][3].ToString();
            lblNum.Text = data.Rows[0][4].ToString();

            if (kuning.Length >= 1)
            {
                lblCY.Text = kuning;
            }
            else
            {
                lblCY.Text = "0";
            }
            if (merah.Length >= 1)
            {
                lblCR.Text = merah;
            }
            else
            {
                lblCR.Text = "0";
            }
            if (gol.Length >= 1)
            {
                lblGO.Text = gol;
            }
            else
            {
                lblGO.Text = "0";
            }
            if (miss.Length >= 1)
            {
                lblPM.Text = miss;
            }
            else
            {
                lblPM.Text = "0";
            }
        }

        private void cmbTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable home = new DataTable();
            sqlQuery = $"select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from team t, player p where t.team_id = p.team_id and t.team_id = '{cmbTeam1.SelectedValue.ToString()}' order by 2 asc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(home);
            DGV1.DataSource = home;

            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim2);
            cmbTeam2.DataSource = dtTim2;
            cmbTeam2.ValueMember = "Team ID";
            cmbTeam2.DisplayMember = "Team Name";
        }

        private void cmbTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable away = new DataTable();
            sqlQuery = $"select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from team t, player p where t.team_id = p.team_id and t.team_id = '{cmbTeam2.SelectedValue.ToString()}' order by 2 asc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(away);
            DGV2.DataSource = away;
        }
        

    }
}
