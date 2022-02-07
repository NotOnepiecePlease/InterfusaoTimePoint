using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfusaoTimePoint.Dados
{
    class BuscarDados
    {
        struct colunasDaLista
        {
            public string nome;
            public string data_criacao;
            public string data_modificacao;

            public colunasDaLista(string _nome, string _data, string _dataModificacao) : this()
            {
                nome = _nome;
                data_criacao = _data;
                data_modificacao = _dataModificacao;
            }
        }

        public static int PegarNumeroDaSemana(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public void PopularGrid(BunifuDataGridView _dataArquivosDasHoras)
        {
            try
            {
                BindingSource bindingSource1 = new BindingSource();
                DataTable dt = new DataTable();
                dt.Columns.Add("Nome");
                dt.Columns.Add("Data de Criação");
                dt.Columns.Add("Data de Modificação");


                BindingList<colunasDaLista> listaDeArquivos = new BindingList<colunasDaLista>();
                DirectoryInfo dinfo = new DirectoryInfo(@"Horas");
                FileInfo[] Files = dinfo.GetFiles("*.txt");
                foreach (FileInfo file in Files)
                {
                    listaDeArquivos.Add(new colunasDaLista(file.Name, file.CreationTime.ToString(), file.LastWriteTime.ToString()));
                }

                foreach (var arquivo in listaDeArquivos)
                {
                    dt.Rows.Add(arquivo.nome, arquivo.data_criacao, arquivo.data_modificacao);
                }

                bindingSource1.DataSource = dt;
                _dataArquivosDasHoras.DataSource = bindingSource1;
                _dataArquivosDasHoras.Sort(_dataArquivosDasHoras.Columns["Nome"], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void PopularGridPorDatas(DateTime _data, BunifuDataGridView _dataArquivosDasHoras)
        {
            try
            {
                BindingSource bindingSource1 = new BindingSource();
                DataTable dt = new DataTable();
                dt.Columns.Add("Nome");
                dt.Columns.Add("Data de Criação");
                dt.Columns.Add("Data de Modificação");


                BindingList<colunasDaLista> listaDeArquivos = new BindingList<colunasDaLista>();
                DirectoryInfo dinfo = new DirectoryInfo(@"Horas");
                FileInfo[] Files = dinfo.GetFiles("*.txt");
                foreach (FileInfo file in Files)
                {
                    if (PegarNumeroDaSemana(file.CreationTime).Equals(PegarNumeroDaSemana(_data)))
                        listaDeArquivos.Add(new colunasDaLista(file.Name, file.CreationTime.ToString(), file.LastWriteTime.ToString()));

                    //if (file.CreationTime.ToShortDateString().Equals(_data))
                    //    listaDeArquivos.Add(new colunasDaLista(file.Name, file.CreationTime.ToString(), file.LastWriteTime.ToString()));
                }

                foreach (var arquivo in listaDeArquivos)
                {
                    dt.Rows.Add(arquivo.nome, arquivo.data_criacao, arquivo.data_modificacao);
                }

                bindingSource1.DataSource = dt;
                _dataArquivosDasHoras.DataSource = bindingSource1;
                _dataArquivosDasHoras.Sort(_dataArquivosDasHoras.Columns["Nome"], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
