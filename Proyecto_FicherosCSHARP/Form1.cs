using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_FicherosCSHARP
{
    public partial class Form1 : Form
    {
        public Form1()  {
            InitializeComponent();
        }

        /*
         * INICIALIZAR LA APLICACIÓN
         * Al iniciar la aplicación se aplicará una ruta por defecto
         */
        private void Form1_Load_1(object sender, EventArgs e) {
            currentrouteTXT.Text = Directory.GetCurrentDirectory();
        }

        /*
         * CREAR UN FICHERO/DIRECTORIO
         * Permite que el usuario pueda crear un fichero/directorio
         */
        private void crearBTN_Click(object sender, EventArgs e) {
            try {
                String path = currentrouteTXT.Text + "/" + routeTXT.Text;

                if (filesCHK.Checked) {
                    if (File.Exists(@path)) {
                        MessageBox.Show("El fichero existe");
                        return;
                    }

                    StreamWriter sw = File.CreateText(@path);
                    sw.Close();
                }

                if (folderCHK.Checked) {
                    if (Directory.Exists(@path)) {
                        MessageBox.Show("El directorio existe");
                        return;
                    }

                    DirectoryInfo di = Directory.CreateDirectory(@path);
                }
                filesfolderBTN.PerformClick();
            }
            catch {
                MessageBox.Show("NO se ha creado con éxito.");
            }
        }

        /*
         * ELIMINAR UN FICHERO/DIRECTORIO
         * Permite que el usuario pueda eliminar un fichero/directorio
         */
        private void deleteBTN_Click(object sender, EventArgs e) {
            try {
                String path = currentrouteTXT.Text + "/" + routeTXT.Text;

                if (filesCHK.Checked) {
                    File.Delete(@path);
                }
                if (folderCHK.Checked) {
                    Directory.Delete(@path, true);
                }
                filesfolderBTN.PerformClick();
            }
            catch {
                MessageBox.Show("NO se ha eliminado con éxito.");
            }
        }

        /*
         * MOVER O RENOMBRAR UN FICHERO/DIRECTORIO
         * Permite que el usuario pueda mover o renombrar un fichero/directorio
         */
        private void moveBTN_Click(object sender, EventArgs e) {
            try {
                String path1 = currentrouteTXT.Text + "/" + filesfolderLIST.SelectedItem.ToString();
                String path2 = routeTXT.Text;

                if (filesCHK.Checked) {
                    File.Move(@path1, @path2);
                }
                if (folderCHK.Checked) {
                    Directory.Move(@path1, @path2);
                }
                filesfolderBTN.PerformClick();
            }
            catch {
                MessageBox.Show("NO se ha renombrado o movido con éxito.");
            }
        }

        /*
         * LISTAR TODOS LOS FICHEROS Y DIRECTORIOS
         * Muestra al usuario todos los ficheros y directorios de la ruta actual
         */
        private void filesfolderBTN_Click(object sender, EventArgs e) {
            String NewPath = "NewPath contiene la ruta que la usuario ha ingresado.";
            String ErrorMessage = null;

            filesfolderLIST.Items.Clear();

            NewPath = currentrouteTXT.Text;

            try {
                Directory.SetCurrentDirectory(NewPath);

                String sourceDirectory = NewPath;

                var txtFiles = Directory.EnumerateFiles(sourceDirectory);

                foreach (String currentFile in txtFiles) {
                    String ultimoCaracter = NewPath.Substring(NewPath.Length - 1);

                    if ((ultimoCaracter.CompareTo("\\") == 0) || (ultimoCaracter.CompareTo(":") == 0)) {
                        String fileName = currentFile.Substring(sourceDirectory.Length);
                        filesfolderLIST.Items.Add(fileName);
                    }
                    else {
                        String fileName = currentFile.Substring(sourceDirectory.Length + 1);
                        filesfolderLIST.Items.Add(fileName);
                    }
                }

                var txtDirectory = Directory.EnumerateDirectories(sourceDirectory);

                foreach (String currentDirectory in txtDirectory) {

                    String ultimoCaracter = NewPath.Substring(NewPath.Length - 1);
                    if ((ultimoCaracter.CompareTo("\\") == 0) || (ultimoCaracter.CompareTo(":") == 0)) {
                        String directoryName = currentDirectory.Substring(sourceDirectory.Length);
                        filesfolderLIST.Items.Add(directoryName);
                    }
                    else {
                        String directoryName = currentDirectory.Substring(sourceDirectory.Length + 1);
                        filesfolderLIST.Items.Add(directoryName);
                    }
                }

            }
            catch (DirectoryNotFoundException f) {
                ErrorMessage = "Debes ingresar una ruta válida.Si intenta acceder a una unidad diferente, recuerde incluir la letra de la unidad" + f;
            }
            catch {
                if (currentrouteTXT.Text == "") {
                    ErrorMessage = "Debes ingresar una ruta.";
                }
            }
            finally {
                if (ErrorMessage != null) {
                    MessageBox.Show(ErrorMessage);
                }
            }
        }

        /*
         * MOSTRAR EL CONTENIDO DE UN FICHERO
         * Muestra al usuario el contenido del fichero seleccionado
         */
        private void showfileBTN_Click(object sender, EventArgs e) {
            try {
                if (filesfolderLIST.SelectedItem == null) {
                    MessageBox.Show("Seleccione fichero");
                    return;
                }

                System.IO.FileInfo thisFile = new FileInfo(filesfolderLIST.SelectedItem.ToString());

                if (thisFile.Exists) {
                    contentfileTXT.Text = System.IO.File.ReadAllText(thisFile.FullName);
                }
            }
            catch {
                MessageBox.Show("Es un directorio");
            }
        }

        /*
         * MODIFICAR EL CONTENIDO DE UN FICHERO
         * Permite al usuario modificar el contenido del fichero seleccionado
         */
        private void modifyfileBTN_Click(object sender, EventArgs e) {
            try {
                if (filesfolderLIST.SelectedItem == null) {
                    MessageBox.Show("Seleccione fichero");
                    return;
                }

                System.IO.FileInfo thisFile = new FileInfo(filesfolderLIST.SelectedItem.ToString());

                if (thisFile.Exists) {
                    System.IO.File.WriteAllText(thisFile.FullName, contentfileTXT.Text);
                }
            }
            catch {
                MessageBox.Show("Es un directorio");
            }
        }

    }
}
