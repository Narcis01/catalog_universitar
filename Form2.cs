using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static unicatalog.Service.Service;
using System.Data.SQLite;
using System.Security.Permissions;

namespace unicatalog
{

    public partial class Form_studenti : Form
    {

        public Form_studenti()
        {
            InitializeComponent();
        }

        private void Form_studenti_Load(object sender, EventArgs e)
        {
            vizibilitatePanel(true, false, false, false);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new Service.Service();
            string nr_matricol = tb_nr_matricol.Text;
            string nume = tb_nume.Text;
            string initiala = tb_initiala.Text;
            string prenume = tb_prenume.Text;
            string cnp = tb_cnp.Text;
            string ciclu = tb_ciclu.Text;
            string medie = tb_medie.Text;
            string grupaString = grupa.Text;
            service.addStudent(nume, prenume, initiala, cnp.ToInt(), ciclu, medie.ToInt(), grupaString);
            string password = "1234";
            service.addCont(nume, password, 1);

            Debug.WriteLine("...Student salvat...");

        }


        private void adaugaStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vizibilitatePanel(true, false, false, false);
        }

        private void adaugaCadruDidacticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vizibilitatePanel(false, true, false, false);


        }
        private void adaugareNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vizibilitatePanel(false, false, true, false);

            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            SQLiteCommand cnd = new SQLiteCommand("SELECT * FROM PROFESOR", sqlite_conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cnd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            cnd.ExecuteNonQuery();
            sqlite_conn.Clone();

            comboProfesor.DataSource = ds.Tables[0];
            comboProfesor.DisplayMember = "NUME";
            comboProfesor.ValueMember = "ID";


            cnd = new SQLiteCommand("SELECT * FROM STUDENT", sqlite_conn);
            da = new SQLiteDataAdapter(cnd);
            ds = new DataSet();

            da.Fill(ds);
            cnd.ExecuteNonQuery();
            sqlite_conn.Clone();

            listBox_studenti.DataSource = ds.Tables[0];
            listBox_studenti.DisplayMember = "NUME";
            listBox_studenti.ValueMember = "ID";


        }
        private void situatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vizibilitatePanel(false, false, false, true);

            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            SQLiteCommand cnd = new SQLiteCommand("SELECT * FROM STUDENT", sqlite_conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cnd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            cnd.ExecuteNonQuery();
            sqlite_conn.Clone();

            comboStudent.DataSource = ds.Tables[0];
            comboStudent.DisplayMember = "NUME";
            comboStudent.ValueMember = "ID";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var service = new Service.Service();

            service.deleteProfesor(deleteCadru.Text);
        }

        private void sterger_Stud_Click(object sender, EventArgs e)
        {
            var service = new Service.Service();

            service.deleteStudent(deleteStudent.Text);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            var service = new Service.Service();

            service.addProfesor(numeProf.Text);
        }

        private void save_Button_Click(object sender, EventArgs e)
        {

            var service = new Service.Service();

            service.addStudent(tb_nume.Text, tb_prenume.Text, tb_initiala.Text, tb_cnp.Text.ToInt(), tb_ciclu.Text, tb_medie.Text.ToInt(), grupa.Text);
        }

        private void vizibilitatePanel(bool panelStudentVisible, bool panelCadruDidacticVisible, bool adaugaNoteVisible, bool panelSituatieVisible)
        {
            panel_student.Visible = panelStudentVisible;
            panel_cadru_didactic.Visible = panelCadruDidacticVisible;
            panel_adauga_note.Visible = adaugaNoteVisible;
            panel_situatie.Visible = panelSituatieVisible;
        }


        private void btn_salvare_nota_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            int nota = tb_nota.Text.ToInt();
            string student = listBox_studenti.SelectedItem.ToString();
            string materie = listBox_materii.SelectedItem.ToString();
            var service = new Service.Service();

            SQLiteCommand cnd = new SQLiteCommand($"SELECT ID FROM STUDENT WHERE NUME = '{student}';", sqlite_conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cnd);

            service.addNote(1, materie, nota);

            Debug.WriteLine("NOTA SALVATA!");
        }

        private void comboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_situatie.Items.Clear();
            
            int nota = new Random().Next(4, 10);
            double suma = nota;
            listBox_situatie.Items.Add($"ROMANA, {nota}");

            nota = new Random().Next(4, 10);
            suma += nota;
            listBox_situatie.Items.Add($"ALGAD, {nota}");

            nota = new Random().Next(4, 10);
            suma += nota;
            listBox_situatie.Items.Add($"MS, {nota}");

            nota = new Random().Next(4, 10);
            suma += nota;
            listBox_situatie.Items.Add($"PCLP, {nota}");

            nota = new Random().Next(4, 10);
            suma += nota;
            listBox_situatie.Items.Add($"SMG, {nota}");

            nota = new Random().Next(4, 10);
            suma += nota;
            listBox_situatie.Items.Add($"FMS, {nota}");

            nota = new Random().Next(4, 10);
            suma += nota;
            listBox_situatie.Items.Add($"BMW, {nota}");

            lbl_medie_student.Text = $"Media: {(suma / 7).ToString("#.##")}";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string content = comboStudent.Text + "\n";
            foreach (string item in listBox_situatie.Items)
            {
                content += "\n";
                content += item.ToString();
            }
            content += $"\n\n{lbl_medie_student.Text}";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(content);
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("Could not save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
