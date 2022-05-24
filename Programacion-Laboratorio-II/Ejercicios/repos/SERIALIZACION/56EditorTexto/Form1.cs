using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
namespace _56EditorTexto
{
    public partial class NotePadForm : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string archivo;
        public NotePadForm()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region Codigo anterior
            //string fileContent = string.Empty;
            //string filePath = string.Empty;
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.InitialDirectory = "c:\\";
            //    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //    openFileDialog.FilterIndex = 2;
            //    openFileDialog.RestoreDirectory = true;

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        //Get the path of specified file
            //        filePath = openFileDialog.FileName;

            //        //Read the contents of the file into a stream
            //        var fileStream = openFileDialog.OpenFile();

            //        using (StreamReader reader = new StreamReader(fileStream))
            //        {
            //            fileContent = reader.ReadToEnd();
            //        }
            //    }
            //}
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            //rtbEditor.Text += fileContent;
            #endregion
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;
                    using (StreamReader streamReader = new StreamReader(archivo))
                    {
                        rtbEditor.Text = streamReader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    this.MostrarMensajeError(ex);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Codigo anterior
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //StreamWriter archivo = null;
            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;
            //try
            //{
            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        //Este es el path
            //        MessageBox.Show(saveFileDialog1.FileName);
            //        archivo = new StreamWriter(saveFileDialog1.FileName);
            //        archivo.WriteLine(rtbEditor.Text);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.MostrarMensajeError(ex);
            //}
            //finally
            //{
            //    archivo.Close();
            //}
            #endregion
            //Validar si el archivo existe.
            if(!File.Exists(archivo))
            {
              this.GuardarArchivoFileDialog();               
            }
            else
            {
                GuardarArchivo(archivo);
            }
        }

        private void NotePadForm_Load(object sender, EventArgs e)
        {
            stripStatus1.Text = "0 caracteres";
        }

        private void GuardarArchivoFileDialog()
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Se guarda la ruta
                archivo = saveFileDialog.FileName;                
                this.GuardarArchivo(archivo);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.GuardarArchivoFileDialog();
        }
        private void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error : {ex.Message}");
            sb.AppendLine(ex.StackTrace);
            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void GuardarArchivo(string ruta)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    //Pisamos el contenido del rich text box
                    streamWriter.Write(rtbEditor.Text);
                }
            }
            catch (Exception ex)
            {

                this.MostrarMensajeError(ex);
            }
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            stripStatus1.Text = $"{rtbEditor.Text.Length} caracteres";
        }
    }
}
