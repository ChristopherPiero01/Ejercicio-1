namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fah = float.Parse(this.txtFa.Text);
            float cel = (fah-32)*5/9;
            txtCe.Text=cel.ToString();
        }
    }
}