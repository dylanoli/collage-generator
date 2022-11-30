namespace GeradorDeRecortes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGerarArquivo_Click(object sender, EventArgs e)
        {
            GerenciadorPdf gerenciadorPdf = new GerenciadorPdf();
            var quantidade = TBQuantidade.Text != string.Empty ? Convert.ToInt32(TBQuantidade.Text) : 1;
            var tamanhoMaximo = TBTamanhoMaximo.Text != string.Empty ? Convert.ToInt32(TBTamanhoMaximo.Text) : 0;
            var tamanhoMinimo = TBTamanhoMinimo.Text != string.Empty ? Convert.ToInt32(TBTamanhoMinimo.Text) : 0;            
            var palavraEspecífica = TBPalavraEspecífica.Text;
            var somenteMaiscula = CBMaiuscula.Checked;
            var tamanhoMaximoDaFonte = TBFonteMaxima.Text != string.Empty ? Convert.ToInt32(TBFonteMaxima.Text) : 0;
            var tamanhoMinimoDaFonte = TBFonteMinima.Text != string.Empty ? Convert.ToInt32(TBFonteMinima.Text) : 0;

            gerenciadorPdf.GerarPdf(quantidade, tamanhoMaximo, tamanhoMinimo, palavraEspecífica, somenteMaiscula, tamanhoMaximoDaFonte, tamanhoMinimoDaFonte);
        }

        private void TBQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteNumeros(sender, e);
        }

        private static void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBTamanhoMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteNumeros(sender, e);
        }

        private void TBTamanhoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteNumeros(sender, e);
        }
    }
}