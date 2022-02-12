using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfusaoTimePoint.Forms
{
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            progressLoading.Value += 20;
            Thread.Sleep(1000);

            if(progressLoading.Value == 100)
            {
                frm_Principal formPrincipal = new frm_Principal();
                formPrincipal.Show();
                this.Hide();
                timerLoading.Stop();
            }
        }
    }
}
