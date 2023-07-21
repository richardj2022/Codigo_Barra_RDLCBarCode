using BarcodeLib;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLCBarCode
{
    public partial class Frm_Repotes : Form
    {
        AppDataRG.BarcodeDataTable _barcode;
        public Frm_Repotes(AppDataRG.BarcodeDataTable barcode)
        {
            InitializeComponent();
            this._barcode = barcode;

        }

        private void Frm_Repotes_Load(object sender, EventArgs e)
        {
           ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
           reportDataSource.Value = _barcode;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
