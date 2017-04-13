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

namespace TestRawPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            RawPrinter.SendString(this.txtNomeImpressora.Text, this.txtData.Text, (ushort)this.numCopias.Value);
        }

    }
}
