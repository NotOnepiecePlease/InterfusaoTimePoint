
namespace InterfusaoTimePoint.Forms
{
    partial class frm_Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loading));
            this.dragArrastarForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelBackground = new System.Windows.Forms.Panel();
            this.progressLoading = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dragArrastarForm
            // 
            this.dragArrastarForm.Fixed = true;
            this.dragArrastarForm.Horizontal = true;
            this.dragArrastarForm.TargetControl = this.panelBackground;
            this.dragArrastarForm.Vertical = true;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBackground.BackgroundImage = global::InterfusaoTimePoint.Properties.Resources.Background_Loading_UPDATE;
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Controls.Add(this.progressLoading);
            this.panelBackground.Controls.Add(this.picLogo);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(505, 407);
            this.panelBackground.TabIndex = 0;
            // 
            // progressLoading
            // 
            this.progressLoading.Animation = 0;
            this.progressLoading.AnimationStep = 10;
            this.progressLoading.BackColor = System.Drawing.Color.Transparent;
            this.progressLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressLoading.BackgroundImage")));
            this.progressLoading.BorderColor = System.Drawing.Color.Transparent;
            this.progressLoading.BorderRadius = 5;
            this.progressLoading.BorderThickness = 2;
            this.progressLoading.Location = new System.Drawing.Point(35, 269);
            this.progressLoading.MaximumValue = 100;
            this.progressLoading.MinimumValue = 0;
            this.progressLoading.Name = "progressLoading";
            this.progressLoading.ProgressBackColor = System.Drawing.Color.Transparent;
            this.progressLoading.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.progressLoading.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.progressLoading.Size = new System.Drawing.Size(434, 28);
            this.progressLoading.TabIndex = 2;
            this.progressLoading.Value = 50;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::InterfusaoTimePoint.Properties.Resources.Logo_UPDATE;
            this.picLogo.Location = new System.Drawing.Point(190, 37);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(117, 131);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // frm_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 407);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Loading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl dragArrastarForm;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.PictureBox picLogo;
        private Bunifu.UI.Winforms.BunifuProgressBar progressLoading;
        private System.Windows.Forms.Timer timerLoading;
    }
}