namespace galgje
{
    partial class frmToevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToevoegen));
            this.lblTitel = new System.Windows.Forms.Label();
            this.lbLijst = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtwoord = new System.Windows.Forms.TextBox();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(12, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(35, 17);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Titel";
            this.lblTitel.Click += new System.EventHandler(this.LblTitel_Click);
            // 
            // lbLijst
            // 
            this.lbLijst.FormattingEnabled = true;
            this.lbLijst.ItemHeight = 16;
            this.lbLijst.Location = new System.Drawing.Point(138, 12);
            this.lbLijst.Name = "lbLijst";
            this.lbLijst.Size = new System.Drawing.Size(120, 228);
            this.lbLijst.TabIndex = 1;
            this.lbLijst.SelectedIndexChanged += new System.EventHandler(this.LbLijst_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(12, 247);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(120, 38);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.BtnToevoegen_Click);
            // 
            // txtwoord
            // 
            this.txtwoord.Location = new System.Drawing.Point(12, 219);
            this.txtwoord.Name = "txtwoord";
            this.txtwoord.Size = new System.Drawing.Size(120, 22);
            this.txtwoord.TabIndex = 3;
            this.txtwoord.TextChanged += new System.EventHandler(this.Txtwoord_TextChanged);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(138, 247);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(120, 38);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.BtnVerwijderen_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(15, 291);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(243, 35);
            this.btnTerug.TabIndex = 5;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // frmToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 330);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.txtwoord);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbLijst);
            this.Controls.Add(this.lblTitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmToevoegen";
            this.Text = "Toevoegen";
            this.Load += new System.EventHandler(this.Toevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ListBox lbLijst;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtwoord;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnTerug;
    }
}