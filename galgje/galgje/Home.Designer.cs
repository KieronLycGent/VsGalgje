namespace galgje
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpties = new System.Windows.Forms.Button();
            this.pctStartSpel = new System.Windows.Forms.PictureBox();
            this.pctE = new System.Windows.Forms.PictureBox();
            this.pctJ = new System.Windows.Forms.PictureBox();
            this.pctG2 = new System.Windows.Forms.PictureBox();
            this.pctL = new System.Windows.Forms.PictureBox();
            this.pctA = new System.Windows.Forms.PictureBox();
            this.pctG = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStartSpel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(925, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.testToolStripMenuItem1.Text = "Test";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // btnOpties
            // 
            this.btnOpties.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpties.Location = new System.Drawing.Point(706, 413);
            this.btnOpties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpties.Name = "btnOpties";
            this.btnOpties.Size = new System.Drawing.Size(167, 51);
            this.btnOpties.TabIndex = 2;
            this.btnOpties.Text = "Opties";
            this.btnOpties.UseVisualStyleBackColor = true;
            this.btnOpties.Click += new System.EventHandler(this.BtnOpties_Click);
            // 
            // pctStartSpel
            // 
            this.pctStartSpel.Location = new System.Drawing.Point(706, 219);
            this.pctStartSpel.Name = "pctStartSpel";
            this.pctStartSpel.Size = new System.Drawing.Size(167, 189);
            this.pctStartSpel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctStartSpel.TabIndex = 61;
            this.pctStartSpel.TabStop = false;
            this.pctStartSpel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctE
            // 
            this.pctE.Location = new System.Drawing.Point(537, 49);
            this.pctE.Name = "pctE";
            this.pctE.Size = new System.Drawing.Size(99, 95);
            this.pctE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctE.TabIndex = 60;
            this.pctE.TabStop = false;
            this.pctE.Click += new System.EventHandler(this.pctE_Click);
            // 
            // pctJ
            // 
            this.pctJ.Location = new System.Drawing.Point(432, 49);
            this.pctJ.Name = "pctJ";
            this.pctJ.Size = new System.Drawing.Size(99, 95);
            this.pctJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctJ.TabIndex = 59;
            this.pctJ.TabStop = false;
            this.pctJ.Click += new System.EventHandler(this.pctJ_Click);
            // 
            // pctG2
            // 
            this.pctG2.Location = new System.Drawing.Point(327, 49);
            this.pctG2.Name = "pctG2";
            this.pctG2.Size = new System.Drawing.Size(99, 95);
            this.pctG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctG2.TabIndex = 58;
            this.pctG2.TabStop = false;
            this.pctG2.Click += new System.EventHandler(this.pctG2_Click);
            // 
            // pctL
            // 
            this.pctL.Location = new System.Drawing.Point(222, 49);
            this.pctL.Name = "pctL";
            this.pctL.Size = new System.Drawing.Size(99, 95);
            this.pctL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctL.TabIndex = 57;
            this.pctL.TabStop = false;
            this.pctL.Click += new System.EventHandler(this.pctL_Click);
            // 
            // pctA
            // 
            this.pctA.Location = new System.Drawing.Point(117, 49);
            this.pctA.Name = "pctA";
            this.pctA.Size = new System.Drawing.Size(99, 95);
            this.pctA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctA.TabIndex = 56;
            this.pctA.TabStop = false;
            this.pctA.Click += new System.EventHandler(this.pctA_Click);
            // 
            // pctG
            // 
            this.pctG.Location = new System.Drawing.Point(12, 49);
            this.pctG.Name = "pctG";
            this.pctG.Size = new System.Drawing.Size(99, 95);
            this.pctG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctG.TabIndex = 55;
            this.pctG.TabStop = false;
            this.pctG.Click += new System.EventHandler(this.pctG_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 495);
            this.Controls.Add(this.pctStartSpel);
            this.Controls.Add(this.pctE);
            this.Controls.Add(this.pctJ);
            this.Controls.Add(this.pctG2);
            this.Controls.Add(this.pctL);
            this.Controls.Add(this.pctA);
            this.Controls.Add(this.pctG);
            this.Controls.Add(this.btnOpties);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStartSpel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button btnOpties;
        private System.Windows.Forms.PictureBox pctG;
        private System.Windows.Forms.PictureBox pctA;
        private System.Windows.Forms.PictureBox pctL;
        private System.Windows.Forms.PictureBox pctG2;
        private System.Windows.Forms.PictureBox pctJ;
        private System.Windows.Forms.PictureBox pctE;
        private System.Windows.Forms.PictureBox pctStartSpel;
        private System.Windows.Forms.Timer timer1;
    }
}