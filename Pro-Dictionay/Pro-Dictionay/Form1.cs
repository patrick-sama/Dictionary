using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pro_Dictionay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public System.Data.OleDb.OleDbConnection ConnectToAccess()
        {
            System.Data.OleDb.OleDbConnection conn = new
                System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= C:\Program Files\Imi Project\Pro-Dictionary\dizionario.mdb";
            try
            {
                conn.Open();
                // Insert code to process data.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            return conn;

        }

        private void search_Click(object sender, EventArgs e)
        {
            Lb_Eng.Items.Clear();
            Lb_Esp.Items.Clear();
            Lb_Fra.Items.Clear();
            Lb_Ita.Items.Clear();
            String s = textBox.Text.ToUpper();
            String query = "SELECT ita , eng , spa , fra FROM tbl_voci " +
                           "WHERE ita LIKE '%" + s + "%' OR eng LIKE '%" + s + "%' OR spa LIKE '%" + s + "%' OR fra LIKE '%" + s + "%'";
            OleDbConnection conn = ConnectToAccess();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query,conn );
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                Lb_Ita.Items.Add( dt.Rows[i][0].ToString());
                Lb_Eng.Items.Add(dt.Rows[i][1].ToString());
                Lb_Esp.Items.Add(dt.Rows[i][2].ToString());
                Lb_Fra.Items.Add(dt.Rows[i][3].ToString());
            }
            
            
            conn.Dispose();
        }

        private void Lb_Ita_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lb_Eng.SelectedIndex = Lb_Ita.SelectedIndex;
            Lb_Esp.SelectedIndex = Lb_Ita.SelectedIndex;
            Lb_Fra.SelectedIndex = Lb_Ita.SelectedIndex;
        }

        private void Lb_Esp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lb_Eng.SelectedIndex = Lb_Esp.SelectedIndex;
            Lb_Ita.SelectedIndex = Lb_Esp.SelectedIndex;
            Lb_Fra.SelectedIndex = Lb_Esp.SelectedIndex;
        }

        private void Lb_Eng_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lb_Esp.SelectedIndex = Lb_Eng.SelectedIndex;
            Lb_Ita.SelectedIndex = Lb_Eng.SelectedIndex;
            Lb_Fra.SelectedIndex = Lb_Eng.SelectedIndex;
        }

        private void Lb_Fra_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lb_Esp.SelectedIndex = Lb_Fra.SelectedIndex;
            Lb_Ita.SelectedIndex = Lb_Fra.SelectedIndex;
            Lb_Eng.SelectedIndex = Lb_Fra.SelectedIndex;
        }

        private void Lb_Ita_DoubleClick(object sender, EventArgs e)
        {
            txtselected.Text = Lb_Ita.SelectedItem.ToString();
        }

        private void Lb_Esp_DoubleClick(object sender, EventArgs e)
        {
            txtselected.Text = Lb_Esp.SelectedItem.ToString();
        }

        private void Lb_Eng_DoubleClick(object sender, EventArgs e)
        {
            txtselected.Text = Lb_Eng.SelectedItem.ToString();
        }

        private void Lb_Fra_DoubleClick(object sender, EventArgs e)
        {
            txtselected.Text = Lb_Fra.SelectedItem.ToString();
        }
    }
}
