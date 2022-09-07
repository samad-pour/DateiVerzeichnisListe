namespace DateiVerzeichnisListe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDateiliste = new System.Windows.Forms.Button();
            this.btnSystemeintraege = new System.Windows.Forms.Button();
            this.btnInVerzeichnis = new System.Windows.Forms.Button();
            this.btnNachOben = new System.Windows.Forms.Button();
            this.lblAktuellesVerzeichnis = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDateiliste
            // 
            this.btnDateiliste.Location = new System.Drawing.Point(29, 35);
            this.btnDateiliste.Name = "btnDateiliste";
            this.btnDateiliste.Size = new System.Drawing.Size(188, 58);
            this.btnDateiliste.TabIndex = 0;
            this.btnDateiliste.Text = "Dataeiliste";
            this.btnDateiliste.UseVisualStyleBackColor = true;
            this.btnDateiliste.Click += new System.EventHandler(this.btnDateiliste_Click);
            // 
            // btnSystemeintraege
            // 
            this.btnSystemeintraege.Location = new System.Drawing.Point(223, 35);
            this.btnSystemeintraege.Name = "btnSystemeintraege";
            this.btnSystemeintraege.Size = new System.Drawing.Size(231, 58);
            this.btnSystemeintraege.TabIndex = 0;
            this.btnSystemeintraege.Text = "Systemeinträge";
            this.btnSystemeintraege.UseVisualStyleBackColor = true;
            this.btnSystemeintraege.Click += new System.EventHandler(this.btnSystemeintraege_Click);
            // 
            // btnInVerzeichnis
            // 
            this.btnInVerzeichnis.Location = new System.Drawing.Point(484, 35);
            this.btnInVerzeichnis.Name = "btnInVerzeichnis";
            this.btnInVerzeichnis.Size = new System.Drawing.Size(241, 58);
            this.btnInVerzeichnis.TabIndex = 0;
            this.btnInVerzeichnis.Text = "in Verzeichnis";
            this.btnInVerzeichnis.UseVisualStyleBackColor = true;
            this.btnInVerzeichnis.Click += new System.EventHandler(this.btnInVerzeichnis_Click);
            // 
            // btnNachOben
            // 
            this.btnNachOben.Location = new System.Drawing.Point(731, 35);
            this.btnNachOben.Name = "btnNachOben";
            this.btnNachOben.Size = new System.Drawing.Size(188, 58);
            this.btnNachOben.TabIndex = 0;
            this.btnNachOben.Text = "nach oben";
            this.btnNachOben.UseVisualStyleBackColor = true;
            this.btnNachOben.Click += new System.EventHandler(this.btnNachOben_Click);
            // 
            // lblAktuellesVerzeichnis
            // 
            this.lblAktuellesVerzeichnis.AutoSize = true;
            this.lblAktuellesVerzeichnis.Location = new System.Drawing.Point(29, 128);
            this.lblAktuellesVerzeichnis.Name = "lblAktuellesVerzeichnis";
            this.lblAktuellesVerzeichnis.Size = new System.Drawing.Size(39, 41);
            this.lblAktuellesVerzeichnis.TabIndex = 2;
            this.lblAktuellesVerzeichnis.Text = "...";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(29, 477);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(39, 41);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "...";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 41;
            this.lstDisplay.Location = new System.Drawing.Point(12, 201);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(907, 250);
            this.lstDisplay.TabIndex = 4;
            this.lstDisplay.SelectedIndexChanged += new System.EventHandler(this.lstDisplay_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 699);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblAktuellesVerzeichnis);
            this.Controls.Add(this.btnNachOben);
            this.Controls.Add(this.btnInVerzeichnis);
            this.Controls.Add(this.btnSystemeintraege);
            this.Controls.Add(this.btnDateiliste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDateiliste;
        private Button btnSystemeintraege;
        private Button btnInVerzeichnis;
        private Button btnNachOben;
        private Label lblAktuellesVerzeichnis;
        private Label lblDisplay;
        private ListBox lstDisplay;
    }
}