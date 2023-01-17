
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
            this.pView = new System.Windows.Forms.Panel();
            this.pSide = new System.Windows.Forms.Panel();
            this.bOpen = new System.Windows.Forms.Button();
            this.pSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pView
            // 
            this.pView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pView.Location = new System.Drawing.Point(0, 0);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(1007, 642);
            this.pView.TabIndex = 0;
            // 
            // pSide
            // 
            this.pSide.Controls.Add(this.bOpen);
            this.pSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pSide.Location = new System.Drawing.Point(926, 0);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(81, 642);
            this.pSide.TabIndex = 0;
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(3, 3);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 642);
            this.Controls.Add(this.pSide);
            this.Controls.Add(this.pView);
            this.Name = "MainForm";
            this.Text = "PlanSicht";
            this.pSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Button bOpen;
    }
}

