using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_W12
{
    public partial class Remove : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlDataReader dr;
        string code;
        string connect = "server=localhost;uid=root;pwd=;database=premier_league";
        DataTable a1 = new DataTable();
        DataTable a2 = new DataTable();
        public Remove()
        {
            InitializeComponent();
        }

        public void updateplyr()
        {
            a2 = new DataTable();
            code = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{teamname.SelectedValue}' and n.nationality_id = p.nationality_id and p.status = '1';"; ;
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a2);
            dgv4.DataSource = a2;
        }

        string idp;
        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idp = dgv4.SelectedCells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a2.Rows.Count < 11)
            {
                MessageBox.Show("Player is less than 11");
            }
            else
            {
                try
                {
                    code = $"update manager set working = '0' where manager_id = '{idp}';";
                    con = new MySqlConnection(connect);
                    cmd = new MySqlCommand(code, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.Close();
                }
                updateplyr();
            }
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            code = "SELECT team_name as 'Team', team_id as 'id team' FROM team;";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a1);
            teamname.DataSource = a1;
            teamname.DisplayMember = "Team";
            teamname.ValueMember = "id team";
        }

        private void teamname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateplyr();
        }
    }
}
