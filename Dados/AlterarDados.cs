using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfusaoTimePoint.Dados
{
    class AlterarDados
    {

        public void AlterarTextoNoArquivo(string _contratos, string _sigla, string _descricaoAtividade, string _horasUtilizadas, string dataServico)
        {
            //Seto o nome do arquivo de texto e busco a data do dia atual.
            string dataHoje = DateTime.Now.ToShortDateString().Replace(@"/", "-");
            string caminhoArquivo = $"Horas\\Dia - {dataHoje}.txt";

            //Escreve no arquivo de texto
            File.AppendAllText(caminhoArquivo, $"{_contratos}\t{_sigla}\t{_descricaoAtividade}\t{_horasUtilizadas}\t{dataServico}\tNÃO CRIADA"); // Editar a primeira linha
            File.AppendAllText(caminhoArquivo, "\n");

            //Copia o texto para o Ctrl+C
            Clipboard.SetText(File.ReadAllText(caminhoArquivo));
        }
    }
}
