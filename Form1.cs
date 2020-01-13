using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalRecordsBusiness;

namespace LoadMedicalData
{
    public partial class Form1 : Form
    {
        mrBO bo = new mrBO();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bo.loadData(@"C:\Users\Cesar\Documents\controlmedico\data.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bo.loadDataAugust(@"C:\Users\Cesar\Documents\controlmedico\PRESION.AGOSTO.TXT");
        }

        private void btnRawData_Click(object sender, EventArgs e)
        {
            bo.LoadData(txData.Lines);
            txData.Clear();
        }

        private void btnBROUCesar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Cesar\Documents\Finanzas\Cesar";
            ofd.Multiselect = true;
            if ( ofd.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                bo.loadBrou("BROU CESAR", ofd.FileNames);
                Cursor = Cursors.Arrow;
            }
        }

        private string[] selectFiles(string path, string mask = "Text Files (.txt)|*.txt")
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = mask;
            ofd.InitialDirectory = path;
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileNames;
            
            return null;
        }

        private void btnCleanMiDinero_Click(object sender, EventArgs e)
        {
            var files = selectFiles(@"C:\Users\Cesar\Documents\Finanzas\Cesar");
            if ( files != null )
            {
                Cursor = Cursors.WaitCursor;
                bo.CleanMiDinero(files);
                Cursor = Cursors.Arrow;
            }
        }

        private void btnMiDinero_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbmiDinero.Text))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = @"C:\Users\Cesar\Documents\Finanzas\Cesar";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    bo.MiDinero(cbmiDinero.Text, ofd.FileNames);
                    Cursor = Cursors.Arrow;
                }
            }
            else MessageBox.Show("Select tarjeta.");
        }

        private void btnAnda_Click(object sender, EventArgs e)
        {
            var files = selectFiles(@"C:\Users\Cesar\Documents\Finanzas\Cesar");
            if (files != null)
            {
                Cursor = Cursors.WaitCursor;
                bo.Anda(files);
                Cursor = Cursors.Arrow;
            }

        }

        private void bhtnPrex_Click(object sender, EventArgs e)
        {
            var files = selectFiles(@"C:\Users\Cesar\Documents\Finanzas\Cesar");
            if (files != null)
            {
                Cursor = Cursors.WaitCursor;
                bo.Prex(files);
                Cursor = Cursors.Arrow;
            }
        }
    }
}
