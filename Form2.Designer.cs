namespace unicatalog
{
    partial class Form_studenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            adaugaStudentToolStripMenuItem = new ToolStripMenuItem();
            adaugaCadruDidacticToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            cadruDidacticToolStripMenuItem = new ToolStripMenuItem();
            adaugareNoteToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            situatieToolStripMenuItem = new ToolStripMenuItem();
            panel_cadru_didactic = new Panel();
            label11 = new Label();
            deleteCadru = new TextBox();
            button2 = new Button();
            label10 = new Label();
            button1 = new Button();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            numeProf = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel_adauga_note = new Panel();
            btn_salvare_nota = new Button();
            label16 = new Label();
            tb_nota = new TextBox();
            label15 = new Label();
            listBox_studenti = new ListBox();
            label14 = new Label();
            comboProfesor = new ComboBox();
            label13 = new Label();
            listBox_materii = new ListBox();
            comboStudent = new ComboBox();
            label17 = new Label();
            listBox_situatie = new ListBox();
            panel_situatie = new Panel();
            btn_export = new Button();
            panel_student = new Panel();
            label12 = new Label();
            deleteStudent = new TextBox();
            sterger_Stud = new Button();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            save_Button = new Button();
            lbl_medie = new Label();
            tb_medie = new TextBox();
            lbl_ciclu = new Label();
            tb_ciclu = new TextBox();
            grupa = new TextBox();
            lbl_initiala = new Label();
            tb_initiala = new TextBox();
            lbl_prenume = new Label();
            tb_prenume = new TextBox();
            lbl_cnp = new Label();
            lbl_inscriere = new Label();
            tb_cnp = new TextBox();
            label1 = new Label();
            label18 = new Label();
            tb_nume = new TextBox();
            lbl_nr_matricol = new Label();
            tb_nr_matricol = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            lbl_medie_student = new Label();
            menuStrip1.SuspendLayout();
            panel_cadru_didactic.SuspendLayout();
            panel_adauga_note.SuspendLayout();
            panel_situatie.SuspendLayout();
            panel_student.SuspendLayout();
            SuspendLayout();
            // 
            // adaugaToolStripMenuItem
            // 
            adaugaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaStudentToolStripMenuItem, adaugaCadruDidacticToolStripMenuItem });
            adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            adaugaToolStripMenuItem.Size = new Size(75, 24);
            adaugaToolStripMenuItem.Text = "Adauga";
            // 
            // adaugaStudentToolStripMenuItem
            // 
            adaugaStudentToolStripMenuItem.Name = "adaugaStudentToolStripMenuItem";
            adaugaStudentToolStripMenuItem.Size = new Size(246, 26);
            adaugaStudentToolStripMenuItem.Text = "Adauga Student";
            adaugaStudentToolStripMenuItem.Click += adaugaStudentToolStripMenuItem_Click;
            // 
            // adaugaCadruDidacticToolStripMenuItem
            // 
            adaugaCadruDidacticToolStripMenuItem.Name = "adaugaCadruDidacticToolStripMenuItem";
            adaugaCadruDidacticToolStripMenuItem.Size = new Size(246, 26);
            adaugaCadruDidacticToolStripMenuItem.Text = "Adauga Cadru Didactic";
            adaugaCadruDidacticToolStripMenuItem.Click += adaugaCadruDidacticToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, cadruDidacticToolStripMenuItem, studentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(278, 30);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadruDidacticToolStripMenuItem
            // 
            cadruDidacticToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugareNoteToolStripMenuItem });
            cadruDidacticToolStripMenuItem.Name = "cadruDidacticToolStripMenuItem";
            cadruDidacticToolStripMenuItem.Size = new Size(121, 24);
            cadruDidacticToolStripMenuItem.Text = "Cadru Didactic";
            // 
            // adaugareNoteToolStripMenuItem
            // 
            adaugareNoteToolStripMenuItem.Name = "adaugareNoteToolStripMenuItem";
            adaugareNoteToolStripMenuItem.Size = new Size(194, 26);
            adaugareNoteToolStripMenuItem.Text = "Adaugare Note";
            adaugareNoteToolStripMenuItem.Click += adaugareNoteToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { situatieToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(74, 24);
            studentToolStripMenuItem.Text = "Student";
            // 
            // situatieToolStripMenuItem
            // 
            situatieToolStripMenuItem.Name = "situatieToolStripMenuItem";
            situatieToolStripMenuItem.Size = new Size(142, 26);
            situatieToolStripMenuItem.Text = "Situatie";
            situatieToolStripMenuItem.Click += situatieToolStripMenuItem_Click;
            // 
            // panel_cadru_didactic
            // 
            panel_cadru_didactic.Controls.Add(label11);
            panel_cadru_didactic.Controls.Add(deleteCadru);
            panel_cadru_didactic.Controls.Add(button2);
            panel_cadru_didactic.Controls.Add(label10);
            panel_cadru_didactic.Controls.Add(button1);
            panel_cadru_didactic.Controls.Add(textBox7);
            panel_cadru_didactic.Controls.Add(textBox5);
            panel_cadru_didactic.Controls.Add(numeProf);
            panel_cadru_didactic.Controls.Add(label8);
            panel_cadru_didactic.Controls.Add(label7);
            panel_cadru_didactic.Controls.Add(label6);
            panel_cadru_didactic.Controls.Add(textBox3);
            panel_cadru_didactic.Controls.Add(textBox4);
            panel_cadru_didactic.Controls.Add(label4);
            panel_cadru_didactic.Controls.Add(label5);
            panel_cadru_didactic.Location = new Point(0, 40);
            panel_cadru_didactic.Name = "panel_cadru_didactic";
            panel_cadru_didactic.Size = new Size(722, 479);
            panel_cadru_didactic.TabIndex = 22;
            panel_cadru_didactic.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(376, 17);
            label11.Name = "label11";
            label11.Size = new Size(64, 18);
            label11.TabIndex = 53;
            label11.Text = "Stergere";
            // 
            // deleteCadru
            // 
            deleteCadru.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCadru.Location = new Point(376, 85);
            deleteCadru.Name = "deleteCadru";
            deleteCadru.Size = new Size(180, 24);
            deleteCadru.TabIndex = 52;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(376, 127);
            button2.Name = "button2";
            button2.Size = new Size(181, 29);
            button2.TabIndex = 51;
            button2.Text = "stergere";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(91, 17);
            label10.Name = "label10";
            label10.Size = new Size(158, 18);
            label10.TabIndex = 50;
            label10.Text = "Adauga Cadru Didactic";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(91, 395);
            button1.Name = "button1";
            button1.Size = new Size(226, 29);
            button1.TabIndex = 46;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(91, 333);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(149, 24);
            textBox7.TabIndex = 45;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(90, 272);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 24);
            textBox5.TabIndex = 44;
            // 
            // numeProf
            // 
            numeProf.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numeProf.Location = new Point(90, 213);
            numeProf.Name = "numeProf";
            numeProf.Size = new Size(150, 24);
            numeProf.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(91, 311);
            label8.Name = "label8";
            label8.Size = new Size(25, 18);
            label8.TabIndex = 42;
            label8.Text = "rol";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(90, 249);
            label7.Name = "label7";
            label7.Size = new Size(30, 18);
            label7.TabIndex = 41;
            label7.Text = "titlu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(91, 185);
            label6.Name = "label6";
            label6.Size = new Size(45, 18);
            label6.TabIndex = 40;
            label6.Text = "nume";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(91, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 24);
            textBox3.TabIndex = 39;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(91, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 24);
            textBox4.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(90, 125);
            label4.Name = "label4";
            label4.Size = new Size(49, 18);
            label4.TabIndex = 37;
            label4.Text = "parola";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(91, 57);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 36;
            label5.Text = "username";
            // 
            // panel_adauga_note
            // 
            panel_adauga_note.Controls.Add(btn_salvare_nota);
            panel_adauga_note.Controls.Add(label16);
            panel_adauga_note.Controls.Add(tb_nota);
            panel_adauga_note.Controls.Add(label15);
            panel_adauga_note.Controls.Add(listBox_studenti);
            panel_adauga_note.Controls.Add(label14);
            panel_adauga_note.Controls.Add(comboProfesor);
            panel_adauga_note.Controls.Add(label13);
            panel_adauga_note.Controls.Add(listBox_materii);
            panel_adauga_note.Location = new Point(0, 40);
            panel_adauga_note.Margin = new Padding(3, 4, 3, 4);
            panel_adauga_note.Name = "panel_adauga_note";
            panel_adauga_note.Size = new Size(753, 597);
            panel_adauga_note.TabIndex = 23;
            // 
            // btn_salvare_nota
            // 
            btn_salvare_nota.Location = new Point(530, 215);
            btn_salvare_nota.Margin = new Padding(3, 4, 3, 4);
            btn_salvare_nota.Name = "btn_salvare_nota";
            btn_salvare_nota.Size = new Size(114, 31);
            btn_salvare_nota.TabIndex = 8;
            btn_salvare_nota.Text = "Salveaza";
            btn_salvare_nota.UseVisualStyleBackColor = true;
            btn_salvare_nota.Click += btn_salvare_nota_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(530, 129);
            label16.Name = "label16";
            label16.Size = new Size(42, 20);
            label16.TabIndex = 7;
            label16.Text = "Nota";
            // 
            // tb_nota
            // 
            tb_nota.Location = new Point(530, 153);
            tb_nota.Margin = new Padding(3, 4, 3, 4);
            tb_nota.Name = "tb_nota";
            tb_nota.Size = new Size(114, 27);
            tb_nota.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(279, 87);
            label15.Name = "label15";
            label15.Size = new Size(64, 20);
            label15.TabIndex = 5;
            label15.Text = "Studenti";
            // 
            // listBox_studenti
            // 
            listBox_studenti.FormattingEnabled = true;
            listBox_studenti.ItemHeight = 20;
            listBox_studenti.Location = new Point(279, 129);
            listBox_studenti.Margin = new Padding(3, 4, 3, 4);
            listBox_studenti.Name = "listBox_studenti";
            listBox_studenti.Size = new Size(222, 324);
            listBox_studenti.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 87);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 3;
            label14.Text = "Materii";
            // 
            // comboProfesor
            // 
            comboProfesor.FormattingEnabled = true;
            comboProfesor.Location = new Point(208, 17);
            comboProfesor.Margin = new Padding(3, 4, 3, 4);
            comboProfesor.Name = "comboProfesor";
            comboProfesor.Size = new Size(138, 28);
            comboProfesor.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 21);
            label13.Name = "label13";
            label13.Size = new Size(172, 20);
            label13.TabIndex = 1;
            label13.Text = "Selectare Cadru Didactic";
            // 
            // listBox_materii
            // 
            listBox_materii.FormattingEnabled = true;
            listBox_materii.ItemHeight = 20;
            listBox_materii.Items.AddRange(new object[] { "ROMANA", "ALGAD", "MS", "PCLP", "SMG", "FMS", "BMW" });
            listBox_materii.Location = new Point(24, 129);
            listBox_materii.Margin = new Padding(3, 4, 3, 4);
            listBox_materii.Name = "listBox_materii";
            listBox_materii.Size = new Size(222, 324);
            listBox_materii.TabIndex = 0;
            // 
            // comboStudent
            // 
            comboStudent.FormattingEnabled = true;
            comboStudent.Location = new Point(162, 33);
            comboStudent.Margin = new Padding(3, 4, 3, 4);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new Size(138, 28);
            comboStudent.TabIndex = 0;
            comboStudent.SelectedIndexChanged += comboStudent_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(32, 37);
            label17.Name = "label17";
            label17.Size = new Size(123, 20);
            label17.TabIndex = 1;
            label17.Text = "Selectare student";
            // 
            // listBox_situatie
            // 
            listBox_situatie.FormattingEnabled = true;
            listBox_situatie.ItemHeight = 20;
            listBox_situatie.Location = new Point(32, 113);
            listBox_situatie.Margin = new Padding(3, 4, 3, 4);
            listBox_situatie.Name = "listBox_situatie";
            listBox_situatie.Size = new Size(309, 364);
            listBox_situatie.TabIndex = 2;
            // 
            // panel_situatie
            // 
            panel_situatie.Controls.Add(lbl_medie_student);
            panel_situatie.Controls.Add(btn_export);
            panel_situatie.Controls.Add(label17);
            panel_situatie.Controls.Add(comboStudent);
            panel_situatie.Controls.Add(listBox_situatie);
            panel_situatie.Location = new Point(0, 40);
            panel_situatie.Margin = new Padding(3, 4, 3, 4);
            panel_situatie.Name = "panel_situatie";
            panel_situatie.Size = new Size(736, 575);
            panel_situatie.TabIndex = 23;
            // 
            // btn_export
            // 
            btn_export.Location = new Point(490, 280);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(94, 29);
            btn_export.TabIndex = 3;
            btn_export.Text = "Export CSV";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btnExport_Click;
            // 
            // panel_student
            // 
            panel_student.Controls.Add(label12);
            panel_student.Controls.Add(deleteStudent);
            panel_student.Controls.Add(sterger_Stud);
            panel_student.Controls.Add(label9);
            panel_student.Controls.Add(textBox2);
            panel_student.Controls.Add(textBox1);
            panel_student.Controls.Add(label3);
            panel_student.Controls.Add(label2);
            panel_student.Controls.Add(save_Button);
            panel_student.Controls.Add(lbl_medie);
            panel_student.Controls.Add(tb_medie);
            panel_student.Controls.Add(lbl_ciclu);
            panel_student.Controls.Add(tb_ciclu);
            panel_student.Controls.Add(grupa);
            panel_student.Controls.Add(lbl_initiala);
            panel_student.Controls.Add(tb_initiala);
            panel_student.Controls.Add(lbl_prenume);
            panel_student.Controls.Add(tb_prenume);
            panel_student.Controls.Add(lbl_cnp);
            panel_student.Controls.Add(lbl_inscriere);
            panel_student.Controls.Add(tb_cnp);
            panel_student.Controls.Add(label1);
            panel_student.Controls.Add(label18);
            panel_student.Controls.Add(tb_nume);
            panel_student.Controls.Add(lbl_nr_matricol);
            panel_student.Controls.Add(tb_nr_matricol);
            panel_student.Location = new Point(0, 40);
            panel_student.Name = "panel_student";
            panel_student.Size = new Size(755, 611);
            panel_student.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(520, 12);
            label12.Name = "label12";
            label12.Size = new Size(64, 18);
            label12.TabIndex = 56;
            label12.Text = "Stergere";
            // 
            // deleteStudent
            // 
            deleteStudent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteStudent.Location = new Point(520, 88);
            deleteStudent.Name = "deleteStudent";
            deleteStudent.Size = new Size(202, 24);
            deleteStudent.TabIndex = 55;
            // 
            // sterger_Stud
            // 
            sterger_Stud.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sterger_Stud.Location = new Point(520, 125);
            sterger_Stud.Name = "sterger_Stud";
            sterger_Stud.Size = new Size(202, 29);
            sterger_Stud.TabIndex = 54;
            sterger_Stud.Text = "Sterge";
            sterger_Stud.UseVisualStyleBackColor = true;
            sterger_Stud.Click += sterger_Stud_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(54, 12);
            label9.Name = "label9";
            label9.Size = new Size(111, 18);
            label9.TabIndex = 50;
            label9.Text = "Adauga Student";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(54, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 24);
            textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(54, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 24);
            textBox1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 125);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 33;
            label3.Text = "parola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 65);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 32;
            label2.Text = "username";
            // 
            // save_Button
            // 
            save_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            save_Button.Location = new Point(54, 487);
            save_Button.Name = "save_Button";
            save_Button.Size = new Size(424, 29);
            save_Button.TabIndex = 31;
            save_Button.Text = "Salveaza";
            save_Button.UseVisualStyleBackColor = true;
            save_Button.Click += save_Button_Click;
            // 
            // lbl_medie
            // 
            lbl_medie.AutoSize = true;
            lbl_medie.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_medie.Location = new Point(273, 389);
            lbl_medie.Name = "lbl_medie";
            lbl_medie.Size = new Size(108, 18);
            lbl_medie.TabIndex = 28;
            lbl_medie.Text = "Medie inscriere";
            // 
            // tb_medie
            // 
            tb_medie.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_medie.Location = new Point(275, 417);
            tb_medie.Name = "tb_medie";
            tb_medie.Size = new Size(202, 24);
            tb_medie.TabIndex = 30;
            // 
            // lbl_ciclu
            // 
            lbl_ciclu.AutoSize = true;
            lbl_ciclu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ciclu.Location = new Point(273, 321);
            lbl_ciclu.Name = "lbl_ciclu";
            lbl_ciclu.Size = new Size(136, 18);
            lbl_ciclu.TabIndex = 27;
            lbl_ciclu.Text = "Ciclu de invatamant";
            // 
            // tb_ciclu
            // 
            tb_ciclu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ciclu.Location = new Point(273, 349);
            tb_ciclu.Name = "tb_ciclu";
            tb_ciclu.Size = new Size(202, 24);
            tb_ciclu.TabIndex = 29;
            // 
            // grupa
            // 
            grupa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grupa.Location = new Point(273, 279);
            grupa.Name = "grupa";
            grupa.Size = new Size(202, 24);
            grupa.TabIndex = 26;
            // 
            // lbl_initiala
            // 
            lbl_initiala.AutoSize = true;
            lbl_initiala.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_initiala.Location = new Point(54, 317);
            lbl_initiala.Name = "lbl_initiala";
            lbl_initiala.Size = new Size(90, 18);
            lbl_initiala.TabIndex = 19;
            lbl_initiala.Text = "Initiala tatalui";
            // 
            // tb_initiala
            // 
            tb_initiala.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_initiala.Location = new Point(54, 349);
            tb_initiala.Name = "tb_initiala";
            tb_initiala.Size = new Size(202, 24);
            tb_initiala.TabIndex = 23;
            // 
            // lbl_prenume
            // 
            lbl_prenume.AutoSize = true;
            lbl_prenume.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_prenume.Location = new Point(54, 389);
            lbl_prenume.Name = "lbl_prenume";
            lbl_prenume.Size = new Size(68, 18);
            lbl_prenume.TabIndex = 20;
            lbl_prenume.Text = "Prenume";
            // 
            // tb_prenume
            // 
            tb_prenume.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_prenume.Location = new Point(54, 417);
            tb_prenume.Name = "tb_prenume";
            tb_prenume.Size = new Size(202, 24);
            tb_prenume.TabIndex = 24;
            // 
            // lbl_cnp
            // 
            lbl_cnp.AutoSize = true;
            lbl_cnp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cnp.Location = new Point(273, 185);
            lbl_cnp.Name = "lbl_cnp";
            lbl_cnp.Size = new Size(40, 18);
            lbl_cnp.TabIndex = 21;
            lbl_cnp.Text = "CNP";
            // 
            // lbl_inscriere
            // 
            lbl_inscriere.AutoSize = true;
            lbl_inscriere.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_inscriere.Location = new Point(273, 251);
            lbl_inscriere.Name = "lbl_inscriere";
            lbl_inscriere.Size = new Size(49, 18);
            lbl_inscriere.TabIndex = 22;
            lbl_inscriere.Text = "Grupa";
            // 
            // tb_cnp
            // 
            tb_cnp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_cnp.Location = new Point(273, 212);
            tb_cnp.Name = "tb_cnp";
            tb_cnp.Size = new Size(202, 24);
            tb_cnp.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 249);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 12;
            label1.Text = "Nume";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(520, 65);
            label18.Name = "label18";
            label18.Size = new Size(48, 18);
            label18.TabIndex = 57;
            label18.Text = "Nume";
            // 
            // tb_nume
            // 
            tb_nume.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nume.Location = new Point(54, 280);
            tb_nume.Name = "tb_nume";
            tb_nume.Size = new Size(202, 24);
            tb_nume.TabIndex = 13;
            // 
            // lbl_nr_matricol
            // 
            lbl_nr_matricol.AutoSize = true;
            lbl_nr_matricol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nr_matricol.Location = new Point(54, 185);
            lbl_nr_matricol.Name = "lbl_nr_matricol";
            lbl_nr_matricol.Size = new Size(110, 18);
            lbl_nr_matricol.TabIndex = 10;
            lbl_nr_matricol.Text = "Numar matricol";
            // 
            // tb_nr_matricol
            // 
            tb_nr_matricol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nr_matricol.Location = new Point(54, 213);
            tb_nr_matricol.Name = "tb_nr_matricol";
            tb_nr_matricol.Size = new Size(202, 24);
            tb_nr_matricol.TabIndex = 11;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "csvfile|*.csv";
            saveFileDialog1.Title = "ExportFile";
            // 
            // lbl_medie_student
            // 
            lbl_medie_student.AutoSize = true;
            lbl_medie_student.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_medie_student.Location = new Point(417, 113);
            lbl_medie_student.Name = "lbl_medie_student";
            lbl_medie_student.Size = new Size(89, 35);
            lbl_medie_student.TabIndex = 4;
            lbl_medie_student.Text = "Media:";
            // 
            // Form_studenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 653);
            Controls.Add(menuStrip1);
            Controls.Add(panel_situatie);
            Controls.Add(panel_student);
            Controls.Add(panel_adauga_note);
            Controls.Add(panel_cadru_didactic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_studenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalog electronic";
            FormClosed += Form2_FormClosed;
            Load += Form_studenti_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_cadru_didactic.ResumeLayout(false);
            panel_cadru_didactic.PerformLayout();
            panel_adauga_note.ResumeLayout(false);
            panel_adauga_note.PerformLayout();
            panel_situatie.ResumeLayout(false);
            panel_situatie.PerformLayout();
            panel_student.ResumeLayout(false);
            panel_student.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem adaugaToolStripMenuItem;
        private ToolStripMenuItem adaugaStudentToolStripMenuItem;
        private ToolStripMenuItem adaugaCadruDidacticToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadruDidacticToolStripMenuItem;
        private ToolStripMenuItem adaugareNoteToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem situatieToolStripMenuItem;
        private Panel panel_cadru_didactic;
        private Label label11;
        private TextBox deleteCadru;
        private Button button2;
        private Label label10;
        private Button button1;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox numeProf;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Panel panel_adauga_note;
        private Button btn_salvare_nota;
        private Label label16;
        private TextBox tb_nota;
        private Label label15;
        private ListBox listBox_studenti;
        private Label label14;
        private ComboBox comboProfesor;
        private Label label13;
        private ListBox listBox_materii;
        private ComboBox comboStudent;
        private Label label17;
        private ListBox listBox_situatie;
        private Panel panel_situatie;
        private Panel panel_student;
        private Label label12;
        private TextBox deleteStudent;
        private Button sterger_Stud;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button save_Button;
        private Label lbl_medie;
        private TextBox tb_medie;
        private Label lbl_ciclu;
        private TextBox tb_ciclu;
        private TextBox grupa;
        private Label lbl_initiala;
        private TextBox tb_initiala;
        private Label lbl_prenume;
        private TextBox tb_prenume;
        private Label lbl_cnp;
        private Label lbl_inscriere;
        private TextBox tb_cnp;
        private Label label1;
        private Label label18;
        private TextBox tb_nume;
        private Label lbl_nr_matricol;
        private TextBox tb_nr_matricol;
        private Button btn_export;
        private SaveFileDialog saveFileDialog1;
        private Label lbl_medie_student;
    }
}