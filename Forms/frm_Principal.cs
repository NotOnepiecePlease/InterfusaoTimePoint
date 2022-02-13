using InterfusaoTimePoint.Dados;
using Syncfusion.WinForms.Input.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfusaoTimePoint.Forms
{
    public partial class frm_Principal : Form
    {
        BuscarDados bd = new BuscarDados();
        const string caminhoContratos = @"Contratos_e_sigla";
        const string caminhoHoras = @"Horas";
        const string caminhoHorasJira = @"Horas\\HorasDetalhadas";
        public frm_Principal()
        {
            InitializeComponent();
            //PopularGridFake();
            VerificarExistenciaPasta();
            bd.PopularGrid(dataArquivosDasHoras);
            calendarCalendario.HighlightTodayCell = true;
            //calendarCalendario.SelectedDate = DateTime.Now;
        }

        private void VerificarExistenciaPasta()
        {
            string caminhoPastaPrincipal = caminhoHoras;
            if (!Directory.Exists(caminhoPastaPrincipal))
            {
                Directory.CreateDirectory(caminhoPastaPrincipal);
            }

            string caminhoPastaContratos = caminhoContratos;
            if (!Directory.Exists(caminhoPastaContratos))
            {
                Directory.CreateDirectory(caminhoPastaContratos);
            }

            string caminhoPastaHorasDetalhadas = caminhoHorasJira;
            if (!Directory.Exists(caminhoPastaHorasDetalhadas))
            {
                Directory.CreateDirectory(caminhoPastaHorasDetalhadas);
            }
        }

        private void PopularGridFake()
        {
            for (int i = 0; i < 15; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataArquivosDasHoras.Rows[i].Clone();
                row.Cells[0].Value = $"Arquivo_Texto{i}.txt";
                row.Cells[1].Value = (i < 10) ? $"0{i}/02/2022" : $"{i}/02/2022";
                row.Cells[2].Value = "06/02/2022";
                dataArquivosDasHoras.Rows.Add(row);
            }
        }

        private void btnSemanaAtual_Click(object sender, EventArgs e)
        {
            frm_InserirHora formInserirHora = new frm_InserirHora();
            formInserirHora.ShowDialog();
            bd.PopularGrid(dataArquivosDasHoras);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //gridArquivosHoras.DataSource = null;
            Application.Exit();
        }

        private void dataArquivosDasHoras_DoubleClick(object sender, EventArgs e)
        {
            frm_InserirHora formInserir = new frm_InserirHora(dataArquivosDasHoras.CurrentRow.Cells[0].Value.ToString());
            formInserir.ShowDialog();
            bd.PopularGrid(dataArquivosDasHoras);
        }

        private void calendarCalendario_SelectionChanged(Syncfusion.WinForms.Input.SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs e)
        {
            //MessageBox.Show(calendarCalendario.SelectedDate.ToString());
            try
            {
                bd.PopularGridPorDatas(calendarCalendario.SelectedDate.Value, dataArquivosDasHoras);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            calendarCalendario.SelectedDate = null;
            bd.PopularGrid(dataArquivosDasHoras);
        }

        private void btnArquivosDaSemana_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetIso8601WeekOfYear(new DateTime(2022, 01, 13)).ToString());
            bd.PopularGridPorArquivosDaSemana(calendarCalendario.SelectedDate.Value, dataArquivosDasHoras);
            //calendarCalendario.SelectedDate = DateTime.Now;
            calendarCalendario.Refresh();
        }

        private void frm_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void btnEditarContratos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @""+caminhoContratos+"\\Contratos.txt";

            if (File.Exists(startInfo.FileName) == false)
            {
                File.AppendAllText(startInfo.FileName, "EXEMPLO1\n");
                File.AppendAllText(startInfo.FileName, "EXEMPLO2\n");
                File.AppendAllText(startInfo.FileName, "EXEMPLO3\n");
                System.Diagnostics.Process.Start(startInfo);
            }
            else
            {
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void btnEditarSigla_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"" + caminhoContratos + "\\Sigla.txt";

            if (File.Exists(startInfo.FileName) == false)
            {
                File.AppendAllText(startInfo.FileName, "AFA");
                System.Diagnostics.Process.Start(startInfo);
            }
            else
            {
                System.Diagnostics.Process.Start(startInfo);
            }
        }
    }
}
