/*
BSD 3-Clause License

Copyright (c) 2017, Carlos Henrique
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

* Neither the name of the copyright holder nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.rawprinter
{
    /// <summary>
    /// Classe static para comunicação e envio de strings diretos a
    /// impressora informada pelo nome
    /// </summary>
    public static class RawPrinter
    {
        /// <summary>
        /// Envia para a impressora que será selecionada pelo usuário os dados de
        /// impressão do texto.
        /// </summary>
        /// <param name="sStringText">Conteudo de texto para ser impresso.</param>
        /// <returns></returns>
        public static bool SendString(string sStringText, ushort iNumCopies)
        {
            PrintDialog pdPrinter = new PrintDialog();
            pdPrinter.AllowCurrentPage = false;
            pdPrinter.AllowPrintToFile = false;
            pdPrinter.AllowSelection = false;
            pdPrinter.AllowSomePages = false;
            pdPrinter.PrinterSettings.Copies = (short)Math.Min((int)iNumCopies, pdPrinter.PrinterSettings.MaximumCopies);

            DialogResult drPrinter = pdPrinter.ShowDialog();

            if (drPrinter != DialogResult.OK)
            {
                MessageBox.Show("Impressão cancelada pelo usuário!", "Imprimir Documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Obtém o nome da impressora a ser impressa.
            string sPrinterName = pdPrinter.PrinterSettings.PrinterName;
            // Numero de cópias a serem impressas.
            iNumCopies = (ushort)pdPrinter.PrinterSettings.Copies;

            // Chama a função para realizar a impressão dos dados.
            return SendString(sPrinterName, sStringText, iNumCopies);
        }

        /// <summary>
        /// Envia para a impressora informada os dados de impressão de texto
        /// que você passou por parametro
        /// </summary>
        /// <param name="sPrinterName">Nome da impressora a receber os dados</param>
        /// <param name="sStringText">Dados de texto a serem impressos.</param>
        /// <param name="Copies">Número de cópias</param>
        /// <returns></returns>
        public static bool SendString(string sPrinterName, string sStringText, ushort iNumCopies)
        {
            // Número de cópias não pode ser 0 ou menor que 0
            if (iNumCopies <= 0)
            {
                MessageBox.Show("Valor para impressão é inválido!", "Imprimir Documento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Caso impressora esteja com nome embranco.
            if (string.IsNullOrEmpty(sPrinterName))
                return SendString(sStringText, iNumCopies);

            // Declaração de todos os dados de resultado de impressão.
            List<bool> lPrintResult = new List<bool>();
            for (ushort i = 0; i < iNumCopies; i++)
                lPrintResult.Add(RawPrinterHelper.SendStringToPrinter(sPrinterName, sStringText));

            // Não houve falhas de impressão, então retornará verdadeiro.
            return (lPrintResult.Where(r => r == false).Count() == 0);
        }

    }
}
