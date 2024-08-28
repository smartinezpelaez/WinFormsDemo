namespace BetterWinFormsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" Hello {FirstNameText.Text} {lastNameText.Text} ");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
