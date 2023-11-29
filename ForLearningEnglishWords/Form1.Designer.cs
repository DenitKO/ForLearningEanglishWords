namespace ForLearningEnglishWords
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnOpen = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Words = new DataGridViewTextBoxColumn();
            Transcription = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            Time0 = new DataGridViewTextBoxColumn();
            Time1 = new DataGridViewTextBoxColumn();
            Time2 = new DataGridViewTextBoxColumn();
            Time3 = new DataGridViewTextBoxColumn();
            Time4 = new DataGridViewTextBoxColumn();
            Time5 = new DataGridViewTextBoxColumn();
            Time6 = new DataGridViewTextBoxColumn();
            Time7 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnValidate = new Button();
            dateTimePicker = new DateTimePicker();
            btnExit = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSaveAss = new Button();
            tbComment = new TextBox();
            tbAddTranscription = new TextBox();
            tbAddWord = new TextBox();
            btnRepeatMemorization = new Button();
            btnClearAll = new Button();
            btnClearTb = new Button();
            btnAdd = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(6, 79);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Открыть";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(140, 79);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(77, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1438, 505);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Words, Transcription, Comment, Time0, Time1, Time2, Time3, Time4, Time5, Time6, Time7 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1438, 389);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Words
            // 
            Words.HeaderText = "Слова";
            Words.Name = "Words";
            Words.ReadOnly = true;
            // 
            // Transcription
            // 
            Transcription.HeaderText = "Транскрипция";
            Transcription.Name = "Transcription";
            Transcription.ReadOnly = true;
            // 
            // Comment
            // 
            Comment.HeaderText = "Перевод / Комеентарий";
            Comment.Name = "Comment";
            Comment.ReadOnly = true;
            // 
            // Time0
            // 
            Time0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time0.HeaderText = "Повтор 0";
            Time0.Name = "Time0";
            Time0.ReadOnly = true;
            Time0.Width = 78;
            // 
            // Time1
            // 
            Time1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time1.HeaderText = "Повтор 1";
            Time1.Name = "Time1";
            Time1.ReadOnly = true;
            Time1.Width = 78;
            // 
            // Time2
            // 
            Time2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time2.HeaderText = "Повтор 2";
            Time2.Name = "Time2";
            Time2.ReadOnly = true;
            Time2.Width = 78;
            // 
            // Time3
            // 
            Time3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time3.HeaderText = "Повтор 3";
            Time3.Name = "Time3";
            Time3.ReadOnly = true;
            Time3.Width = 78;
            // 
            // Time4
            // 
            Time4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time4.HeaderText = "Повтор 4";
            Time4.Name = "Time4";
            Time4.ReadOnly = true;
            Time4.Width = 78;
            // 
            // Time5
            // 
            Time5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time5.HeaderText = "Повтор 5";
            Time5.Name = "Time5";
            Time5.ReadOnly = true;
            Time5.Width = 78;
            // 
            // Time6
            // 
            Time6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time6.HeaderText = "Повтор 6";
            Time6.Name = "Time6";
            Time6.ReadOnly = true;
            Time6.Width = 78;
            // 
            // Time7
            // 
            Time7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Time7.HeaderText = "Повтор 7";
            Time7.Name = "Time7";
            Time7.ReadOnly = true;
            Time7.Width = 78;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnValidate);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSaveAss);
            groupBox1.Controls.Add(tbComment);
            groupBox1.Controls.Add(tbAddTranscription);
            groupBox1.Controls.Add(tbAddWord);
            groupBox1.Controls.Add(btnRepeatMemorization);
            groupBox1.Controls.Add(btnClearAll);
            groupBox1.Controls.Add(btnClearTb);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1438, 116);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnValidate
            // 
            btnValidate.Enabled = false;
            btnValidate.Location = new Point(515, 79);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(86, 23);
            btnValidate.TabIndex = 11;
            btnValidate.Text = "Валидация";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(740, 29);
            dateTimePicker.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(162, 23);
            dateTimePicker.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1273, 79);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(1273, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(1192, 29);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(740, 9);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Повтор 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 11);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 6;
            label3.Text = "Перевод | Комментарий";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 11);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "Транскрипция";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Слово";
            // 
            // btnSaveAss
            // 
            btnSaveAss.Enabled = false;
            btnSaveAss.Location = new Point(267, 79);
            btnSaveAss.Name = "btnSaveAss";
            btnSaveAss.Size = new Size(100, 23);
            btnSaveAss.TabIndex = 5;
            btnSaveAss.Text = "СохранитьКак";
            btnSaveAss.UseVisualStyleBackColor = true;
            btnSaveAss.Click += btnSaveAss_Click;
            // 
            // tbComment
            // 
            tbComment.Location = new Point(515, 29);
            tbComment.Name = "tbComment";
            tbComment.Size = new Size(219, 23);
            tbComment.TabIndex = 4;
            // 
            // tbAddTranscription
            // 
            tbAddTranscription.Location = new Point(276, 29);
            tbAddTranscription.Name = "tbAddTranscription";
            tbAddTranscription.Size = new Size(219, 23);
            tbAddTranscription.TabIndex = 4;
            // 
            // tbAddWord
            // 
            tbAddWord.Location = new Point(6, 29);
            tbAddWord.Name = "tbAddWord";
            tbAddWord.Size = new Size(238, 23);
            tbAddWord.TabIndex = 4;
            // 
            // btnRepeatMemorization
            // 
            btnRepeatMemorization.Enabled = false;
            btnRepeatMemorization.Location = new Point(720, 79);
            btnRepeatMemorization.Name = "btnRepeatMemorization";
            btnRepeatMemorization.Size = new Size(476, 23);
            btnRepeatMemorization.TabIndex = 2;
            btnRepeatMemorization.Text = "Повторить Запоминание";
            btnRepeatMemorization.UseVisualStyleBackColor = true;
            btnRepeatMemorization.Click += btnRepeatMemorization_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(962, 54);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(93, 23);
            btnClearAll.TabIndex = 2;
            btnClearAll.Text = "Очистить всё";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnClearTb
            // 
            btnClearTb.Location = new Point(971, 29);
            btnClearTb.Name = "btnClearTb";
            btnClearTb.Size = new Size(75, 23);
            btnClearTb.TabIndex = 2;
            btnClearTb.Text = "Очистить";
            btnClearTb.UseVisualStyleBackColor = true;
            btnClearTb.Click += btnClearTb_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1111, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 505);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btnSave;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnAdd;
        private TextBox tbAddWord;
        private TextBox tbAddTranscription;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSaveAss;
        private TextBox tbComment;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnRepeatMemorization;
        private Button btnExit;
        private DataGridViewTextBoxColumn Words;
        private DataGridViewTextBoxColumn Transcription;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewTextBoxColumn Time0;
        private DataGridViewTextBoxColumn Time1;
        private DataGridViewTextBoxColumn Time2;
        private DataGridViewTextBoxColumn Time3;
        private DataGridViewTextBoxColumn Time4;
        private DataGridViewTextBoxColumn Time5;
        private DataGridViewTextBoxColumn Time6;
        private DataGridViewTextBoxColumn Time7;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private System.Windows.Forms.Timer timer2;
        private Button btnClearTb;
        private Button btnClearAll;
        private Button btnValidate;
        protected internal DataGridView dataGridView1;
    }
}