
namespace PlanSicht
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pSide = new System.Windows.Forms.Panel();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.bOpen = new System.Windows.Forms.Button();
            this.bResetZoom = new System.Windows.Forms.Button();
            this.bResetPos = new System.Windows.Forms.Button();
            this.pSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSide
            // 
            this.pSide.Controls.Add(this.tbStatus);
            this.pSide.Controls.Add(this.bResetPos);
            this.pSide.Controls.Add(this.bResetZoom);
            this.pSide.Controls.Add(this.bOpen);
            this.pSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pSide.Location = new System.Drawing.Point(807, 0);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(200, 642);
            this.pSide.TabIndex = 0;
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.Location = new System.Drawing.Point(3, 479);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(194, 160);
            this.tbStatus.TabIndex = 1;
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(3, 3);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bResetZoom
            // 
            this.bResetZoom.Location = new System.Drawing.Point(3, 32);
            this.bResetZoom.Name = "bResetZoom";
            this.bResetZoom.Size = new System.Drawing.Size(75, 23);
            this.bResetZoom.TabIndex = 0;
            this.bResetZoom.Text = "Reset Zoom";
            this.bResetZoom.UseVisualStyleBackColor = true;
            this.bResetZoom.Click += new System.EventHandler(this.bResetZoom_Click);
            // 
            // bResetPos
            // 
            this.bResetPos.Location = new System.Drawing.Point(3, 61);
            this.bResetPos.Name = "bResetPos";
            this.bResetPos.Size = new System.Drawing.Size(75, 23);
            this.bResetPos.TabIndex = 0;
            this.bResetPos.Text = "Reset Pos";
            this.bResetPos.UseVisualStyleBackColor = true;
            this.bResetPos.Click += new System.EventHandler(this.bResetPos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 642);
            this.Controls.Add(this.pSide);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "PlanSicht";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.pSide.ResumeLayout(false);
            this.pSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button bResetPos;
        private System.Windows.Forms.Button bResetZoom;
    }
}

