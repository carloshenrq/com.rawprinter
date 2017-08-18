using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.rawprinter;
using System.IO;

namespace GT800_GraphicPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarGrafico_Click(object sender, EventArgs e)
        {
            DialogResult drOfd = this.ofdGraphics.ShowDialog();

            if (drOfd == DialogResult.OK)
            {
                FileInfo fiPcx = new FileInfo(this.ofdGraphics.FileName);

                using (Stream sFileOpen = this.ofdGraphics.OpenFile())
                using (BinaryReader brFileOpen = new BinaryReader(sFileOpen))
                using (MemoryStream msFile = new MemoryStream())
                using (BinaryWriter bwFile = new BinaryWriter(msFile))
                {
                    bwFile.Write(Encoding.ASCII.GetBytes("GM\"IMAGE\"" + fiPcx.Length));
                    bwFile.Write(brFileOpen.ReadBytes(Convert.ToInt32(fiPcx.Length)));
                    bwFile.Flush();
                    msFile.Flush();

                    msFile.Seek(0, SeekOrigin.Begin);

                    byte[] bMemdata = new byte[msFile.Length];
                    msFile.Read(bMemdata, 0, bMemdata.Length);

                    RawPrinter.SendBytesToPrinter(this.txtGT800.Text, bMemdata, 1);

                    bwFile.Close();
                    msFile.Close();

                    brFileOpen.Close();
                    sFileOpen.Close();
                }

                this.btnInformacoes_Click(sender, e);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            RawPrinter.SendString(this.txtGT800.Text, "GK\"*\"\r\n", 1);
            this.btnInformacoes_Click(sender, e);
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            RawPrinter.SendString(this.txtGT800.Text, "GI\r\n", 1);
        }

        private void btnImprimirEtq_Click(object sender, EventArgs e)
        {
            RawPrinter.SendString(this.txtGT800.Text, this.txtData.Text, 1);
        }
    }
}
