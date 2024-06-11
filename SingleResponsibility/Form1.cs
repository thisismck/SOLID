namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        //Single Responsibility Principle
        //This class should only be responsible for the form itself
        //It should not be responsible for the form's design
        //It should not be responsible for the form's behavior
        //It should not be responsible for the form's data
        //It should not be responsible for the form's presentation
        //It should not be responsible for the form's validation

    }
}
