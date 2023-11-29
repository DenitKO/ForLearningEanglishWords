namespace ForLearningEnglishWords
{
    public partial class ReminderForm : Form
    {
        public ReminderForm()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label2.Text)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (textBox1.Text.ToLower() == label2.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}