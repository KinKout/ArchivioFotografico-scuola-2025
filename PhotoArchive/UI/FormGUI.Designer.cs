using PhotoArchive.Query;

namespace PhotoArchive.UI
{
    partial class FormGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_dataF = new GroupBox();
            groupBox1 = new GroupBox();
            tb_n_photo = new TextBox();
            label2 = new Label();
            bt_pre_photo = new Button();
            bt_next_photo = new Button();
            tb_dataF_8 = new TextBox();
            l_dataF_desc = new Label();
            l_dataF_deat = new Label();
            tb_dataF_7 = new TextBox();
            groupBox3 = new GroupBox();
            tb_n_result = new TextBox();
            label1 = new Label();
            bt_pre_result = new Button();
            bt_next_result = new Button();
            l_dataF_birt = new Label();
            tb_dataF_6 = new TextBox();
            l_dataF_1 = new Label();
            tb_dataF_5_2 = new TextBox();
            l_dataF_care = new Label();
            tb_dataF_5_1 = new TextBox();
            l_dataF_prof = new Label();
            tb_dataF_3 = new TextBox();
            tb_dataF_4 = new TextBox();
            tb_dataF_2 = new TextBox();
            l_dataF_team = new Label();
            l_dataF_surn = new Label();
            l_dataF_name = new Label();
            tb_dataF_1 = new TextBox();
            dtp_ric_dateB = new DateTimePicker();
            gb_ric = new GroupBox();
            rb_ric_care = new RadioButton();
            rb_ric_life = new RadioButton();
            gb_ric_main = new GroupBox();
            rb_ric_poli = new RadioButton();
            rb_ric_luog = new RadioButton();
            rb_ric_spor = new RadioButton();
            rb_ric_arti = new RadioButton();
            rb_ric_team = new RadioButton();
            l_ric_2 = new Label();
            rb_ric_name = new RadioButton();
            rb_ric_prof = new RadioButton();
            l_ric_1 = new Label();
            dtp_ric_dateOUT = new DateTimePicker();
            rb_ric_surn = new RadioButton();
            dtp_ric_dateIN = new DateTimePicker();
            dtp_ric_dateD = new DateTimePicker();
            tb_ric_1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tb_data_count = new TextBox();
            bSubmitToDatabase = new Button();
            gb_dataF.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            gb_ric.SuspendLayout();
            gb_ric_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gb_dataF
            // 
            gb_dataF.Controls.Add(groupBox1);
            gb_dataF.Controls.Add(tb_dataF_8);
            gb_dataF.Controls.Add(l_dataF_desc);
            gb_dataF.Controls.Add(l_dataF_deat);
            gb_dataF.Controls.Add(tb_dataF_7);
            gb_dataF.Controls.Add(groupBox3);
            gb_dataF.Controls.Add(l_dataF_birt);
            gb_dataF.Controls.Add(tb_dataF_6);
            gb_dataF.Controls.Add(l_dataF_1);
            gb_dataF.Controls.Add(tb_dataF_5_2);
            gb_dataF.Controls.Add(l_dataF_care);
            gb_dataF.Controls.Add(tb_dataF_5_1);
            gb_dataF.Controls.Add(l_dataF_prof);
            gb_dataF.Controls.Add(tb_dataF_3);
            gb_dataF.Controls.Add(tb_dataF_4);
            gb_dataF.Controls.Add(tb_dataF_2);
            gb_dataF.Controls.Add(l_dataF_team);
            gb_dataF.Controls.Add(l_dataF_surn);
            gb_dataF.Controls.Add(l_dataF_name);
            gb_dataF.Controls.Add(tb_dataF_1);
            gb_dataF.Location = new Point(12, 282);
            gb_dataF.Name = "gb_dataF";
            gb_dataF.Size = new Size(418, 318);
            gb_dataF.TabIndex = 0;
            gb_dataF.TabStop = false;
            gb_dataF.Text = "Dati della foto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_n_photo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(bt_pre_photo);
            groupBox1.Controls.Add(bt_next_photo);
            groupBox1.Location = new Point(307, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(98, 105);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // tb_n_photo
            // 
            tb_n_photo.BackColor = Color.Gainsboro;
            tb_n_photo.Location = new Point(6, 74);
            tb_n_photo.MaxLength = 20;
            tb_n_photo.Name = "tb_n_photo";
            tb_n_photo.ReadOnly = true;
            tb_n_photo.Size = new Size(86, 23);
            tb_n_photo.TabIndex = 40;
            tb_n_photo.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 39;
            label2.Text = "Scorri foto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_pre_photo
            // 
            bt_pre_photo.Location = new Point(6, 17);
            bt_pre_photo.Name = "bt_pre_photo";
            bt_pre_photo.Size = new Size(37, 23);
            bt_pre_photo.TabIndex = 20;
            bt_pre_photo.Text = "<";
            bt_pre_photo.UseVisualStyleBackColor = true;
            bt_pre_photo.Click += bt_pre_photo_Click;
            // 
            // bt_next_photo
            // 
            bt_next_photo.Location = new Point(55, 17);
            bt_next_photo.Name = "bt_next_photo";
            bt_next_photo.Size = new Size(37, 23);
            bt_next_photo.TabIndex = 20;
            bt_next_photo.Text = ">";
            bt_next_photo.UseVisualStyleBackColor = true;
            bt_next_photo.Click += bt_next_photo_Click;
            // 
            // tb_dataF_8
            // 
            tb_dataF_8.BackColor = Color.Gainsboro;
            tb_dataF_8.Location = new Point(106, 225);
            tb_dataF_8.MaxLength = 100;
            tb_dataF_8.Multiline = true;
            tb_dataF_8.Name = "tb_dataF_8";
            tb_dataF_8.ReadOnly = true;
            tb_dataF_8.Size = new Size(190, 82);
            tb_dataF_8.TabIndex = 17;
            tb_dataF_8.Visible = false;
            // 
            // l_dataF_desc
            // 
            l_dataF_desc.Location = new Point(17, 225);
            l_dataF_desc.Name = "l_dataF_desc";
            l_dataF_desc.Size = new Size(83, 23);
            l_dataF_desc.TabIndex = 16;
            l_dataF_desc.Text = "Descrizione";
            l_dataF_desc.TextAlign = ContentAlignment.MiddleRight;
            l_dataF_desc.Visible = false;
            // 
            // l_dataF_deat
            // 
            l_dataF_deat.Location = new Point(6, 195);
            l_dataF_deat.Name = "l_dataF_deat";
            l_dataF_deat.Size = new Size(94, 23);
            l_dataF_deat.TabIndex = 15;
            l_dataF_deat.Text = "Data di morte";
            l_dataF_deat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_dataF_7
            // 
            tb_dataF_7.BackColor = Color.Gainsboro;
            tb_dataF_7.Location = new Point(106, 196);
            tb_dataF_7.MaxLength = 20;
            tb_dataF_7.Name = "tb_dataF_7";
            tb_dataF_7.ReadOnly = true;
            tb_dataF_7.Size = new Size(77, 23);
            tb_dataF_7.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tb_n_result);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(bt_pre_result);
            groupBox3.Controls.Add(bt_next_result);
            groupBox3.Location = new Point(307, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 105);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            // 
            // tb_n_result
            // 
            tb_n_result.BackColor = Color.Gainsboro;
            tb_n_result.Location = new Point(6, 74);
            tb_n_result.MaxLength = 20;
            tb_n_result.Name = "tb_n_result";
            tb_n_result.ReadOnly = true;
            tb_n_result.Size = new Size(86, 23);
            tb_n_result.TabIndex = 39;
            tb_n_result.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 39;
            label1.Text = "Scorri risultati";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_pre_result
            // 
            bt_pre_result.Location = new Point(6, 17);
            bt_pre_result.Name = "bt_pre_result";
            bt_pre_result.Size = new Size(37, 23);
            bt_pre_result.TabIndex = 20;
            bt_pre_result.Text = "<";
            bt_pre_result.UseVisualStyleBackColor = true;
            bt_pre_result.Click += bt_pre_result_Click;
            // 
            // bt_next_result
            // 
            bt_next_result.Location = new Point(55, 17);
            bt_next_result.Name = "bt_next_result";
            bt_next_result.Size = new Size(37, 23);
            bt_next_result.TabIndex = 20;
            bt_next_result.Text = ">";
            bt_next_result.UseVisualStyleBackColor = true;
            bt_next_result.Click += bt_next_result_Click;
            // 
            // l_dataF_birt
            // 
            l_dataF_birt.Location = new Point(6, 166);
            l_dataF_birt.Name = "l_dataF_birt";
            l_dataF_birt.Size = new Size(94, 23);
            l_dataF_birt.TabIndex = 13;
            l_dataF_birt.Text = "Data di nascita";
            l_dataF_birt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_dataF_6
            // 
            tb_dataF_6.BackColor = Color.Gainsboro;
            tb_dataF_6.Location = new Point(106, 167);
            tb_dataF_6.MaxLength = 20;
            tb_dataF_6.Name = "tb_dataF_6";
            tb_dataF_6.ReadOnly = true;
            tb_dataF_6.Size = new Size(77, 23);
            tb_dataF_6.TabIndex = 12;
            // 
            // l_dataF_1
            // 
            l_dataF_1.Location = new Point(189, 137);
            l_dataF_1.Name = "l_dataF_1";
            l_dataF_1.Size = new Size(24, 23);
            l_dataF_1.TabIndex = 11;
            l_dataF_1.Text = "al";
            l_dataF_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_dataF_5_2
            // 
            tb_dataF_5_2.BackColor = Color.Gainsboro;
            tb_dataF_5_2.Location = new Point(219, 138);
            tb_dataF_5_2.MaxLength = 20;
            tb_dataF_5_2.Name = "tb_dataF_5_2";
            tb_dataF_5_2.ReadOnly = true;
            tb_dataF_5_2.Size = new Size(77, 23);
            tb_dataF_5_2.TabIndex = 11;
            // 
            // l_dataF_care
            // 
            l_dataF_care.Location = new Point(6, 137);
            l_dataF_care.Name = "l_dataF_care";
            l_dataF_care.Size = new Size(94, 23);
            l_dataF_care.TabIndex = 10;
            l_dataF_care.Text = "In carica dal";
            l_dataF_care.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_dataF_5_1
            // 
            tb_dataF_5_1.BackColor = Color.Gainsboro;
            tb_dataF_5_1.Location = new Point(106, 138);
            tb_dataF_5_1.MaxLength = 20;
            tb_dataF_5_1.Name = "tb_dataF_5_1";
            tb_dataF_5_1.ReadOnly = true;
            tb_dataF_5_1.Size = new Size(77, 23);
            tb_dataF_5_1.TabIndex = 8;
            // 
            // l_dataF_prof
            // 
            l_dataF_prof.Location = new Point(6, 80);
            l_dataF_prof.Name = "l_dataF_prof";
            l_dataF_prof.Size = new Size(94, 23);
            l_dataF_prof.TabIndex = 5;
            l_dataF_prof.Text = "Partito";
            l_dataF_prof.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_dataF_3
            // 
            tb_dataF_3.BackColor = Color.Gainsboro;
            tb_dataF_3.Location = new Point(106, 80);
            tb_dataF_3.MaxLength = 30;
            tb_dataF_3.Name = "tb_dataF_3";
            tb_dataF_3.ReadOnly = true;
            tb_dataF_3.Size = new Size(190, 23);
            tb_dataF_3.TabIndex = 2;
            // 
            // tb_dataF_4
            // 
            tb_dataF_4.BackColor = Color.Gainsboro;
            tb_dataF_4.Location = new Point(106, 109);
            tb_dataF_4.MaxLength = 30;
            tb_dataF_4.Name = "tb_dataF_4";
            tb_dataF_4.ReadOnly = true;
            tb_dataF_4.Size = new Size(190, 23);
            tb_dataF_4.TabIndex = 3;
            tb_dataF_4.Visible = false;
            // 
            // tb_dataF_2
            // 
            tb_dataF_2.BackColor = Color.Gainsboro;
            tb_dataF_2.Location = new Point(106, 51);
            tb_dataF_2.MaxLength = 30;
            tb_dataF_2.Name = "tb_dataF_2";
            tb_dataF_2.ReadOnly = true;
            tb_dataF_2.Size = new Size(190, 23);
            tb_dataF_2.TabIndex = 1;
            // 
            // l_dataF_team
            // 
            l_dataF_team.Location = new Point(17, 109);
            l_dataF_team.Name = "l_dataF_team";
            l_dataF_team.Size = new Size(83, 23);
            l_dataF_team.TabIndex = 7;
            l_dataF_team.Text = "Squadra";
            l_dataF_team.TextAlign = ContentAlignment.MiddleRight;
            l_dataF_team.Visible = false;
            // 
            // l_dataF_surn
            // 
            l_dataF_surn.Location = new Point(17, 51);
            l_dataF_surn.Name = "l_dataF_surn";
            l_dataF_surn.Size = new Size(83, 23);
            l_dataF_surn.TabIndex = 6;
            l_dataF_surn.Text = "Cognome";
            l_dataF_surn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_dataF_name
            // 
            l_dataF_name.Location = new Point(6, 22);
            l_dataF_name.Name = "l_dataF_name";
            l_dataF_name.Size = new Size(94, 23);
            l_dataF_name.TabIndex = 4;
            l_dataF_name.Text = "Nome";
            l_dataF_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_dataF_1
            // 
            tb_dataF_1.BackColor = Color.Gainsboro;
            tb_dataF_1.Location = new Point(106, 22);
            tb_dataF_1.MaxLength = 50;
            tb_dataF_1.Name = "tb_dataF_1";
            tb_dataF_1.ReadOnly = true;
            tb_dataF_1.Size = new Size(190, 23);
            tb_dataF_1.TabIndex = 0;
            // 
            // dtp_ric_dateB
            // 
            dtp_ric_dateB.Enabled = false;
            dtp_ric_dateB.Format = DateTimePickerFormat.Short;
            dtp_ric_dateB.Location = new Point(307, 22);
            dtp_ric_dateB.Name = "dtp_ric_dateB";
            dtp_ric_dateB.Size = new Size(98, 23);
            dtp_ric_dateB.TabIndex = 1;
            // 
            // gb_ric
            // 
            gb_ric.Controls.Add(rb_ric_care);
            gb_ric.Controls.Add(rb_ric_life);
            gb_ric.Controls.Add(gb_ric_main);
            gb_ric.Controls.Add(rb_ric_team);
            gb_ric.Controls.Add(l_ric_2);
            gb_ric.Controls.Add(rb_ric_name);
            gb_ric.Controls.Add(rb_ric_prof);
            gb_ric.Controls.Add(l_ric_1);
            gb_ric.Controls.Add(dtp_ric_dateOUT);
            gb_ric.Controls.Add(rb_ric_surn);
            gb_ric.Controls.Add(dtp_ric_dateIN);
            gb_ric.Controls.Add(dtp_ric_dateD);
            gb_ric.Controls.Add(dtp_ric_dateB);
            gb_ric.Location = new Point(12, 12);
            gb_ric.Name = "gb_ric";
            gb_ric.Size = new Size(418, 139);
            gb_ric.TabIndex = 18;
            gb_ric.TabStop = false;
            // 
            // rb_ric_care
            // 
            rb_ric_care.Cursor = Cursors.Hand;
            rb_ric_care.Location = new Point(224, 79);
            rb_ric_care.Name = "rb_ric_care";
            rb_ric_care.Size = new Size(77, 23);
            rb_ric_care.TabIndex = 35;
            rb_ric_care.Text = "Attivo dal";
            rb_ric_care.UseVisualStyleBackColor = true;
            rb_ric_care.CheckedChanged += rb_ric_care_CheckedChanged;
            // 
            // rb_ric_life
            // 
            rb_ric_life.Cursor = Cursors.Hand;
            rb_ric_life.Location = new Point(224, 22);
            rb_ric_life.Name = "rb_ric_life";
            rb_ric_life.Size = new Size(77, 23);
            rb_ric_life.TabIndex = 27;
            rb_ric_life.Text = "Nato fra il";
            rb_ric_life.UseVisualStyleBackColor = true;
            rb_ric_life.CheckedChanged += rb_ric_life_CheckedChanged;
            // 
            // gb_ric_main
            // 
            gb_ric_main.BackColor = SystemColors.Control;
            gb_ric_main.Controls.Add(rb_ric_poli);
            gb_ric_main.Controls.Add(rb_ric_luog);
            gb_ric_main.Controls.Add(rb_ric_spor);
            gb_ric_main.Controls.Add(rb_ric_arti);
            gb_ric_main.Location = new Point(0, 0);
            gb_ric_main.Margin = new Padding(0);
            gb_ric_main.Name = "gb_ric_main";
            gb_ric_main.Padding = new Padding(0);
            gb_ric_main.Size = new Size(93, 139);
            gb_ric_main.TabIndex = 23;
            gb_ric_main.TabStop = false;
            gb_ric_main.Text = "Ricerca";
            // 
            // rb_ric_poli
            // 
            rb_ric_poli.Checked = true;
            rb_ric_poli.Cursor = Cursors.Hand;
            rb_ric_poli.Location = new Point(11, 22);
            rb_ric_poli.Name = "rb_ric_poli";
            rb_ric_poli.Size = new Size(65, 23);
            rb_ric_poli.TabIndex = 19;
            rb_ric_poli.TabStop = true;
            rb_ric_poli.Text = "Politico";
            rb_ric_poli.UseVisualStyleBackColor = true;
            rb_ric_poli.CheckedChanged += rb_ric_poli_CheckedChanged;
            // 
            // rb_ric_luog
            // 
            rb_ric_luog.Cursor = Cursors.Hand;
            rb_ric_luog.Location = new Point(11, 107);
            rb_ric_luog.Name = "rb_ric_luog";
            rb_ric_luog.Size = new Size(59, 23);
            rb_ric_luog.TabIndex = 22;
            rb_ric_luog.Text = "Luogo";
            rb_ric_luog.UseVisualStyleBackColor = true;
            rb_ric_luog.CheckedChanged += rb_ric_luog_CheckedChanged;
            // 
            // rb_ric_spor
            // 
            rb_ric_spor.Cursor = Cursors.Hand;
            rb_ric_spor.Location = new Point(11, 50);
            rb_ric_spor.Name = "rb_ric_spor";
            rb_ric_spor.Size = new Size(69, 23);
            rb_ric_spor.TabIndex = 20;
            rb_ric_spor.Text = "Sportivo";
            rb_ric_spor.UseVisualStyleBackColor = true;
            rb_ric_spor.CheckedChanged += rb_ric_spor_CheckedChanged;
            // 
            // rb_ric_arti
            // 
            rb_ric_arti.Cursor = Cursors.Hand;
            rb_ric_arti.Location = new Point(11, 79);
            rb_ric_arti.Name = "rb_ric_arti";
            rb_ric_arti.Size = new Size(59, 23);
            rb_ric_arti.TabIndex = 21;
            rb_ric_arti.Text = "Artista";
            rb_ric_arti.UseVisualStyleBackColor = true;
            rb_ric_arti.CheckedChanged += rb_ric_arti_CheckedChanged;
            // 
            // rb_ric_team
            // 
            rb_ric_team.Cursor = Cursors.Hand;
            rb_ric_team.Location = new Point(102, 107);
            rb_ric_team.Name = "rb_ric_team";
            rb_ric_team.Size = new Size(68, 23);
            rb_ric_team.TabIndex = 26;
            rb_ric_team.Text = "Squadra";
            rb_ric_team.UseVisualStyleBackColor = true;
            rb_ric_team.Visible = false;
            rb_ric_team.CheckedChanged += rb_ric_team_CheckedChanged;
            // 
            // l_ric_2
            // 
            l_ric_2.Location = new Point(265, 107);
            l_ric_2.Name = "l_ric_2";
            l_ric_2.Size = new Size(33, 23);
            l_ric_2.TabIndex = 30;
            l_ric_2.Text = "al";
            l_ric_2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rb_ric_name
            // 
            rb_ric_name.Checked = true;
            rb_ric_name.Cursor = Cursors.Hand;
            rb_ric_name.Location = new Point(102, 22);
            rb_ric_name.Name = "rb_ric_name";
            rb_ric_name.Size = new Size(58, 23);
            rb_ric_name.TabIndex = 23;
            rb_ric_name.TabStop = true;
            rb_ric_name.Text = "Nome";
            rb_ric_name.UseVisualStyleBackColor = true;
            rb_ric_name.CheckedChanged += rb_ric_name_CheckedChanged;
            // 
            // rb_ric_prof
            // 
            rb_ric_prof.Cursor = Cursors.Hand;
            rb_ric_prof.Location = new Point(102, 79);
            rb_ric_prof.Name = "rb_ric_prof";
            rb_ric_prof.Size = new Size(68, 23);
            rb_ric_prof.TabIndex = 25;
            rb_ric_prof.Text = "Partito";
            rb_ric_prof.UseVisualStyleBackColor = true;
            rb_ric_prof.CheckedChanged += rb_ric_prof_CheckedChanged;
            // 
            // l_ric_1
            // 
            l_ric_1.Location = new Point(265, 50);
            l_ric_1.Name = "l_ric_1";
            l_ric_1.Size = new Size(34, 23);
            l_ric_1.TabIndex = 18;
            l_ric_1.Text = "e il";
            l_ric_1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtp_ric_dateOUT
            // 
            dtp_ric_dateOUT.Enabled = false;
            dtp_ric_dateOUT.Format = DateTimePickerFormat.Short;
            dtp_ric_dateOUT.Location = new Point(307, 107);
            dtp_ric_dateOUT.Name = "dtp_ric_dateOUT";
            dtp_ric_dateOUT.Size = new Size(98, 23);
            dtp_ric_dateOUT.TabIndex = 29;
            // 
            // rb_ric_surn
            // 
            rb_ric_surn.Cursor = Cursors.Hand;
            rb_ric_surn.Location = new Point(102, 50);
            rb_ric_surn.Name = "rb_ric_surn";
            rb_ric_surn.Size = new Size(86, 23);
            rb_ric_surn.TabIndex = 24;
            rb_ric_surn.Text = "Cognome";
            rb_ric_surn.UseVisualStyleBackColor = true;
            rb_ric_surn.CheckedChanged += rb_ric_surn_CheckedChanged;
            // 
            // dtp_ric_dateIN
            // 
            dtp_ric_dateIN.Enabled = false;
            dtp_ric_dateIN.Format = DateTimePickerFormat.Short;
            dtp_ric_dateIN.Location = new Point(307, 79);
            dtp_ric_dateIN.Name = "dtp_ric_dateIN";
            dtp_ric_dateIN.Size = new Size(98, 23);
            dtp_ric_dateIN.TabIndex = 28;
            // 
            // dtp_ric_dateD
            // 
            dtp_ric_dateD.Enabled = false;
            dtp_ric_dateD.Format = DateTimePickerFormat.Short;
            dtp_ric_dateD.Location = new Point(307, 50);
            dtp_ric_dateD.Name = "dtp_ric_dateD";
            dtp_ric_dateD.Size = new Size(98, 23);
            dtp_ric_dateD.TabIndex = 2;
            // 
            // tb_ric_1
            // 
            tb_ric_1.AccessibleDescription = "";
            tb_ric_1.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_ric_1.ImeMode = ImeMode.NoControl;
            tb_ric_1.Location = new Point(23, 185);
            tb_ric_1.MaxLength = 100;
            tb_ric_1.Name = "tb_ric_1";
            tb_ric_1.PlaceholderText = "Inserisci il nome del politico";
            tb_ric_1.Size = new Size(285, 23);
            tb_ric_1.TabIndex = 18;
            tb_ric_1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowFrame;
            pictureBox1.Location = new Point(60, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(452, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 580);
            panel1.TabIndex = 37;
            // 
            // tb_data_count
            // 
            tb_data_count.BackColor = Color.Gainsboro;
            tb_data_count.Location = new Point(23, 219);
            tb_data_count.MaxLength = 50;
            tb_data_count.Name = "tb_data_count";
            tb_data_count.ReadOnly = true;
            tb_data_count.Size = new Size(285, 23);
            tb_data_count.TabIndex = 38;
            tb_data_count.TextAlign = HorizontalAlignment.Center;
            // 
            // bSubmitToDatabase
            // 
            bSubmitToDatabase.Location = new Point(325, 185);
            bSubmitToDatabase.Name = "bSubmitToDatabase";
            bSubmitToDatabase.Size = new Size(86, 23);
            bSubmitToDatabase.TabIndex = 36;
            bSubmitToDatabase.Text = "Cerca";
            bSubmitToDatabase.UseVisualStyleBackColor = true;
            bSubmitToDatabase.Click += bSubmitToDatabase_Click;
            // 
            // FormGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 614);
            Controls.Add(tb_data_count);
            Controls.Add(panel1);
            Controls.Add(bSubmitToDatabase);
            Controls.Add(gb_dataF);
            Controls.Add(gb_ric);
            Controls.Add(tb_ric_1);
            Name = "FormGUI";
            Text = "Photo Archive";
            gb_dataF.ResumeLayout(false);
            gb_dataF.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gb_ric.ResumeLayout(false);
            gb_ric_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
            // 
            // Set radio button name for query
            // 


        }

