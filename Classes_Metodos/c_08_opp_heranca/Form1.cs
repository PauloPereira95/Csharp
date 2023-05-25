namespace c_08_opp_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cilindro c = new Cilindro();
            c.AlturaCilindro = int.Parse(txtAltura.Text);
            c.Area = int.Parse(txtAreaBase.Text);
            lblResultado.Text = $"\nA -> {c.AlturaCilindro} || AB -> {c.Area} \n " +
                $"Volume -> {c.Volume}";
        }
    }
}