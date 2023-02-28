namespace wfaDöngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <=10; i++ )
            {
                MessageBox.Show("Merhaba Dünya")
;            }
        }
    }
}