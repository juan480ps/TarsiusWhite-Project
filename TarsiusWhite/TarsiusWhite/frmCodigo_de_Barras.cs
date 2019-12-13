using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using System.Drawing.Imaging;

namespace TarsiusWhite
{
    public partial class frmCodigo_de_Barras : Form
    {
        public frmCodigo_de_Barras()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            //panelResultado.BackgroundImage = Codigo.Encode(TYPE.UPCA, Convert.ToString(txtCodigo), Color.Black, Color.White, 290, 120);

            panelResultado.BackgroundImage = Codigo.Encode(TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 290, 120);
            btnGuardar.Enabled = true;

           // Image img = Codigo.Encode(TYPE.UPCA, "dsfsdvfdsfv", Color.Black, Color.White, 290, 120);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panelResultado.BackgroundImage.Clone();

            SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
            CajaDeDiaologoGuardar.AddExtension = true;
            CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDeDiaologoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
            {
                imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }
    }
}
