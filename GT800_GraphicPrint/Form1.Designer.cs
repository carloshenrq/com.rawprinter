namespace GT800_GraphicPrint
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
            this.txtGT800 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEnviarGrafico = new System.Windows.Forms.Button();
            this.ofdGraphics = new System.Windows.Forms.OpenFileDialog();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.btnImprimirEtq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGT800
            // 
            this.txtGT800.Location = new System.Drawing.Point(15, 46);
            this.txtGT800.Name = "txtGT800";
            this.txtGT800.Size = new System.Drawing.Size(335, 20);
            this.txtGT800.TabIndex = 0;
            this.txtGT800.Text = "ZDesigner GT800 (EPL)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Impressora:";
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.Location = new System.Drawing.Point(112, 72);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(128, 23);
            this.btnInformacoes.TabIndex = 2;
            this.btnInformacoes.Text = "Informações Gráficas";
            this.btnInformacoes.UseVisualStyleBackColor = true;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(15, 72);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar Gráficos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEnviarGrafico
            // 
            this.btnEnviarGrafico.Location = new System.Drawing.Point(246, 72);
            this.btnEnviarGrafico.Name = "btnEnviarGrafico";
            this.btnEnviarGrafico.Size = new System.Drawing.Size(104, 23);
            this.btnEnviarGrafico.TabIndex = 4;
            this.btnEnviarGrafico.Text = "Enviar Gráfico";
            this.btnEnviarGrafico.UseVisualStyleBackColor = true;
            this.btnEnviarGrafico.Click += new System.EventHandler(this.btnEnviarGrafico_Click);
            // 
            // ofdGraphics
            // 
            this.ofdGraphics.Filter = "Arquivos PCX|*.PCX";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(15, 101);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(335, 239);
            this.txtData.TabIndex = 5;
            this.txtData.Text = resources.GetString("txtData.Text");
            // 
            // btnImprimirEtq
            // 
            this.btnImprimirEtq.Location = new System.Drawing.Point(15, 346);
            this.btnImprimirEtq.Name = "btnImprimirEtq";
            this.btnImprimirEtq.Size = new System.Drawing.Size(335, 29);
            this.btnImprimirEtq.TabIndex = 6;
            this.btnImprimirEtq.Text = "Imprimir Etiqueta";
            this.btnImprimirEtq.UseVisualStyleBackColor = true;
            this.btnImprimirEtq.Click += new System.EventHandler(this.btnImprimirEtq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 387);
            this.Controls.Add(this.btnImprimirEtq);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnEnviarGrafico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInformacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGT800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGT800;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEnviarGrafico;
        private System.Windows.Forms.OpenFileDialog ofdGraphics;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Button btnImprimirEtq;


    }
}

