using Microsoft.Data.Sqlite;
using ServiceStack;
using ServiceStack.Script;
using System.Data.SQLite;
using System.Diagnostics;
namespace unicatalog
{
    public partial class form_autentificare : Form
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=CATALOG1.db; Version = 3; New = True; Compress = True; ");

        public form_autentificare()
        {
            InitializeComponent();
        }


        private void btn_signin_Click(object sender, EventArgs e)
        {
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            SQLiteDataReader sqlite_datareader;
            sqlite_conn.Open();

            sqlite_cmd.CommandText = $"SELECT NUME, PAROLA FROM CONT;";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                string nume = sqlite_datareader.GetString(0);
                string parola = sqlite_datareader.GetString(1);
                // string tip = sqlite_datareader.GetString(2);

                if (nume == username.Text && parola == password.Text)
                {
                    var form2 = new Form_studenti();
                    form2.Show();
                    this.Visible = false;
                }

            }

            sqlite_conn.Close();
        }

        /// <summary>
        /// Cand este apasat enter 
        /// butonul de sign in este apasat automat
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_signin_Click(sender, e);
            }
        }

    }
}