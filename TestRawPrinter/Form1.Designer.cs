namespace TestRawPrinter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.lblNomeImpressora = new System.Windows.Forms.Label();
            this.txtNomeImpressora = new System.Windows.Forms.TextBox();
            this.numCopias = new System.Windows.Forms.NumericUpDown();
            this.lblCopias = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 71);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(424, 145);
            this.txtData.TabIndex = 0;
            this.txtData.Text = resources.GetString("txtData.Text");
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Location = new System.Drawing.Point(12, 55);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(122, 13);
            this.lblConteudo.TabIndex = 1;
            this.lblConteudo.Text = "Conteúdo da Impressão:";
            // 
            // lblNomeImpressora
            // 
            this.lblNomeImpressora.AutoSize = true;
            this.lblNomeImpressora.Location = new System.Drawing.Point(9, 16);
            this.lblNomeImpressora.Name = "lblNomeImpressora";
            this.lblNomeImpressora.Size = new System.Drawing.Size(107, 13);
            this.lblNomeImpressora.TabIndex = 2;
            this.lblNomeImpressora.Text = "Nome da Impressora:";
            // 
            // txtNomeImpressora
            // 
            this.txtNomeImpressora.Location = new System.Drawing.Point(12, 32);
            this.txtNomeImpressora.Name = "txtNomeImpressora";
            this.txtNomeImpressora.Size = new System.Drawing.Size(280, 20);
            this.txtNomeImpressora.TabIndex = 3;
            // 
            // numCopias
            // 
            this.numCopias.Location = new System.Drawing.Point(298, 32);
            this.numCopias.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCopias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCopias.Name = "numCopias";
            this.numCopias.Size = new System.Drawing.Size(138, 20);
            this.numCopias.TabIndex = 4;
            this.numCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCopias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Location = new System.Drawing.Point(295, 16);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(42, 13);
            this.lblCopias.TabIndex = 5;
            this.lblCopias.Text = "Cópias:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(144, 222);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(161, 48);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 282);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblCopias);
            this.Controls.Add(this.numCopias);
            this.Controls.Add(this.txtNomeImpressora);
            this.Controls.Add(this.lblNomeImpressora);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.txtData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(464, 321);
            this.MinimumSize = new System.Drawing.Size(464, 321);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCopias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Label lblNomeImpressora;
        private System.Windows.Forms.TextBox txtNomeImpressora;
        private System.Windows.Forms.NumericUpDown numCopias;
        private System.Windows.Forms.Label lblCopias;
        private System.Windows.Forms.Button btnImprimir;
    }
}

