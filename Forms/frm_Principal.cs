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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            //PopularGridFake();
            PopularGrid();
        }

        private void PopularGridFake()
        {

            for (int i = 0; i <15; i++)
            {
                DataGridViewRow row = (DataGridViewRow)gridArquivosHoras.Rows[i].Clone();
                row.Cells[0].Value = $"Arquivo_Texto{i}.txt";
                row.Cells[1].Value = (i <10) ? $"0{i}/02/2022" : $"{i}/02/2022";
                row.Cells[2].Value = "06/02/2022";
                gridArquivosHoras.Rows.Add(row);
            }
        }

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
        private void PopularGrid()
        {
            List<colunasDaLista> listaDeArquivos = new List<colunasDaLista>();
            //List<KeyValuePair<string, string>> listaDeArquivos = new List<KeyValuePair<string, string>>();
            //Dictionary<string, string> listaDeArquivos = new Dictionary<string, string>();
            // _items.Add(new KeyValuePair<string, string>(foo, bar));
            DirectoryInfo dinfo = new DirectoryInfo(@"Horas");
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                listaDeArquivos.Add(new colunasDaLista(file.Name, file.CreationTime.ToString(), file.LastWriteTime.ToString()));
            }

            for (int i = 0; i < listaDeArquivos.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)gridArquivosHoras.Rows[i].Clone();
                row.Cells[0].Value = $"{listaDeArquivos[i].nome}";
                row.Cells[1].Value = $"{listaDeArquivos[i].data_criacao}";
                row.Cells[2].Value = $"{listaDeArquivos[i].data_modificacao}";
                gridArquivosHoras.Rows.Add(row);
            }
        }
    }
}
