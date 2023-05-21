using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Praktikum_W12
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlDataReader dr;
        string code;
        string connect = "server=localhost;uid=root;pwd=;database=premier_league";
        DataTable a1 = new DataTable();
        DataTable a2 = new DataTable();
        DataTable a3 = new DataTable();
        DataTable a4 = new DataTable();
        DataTable a5 = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        public void updatemanager()
        {
            a2 = new DataTable();
            code = $"select m.manager_id,m.manager_name,t.team_name,m.birthdate, m.nationality_id, m.working from manager m\r\nleft join team t on m.manager_id = t.manager_id where t.team_id = '{namateam.SelectedValue.ToString()}';";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a2);
            dgv2.DataSource = a2;

            a3 = new DataTable();
            code = $"select m.manager_id,m.manager_name,m.birthdate, m.nationality_id, m.working from manager m  where m.working = '0';";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a3);
            dgv3.DataSource = a3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            code = "SELECT team_name as 'Team', team_id as 'id team' FROM team;";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a1);
            namateam.DataSource = a1;
            namateam.DisplayMember = "Team";
            namateam.ValueMember = "id team";
        }

        private void namateam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updatemanager();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                code = $"update team set manager_id = '{gkrja}' where team_id = '{namateam.SelectedValue}';";
                con = new MySqlConnection(connect);
                cmd = new MySqlCommand(code, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }

            try
            {
                code = $"update manager set working = '0' where manager_id = '{idm}';";
                con = new MySqlConnection(connect);
                cmd = new MySqlCommand(code, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }

            try
            {
                code = $"update manager set working = '1' where manager_id = '{gkrja}';";
                con = new MySqlConnection(connect);
                cmd = new MySqlCommand(code, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            updatemanager();
        }

        string idm;
        string gkrja;
        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idm = dgv2.SelectedCells[0].Value.ToString();
            code = $"SELECT nation from nationality where nationality_id = '{dgv2.SelectedCells[4].Value}';";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a5);
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gkrja = dgv3.SelectedCells[0].Value.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void namateam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
