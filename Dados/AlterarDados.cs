using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfusaoTimePoint.Dados
{
    // [DebuggerDisplay("MyProperty: {MyProperty}")]
    class AlterarDados
    {
        // public int MyProperty { get; set; }

        #region Alterar dado ja existente
        public void AlterarTextoNoArquivo(string _nomeArquivo, string _descricaoTarefa, float _horasUtilizadas, string _dataServico)
        {
            try
            {
                string[] linhasDoTexto = File.ReadAllLines(@"Horas\" + _nomeArquivo + "");
                string[] linhasDoTextoATUALIZADA = new string[linhasDoTexto.Length];
                int contadorLinhas = 0;
                foreach (string linha in linhasDoTexto)
                {
                    //0 - Contrato
                    //1 - Sigla
                    //2 - Descricao
                    //3 - Horas utilizadas
                    //4 - Data
                    //5 - NAO CRIADA
                    string[] linhaQuebradaPorTab = linha.Split('\t');
                    //_caixaDeTexto.Text += linha + "\n";
                    if (_descricaoTarefa.Equals(linhaQuebradaPorTab[2]))
                    {
                        float valorJaExistenteNoArquivo = float.Parse(linhaQuebradaPorTab[3]);
                        float valor1 = 0.0f;

                        if(valorJaExistenteNoArquivo >= 10.0f && linhaQuebradaPorTab[3].Length < 5)
                        {
                            valor1 = float.Parse(linhaQuebradaPorTab[3] + "0");
                        }
                        else
                        {
                            valor1 = float.Parse(linhaQuebradaPorTab[3]);
                        }

                        float valor2 = _horasUtilizadas;
                        float somaHoras = valor1 + valor2;
                        linhaQuebradaPorTab[3] = (somaHoras).ToString("F");//.Replace(",", ".");
                        linhaQuebradaPorTab[4] = _dataServico;

                        //return true;
                    }
                    string linhaAtualizada = linhaQuebradaPorTab.ToString();
                    linhaAtualizada = string.Join("\t", linhaQuebradaPorTab);
                    linhasDoTextoATUALIZADA[contadorLinhas] = linhaAtualizada;
                    contadorLinhas++;
                }
                File.WriteAllLines(@"Horas\" + _nomeArquivo + "", linhasDoTextoATUALIZADA);
                //return false;
            }
            catch (Exception)
            {
                // throw;
                //return false;
            }
        }
        #endregion
    }
}
