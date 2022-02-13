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
        AlterarDados ad = new AlterarDados();

        #region Inserir os dados no arquivo de horas
        public void InserirTextoNoArquivoHoras(string _nomeArquivo, string _contratos, string _sigla, string _descricaoAtividade, float _horasUtilizadas, string _dataServico)
        {
            if (VerificarDados.VerificarSeTarefaExiste(_nomeArquivo, _descricaoAtividade) == true)
            {
                //MessageBox.Show("Ja existe");
                ad.AlterarTextoNoArquivo(_nomeArquivo, _descricaoAtividade, _horasUtilizadas, _dataServico);
            }
            else
            {
                //Seto o nome do arquivo de texto e busco a data do dia atual.
                //string dataHoje = DateTime.Now.ToShortDateString().Replace(@"/", "-");
                VerificarDados.VerificarExistenciaPasta();
                string caminhoArquivo = $"Horas\\{_nomeArquivo}";

                //Escreve no arquivo de texto
                File.AppendAllText(caminhoArquivo, $"{_contratos}\t{_sigla}\t{_descricaoAtividade}\t{_horasUtilizadas}\t{_dataServico}\tNÃO CRIADA"); // Editar a primeira linha
                File.AppendAllText(caminhoArquivo, "\n");

                //Copia o texto para o Ctrl+C
                Clipboard.SetText(File.ReadAllText(caminhoArquivo));
            }
        }
        #endregion

        #region Inserir os dados no arquivo de horas detalhadas (jira)
        public void InserirTextoArquivoHorasDETALHADAS(string _nomeArquivo, string _contratos, string _sigla, string _descricaoAtividade, string _hInicial, string _hFinal, float _horasUtilizadas, string _dataServico)
        {
            string[] nomeArquivoDividido = _nomeArquivo.Split('.');
            //Seto o nome do arquivo de texto e busco a data do dia atual.
            VerificarDados.VerificarExistenciaPasta();
            string caminhoArquivo = $"Horas\\HorasDetalhadas\\{nomeArquivoDividido[0]}-JIRA.txt";

            //Escreve no arquivo de texto
            File.AppendAllText(caminhoArquivo, $"{_dataServico}  |  {_hInicial} - {_hFinal} - {_descricaoAtividade} | {_horasUtilizadas}"); // Editar a primeira linha
            File.AppendAllText(caminhoArquivo, "\n");
        }
        #endregion
    }
}
