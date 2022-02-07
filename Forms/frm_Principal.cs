using InterfusaoTimePoint.Dados;
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
        public frm_Principal()
        {
            InitializeComponent();
            //PopularGridFake();
            VerificarExistenciaPasta();
            bd.PopularGrid(dataArquivosDasHoras);
        }

        private void VerificarExistenciaPasta()
        {
            string caminhoPasta = @"Horas";
            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
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

        private void bunifuButton1_Click(object sender, EventArgs e)
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
            bd.PopularGridPorDatas(calendarCalendario.SelectedDate.Value, dataArquivosDasHoras);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            bd.PopularGrid(dataArquivosDasHoras);
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetIso8601WeekOfYear(new DateTime(2022, 01, 13)).ToString());
            calendarCalendario.SelectedDate = DateTime.Now;
            calendarCalendario.Refresh();
        }
    }
}
