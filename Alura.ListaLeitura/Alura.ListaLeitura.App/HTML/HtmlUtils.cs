using System;
using System.IO;

namespace Alura.ListaLeitura.App.HTML
{
    public class HtmlUtils
    {
        public static String CarregaArquivoHTML(string nomeArquivo)
        {
            string nomeCompletoArquivo = $"C:\\Users\\hicol\\Desktop\\Projetos\\Alura\\AspNetCoreMVC\\Alura.ListaLeitura\\Alura.ListaLeitura.App\\HTML\\{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
