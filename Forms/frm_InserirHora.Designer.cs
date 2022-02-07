
namespace InterfusaoTimePoint.Forms
{
    partial class frm_InserirHora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InserirHora));
            this.cmbContratos = new System.Windows.Forms.ComboBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDescricaoAtividade = new System.Windows.Forms.TextBox();
            this.txtHorasUtilizadas = new System.Windows.Forms.TextBox();
            this.dateDataServico = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbContratos
            // 
            this.cmbContratos.FormattingEnabled = true;
            this.cmbContratos.Items.AddRange(new object[] {
            "ITF-SUP-CONTRATOS2022",
            "ITF-SUP-CONTRATOS2022",
            "ITF-SUP-CONTRATOS2022",
            "ITF-SUP-CONTRATOS2022"});
            this.cmbContratos.Location = new System.Drawing.Point(12, 43);
            this.cmbContratos.Name = "cmbContratos";
            this.cmbContratos.Size = new System.Drawing.Size(138, 21);
            this.cmbContratos.TabIndex = 0;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(156, 43);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(52, 20);
            this.txtSigla.TabIndex = 1;
            this.txtSigla.Text = "AFA";
            this.txtSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricaoAtividade
            // 
            this.txtDescricaoAtividade.Location = new System.Drawing.Point(228, 44);
            this.txtDescricaoAtividade.Name = "txtDescricaoAtividade";
            this.txtDescricaoAtividade.Size = new System.Drawing.Size(252, 20);
            this.txtDescricaoAtividade.TabIndex = 2;
            this.txtDescricaoAtividade.Text = "AFA - Teste unitario na funcao";
            this.txtDescricaoAtividade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHorasUtilizadas
            // 
            this.txtHorasUtilizadas.Location = new System.Drawing.Point(486, 44);
            this.txtHorasUtilizadas.Name = "txtHorasUtilizadas";
            this.txtHorasUtilizadas.Size = new System.Drawing.Size(52, 20);
            this.txtHorasUtilizadas.TabIndex = 3;
            this.txtHorasUtilizadas.Text = "1:45";
            this.txtHorasUtilizadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateDataServico
            // 
            this.dateDataServico.BorderRadius = 1;
            this.dateDataServico.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dateDataServico.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateDataServico.DisabledColor = System.Drawing.Color.Gray;
            this.dateDataServico.DisplayWeekNumbers = false;
            this.dateDataServico.DPHeight = 0;
            this.dateDataServico.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateDataServico.FillDatePicker = false;
            this.dateDataServico.ForeColor = System.Drawing.Color.Purple;
            this.dateDataServico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataServico.Icon = ((System.Drawing.Image)(resources.GetObject("dateDataServico.Icon")));
            this.dateDataServico.IconColor = System.Drawing.Color.Purple;
            this.dateDataServico.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateDataServico.Location = new System.Drawing.Point(554, 35);
            this.dateDataServico.MinimumSize = new System.Drawing.Size(217, 32);
            this.dateDataServico.Name = "dateDataServico";
            this.dateDataServico.Size = new System.Drawing.Size(217, 32);
            this.dateDataServico.TabIndex = 4;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(696, 73);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "button1";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frm_InserirHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 138);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dateDataServico);
            this.Controls.Add(this.txtHorasUtilizadas);
            this.Controls.Add(this.txtDescricaoAtividade);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.cmbContratos);
            this.Name = "frm_InserirHora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_InserirHora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbContratos;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtDescricaoAtividade;
        private System.Windows.Forms.TextBox txtHorasUtilizadas;
        private Bunifu.UI.WinForms.BunifuDatePicker dateDataServico;
        private System.Windows.Forms.Button btnInserir;
    }
}