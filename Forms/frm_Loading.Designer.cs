
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.progressbar = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressbar);
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 140);
            this.panel1.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::InterfusaoTimePoint.Properties.Resources.Logo_FULL;
            this.pictureLogo.Location = new System.Drawing.Point(80, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(247, 74);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 17;
            this.pictureLogo.TabStop = false;
            // 
            // progressbar
            // 
            this.progressbar.Animation = 0;
            this.progressbar.AnimationStep = 10;
            this.progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbar.BackgroundImage")));
            this.progressbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.progressbar.BorderRadius = 5;
            this.progressbar.BorderThickness = 2;
            this.progressbar.Location = new System.Drawing.Point(40, 83);
            this.progressbar.MaximumValue = 100;
            this.progressbar.MinimumValue = 0;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.progressbar.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.progressbar.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.progressbar.Size = new System.Drawing.Size(326, 20);
            this.progressbar.TabIndex = 18;
            this.progressbar.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(117, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Abrindo o TimePoint...";
            // 
            // frm_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 140);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private Bunifu.UI.Winforms.BunifuProgressBar progressbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}