namespace GraphicPenisGenerator
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.labPenis = new System.Windows.Forms.Label();
            this.grpBoxChoixGen = new System.Windows.Forms.GroupBox();
            this.grpBoxChoice = new System.Windows.Forms.GroupBox();
            this.radMs = new System.Windows.Forms.RadioButton();
            this.radMin = new System.Windows.Forms.RadioButton();
            this.radSec = new System.Windows.Forms.RadioButton();
            this.chkGen = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxChoixGen.SuspendLayout();
            this.grpBoxChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 25);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // labPenis
            // 
            this.labPenis.AutoSize = true;
            this.labPenis.Location = new System.Drawing.Point(78, 150);
            this.labPenis.Name = "labPenis";
            this.labPenis.Size = new System.Drawing.Size(121, 13);
            this.labPenis.TabIndex = 1;
            this.labPenis.Text = "Waiting to be generated";
            // 
            // grpBoxChoixGen
            // 
            this.grpBoxChoixGen.Controls.Add(this.grpBoxChoice);
            this.grpBoxChoixGen.Controls.Add(this.chkGen);
            this.grpBoxChoixGen.Location = new System.Drawing.Point(123, 12);
            this.grpBoxChoixGen.Name = "grpBoxChoixGen";
            this.grpBoxChoixGen.Size = new System.Drawing.Size(149, 125);
            this.grpBoxChoixGen.TabIndex = 2;
            this.grpBoxChoixGen.TabStop = false;
            this.grpBoxChoixGen.Text = "Generate a penis each";
            // 
            // grpBoxChoice
            // 
            this.grpBoxChoice.Controls.Add(this.radMs);
            this.grpBoxChoice.Controls.Add(this.radMin);
            this.grpBoxChoice.Controls.Add(this.radSec);
            this.grpBoxChoice.Location = new System.Drawing.Point(7, 41);
            this.grpBoxChoice.Name = "grpBoxChoice";
            this.grpBoxChoice.Size = new System.Drawing.Size(136, 78);
            this.grpBoxChoice.TabIndex = 1;
            this.grpBoxChoice.TabStop = false;
            this.grpBoxChoice.Visible = false;
            // 
            // radMs
            // 
            this.radMs.AutoSize = true;
            this.radMs.Location = new System.Drawing.Point(6, 9);
            this.radMs.Name = "radMs";
            this.radMs.Size = new System.Drawing.Size(77, 17);
            this.radMs.TabIndex = 2;
            this.radMs.TabStop = true;
            this.radMs.Tag = "";
            this.radMs.Text = "Millisecond";
            this.radMs.UseVisualStyleBackColor = true;
            this.radMs.CheckedChanged += new System.EventHandler(this.radMs_CheckedChanged);
            // 
            // radMin
            // 
            this.radMin.AutoSize = true;
            this.radMin.Location = new System.Drawing.Point(6, 55);
            this.radMin.Name = "radMin";
            this.radMin.Size = new System.Drawing.Size(57, 17);
            this.radMin.TabIndex = 1;
            this.radMin.TabStop = true;
            this.radMin.Tag = "";
            this.radMin.Text = "Minute";
            this.radMin.UseVisualStyleBackColor = true;
            this.radMin.CheckedChanged += new System.EventHandler(this.radMin_CheckedChanged);
            // 
            // radSec
            // 
            this.radSec.AutoSize = true;
            this.radSec.Location = new System.Drawing.Point(6, 32);
            this.radSec.Name = "radSec";
            this.radSec.Size = new System.Drawing.Size(62, 17);
            this.radSec.TabIndex = 0;
            this.radSec.TabStop = true;
            this.radSec.Tag = "";
            this.radSec.Text = "Second";
            this.radSec.UseVisualStyleBackColor = true;
            this.radSec.CheckedChanged += new System.EventHandler(this.radSec_CheckedChanged);
            // 
            // chkGen
            // 
            this.chkGen.AutoSize = true;
            this.chkGen.Location = new System.Drawing.Point(42, 19);
            this.chkGen.Name = "chkGen";
            this.chkGen.Size = new System.Drawing.Size(65, 17);
            this.chkGen.TabIndex = 0;
            this.chkGen.Text = "Activate";
            this.chkGen.UseVisualStyleBackColor = true;
            this.chkGen.CheckedChanged += new System.EventHandler(this.chkGen_CheckedChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 93);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 59);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(296, 175);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grpBoxChoixGen);
            this.Controls.Add(this.labPenis);
            this.Controls.Add(this.btnGenerate);
            this.MaximizeBox = false;
            this.Name = "FrmAccueil";
            this.Text = "Graphic Penis Generator";
            this.grpBoxChoixGen.ResumeLayout(false);
            this.grpBoxChoixGen.PerformLayout();
            this.grpBoxChoice.ResumeLayout(false);
            this.grpBoxChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labPenis;
        private System.Windows.Forms.GroupBox grpBoxChoixGen;
        private System.Windows.Forms.GroupBox grpBoxChoice;
        private System.Windows.Forms.RadioButton radMin;
        private System.Windows.Forms.RadioButton radSec;
        private System.Windows.Forms.CheckBox chkGen;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton radMs;
        private System.Windows.Forms.Button btnClear;
    }
}

