using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Compression;
using Ionic.Zip;

namespace AppExtractorXML.Vista
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        FolderBrowserDialog folder = new FolderBrowserDialog();


        /// <summary>
        /// Boton para seleccionar la carpeta donde se encuentran los archivos XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtRutaXML.Text = folder.SelectedPath;
            }
        }


        /// <summary>
        /// Bonot para seleccionar la carpeta donde se almacenara los archivos .ZIP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDestino_Click(object sender, EventArgs e)
        {
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtRutaZIP.Text = folder.SelectedPath;
            }
        }


        /// <summary>
        /// Proceso para generar el archivo .zip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtRutaXML.Text.Equals("") && txtRutaZIP.Text.Equals(""))
            {
                MessageBox.Show("Elegir carpeta de XMl y carpeta destino");
            }
            else
            {
                string[] files = Directory.GetFiles(txtRutaXML.Text, "*.xml", SearchOption.AllDirectories);

                foreach (var item in files)
                {
                    string fileName = Path.GetFileName(item);
                    Directory.CreateDirectory(@"C:\ArchivosTemporales");
                    File.Copy(item, @"C:\ArchivosTemporales\" + fileName, true);
                }

                using (ZipFile zip = new ZipFile())
                {
                    try
                    {
                        zip.AddDirectory(@"C:\ArchivosTemporales");
                        string saveZip = txtRutaZIP.Text + "\\ArchivosXML_" + System.DateTime.Now.ToString("ddMMMMyyyy") + ".zip";
                        zip.Save(saveZip);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

                //Directory.Delete(@"C:\ArchivosTemporales");
                Directory.Delete(@"C:\ArchivosTemporales", true);
                //Directory.Delete(@"C:\ArchivosTemporales");
            }
        }
    }
}
