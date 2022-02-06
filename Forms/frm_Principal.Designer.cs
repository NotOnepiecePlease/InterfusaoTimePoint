
namespace InterfusaoTimePoint.Forms
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.gridArquivosHoras = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Modificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.calendarCalendario = new Syncfusion.WinForms.Input.SfCalendar();
            this.formdockPanelBackground = new Bunifu.UI.WinForms.BunifuFormDock();
            this.formdockGridview = new Bunifu.UI.WinForms.BunifuFormDock();
            this.formdockCalendar = new Bunifu.UI.WinForms.BunifuFormDock();
            this.formdockPicLogo = new Bunifu.UI.WinForms.BunifuFormDock();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArquivosHoras)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.panelBackground.Controls.Add(this.bunifuVScrollBar1);
            this.panelBackground.Controls.Add(this.bunifuSeparator1);
            this.panelBackground.Controls.Add(this.bunifuButton4);
            this.panelBackground.Controls.Add(this.bunifuButton2);
            this.panelBackground.Controls.Add(this.bunifuButton1);
            this.panelBackground.Controls.Add(this.panelHeader);
            this.panelBackground.Controls.Add(this.gridArquivosHoras);
            this.panelBackground.Controls.Add(this.calendarCalendario);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1280, 720);
            this.panelBackground.TabIndex = 0;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.gridArquivosHoras;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuVScrollBar1.BorderRadius = 15;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 5;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1251, 60);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(17, 648);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 8;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuVScrollBar1.ThumbLength = 31;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // gridArquivosHoras
            // 
            this.gridArquivosHoras.AllowCustomTheming = true;
            this.gridArquivosHoras.AllowUserToDeleteRows = false;
            this.gridArquivosHoras.AllowUserToOrderColumns = true;
            this.gridArquivosHoras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.gridArquivosHoras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridArquivosHoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridArquivosHoras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridArquivosHoras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridArquivosHoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridArquivosHoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridArquivosHoras.ColumnHeadersHeight = 40;
            this.gridArquivosHoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Data_Criacao,
            this.Data_Modificacao});
            this.gridArquivosHoras.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridArquivosHoras.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.gridArquivosHoras.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridArquivosHoras.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridArquivosHoras.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gridArquivosHoras.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.gridArquivosHoras.CurrentTheme.Name = null;
            this.gridArquivosHoras.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridArquivosHoras.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridArquivosHoras.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridArquivosHoras.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridArquivosHoras.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridArquivosHoras.EnableHeadersVisualStyles = false;
            this.gridArquivosHoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.HeaderBgColor = System.Drawing.Color.Empty;
            this.gridArquivosHoras.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.gridArquivosHoras.Location = new System.Drawing.Point(455, 71);
            this.gridArquivosHoras.MultiSelect = false;
            this.gridArquivosHoras.Name = "gridArquivosHoras";
            this.gridArquivosHoras.ReadOnly = true;
            this.gridArquivosHoras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(39)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridArquivosHoras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridArquivosHoras.RowHeadersVisible = false;
            this.gridArquivosHoras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(39)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridArquivosHoras.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridArquivosHoras.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.gridArquivosHoras.RowTemplate.Height = 40;
            this.gridArquivosHoras.RowTemplate.ReadOnly = true;
            this.gridArquivosHoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArquivosHoras.Size = new System.Drawing.Size(785, 637);
            this.gridArquivosHoras.TabIndex = 1;
            this.gridArquivosHoras.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Data_Criacao
            // 
            this.Data_Criacao.HeaderText = "Data de Criação";
            this.Data_Criacao.Name = "Data_Criacao";
            this.Data_Criacao.ReadOnly = true;
            // 
            // Data_Modificacao
            // 
            this.Data_Modificacao.HeaderText = "Data de Modificação";
            this.Data_Modificacao.Name = "Data_Modificacao";
            this.Data_Modificacao.ReadOnly = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(426, 60);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(14, 660);
            this.bunifuSeparator1.TabIndex = 7;
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.AllowToggling = false;
            this.bunifuButton4.AnimationSpeed = 200;
            this.bunifuButton4.AutoGenerateColors = false;
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.ButtonText = "Semana Atual";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.ColorContrastOnClick = 45;
            this.bunifuButton4.ColorContrastOnHover = 45;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges1;
            this.bunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton4.IconMarginLeft = 11;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton4.IdleBorderRadius = 10;
            this.bunifuButton4.IdleBorderThickness = 10;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.IndicateFocus = false;
            this.bunifuButton4.Location = new System.Drawing.Point(12, 524);
            this.bunifuButton4.Name = "bunifuButton4";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(42)))));
            stateProperties1.BorderRadius = 10;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 10;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(42)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton4.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            stateProperties2.BorderRadius = 10;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 10;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton4.OnPressedState = stateProperties2;
            this.bunifuButton4.Size = new System.Drawing.Size(398, 45);
            this.bunifuButton4.TabIndex = 6;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Horarios Pendentes";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges2;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton2.IdleBorderRadius = 10;
            this.bunifuButton2.IdleBorderThickness = 10;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(12, 479);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(42)))));
            stateProperties3.BorderRadius = 10;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 10;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(42)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            stateProperties4.BorderRadius = 10;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 10;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.bunifuButton2.OnPressedState = stateProperties4;
            this.bunifuButton2.Size = new System.Drawing.Size(398, 45);
            this.bunifuButton2.TabIndex = 4;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Todos";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges3;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton1.IdleBorderRadius = 10;
            this.bunifuButton1.IdleBorderThickness = 10;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(12, 434);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(42)))));
            stateProperties5.BorderRadius = 10;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 10;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(42)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            stateProperties6.BorderRadius = 10;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 10;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties6;
            this.bunifuButton1.Size = new System.Drawing.Size(398, 45);
            this.bunifuButton1.TabIndex = 3;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.bunifuSeparator2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1280, 65);
            this.panelHeader.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::InterfusaoTimePoint.Properties.Resources.Logo_FULL;
            this.picLogo.Location = new System.Drawing.Point(463, -3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(354, 59);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 51);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(1280, 14);
            this.bunifuSeparator2.TabIndex = 8;
            // 
            // calendarCalendario
            // 
            this.calendarCalendario.Location = new System.Drawing.Point(3, 71);
            this.calendarCalendario.MinimumSize = new System.Drawing.Size(196, 196);
            this.calendarCalendario.Name = "calendarCalendario";
            this.calendarCalendario.Size = new System.Drawing.Size(427, 332);
            this.calendarCalendario.Style.BorderColor = System.Drawing.Color.Transparent;
            this.calendarCalendario.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.White;
            this.calendarCalendario.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.calendarCalendario.Style.Cell.CellForeColor = System.Drawing.Color.White;
            this.calendarCalendario.Style.Cell.SelectedCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.calendarCalendario.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.calendarCalendario.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            this.calendarCalendario.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.calendarCalendario.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.calendarCalendario.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.calendarCalendario.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.calendarCalendario.Style.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.calendarCalendario.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.calendarCalendario.Style.Header.DayNamesFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarCalendario.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.calendarCalendario.Style.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.calendarCalendario.Style.Header.NavigationButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.calendarCalendario.TabIndex = 0;
            this.calendarCalendario.Text = "sfCalendar1";
            // 
            // formdockPanelBackground
            // 
            this.formdockPanelBackground.AllowFormDragging = false;
            this.formdockPanelBackground.AllowFormDropShadow = true;
            this.formdockPanelBackground.AllowFormResizing = false;
            this.formdockPanelBackground.AllowHidingBottomRegion = true;
            this.formdockPanelBackground.AllowOpacityChangesWhileDragging = true;
            this.formdockPanelBackground.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPanelBackground.BorderOptions.BottomBorder.BorderThickness = 1;
            this.formdockPanelBackground.BorderOptions.BottomBorder.ShowBorder = true;
            this.formdockPanelBackground.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPanelBackground.BorderOptions.LeftBorder.BorderThickness = 1;
            this.formdockPanelBackground.BorderOptions.LeftBorder.ShowBorder = true;
            this.formdockPanelBackground.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPanelBackground.BorderOptions.RightBorder.BorderThickness = 1;
            this.formdockPanelBackground.BorderOptions.RightBorder.ShowBorder = true;
            this.formdockPanelBackground.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPanelBackground.BorderOptions.TopBorder.BorderThickness = 1;
            this.formdockPanelBackground.BorderOptions.TopBorder.ShowBorder = true;
            this.formdockPanelBackground.ContainerControl = this;
            this.formdockPanelBackground.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.formdockPanelBackground.DockingIndicatorsOpacity = 0.3D;
            this.formdockPanelBackground.DockingOptions.DockAll = true;
            this.formdockPanelBackground.DockingOptions.DockBottomLeft = true;
            this.formdockPanelBackground.DockingOptions.DockBottomRight = true;
            this.formdockPanelBackground.DockingOptions.DockFullScreen = true;
            this.formdockPanelBackground.DockingOptions.DockLeft = true;
            this.formdockPanelBackground.DockingOptions.DockRight = true;
            this.formdockPanelBackground.DockingOptions.DockTopLeft = true;
            this.formdockPanelBackground.DockingOptions.DockTopRight = true;
            this.formdockPanelBackground.FormDraggingOpacity = 0.3D;
            this.formdockPanelBackground.ParentForm = this;
            this.formdockPanelBackground.ShowCursorChanges = true;
            this.formdockPanelBackground.ShowDockingIndicators = true;
            this.formdockPanelBackground.TitleBarOptions.AllowFormDragging = true;
            this.formdockPanelBackground.TitleBarOptions.BunifuFormDock = this.formdockPanelBackground;
            this.formdockPanelBackground.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.formdockPanelBackground.TitleBarOptions.TitleBarControl = this.panelBackground;
            this.formdockPanelBackground.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // formdockGridview
            // 
            this.formdockGridview.AllowFormDragging = false;
            this.formdockGridview.AllowFormDropShadow = true;
            this.formdockGridview.AllowFormResizing = false;
            this.formdockGridview.AllowHidingBottomRegion = true;
            this.formdockGridview.AllowOpacityChangesWhileDragging = false;
            this.formdockGridview.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockGridview.BorderOptions.BottomBorder.BorderThickness = 1;
            this.formdockGridview.BorderOptions.BottomBorder.ShowBorder = true;
            this.formdockGridview.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockGridview.BorderOptions.LeftBorder.BorderThickness = 1;
            this.formdockGridview.BorderOptions.LeftBorder.ShowBorder = true;
            this.formdockGridview.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockGridview.BorderOptions.RightBorder.BorderThickness = 1;
            this.formdockGridview.BorderOptions.RightBorder.ShowBorder = true;
            this.formdockGridview.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockGridview.BorderOptions.TopBorder.BorderThickness = 1;
            this.formdockGridview.BorderOptions.TopBorder.ShowBorder = true;
            this.formdockGridview.ContainerControl = this;
            this.formdockGridview.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.formdockGridview.DockingIndicatorsOpacity = 0.5D;
            this.formdockGridview.DockingOptions.DockAll = true;
            this.formdockGridview.DockingOptions.DockBottomLeft = true;
            this.formdockGridview.DockingOptions.DockBottomRight = true;
            this.formdockGridview.DockingOptions.DockFullScreen = true;
            this.formdockGridview.DockingOptions.DockLeft = true;
            this.formdockGridview.DockingOptions.DockRight = true;
            this.formdockGridview.DockingOptions.DockTopLeft = true;
            this.formdockGridview.DockingOptions.DockTopRight = true;
            this.formdockGridview.FormDraggingOpacity = 0.5D;
            this.formdockGridview.ParentForm = this;
            this.formdockGridview.ShowCursorChanges = true;
            this.formdockGridview.ShowDockingIndicators = true;
            this.formdockGridview.TitleBarOptions.AllowFormDragging = false;
            this.formdockGridview.TitleBarOptions.BunifuFormDock = this.formdockGridview;
            this.formdockGridview.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.formdockGridview.TitleBarOptions.TitleBarControl = this.gridArquivosHoras;
            this.formdockGridview.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // formdockCalendar
            // 
            this.formdockCalendar.AllowFormDragging = true;
            this.formdockCalendar.AllowFormDropShadow = true;
            this.formdockCalendar.AllowFormResizing = false;
            this.formdockCalendar.AllowHidingBottomRegion = true;
            this.formdockCalendar.AllowOpacityChangesWhileDragging = false;
            this.formdockCalendar.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockCalendar.BorderOptions.BottomBorder.BorderThickness = 1;
            this.formdockCalendar.BorderOptions.BottomBorder.ShowBorder = true;
            this.formdockCalendar.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockCalendar.BorderOptions.LeftBorder.BorderThickness = 1;
            this.formdockCalendar.BorderOptions.LeftBorder.ShowBorder = true;
            this.formdockCalendar.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockCalendar.BorderOptions.RightBorder.BorderThickness = 1;
            this.formdockCalendar.BorderOptions.RightBorder.ShowBorder = true;
            this.formdockCalendar.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockCalendar.BorderOptions.TopBorder.BorderThickness = 1;
            this.formdockCalendar.BorderOptions.TopBorder.ShowBorder = true;
            this.formdockCalendar.ContainerControl = this;
            this.formdockCalendar.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.formdockCalendar.DockingIndicatorsOpacity = 0.5D;
            this.formdockCalendar.DockingOptions.DockAll = true;
            this.formdockCalendar.DockingOptions.DockBottomLeft = true;
            this.formdockCalendar.DockingOptions.DockBottomRight = true;
            this.formdockCalendar.DockingOptions.DockFullScreen = true;
            this.formdockCalendar.DockingOptions.DockLeft = true;
            this.formdockCalendar.DockingOptions.DockRight = true;
            this.formdockCalendar.DockingOptions.DockTopLeft = true;
            this.formdockCalendar.DockingOptions.DockTopRight = true;
            this.formdockCalendar.FormDraggingOpacity = 0.5D;
            this.formdockCalendar.ParentForm = this;
            this.formdockCalendar.ShowCursorChanges = true;
            this.formdockCalendar.ShowDockingIndicators = true;
            this.formdockCalendar.TitleBarOptions.AllowFormDragging = true;
            this.formdockCalendar.TitleBarOptions.BunifuFormDock = this.formdockCalendar;
            this.formdockCalendar.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.formdockCalendar.TitleBarOptions.TitleBarControl = this.calendarCalendario;
            this.formdockCalendar.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // formdockPicLogo
            // 
            this.formdockPicLogo.AllowFormDragging = false;
            this.formdockPicLogo.AllowFormDropShadow = true;
            this.formdockPicLogo.AllowFormResizing = false;
            this.formdockPicLogo.AllowHidingBottomRegion = true;
            this.formdockPicLogo.AllowOpacityChangesWhileDragging = true;
            this.formdockPicLogo.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPicLogo.BorderOptions.BottomBorder.BorderThickness = 1;
            this.formdockPicLogo.BorderOptions.BottomBorder.ShowBorder = true;
            this.formdockPicLogo.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPicLogo.BorderOptions.LeftBorder.BorderThickness = 1;
            this.formdockPicLogo.BorderOptions.LeftBorder.ShowBorder = true;
            this.formdockPicLogo.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPicLogo.BorderOptions.RightBorder.BorderThickness = 1;
            this.formdockPicLogo.BorderOptions.RightBorder.ShowBorder = true;
            this.formdockPicLogo.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.formdockPicLogo.BorderOptions.TopBorder.BorderThickness = 1;
            this.formdockPicLogo.BorderOptions.TopBorder.ShowBorder = true;
            this.formdockPicLogo.ContainerControl = this;
            this.formdockPicLogo.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.formdockPicLogo.DockingIndicatorsOpacity = 0.3D;
            this.formdockPicLogo.DockingOptions.DockAll = true;
            this.formdockPicLogo.DockingOptions.DockBottomLeft = true;
            this.formdockPicLogo.DockingOptions.DockBottomRight = true;
            this.formdockPicLogo.DockingOptions.DockFullScreen = true;
            this.formdockPicLogo.DockingOptions.DockLeft = true;
            this.formdockPicLogo.DockingOptions.DockRight = true;
            this.formdockPicLogo.DockingOptions.DockTopLeft = true;
            this.formdockPicLogo.DockingOptions.DockTopRight = true;
            this.formdockPicLogo.FormDraggingOpacity = 0.3D;
            this.formdockPicLogo.ParentForm = this;
            this.formdockPicLogo.ShowCursorChanges = true;
            this.formdockPicLogo.ShowDockingIndicators = true;
            this.formdockPicLogo.TitleBarOptions.AllowFormDragging = true;
            this.formdockPicLogo.TitleBarOptions.BunifuFormDock = this.formdockPicLogo;
            this.formdockPicLogo.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.formdockPicLogo.TitleBarOptions.TitleBarControl = this.picLogo;
            this.formdockPicLogo.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfusao TimePoint";
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArquivosHoras)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private Syncfusion.WinForms.Input.SfCalendar calendarCalendario;
        private Bunifu.UI.WinForms.BunifuFormDock formdockPanelBackground;
        private Bunifu.UI.WinForms.BunifuDataGridView gridArquivosHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Modificacao;
        private Bunifu.UI.WinForms.BunifuFormDock formdockGridview;
        private Bunifu.UI.WinForms.BunifuFormDock formdockCalendar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private Bunifu.UI.WinForms.BunifuFormDock formdockPicLogo;
    }
}