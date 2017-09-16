namespace DateiPfadGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.choseButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choseButton
            // 
            this.choseButton.Location = new System.Drawing.Point(15, 44);
            this.choseButton.Name = "choseButton";
            this.choseButton.Size = new System.Drawing.Size(127, 23);
            this.choseButton.TabIndex = 0;
            this.choseButton.Text = "Datei Auswählen";
            this.choseButton.UseVisualStyleBackColor = true;
            this.choseButton.Click += new System.EventHandler(this.choseButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(62, 13);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Dateipfad : ";
            // 
            // copyButton
            // 
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(148, 44);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Kopieren";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.Location = new System.Drawing.Point(72, 6);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.ReadOnly = true;
            this.pathLabel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pathLabel.Size = new System.Drawing.Size(200, 20);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "Bitte Wähle eine Datei aus.";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 79);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.choseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Dateipfad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choseButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox pathLabel;
    }
}

