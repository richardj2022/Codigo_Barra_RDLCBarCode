using BarcodeStandard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLCBarCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            //BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();   
            Image img  = barcode.Encode(BarcodeLib.TYPE.UPCA, Txt_Barcode.Text, Color.Black, Color.White, 100, 30);
            pintureboxcode.Image = img;
            //en un panel
            //pan_barcode.BackgroundImage = img;
            this.appDataRG1.Clear();

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                for (int i=0; i< numero.Value; i++)
                this.appDataRG1.Barcode.AddBarcodeRow(Txt_Barcode.Text, ms.ToArray());
                  
            }
            
            using (Frm_Repotes frm = new Frm_Repotes(this.appDataRG1.Barcode))
            {

                frm.ShowDialog();
            }

        }

       
    }
}
