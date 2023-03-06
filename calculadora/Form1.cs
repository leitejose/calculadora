namespace calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao operacaoSelecionada { get; set; }
 
        private enum Operacao
        {
            soma,
            subtracao,
            multiplicacao,
            divisao,
            porcentagem
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            boxResultado.Text += "9";
        }

        private void btnZero_Click_1(object sender, EventArgs e)
        {
            boxResultado.Text += "0";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.soma;
            Valor = Convert.ToDecimal (boxResultado.Text);
            boxResultado.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.subtracao;
            Valor = Convert.ToDecimal(boxResultado.Text);
            boxResultado.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.multiplicacao;
            Valor = Convert.ToDecimal(boxResultado.Text);
            boxResultado.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.divisao;
            Valor = Convert.ToDecimal(boxResultado.Text);
            boxResultado.Text = "";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.porcentagem;
            Valor = Convert.ToDecimal(boxResultado.Text);
            boxResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacaoSelecionada)
            {
                   case Operacao.divisao:
                    Resultado = Valor / Convert.ToDecimal (boxResultado.Text);
                    break;
                   case Operacao.subtracao:
                    Resultado = Valor - Convert.ToDecimal(boxResultado.Text);
                    break;
                   case Operacao.multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(boxResultado.Text);
                    break;
                   case Operacao.soma:
                    Resultado = Valor + Convert.ToDecimal(boxResultado.Text);
                    break;
                   case Operacao.porcentagem:
                    Resultado = (Valor /100) * Convert.ToDecimal(boxResultado.Text);
                    break;

            }
            boxResultado.Text =Convert.ToString (Resultado);
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!boxResultado.Text.Contains(",")){
                boxResultado.Text += ",";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            boxResultado.Text = "";
        }
    }
}