        #endregion

        private GroupBox gb_dataF;
        private TextBox tb_dataF_3;
        private TextBox tb_dataF_2;
        private TextBox tb_dataF_1;
        private Label l_dataF_name;
        private TextBox tb_dataF_4;
        private Label l_dataF_team;
        private Label l_dataF_surn;
        private Label l_dataF_prof;
        private Label l_dataF_1;
        private TextBox tb_dataF_5_2;
        private Label l_dataF_care;
        private TextBox tb_dataF_5_1;
        private Label l_dataF_birt;
        private TextBox tb_dataF_6;
        private Label l_dataF_deat;
        private TextBox tb_dataF_7;
        private TextBox tb_dataF_8;
        private Label l_dataF_desc;
        private DateTimePicker dtp_ric_dateB;
        private GroupBox gb_ric;
        private DateTimePicker dtp_ric_dateD;
        private RadioButton rb_ric_luog;
        private RadioButton rb_ric_arti;
        private RadioButton rb_ric_spor;
        private RadioButton rb_ric_poli;
        private TextBox tb_ric_1;
        private DateTimePicker dtp_ric_dateIN;
        private Label l_ric_1;
        private Label l_ric_2;
        private Button bt_pre_result;
        private Button bt_next_result;
        private GroupBox groupBox3;
        private RadioButton rb_ric_name;
        private GroupBox gb_ric_main;
        private RadioButton rb_ric_surn;
        private RadioButton rb_ric_prof;
        private RadioButton rb_ric_team;
        private RadioButton rb_ric_life;
        private RadioButton rb_ric_care;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox tb_data_count;
        private DateTimePicker dtp_ric_dateOUT;
        private Button bSubmitToDatabase;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button bt_pre_photo;
        private Button bt_next_photo;
        private TextBox tb_n_result;
        private TextBox tb_n_photo;
    }
}