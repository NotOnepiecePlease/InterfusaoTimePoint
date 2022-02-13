using InterfusaoTimePoint.Dados;
using Syncfusion.WinForms.ListView.Enums;
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
            IdentificarNomeArquivoDiaAtual();
            busDados.PreencherCaixaDeTexto(richtxtArquivoDeNotas, nomeDoArquivo);
            busDados.BuscarDescricaAtividade(cmbDescricao, nomeDoArquivo);
            dateDataServico.Value = DateTime.Now;
            cmbDescricao.AutoCompleteSuggestMode = AutoCompleteSuggestMode.Contains;
            cmbDescricao.DropDownListView.ItemHeight = 40;
            busDados.BuscarContratos(cmbContratos);
            SelecionarIndiceComboboxContratos();
        }
        public frm_InserirHora(string _nomeDoArquivo)
        {
            InitializeComponent();
            nomeDoArquivo = _nomeDoArquivo;
            lblArquivo.Text = _nomeDoArquivo;
            busDados.PreencherCaixaDeTexto(richtxtArquivoDeNotas, _nomeDoArquivo);
            busDados.BuscarDescricaAtividade(cmbDescricao, nomeDoArquivo);
            dateDataServico.Value = DateTime.Now;
            cmbDescricao.AutoCompleteSuggestMode = AutoCompleteSuggestMode.Contains;
            cmbDescricao.DropDownListView.ItemHeight = 40;
            busDados.BuscarContratos(cmbContratos);
            SelecionarIndiceComboboxContratos();
        }

        private void SelecionarIndiceComboboxContratos()
        {
            try
            {
                cmbContratos.SelectedIndex = 0;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void IdentificarNomeArquivoDiaAtual()
        {
            string dataHoje = DateTime.Now.ToShortDateString().Replace(@"/", "-");
            nomeDoArquivo = $"Dia - {dataHoje}.txt";

            string caminhoArquivo = $"Horas\\{nomeDoArquivo}";

            lblArquivo.Text = nomeDoArquivo;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string[] inicial_HORA_MINUTO = txtHoraInicial.Text.Split(':');
            string[] final_HORA_MINUTO = txtHoraFinal.Text.Split(':');
            DateTime hInicial = new DateTime(2022, 02, 11, Convert.ToInt32(inicial_HORA_MINUTO[0]), Convert.ToInt32(inicial_HORA_MINUTO[1]), 0);
            DateTime hFinal = new DateTime(2022, 02, 11, Convert.ToInt32(final_HORA_MINUTO[0]), Convert.ToInt32(final_HORA_MINUTO[1]), 0);

            TimeSpan subtracaoDasDatas_EmMinutos = hFinal.Subtract(hInicial);

            // MessageBox.Show(subtracaoDasDatas_EmMinutos.ToString(@"hh\:mm"));
            // MessageBox.Show($"h_Inicial = {hInicial.ToString("HH:mm")}\nh_Final = {hFinal.ToString("HH:mm")}\nTime Span = {resultado_subtracao_datas.TotalMinutes}");
            //txtHoraInicial precisa receber valor no formato: 2h20m
            //string horasUtilizadas = CalcularPorcentagemHoras(txtHoraInicial.Text).Replace(",", ".");
            float horasUtilizadas = CalcularPorcentagemHoras(subtracaoDasDatas_EmMinutos.ToString(@"hh\:mm"));//.Replace(",", ".");
            //Inserir horas normais, que vai ser copiada para o doc do lider
            insDados.InserirTextoNoArquivoHoras(nomeDoArquivo, cmbContratos.SelectedItem.ToString(), txtSigla.Text, cmbDescricao.Text, horasUtilizadas, dateDataServico.Value.ToShortDateString());

            //Inserir horas detalhadas, usada pra apontar no jira depois
            insDados.InserirTextoArquivoHorasDETALHADAS(nomeDoArquivo, cmbContratos.SelectedItem.ToString(), txtSigla.Text, cmbDescricao.Text, txtHoraInicial.Text, txtHoraFinal.Text, horasUtilizadas, dateDataServico.Value.ToShortDateString());


            richtxtArquivoDeNotas.Text = "";
            busDados.PreencherCaixaDeTexto(richtxtArquivoDeNotas, nomeDoArquivo);

            busDados.BuscarDescricaAtividade(cmbDescricao, nomeDoArquivo);
        }

        private float CalcularPorcentagemHoras(string _minutosTotais)
        {
            string[] tempoTotal = PegarNumerosDaString(_minutosTotais);
            int horasEmMinutos = Convert.ToInt32(tempoTotal[0]) * 60; //tempoTotal[0] == Horas
            horasEmMinutos += Convert.ToInt32(tempoTotal[1]); //Somo com os minutos do inicio da string

            //Calculo
            float tempoGastoAtividade = ((horasEmMinutos * 100) / 60f) / 100;
            float resultado = float.Parse(tempoGastoAtividade.ToString("F"));
            return resultado;
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

            string[] resultadoFinal = new string[2] { horas, minutos };

            return resultadoFinal;
        }

        private void frm_InserirHora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtHoraInicial_Leave(object sender, EventArgs e)
        {
            if (txtHoraInicial.TextLength == 4)
            {
                char[] arr = txtHoraInicial.Text.ToCharArray();

                txtHoraInicial.Text = $"" + arr[0] + arr[1] + ":" + arr[2] + arr[3];
            }
        }

        private void txtHoraFinal_Leave(object sender, EventArgs e)
        {
            if (txtHoraFinal.TextLength == 4)
            {
                char[] arr = txtHoraFinal.Text.ToCharArray();

                txtHoraFinal.Text = $"" + arr[0] + arr[1] + ":" + arr[2] + arr[3];
            }
        }
    }
}
