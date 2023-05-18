namespace winFuncoes
{
    public partial class FormFuncoesAritmeticas : Form
    {
        public FormFuncoesAritmeticas()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            double v1 = 0, v2 = 0, resultado = 0;
            double.TryParse(textValor1.Text, out v1);
            double.TryParse(textValor2.Text, out v2);

            resultado = libraryFuncoes.FuncoesAritmeticas.Somar(v1, v2);
            textResultado.Text = resultado.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";

            double v1 = 0, v2 = 0, resultado = 0;
            double.TryParse(textValor1.Text, out v1);
            double.TryParse(textValor2.Text, out v2);

            resultado = libraryFuncoes.FuncoesAritmeticas.Subtrair(v1, v2);
            textResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";

            double v1 = 0, v2 = 0, resultado = 0;
            double.TryParse(textValor1.Text, out v1);
            double.TryParse(textValor2.Text, out v2);

            resultado = libraryFuncoes.FuncoesAritmeticas.Multiplicar(v1, v2);
            textResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";

            double v1 = 0, v2 = 0, resultado = 0;
            double.TryParse(textValor1.Text, out v1);
            double.TryParse(textValor2.Text, out v2);

            resultado = libraryFuncoes.FuncoesAritmeticas.Dividir(v1, v2);
            textResultado.Text = resultado.ToString();
        }
    }
}