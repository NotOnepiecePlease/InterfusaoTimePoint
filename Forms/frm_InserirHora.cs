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
        public frm_InserirHora()
        {
            InitializeComponent();
            cmbContratos.SelectedIndex = 0;
            IdentificarNomeArquivoDiaAtual();
        }
        public frm_InserirHora(string _nomeDoArquivo)
        {
            InitializeComponent();
            nomeDoArquivo = _nomeDoArquivo;
            cmbContratos.SelectedIndex = 0;
            this.Text = _nomeDoArquivo;
        }

        private void IdentificarNomeArquivoDiaAtual()
        {
            string dataHoje = DateTime.Now.ToShortDateString().Replace(@"/", "-");
            nomeDoArquivo = $"Dia - {dataHoje}.txt";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            insDados.InserirTextoNoArquivo(nomeDoArquivo, cmbContratos.SelectedItem.ToString(),txtSigla.Text,txtDescricaoAtividade.Text,txtHorasUtilizadas.Text,dateDataServico.Value.ToShortDateString());
        }
    }
}
