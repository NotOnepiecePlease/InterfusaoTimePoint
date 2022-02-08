using InterfusaoTimePoint.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfusaoTimePoint.Forms
{
    public partial class frm_InserirHora : Form
    {
        public string nomeDoArquivo { get; set; }
        InserirDados insDados = new InserirDados();
        BuscarDados busDados = new BuscarDados();
        public frm_InserirHora()
        {
            InitializeComponent();
            cmbContratos.SelectedIndex = 0;
            IdentificarNomeArquivoDiaAtual();
            busDados.BuscarDescricaAtividade(cmbDescricao, nomeDoArquivo);
        }
        public frm_InserirHora(string _nomeDoArquivo)
        {
            InitializeComponent();
            nomeDoArquivo = _nomeDoArquivo;
            cmbContratos.SelectedIndex = 0;
            lblArquivo.Text = _nomeDoArquivo;
            busDados.PreencherCaixaDeTexto(richtxtArquivoDeNotas, _nomeDoArquivo);
            busDados.BuscarDescricaAtividade(cmbDescricao, nomeDoArquivo);
        }

        private void IdentificarNomeArquivoDiaAtual()
        {
            string dataHoje = DateTime.Now.ToShortDateString().Replace(@"/", "-");
            nomeDoArquivo = $"Dia - {dataHoje}.txt";
            lblArquivo.Text = nomeDoArquivo;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string horasUtilizadas = CalcularPorcentagemHoras(txtHorasUtilizadas.Text).Replace(",", ".");
            insDados.InserirTextoNoArquivo(nomeDoArquivo, cmbContratos.SelectedItem.ToString(), txtSigla.Text, txtDescricaoAtividade.Text, horasUtilizadas, dateDataServico.Value.ToShortDateString());
            richtxtArquivoDeNotas.Text = "";
            busDados.PreencherCaixaDeTexto(richtxtArquivoDeNotas, nomeDoArquivo);

            busDados.BuscarDescricaAtividade(cmbDescricao, nomeDoArquivo);
        }

        private string CalcularPorcentagemHoras(string _horasString)
        {
            string[] tempoTotal = PegarNumerosDaString(_horasString);
            int horasEmMinutos = Convert.ToInt32(tempoTotal[0]) * 60; //tempoTotal[0] == Horas
            horasEmMinutos += Convert.ToInt32(tempoTotal[1]);

            //Calculo
            float tempoGastoAtividade = ((horasEmMinutos * 100) / 60f)/100;

            return tempoGastoAtividade.ToString("F");
        }

        private string[] PegarNumerosDaString(string _horasString)
        {
            char[] arrayCaracteres;
            string horas = "";
            string minutos = "";
            int loop = 1;
            arrayCaracteres = _horasString.ToCharArray(0, _horasString.Length);

            foreach (char caractere in arrayCaracteres)
            {
                string caractereString = caractere.ToString();
                if (caractereString.All(char.IsDigit) && loop == 1)
                {
                    horas += caractereString;
                }
                else
                {
                    loop = 2;
                    if (caractereString.All(char.IsDigit) && loop == 2)
                    {
                        minutos += caractereString;
                    }
                }
            }

            string[] resultadoFinal = new string[2] {horas, minutos };
            
            return resultadoFinal;
        }
    }
}
