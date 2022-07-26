namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnPluse = new System.Windows.Forms.Button();
            this.btnMinuse = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRand = new System.Windows.Forms.Button();
            this.tbRand = new System.Windows.Forms.TextBox();
            this.cbRand = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIstertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьДатуИВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.clbPass = new System.Windows.Forms.CheckedListBox();
            this.nudPass = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmFrom = new System.Windows.Forms.ComboBox();
            this.cmTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmMetrics = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPass)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.помощToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.фаилToolStripMenuItem.Text = " Фаил";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(109, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // помощToolStripMenuItem
            // 
            this.помощToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            this.помощToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощToolStripMenuItem.Text = "Помощь";
            this.помощToolStripMenuItem.Click += new System.EventHandler(this.помощToolStripMenuItem_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.оПрогреаммеToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 319);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelCount);
            this.tabPage1.Controls.Add(this.btnPluse);
            this.tabPage1.Controls.Add(this.btnMinuse);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.labelCount.Location = new System.Drawing.Point(213, 120);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(41, 44);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "0";
            // 
            // btnPluse
            // 
            this.btnPluse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnPluse.Location = new System.Drawing.Point(182, 6);
            this.btnPluse.Name = "btnPluse";
            this.btnPluse.Size = new System.Drawing.Size(108, 51);
            this.btnPluse.TabIndex = 2;
            this.btnPluse.Text = "+";
            this.btnPluse.UseVisualStyleBackColor = true;
            this.btnPluse.Click += new System.EventHandler(this.btnPluse_Click);
            // 
            // btnMinuse
            // 
            this.btnMinuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnMinuse.Location = new System.Drawing.Point(182, 234);
            this.btnMinuse.Name = "btnMinuse";
            this.btnMinuse.Size = new System.Drawing.Size(108, 51);
            this.btnMinuse.TabIndex = 1;
            this.btnMinuse.Text = "-";
            this.btnMinuse.UseVisualStyleBackColor = true;
            this.btnMinuse.Click += new System.EventHandler(this.btnMinuse_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnReset.Location = new System.Drawing.Point(344, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 51);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRand);
            this.tabPage2.Controls.Add(this.tbRand);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.lblRand);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRand);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.numericUpDown2.Location = new System.Drawing.Point(64, 86);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(64, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lblRand
            // 
            this.lblRand.AutoSize = true;
            this.lblRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblRand.Location = new System.Drawing.Point(285, 92);
            this.lblRand.Name = "lblRand";
            this.lblRand.Size = new System.Drawing.Size(27, 29);
            this.lblRand.TabIndex = 3;
            this.lblRand.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "От";
            // 
            // btnRand
            // 
            this.btnRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnRand.Location = new System.Drawing.Point(276, 42);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(188, 43);
            this.btnRand.TabIndex = 0;
            this.btnRand.Text = "Генерировать";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // tbRand
            // 
            this.tbRand.Location = new System.Drawing.Point(354, 166);
            this.tbRand.MaxLength = 2;
            this.tbRand.Multiline = true;
            this.tbRand.Name = "tbRand";
            this.tbRand.Size = new System.Drawing.Size(110, 119);
            this.tbRand.TabIndex = 6;
            // 
            // cbRand
            // 
            this.cbRand.AutoSize = true;
            this.cbRand.Checked = true;
            this.cbRand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRand.Location = new System.Drawing.Point(354, 143);
            this.cbRand.Name = "cbRand";
            this.cbRand.Size = new System.Drawing.Size(97, 17);
            this.cbRand.TabIndex = 7;
            this.cbRand.Text = "Не Повторять";
            this.cbRand.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(487, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блокнот";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(487, 293);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiIstertTime,
            this.вставитьДатуИВремяToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiOpen});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(234, 22);
            this.tsmiInsertDate.Text = "Вставить дату";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiIstertTime
            // 
            this.tsmiIstertTime.Name = "tsmiIstertTime";
            this.tsmiIstertTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.tsmiIstertTime.Size = new System.Drawing.Size(234, 22);
            this.tsmiIstertTime.Text = "Вставить время";
            this.tsmiIstertTime.Click += new System.EventHandler(this.tsmiIstertTime_Click);
            // 
            // вставитьДатуИВремяToolStripMenuItem
            // 
            this.вставитьДатуИВремяToolStripMenuItem.Name = "вставитьДатуИВремяToolStripMenuItem";
            this.вставитьДатуИВремяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.вставитьДатуИВремяToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.вставитьДатуИВремяToolStripMenuItem.Text = "Вставить дату и время";
            this.вставитьДатуИВремяToolStripMenuItem.Click += new System.EventHandler(this.вставитьДатуИВремяToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(234, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(234, 22);
            this.tsmiOpen.Text = "Открыть";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbPass);
            this.tabPage4.Controls.Add(this.btnPass);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.nudPass);
            this.tabPage4.Controls.Add(this.clbPass);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(487, 293);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пароль";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // clbPass
            // 
            this.clbPass.CheckOnClick = true;
            this.clbPass.FormattingEnabled = true;
            this.clbPass.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: %, *, ), ?, !, #, $, ^, &, ~"});
            this.clbPass.Location = new System.Drawing.Point(17, 20);
            this.clbPass.Name = "clbPass";
            this.clbPass.Size = new System.Drawing.Size(379, 64);
            this.clbPass.TabIndex = 0;
            // 
            // nudPass
            // 
            this.nudPass.Location = new System.Drawing.Point(17, 148);
            this.nudPass.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPass.Name = "nudPass";
            this.nudPass.Size = new System.Drawing.Size(120, 20);
            this.nudPass.TabIndex = 1;
            this.nudPass.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина пароля";
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnPass.Location = new System.Drawing.Point(81, 219);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(315, 43);
            this.btnPass.TabIndex = 3;
            this.btnPass.Text = "Сгенерировать";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(198, 147);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(263, 20);
            this.tbPass.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cmMetrics);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.btnConvert);
            this.tabPage5.Controls.Add(this.tbTo);
            this.tabPage5.Controls.Add(this.tbFrom);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.cmTo);
            this.tabPage5.Controls.Add(this.cmFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(487, 293);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конвертор";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cmFrom
            // 
            this.cmFrom.FormattingEnabled = true;
            this.cmFrom.Items.AddRange(new object[] {
            "mm",
            "sm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cmFrom.Location = new System.Drawing.Point(8, 87);
            this.cmFrom.Name = "cmFrom";
            this.cmFrom.Size = new System.Drawing.Size(121, 21);
            this.cmFrom.TabIndex = 0;
            this.cmFrom.Text = "mm";
            // 
            // cmTo
            // 
            this.cmTo.FormattingEnabled = true;
            this.cmTo.Items.AddRange(new object[] {
            "mm",
            "sm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cmTo.Location = new System.Drawing.Point(358, 87);
            this.cmTo.Name = "cmTo";
            this.cmTo.Size = new System.Drawing.Size(121, 21);
            this.cmTo.TabIndex = 1;
            this.cmTo.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Конвертуемое";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Результат";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(8, 114);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(121, 20);
            this.tbFrom.TabIndex = 4;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(358, 114);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(121, 20);
            this.tbTo.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(184, 114);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(119, 39);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "<->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmMetrics
            // 
            this.cmMetrics.FormattingEnabled = true;
            this.cmMetrics.Items.AddRange(new object[] {
            "Длина",
            "Вес"});
            this.cmMetrics.Location = new System.Drawing.Point(184, 24);
            this.cmMetrics.Name = "cmMetrics";
            this.cmMetrics.Size = new System.Drawing.Size(119, 21);
            this.cmMetrics.TabIndex = 8;
            this.cmMetrics.Text = "Длина";
            this.cmMetrics.SelectedIndexChanged += new System.EventHandler(this.cmMetrics_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Tag = "";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPass)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem помощToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnPluse;
        private System.Windows.Forms.Button btnMinuse;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblRand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.TextBox tbRand;
        private System.Windows.Forms.CheckBox cbRand;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiIstertTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripMenuItem вставитьДатуИВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPass;
        private System.Windows.Forms.CheckedListBox clbPass;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmTo;
        private System.Windows.Forms.ComboBox cmFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmMetrics;
    }
}

