using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfusaoTimePoint.Dados
{
    static class VerificarDados
    {
        public static void VerificarExistenciaPasta()
        {
            string caminhoPastaPrincipal = @"Horas";
            if (!Directory.Exists(caminhoPastaPrincipal))
            {
                Directory.CreateDirectory(caminhoPastaPrincipal);
            }

            string caminhoPastaHorasDetalhadas = @"Horas\\HorasDetalhadas";
            if (!Directory.Exists(caminhoPastaHorasDetalhadas))
            {
                Directory.CreateDirectory(caminhoPastaHorasDetalhadas);
            }
        }

        public static bool VerificarSeTarefaExiste(string _nomeArquivo, string _descricaoTarefa)
        {
            try
            {
                string[] linhasDoTexto = File.ReadAllLines(@"Horas\" + _nomeArquivo + "");

                foreach (string linha in linhasDoTexto)
                {
                    string[] linhaQuebradaPorTab = linha.Split('\t');
                    //_caixaDeTexto.Text += linha + "\n";
                    if (_descricaoTarefa.Equals(linhaQuebradaPorTab[2]))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                // throw;
                return false;
            }
        }
    }
}
