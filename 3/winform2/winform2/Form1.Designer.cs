namespace winform2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PapaFamiliya = new System.Windows.Forms.TextBox();
            this.PapaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PapaOtchestvo = new System.Windows.Forms.TextBox();
            this.PapaDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.PapaList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PapaPassport = new System.Windows.Forms.TextBox();
            this.AddPapa = new System.Windows.Forms.Button();
            this.ClearPapa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Papa_pol_myz = new System.Windows.Forms.RadioButton();
            this.Papa_pol_zhenshina = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearPapaSpisok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearHistory = new System.Windows.Forms.Button();
            this.AddHistory = new System.Windows.Forms.Button();
            this.DateHistory = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.HistorySum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HistorycheckBox3 = new System.Windows.Forms.CheckBox();
            this.HistorycheckBox2 = new System.Windows.Forms.CheckBox();
            this.HistorycheckBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Read = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ShchetList = new System.Windows.Forms.ListBox();
            this.ClearShchet = new System.Windows.Forms.Button();
            this.AddShchet = new System.Windows.Forms.Button();
            this.ShchetcheckBox2 = new System.Windows.Forms.CheckBox();
            this.ShchetcheckBox1 = new System.Windows.Forms.CheckBox();
            this.ShchetmonthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label12 = new System.Windows.Forms.Label();
            this.ShchetBalans = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ShchetListVladelec = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ShchetType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ShchetNomer = new System.Windows.Forms.TextBox();
            this.ClearspisVladel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типОперацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.схранитьВXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.последнийПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PapaFamiliya
            // 
            this.PapaFamiliya.Location = new System.Drawing.Point(16, 53);
            this.PapaFamiliya.Name = "PapaFamiliya";
            this.PapaFamiliya.Size = new System.Drawing.Size(120, 22);
            this.PapaFamiliya.TabIndex = 0;
            // 
            // PapaName
            // 
            this.PapaName.Location = new System.Drawing.Point(209, 53);
            this.PapaName.Name = "PapaName";
            this.PapaName.Size = new System.Drawing.Size(120, 22);
            this.PapaName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отчество";
            // 
            // PapaOtchestvo
            // 
            this.PapaOtchestvo.Location = new System.Drawing.Point(16, 107);
            this.PapaOtchestvo.Name = "PapaOtchestvo";
            this.PapaOtchestvo.Size = new System.Drawing.Size(164, 22);
            this.PapaOtchestvo.TabIndex = 6;
            // 
            // PapaDate
            // 
            this.PapaDate.Location = new System.Drawing.Point(209, 107);
            this.PapaDate.Name = "PapaDate";
            this.PapaDate.Size = new System.Drawing.Size(166, 22);
            this.PapaDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата рождения";
            // 
            // PapaList
            // 
            this.PapaList.FormattingEnabled = true;
            this.PapaList.ItemHeight = 16;
            this.PapaList.Location = new System.Drawing.Point(6, 301);
            this.PapaList.Name = "PapaList";
            this.PapaList.Size = new System.Drawing.Size(465, 212);
            this.PapaList.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Паспорт";
            // 
            // PapaPassport
            // 
            this.PapaPassport.Location = new System.Drawing.Point(16, 169);
            this.PapaPassport.Name = "PapaPassport";
            this.PapaPassport.Size = new System.Drawing.Size(164, 22);
            this.PapaPassport.TabIndex = 12;
            // 
            // AddPapa
            // 
            this.AddPapa.Location = new System.Drawing.Point(16, 237);
            this.AddPapa.Name = "AddPapa";
            this.AddPapa.Size = new System.Drawing.Size(150, 46);
            this.AddPapa.TabIndex = 13;
            this.AddPapa.Text = "Добавить владельца";
            this.AddPapa.UseVisualStyleBackColor = true;
            this.AddPapa.Click += new System.EventHandler(this.AddPapa_Click);
            // 
            // ClearPapa
            // 
            this.ClearPapa.Location = new System.Drawing.Point(172, 237);
            this.ClearPapa.Name = "ClearPapa";
            this.ClearPapa.Size = new System.Drawing.Size(149, 46);
            this.ClearPapa.TabIndex = 14;
            this.ClearPapa.Text = "Очистить поля";
            this.ClearPapa.UseVisualStyleBackColor = true;
            this.ClearPapa.Click += new System.EventHandler(this.ClearPapa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Пол";
            // 
            // Papa_pol_myz
            // 
            this.Papa_pol_myz.AutoSize = true;
            this.Papa_pol_myz.Location = new System.Drawing.Point(209, 169);
            this.Papa_pol_myz.Name = "Papa_pol_myz";
            this.Papa_pol_myz.Size = new System.Drawing.Size(86, 21);
            this.Papa_pol_myz.TabIndex = 16;
            this.Papa_pol_myz.TabStop = true;
            this.Papa_pol_myz.Text = "Мужской";
            this.Papa_pol_myz.UseVisualStyleBackColor = true;
            // 
            // Papa_pol_zhenshina
            // 
            this.Papa_pol_zhenshina.AutoSize = true;
            this.Papa_pol_zhenshina.Location = new System.Drawing.Point(209, 196);
            this.Papa_pol_zhenshina.Name = "Papa_pol_zhenshina";
            this.Papa_pol_zhenshina.Size = new System.Drawing.Size(88, 21);
            this.Papa_pol_zhenshina.TabIndex = 17;
            this.Papa_pol_zhenshina.TabStop = true;
            this.Papa_pol_zhenshina.Text = "Женский";
            this.Papa_pol_zhenshina.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearPapaSpisok);
            this.groupBox1.Controls.Add(this.PapaList);
            this.groupBox1.Controls.Add(this.Papa_pol_zhenshina);
            this.groupBox1.Controls.Add(this.Papa_pol_myz);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ClearPapa);
            this.groupBox1.Controls.Add(this.AddPapa);
            this.groupBox1.Controls.Add(this.PapaPassport);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PapaDate);
            this.groupBox1.Controls.Add(this.PapaOtchestvo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PapaName);
            this.groupBox1.Controls.Add(this.PapaFamiliya);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 533);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Владелец";
            // 
            // ClearPapaSpisok
            // 
            this.ClearPapaSpisok.Location = new System.Drawing.Point(327, 236);
            this.ClearPapaSpisok.Name = "ClearPapaSpisok";
            this.ClearPapaSpisok.Size = new System.Drawing.Size(144, 46);
            this.ClearPapaSpisok.TabIndex = 21;
            this.ClearPapaSpisok.Text = "Очистить список";
            this.ClearPapaSpisok.UseVisualStyleBackColor = true;
            this.ClearPapaSpisok.Click += new System.EventHandler(this.ClearPapaSpisok_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.HistoryList);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ClearHistory);
            this.groupBox2.Controls.Add(this.AddHistory);
            this.groupBox2.Controls.Add(this.DateHistory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HistorySum);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(514, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 533);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "История операций";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Очистить список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoryList
            // 
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.ItemHeight = 16;
            this.HistoryList.Location = new System.Drawing.Point(6, 301);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(478, 52);
            this.HistoryList.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Дата операции:";
            // 
            // ClearHistory
            // 
            this.ClearHistory.Location = new System.Drawing.Point(169, 235);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(144, 46);
            this.ClearHistory.TabIndex = 20;
            this.ClearHistory.Text = "Очистить поля";
            this.ClearHistory.UseVisualStyleBackColor = true;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // AddHistory
            // 
            this.AddHistory.Location = new System.Drawing.Point(9, 235);
            this.AddHistory.Name = "AddHistory";
            this.AddHistory.Size = new System.Drawing.Size(144, 46);
            this.AddHistory.TabIndex = 7;
            this.AddHistory.Text = "Добавить операцию";
            this.AddHistory.UseVisualStyleBackColor = true;
            this.AddHistory.Click += new System.EventHandler(this.AddHistory_Click);
            // 
            // DateHistory
            // 
            this.DateHistory.Location = new System.Drawing.Point(169, 169);
            this.DateHistory.Name = "DateHistory";
            this.DateHistory.Size = new System.Drawing.Size(200, 22);
            this.DateHistory.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма";
            // 
            // HistorySum
            // 
            this.HistorySum.Location = new System.Drawing.Point(258, 88);
            this.HistorySum.Name = "HistorySum";
            this.HistorySum.Size = new System.Drawing.Size(111, 22);
            this.HistorySum.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HistorycheckBox3);
            this.groupBox3.Controls.Add(this.HistorycheckBox2);
            this.groupBox3.Controls.Add(this.HistorycheckBox1);
            this.groupBox3.Location = new System.Drawing.Point(25, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип операции";
            // 
            // HistorycheckBox3
            // 
            this.HistorycheckBox3.AutoSize = true;
            this.HistorycheckBox3.Location = new System.Drawing.Point(10, 75);
            this.HistorycheckBox3.Name = "HistorycheckBox3";
            this.HistorycheckBox3.Size = new System.Drawing.Size(171, 21);
            this.HistorycheckBox3.TabIndex = 2;
            this.HistorycheckBox3.Text = "Пополнение баланса";
            this.HistorycheckBox3.UseVisualStyleBackColor = true;
            // 
            // HistorycheckBox2
            // 
            this.HistorycheckBox2.AutoSize = true;
            this.HistorycheckBox2.Location = new System.Drawing.Point(10, 48);
            this.HistorycheckBox2.Name = "HistorycheckBox2";
            this.HistorycheckBox2.Size = new System.Drawing.Size(118, 21);
            this.HistorycheckBox2.TabIndex = 1;
            this.HistorycheckBox2.Text = "Обмен валют";
            this.HistorycheckBox2.UseVisualStyleBackColor = true;
            // 
            // HistorycheckBox1
            // 
            this.HistorycheckBox1.AutoSize = true;
            this.HistorycheckBox1.Location = new System.Drawing.Point(10, 21);
            this.HistorycheckBox1.Name = "HistorycheckBox1";
            this.HistorycheckBox1.Size = new System.Drawing.Size(169, 21);
            this.HistorycheckBox1.TabIndex = 0;
            this.HistorycheckBox1.Text = "Денежные переводы";
            this.HistorycheckBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Read);
            this.groupBox5.Controls.Add(this.Save);
            this.groupBox5.Location = new System.Drawing.Point(1137, 480);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 59);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Работа с файлами";
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(210, 19);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(179, 40);
            this.Read.TabIndex = 15;
            this.Read.Text = "Открыть файл";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(25, 19);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(179, 40);
            this.Save.TabIndex = 14;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ShchetList
            // 
            this.ShchetList.FormattingEnabled = true;
            this.ShchetList.ItemHeight = 16;
            this.ShchetList.Location = new System.Drawing.Point(27, 581);
            this.ShchetList.Name = "ShchetList";
            this.ShchetList.Size = new System.Drawing.Size(1554, 84);
            this.ShchetList.TabIndex = 13;
            // 
            // ClearShchet
            // 
            this.ClearShchet.Location = new System.Drawing.Point(1016, 287);
            this.ClearShchet.Name = "ClearShchet";
            this.ClearShchet.Size = new System.Drawing.Size(128, 49);
            this.ClearShchet.TabIndex = 12;
            this.ClearShchet.Text = "Очистить поля";
            this.ClearShchet.UseVisualStyleBackColor = true;
            this.ClearShchet.Click += new System.EventHandler(this.ClearShchet_Click);
            // 
            // AddShchet
            // 
            this.AddShchet.Location = new System.Drawing.Point(1016, 238);
            this.AddShchet.Name = "AddShchet";
            this.AddShchet.Size = new System.Drawing.Size(128, 47);
            this.AddShchet.TabIndex = 11;
            this.AddShchet.Text = "Добавить счет";
            this.AddShchet.UseVisualStyleBackColor = true;
            this.AddShchet.Click += new System.EventHandler(this.AddShchet_Click);
            // 
            // ShchetcheckBox2
            // 
            this.ShchetcheckBox2.AutoSize = true;
            this.ShchetcheckBox2.Location = new System.Drawing.Point(1021, 196);
            this.ShchetcheckBox2.Name = "ShchetcheckBox2";
            this.ShchetcheckBox2.Size = new System.Drawing.Size(235, 21);
            this.ShchetcheckBox2.TabIndex = 10;
            this.ShchetcheckBox2.Text = "Подключение смс-оповещений";
            this.ShchetcheckBox2.UseVisualStyleBackColor = true;
            // 
            // ShchetcheckBox1
            // 
            this.ShchetcheckBox1.AutoSize = true;
            this.ShchetcheckBox1.Location = new System.Drawing.Point(1021, 171);
            this.ShchetcheckBox1.Name = "ShchetcheckBox1";
            this.ShchetcheckBox1.Size = new System.Drawing.Size(251, 21);
            this.ShchetcheckBox1.TabIndex = 9;
            this.ShchetcheckBox1.Text = "Подключение интернет банкинга";
            this.ShchetcheckBox1.UseVisualStyleBackColor = true;
            // 
            // ShchetmonthCalendar1
            // 
            this.ShchetmonthCalendar1.Location = new System.Drawing.Point(1311, 155);
            this.ShchetmonthCalendar1.Name = "ShchetmonthCalendar1";
            this.ShchetmonthCalendar1.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1379, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Баланс";
            // 
            // ShchetBalans
            // 
            this.ShchetBalans.Location = new System.Drawing.Point(1382, 53);
            this.ShchetBalans.Name = "ShchetBalans";
            this.ShchetBalans.Size = new System.Drawing.Size(121, 22);
            this.ShchetBalans.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1023, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Владелец";
            // 
            // ShchetListVladelec
            // 
            this.ShchetListVladelec.FormattingEnabled = true;
            this.ShchetListVladelec.Location = new System.Drawing.Point(1010, 100);
            this.ShchetListVladelec.Name = "ShchetListVladelec";
            this.ShchetListVladelec.Size = new System.Drawing.Size(521, 55);
            this.ShchetListVladelec.TabIndex = 4;
            this.ShchetListVladelec.SelectedIndexChanged += new System.EventHandler(this.ShchetListVladelec_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1171, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Тип операции";
            // 
            // ShchetType
            // 
            this.ShchetType.FormattingEnabled = true;
            this.ShchetType.Location = new System.Drawing.Point(1174, 53);
            this.ShchetType.Name = "ShchetType";
            this.ShchetType.Size = new System.Drawing.Size(167, 24);
            this.ShchetType.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1020, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Номер";
            // 
            // ShchetNomer
            // 
            this.ShchetNomer.Location = new System.Drawing.Point(1023, 55);
            this.ShchetNomer.Name = "ShchetNomer";
            this.ShchetNomer.Size = new System.Drawing.Size(121, 22);
            this.ShchetNomer.TabIndex = 0;
            // 
            // ClearspisVladel
            // 
            this.ClearspisVladel.Location = new System.Drawing.Point(1162, 238);
            this.ClearspisVladel.Name = "ClearspisVladel";
            this.ClearspisVladel.Size = new System.Drawing.Size(128, 47);
            this.ClearspisVladel.TabIndex = 20;
            this.ClearspisVladel.Text = "Очистить список Владельцев";
            this.ClearspisVladel.UseVisualStyleBackColor = true;
            this.ClearspisVladel.Click += new System.EventHandler(this.ClearspisVladel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1162, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 49);
            this.button3.TabIndex = 21;
            this.button3.Text = "Очистить список счета";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортироватьToolStripMenuItem,
            this.схранитьВXMLToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1613, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типОперацииToolStripMenuItem,
            this.поДатеToolStripMenuItem});
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.сортироватьToolStripMenuItem.Text = "Сортировать";
            // 
            // типОперацииToolStripMenuItem
            // 
            this.типОперацииToolStripMenuItem.Name = "типОперацииToolStripMenuItem";
            this.типОперацииToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.типОперацииToolStripMenuItem.Text = "По номеру операции";
            this.типОперацииToolStripMenuItem.Click += new System.EventHandler(this.типОперацииToolStripMenuItem_Click);
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.поДатеToolStripMenuItem.Text = "По дате";
            this.поДатеToolStripMenuItem.Click += new System.EventHandler(this.поДатеToolStripMenuItem_Click);
            // 
            // схранитьВXMLToolStripMenuItem
            // 
            this.схранитьВXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.последнийПоискToolStripMenuItem,
            this.сортировкуToolStripMenuItem});
            this.схранитьВXMLToolStripMenuItem.Name = "схранитьВXMLToolStripMenuItem";
            this.схранитьВXMLToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.схранитьВXMLToolStripMenuItem.Text = "Сохранить в XML";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1613, 25);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 20);
            this.toolStripStatusLabel1.Text = "Дата";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // последнийПоискToolStripMenuItem
            // 
            this.последнийПоискToolStripMenuItem.Name = "последнийПоискToolStripMenuItem";
            this.последнийПоискToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.последнийПоискToolStripMenuItem.Text = "Последний поиск";
            this.последнийПоискToolStripMenuItem.Click += new System.EventHandler(this.последнийПоискToolStripMenuItem_Click);
            // 
            // сортировкуToolStripMenuItem
            // 
            this.сортировкуToolStripMenuItem.Name = "сортировкуToolStripMenuItem";
            this.сортировкуToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.сортировкуToolStripMenuItem.Text = "Сортировку";
            this.сортировкуToolStripMenuItem.Click += new System.EventHandler(this.сортировкуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 730);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ClearspisVladel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ShchetList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearShchet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddShchet);
            this.Controls.Add(this.ShchetListVladelec);
            this.Controls.Add(this.ShchetcheckBox2);
            this.Controls.Add(this.ShchetNomer);
            this.Controls.Add(this.ShchetcheckBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ShchetmonthCalendar1);
            this.Controls.Add(this.ShchetType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ShchetBalans);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Банк";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PapaFamiliya;
        private System.Windows.Forms.TextBox PapaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PapaOtchestvo;
        private System.Windows.Forms.DateTimePicker PapaDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox PapaList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PapaPassport;
        private System.Windows.Forms.Button AddPapa;
        private System.Windows.Forms.Button ClearPapa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Papa_pol_myz;
        private System.Windows.Forms.RadioButton Papa_pol_zhenshina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearHistory;
        private System.Windows.Forms.Button AddHistory;
        private System.Windows.Forms.DateTimePicker DateHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HistorySum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox HistorycheckBox3;
        private System.Windows.Forms.CheckBox HistorycheckBox2;
        private System.Windows.Forms.CheckBox HistorycheckBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListBox ShchetList;
        private System.Windows.Forms.Button ClearShchet;
        private System.Windows.Forms.Button AddShchet;
        private System.Windows.Forms.CheckBox ShchetcheckBox2;
        private System.Windows.Forms.CheckBox ShchetcheckBox1;
        private System.Windows.Forms.MonthCalendar ShchetmonthCalendar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ShchetBalans;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox ShchetListVladelec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ShchetType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ShchetNomer;
        private System.Windows.Forms.Button ClearPapaSpisok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearspisVladel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типОперацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem схранитьВXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem последнийПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкуToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog Save_Dialog;
    }
}

