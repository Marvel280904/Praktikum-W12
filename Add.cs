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
    public partial class Add : Form
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
        public Add()
        {
            InitializeComponent();
        }

        public void updateplayer()
        {
            a1 = new DataTable();
            code = "SELECT * FROM player;";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a1);
            dgv1.DataSource = a1;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            code = "SELECT nation as 'Negara', nationality_id as 'ID Negara' FROM nationality;";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a2);
            Na.DataSource = a2;
            Na.DisplayMember = "Negara";
            Na.ValueMember = "ID Negara";

            code = "SELECT team_name as 'Team', team_id as 'ID' FROM team;";
            con = new MySqlConnection(connect);
            cmd = new MySqlCommand(code, con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(a3);
            TN.DataSource = a3;
            TN.DisplayMember = "Team";
            TN.ValueMember = "ID";

            updateplayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idnegara = Na.SelectedValue.ToString();
            string idteam = TN.SelectedValue.ToString();
            string bday = B.Text; string status = "1"; string delet = "0";
            try
            {
                code = $"insert into player values ('{ID.Text}', {TM.Text}, '{N.Text}', '{idnegara}', '{Pos.Text}', {H.Text}, {W.Text}, '{bday}', '{idteam}', {status}, {delet})";
                con = new MySqlConnection(connect);
                cmd = new MySqlCommand(code, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            updateplayer();
        }
    }
}
