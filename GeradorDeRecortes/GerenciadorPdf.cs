using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using Font = iTextSharp.text.Font;

namespace GeradorDeRecortes
{
    public class GerenciadorPdf
    {
        public void GerarPdf(int quantidadeDePalavras, int tamanhoMaximo, int tamanhoMinimo, string palavraEspecifica, bool somenteMaiscula, int tamanhoMaximoDaFonte, int tamanhoMinimoDaFonte)
        {
            var nomeArquivo = "pdfcriado.pdf";
            using (var arquivo = new FileStream(nomeArquivo, FileMode.Create))
            {
                var documento = new Document(PageSize.A4);
                var writer = PdfWriter.GetInstance(documento, arquivo);
                documento.Open();
                GeracaoPdf(documento, quantidadeDePalavras, tamanhoMaximo, tamanhoMinimo, palavraEspecifica, somenteMaiscula, tamanhoMaximoDaFonte, tamanhoMinimoDaFonte);
                documento.Close();

                var caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);
                if (File.Exists(caminho))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = $"/c start {caminho}",
                        FileName = "cmd.exe",
                        CreateNoWindow = true,
                    });
                }
            }
        }

        private void GeracaoPdf(Document doc, int quantidadeDePalavras, int tamanhoMaximo, int tamanhoMinimo, string palavraEspecifica, bool somenteMaiscula, int tamanhoMaximoDaFonte, int tamanhoMinimoDaFonte)
        {
            var listaDeEstilos = BibliotecaDeEstilos();
            var tabela = new PdfPTable(new float[] { 1f });
            var rnd = new Random();
            for (int i = 0; i < quantidadeDePalavras; i++)
            {
                var estilo = listaDeEstilos[rnd.Next(listaDeEstilos.Count)];
                var corUmEhCorDeFundo = rnd.Next(2) == 1;
                var corDeFundo = corUmEhCorDeFundo ? estilo.Cor1 : estilo.Cor2;
                var corDaFonte = corUmEhCorDeFundo ? estilo.Cor2 : estilo.Cor1;
                var celula = new PdfPCell();
                celula.BorderWidth = 0;
                GerarPalavra(celula, corDaFonte, tamanhoMaximo, tamanhoMinimo, palavraEspecifica, somenteMaiscula, tamanhoMaximoDaFonte, tamanhoMinimoDaFonte);
                celula.BackgroundColor = corDeFundo;
                tabela.AddCell(celula);
            }
            doc.Add(tabela);
        }

        private List<Estilo> BibliotecaDeEstilos()
        {
            return new List<Estilo>()
            {
                //vermelha
                new Estilo(new BaseColor(231,45,46),BaseColor.WHITE),
                new Estilo(new BaseColor(231,45,46),BaseColor.BLACK),
                new Estilo(new BaseColor(193,62,48),BaseColor.WHITE),
                //laranja
                new Estilo(new BaseColor(246,145,28), BaseColor.WHITE),
                new Estilo(new BaseColor(255,145,76), BaseColor.BLACK),
                new Estilo(new BaseColor(255,169,27),new BaseColor(64,64,64)),
                //amarelo
                new Estilo(new BaseColor(250,237,1), BaseColor.BLACK),
                new Estilo(new BaseColor(185,173,53), BaseColor.BLACK),
                //ciano
                new Estilo(new BaseColor(62,191,190), BaseColor.WHITE),
                //verde
                new Estilo(new BaseColor(140,198,65), BaseColor.WHITE),
                new Estilo(new BaseColor(0,203,148), new BaseColor(2,83,104)),
                new Estilo(new BaseColor(0,120,51), BaseColor.WHITE),
                //roxo
                new Estilo(new BaseColor(166,132,189), BaseColor.WHITE),
                //rosa
                new Estilo(new BaseColor(224,110,169), BaseColor.BLACK),
                //azul
                new Estilo(new BaseColor(24,108,251), new BaseColor(173,211,252)),
                new Estilo(new BaseColor(82,155,196), new BaseColor(253,229,97)),
                new Estilo(new BaseColor(0,108,183), BaseColor.BLACK),
                new Estilo(new BaseColor(31, 69, 80), new BaseColor(253,255,250)),
            };
        }

        private void GerarPalavra(PdfPCell celula, BaseColor cor, int tamanhoMaximo, int tamanhoMinimo, string palavraEspecifica, bool somenteMaiscula, int tamanhoMaximoDaFonte, int tamanhoMinimoDaFonte)
        {
            var rnd = new Random();

            var textoFinal = string.Empty;

            if(palavraEspecifica != string.Empty)
            {
                textoFinal = palavraEspecifica;
            }
            else
            {
                var biblioteca = new Biblioteca();
                textoFinal = biblioteca.GerarPalavra(tamanhoMaximo, tamanhoMinimo, somenteMaiscula);
            }
            var fontes = FontFactory.RegisteredFonts.ToList();
            fontes.Remove("symbol");
            fontes.Remove("zapfdingbats");
            var totalfonts = fontes.Count;
            var indiceFonte = rnd.Next(totalfonts);
            var fontFamily = fontes[indiceFonte];
            var tamanhoDaFonte = rnd.Next(tamanhoMinimoDaFonte, tamanhoMaximoDaFonte);
            var fonte = FontFactory.GetFont(fontFamily, tamanhoDaFonte);
            fonte.Color = cor;
            var pTexto = new Paragraph(textoFinal, fonte);
            pTexto.Alignment = Element.ALIGN_CENTER;
            celula.FixedHeight = tamanhoDaFonte * 2;
            celula.HorizontalAlignment = Element.ALIGN_CENTER;
            celula.VerticalAlignment = Element.ALIGN_TOP;
            celula.AddElement(pTexto);
        }
    }
}
