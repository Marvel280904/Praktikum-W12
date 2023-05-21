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

namespace Praktikum_W12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 edit = new Form2();
            edit.Close();
            Add addplyr = new Add();
            addplyr.Show();
            Remove rmv = new Remove();
            rmv.Close();
        }

        private void editManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 edit = new Form2();
            edit.Show();
            Add addplyr = new Add();
            addplyr.Close();
            Remove rmv = new Remove();
            rmv.Close();
        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove rmv = new Remove();
            rmv.Show();
            Form2 edit = new Form2();
            edit.Close();
            Add addplyr = new Add();
            addplyr.Close();
        }
    }
}
