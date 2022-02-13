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
            this.BackColor = Color.FromArgb( 9, 12, 9 );
            //this.BackColor = Color.White;
            this.TransparencyKey = BackColor;
            progressbar.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressbar.Value < 99)
            {
                progressbar.Value += 50;
                Thread.Sleep(200);
            }
            else
            {
                timer1.Stop();
                frm_Principal formPrincipal = new frm_Principal();
                formPrincipal.Show();
                this.Hide();
            }
        }
    }
}
