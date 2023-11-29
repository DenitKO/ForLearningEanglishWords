using System.Text;

namespace ForLearningEnglishWords
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        string fileValidator = string.Empty;
        bool gridChanged = false;
        List<bool[]> checkedList = new List<bool[]>();
        
        public Form1()
        {
            InitializeComponent();
            settings();
        }

        private void settings()
        {
            //dataGridView1.AllowUserToAddRows = false;
            openFileDialog1.Filter = "CSV files(*.csv)|*.csv";
            // Предпологалось изспользоывть разные расширения, но пока оставлю только csv
            //openFileDialog1.Filter = "CSV files(*.csv)|*.csv|Text files(*.txt)|*.txt|All files(*.*)|*.*";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            timer1.Interval = 1000; //1 sec
            timer1.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MeExit()) e.Cancel = true;
        }

        private bool MeExit()
        {
            DialogResult iExit;
            if (gridChanged)
            {
                iExit = MessageBox.Show("Confirm if you want to exit without saving", "Save DataGirdView", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.No)
                {
                    return false;
                }
                else return true;
            }
            else return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkedList.Add(Enumerable.Repeat(false, 8).ToArray());
            DateTime[] SomeDate = ToArrayOfDateTime(DateTime.Now);
            dataGridView1.Rows.Add(tbAddWord.Text, tbAddTranscription.Text, tbComment.Text, SomeDate[0], SomeDate[1], SomeDate[2], SomeDate[3], SomeDate[4], SomeDate[5], SomeDate[6], SomeDate[7]);
            ActivateBtns();
            ClearTextBoxesAndActivateTimer();
            gridChanged = true;
        }

        private DateTime[] ToArrayOfDateTime(DateTime firstDateTime)
        {
            DateTime[] DatesTimes = new DateTime[8];
            DatesTimes[0] = firstDateTime;
            DatesTimes[1] = DatesTimes[0];
            DatesTimes[2] = DatesTimes[1].AddMinutes(20);
            DatesTimes[3] = DatesTimes[2].AddHours(8);
            DatesTimes[4] = DatesTimes[3].AddHours(24);
            DatesTimes[5] = DatesTimes[4].AddDays(3);
            DatesTimes[6] = DatesTimes[5].AddMonths(1);
            DatesTimes[7] = DatesTimes[6].AddMonths(4);
            return DatesTimes;
        }

        private void ChangeDateTimesAtDataGrid(DateTime firstToRepeatDateTime)
        {
            DateTime[] someArray = ToArrayOfDateTime(firstToRepeatDateTime);
            for (int i = 0; i < someArray.Length; i++)
            {
                dataGridView1[i + 3, dataGridView1.CurrentCell.RowIndex].Value = someArray[i];
            }
        }

        private void ActivateBtns()
        {
            btnSave.Enabled = true;
            btnSaveAss.Enabled = true;
            btnRepeatMemorization.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnValidate.Enabled = true;
        }

        private void DeActivateBtnsAndClearFilePath()
        {
            btnSave.Enabled = false;
            btnSaveAss.Enabled = false;
            btnRepeatMemorization.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnValidate.Enabled = false;

            filePath = string.Empty;
            fileValidator = string.Empty;

            gridChanged = false;
        }

        private void ClearTextBoxesAndActivateTimer()
        {
            tbAddWord.Text = String.Empty;
            tbComment.Text = String.Empty;
            tbAddTranscription.Text = String.Empty;
            timer1.Enabled = true;
        }

        private void ValidateDateTimeMemorization()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 3; j < dataGridView1.Columns.Count; j++)
                {
                    if ((DateTime)dataGridView1[j, i].Value < DateTime.Now && checkedList[i] [j-3])
                        dataGridView1[j, i].Style.BackColor = Color.Green;
                    else if ((DateTime)dataGridView1[j, i].Value < DateTime.Now) 
                        dataGridView1[j, i].Style.BackColor = Color.Red;
                    else
                        dataGridView1[j, i].Style.BackColor = Color.White;
                }
            }
        }

        private void iDeleted()
        {
            // Удаляет все строки по выделенным ячейкам
            // Delete Rows By Selected Cells
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                int index = cell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                checkedList.RemoveAt(index);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            gridChanged = true;
            iDeleted();
            if (dataGridView1.Rows.Count == 0) DeActivateBtnsAndClearFilePath();
            ClearTextBoxesAndActivateTimer();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != -1)
            {
                timer1.Enabled = false;
                tbAddWord.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                tbAddTranscription.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                tbComment.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                dateTimePicker.Value = (DateTime)dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value = tbAddWord.Text;
            dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value = tbAddTranscription.Text;
            dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value = tbComment.Text;
            ChangeDateTimesAtDataGrid(dateTimePicker.Value);
            ClearTextBoxesAndActivateTimer();
            gridChanged = true;
        }

        private void OpenFileValidator()
        {
            StreamReader sr = new StreamReader(fileValidator);
            int i = 0;
            while (!sr.EndOfStream)
            {
                checkedList.Add(new bool[] { false, false, false, false, false, false, false, false });
                int j = 0;
                foreach (var item in sr.ReadLine().Split(';'))
                {
                    if (item == "True")
                    {
                        checkedList[i][j] = true;
                        j++;
                    } else break;
                }
                i++;
            }
            sr.Close();
        }

        private void btnRepeatMemorization_Click(object sender, EventArgs e)
        {
            ClearTextBoxesAndActivateTimer();
            dataGridView1.Visible = false;
            if (File.Exists(fileValidator))
            {
                OpenFileValidator();
                showDialogOfMemorizing();
                iSaveToFile();
                iSaveFileValidator();
                gridChanged = false;
            }
            else
            {
                if (File.Exists(filePath))
                {
                    checkedList = createListBoolMatrix();
                    showDialogOfMemorizing();
                    iSaveToFile();
                    iSaveFileValidator();
                    gridChanged = false;
                }
                else
                {
                    checkedList = createListBoolMatrix();
                    iSaveAssToFile();
                    showDialogOfMemorizing();
                    iSaveFileValidator();
                    gridChanged = false;
                }
            }
            dataGridView1.Visible = true;
        }

        private List<bool[]> createListBoolMatrix()
        {
            List<bool[]> data = new List<bool[]>(dataGridView1.Rows.Count);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                data.Add(new bool[] { false, false, false, false, false, false, false, false });
            }
            return data;
        }

        private void showDialogOfMemorizing()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!checkedList[i][j])
                    {
                        if ((DateTime)dataGridView1[j + 3, i].Value < DateTime.Now)
                        {
                            ReminderForm reminderForm = new ReminderForm();
                            //settings
                            reminderForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                            reminderForm.ControlBox = false;

                            reminderForm.label1.Text = dataGridView1[2, i].Value.ToString();
                            reminderForm.label2.Text = dataGridView1[0, i].Value.ToString().ToLower();

                            reminderForm.ShowDialog();
                            if (reminderForm.DialogResult == DialogResult.OK)
                            {
                                checkedList[i][j] = true;
                            }
                            reminderForm.Close();
                        }
                        else break;
                    }
                }
            }
        }

        private void iSaveFileValidator()
        {
            StreamWriter sw = new StreamWriter(fileValidator);

            StringBuilder sb = new StringBuilder();
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        sb.Append(checkedList[i][j]);
                        sb.Append(";");
                    }
                    sb.Length = sb.Length - 1;
                    sb.Append("\n");
                }
                sb.Length = sb.Length - 1;
            }
            sw.Write(sb);
            sw.Close();
        }

        private void iFillDataGridFromFileAndClearGrid()
        {
            //Присвоение пути двум файлам, файл для Валидации проверки слов, и сам файл со словами
            filePath = openFileDialog1.FileName;
            fileValidator = filePath.Remove(filePath.Length - 4);
            fileValidator = fileValidator + "Validator.csv";

            dataGridView1.Rows.Clear();
            StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(';');
                dataGridView1.Rows.Add(line[0],
                                       line[1],
                                       line[2],
                                       DateTime.Parse(line[3]),
                                       DateTime.Parse(line[4]),
                                       DateTime.Parse(line[5]),
                                       DateTime.Parse(line[6]),
                                       DateTime.Parse(line[7]),
                                       DateTime.Parse(line[8]),
                                       DateTime.Parse(line[9]),
                                       DateTime.Parse(line[10]));
            }
            sr.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                iFillDataGridFromFileAndClearGrid();
                ActivateBtns();
            }
            if (File.Exists(fileValidator))
            {
                //checkedList = createListBoolMatrix();
                OpenFileValidator();
            }
            else
            {
                checkedList = createListBoolMatrix();
            }
        }

        private void iSaveToFile()
        {
            StreamWriter sw = new StreamWriter(filePath);

            StringBuilder sb = new StringBuilder();
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        sb.Append(dataGridView1[j, i].Value);
                        sb.Append(";");
                    }
                    sb.Length = sb.Length - 1;
                    sb.Append("\n");
                }
                sb.Length = sb.Length - 1;
            }
            sw.Write(sb);
            sw.Close();
        }

        private void iSaveAssToFile()
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Azaza.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV files(*.csv)|*.csv";
            //saveFileDialog1.Filter = "CSV files(*.csv)|*.csv|Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                fileValidator = filePath.Remove(filePath.Length - 4);
                fileValidator = fileValidator + "Validator.csv";
                iSaveToFile();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty) { }
            else
            {
                iSaveToFile();
                if (checkedList != null) { iSaveFileValidator(); }
                gridChanged = false;
            }
        }

        private void btnSaveAss_Click(object sender, EventArgs e)
        {
            iSaveAssToFile();
            if (checkedList != null) { iSaveFileValidator(); }
            gridChanged = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnClearTb_Click(object sender, EventArgs e)
        {
            ClearTextBoxesAndActivateTimer();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            checkedList.Clear();
            ClearTextBoxesAndActivateTimer();
            DeActivateBtnsAndClearFilePath();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidateDateTimeMemorization();
        }

    }
}