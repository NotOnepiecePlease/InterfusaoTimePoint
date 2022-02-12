using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfusaoTimePoint.Dados
{
    class InserirDados
    {

        public void InserirTextoNoArquivoHoras(string _nomeArquivo, string _contratos, string _sigla, string _descricaoAtividade, string _horasUtilizadas, string dataServico)
        {
            if (VerificarSeTarefaExiste(_nomeArquivo, _descricaoAtividade) == true)
            {
                MessageBox.Show("Ja existe");
            }
            else
            {
                //Seto o nome do arquivo de texto e busco a data do dia atual.
                //string dataHoje = DateTime.Now.ToShortDateString().Replace(@"/", "-");
                VerificarExistenciaPasta();
                string caminhoArquivo = $"Horas\\{_nomeArquivo}";

                //Escreve no arquivo de texto
                File.AppendAllText(caminhoArquivo, $"{_contratos}\t{_sigla}\t{_descricaoAtividade}\t{_horasUtilizadas}\t{dataServico}\tNÃO CRIADA"); // Editar a primeira linha
                File.AppendAllText(caminhoArquivo, "\n");

                //Copia o texto para o Ctrl+C
                Clipboard.SetText(File.ReadAllText(caminhoArquivo));
            }
        }

        public void InserirTextoArquivoHorasDETALHADAS(string _nomeArquivo, string _contratos, string _sigla, string _descricaoAtividade, string _hInicial, string _hFinal, string _horasUtilizadas, string _dataServico)
        {
            string[] nomeArquivoDividido = _nomeArquivo.Split('.');
            //Seto o nome do arquivo de texto e busco a data do dia atual.
            VerificarExistenciaPasta();
            string caminhoArquivo = $"Horas\\HorasDetalhadas\\{nomeArquivoDividido[0]}-JIRA.txt";

            //Escreve no arquivo de texto
            File.AppendAllText(caminhoArquivo, $"{_dataServico}  |  {_hInicial} - {_hFinal} - {_descricaoAtividade} | {_horasUtilizadas}"); // Editar a primeira linha
            File.AppendAllText(caminhoArquivo, "\n");
        }

        private void VerificarExistenciaPasta()
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

        public bool VerificarSeTarefaExiste(string _nomeArquivo, string _descricaoTarefa)
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
