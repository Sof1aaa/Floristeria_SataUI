using Floristeria_SataUI.Controllers_query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria_SataUI.Vistas.SubVistas
{
    public partial class Regis_empleado : Form
    {

        private const string IMG_FOLDER_NAME = "Empleados_img";
        private readonly string imagesFolderPath;
        private string imageFileName = string.Empty;
        private string fileRoute = string.Empty;
        public Regis_empleado()
        {
            imagesFolderPath = Path.Combine(Application.StartupPath, IMG_FOLDER_NAME);
            InitializeComponent();
            this.sataPanel1.MouseDown += Form1_MouseDown;
        }



        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Img_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    cargar_imagen(openFileDialog.FileName, EventArgs.Empty);
                }
            }
        }


        public void cargar_imagen(object sender, EventArgs e)
        {
            try
            {
                string sourceFilePath = sender.ToString();
                string imagesFolderPath = Path.Combine(Application.StartupPath, "Empleados");

                if (!Directory.Exists(imagesFolderPath))
                    Directory.CreateDirectory(imagesFolderPath);

                imageFileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(imagesFolderPath, imageFileName);

                File.Copy(sourceFilePath, destinationFilePath, true);
                string relativePath = Path.Combine("Empleados", imageFileName);
                fileRoute = relativePath;

                img_load(destinationFilePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void img_load(string img_path)
        {
            try
            {
                using (var tempimg = Image.FromFile(img_path))
                {
                    pictureBox1.Image = new Bitmap(tempimg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                pictureBox1.Image = null;
            }
        }

        private void sataButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Texts))
            {
                MessageBox.Show("Por favor, ingrese el nombre del empleado.");
                return;

            }
            if (string.IsNullOrEmpty(txt_last.Texts))
            {
                MessageBox.Show("Por favor, ingrese el apellido del empleado.");
                return;
            }
            if (string.IsNullOrEmpty(txt_id.Texts))
            {
                MessageBox.Show("Por favor, ingrese el documento de usuario.");
                return;
            }
            if (Combo_charge.SelectedItem == null)
            {
                MessageBox.Show("Por favor, ingrese el cargo del empleado.");
                return;
            }
            if (string.IsNullOrEmpty(Txt_pass.Texts))
            {
                MessageBox.Show("Por favor, ingrese la contraseña del empleado.");
                return;
            }
            if (string.IsNullOrEmpty(fileRoute))
            {
                MessageBox.Show("Por favor, cargue una imagen del empleado.");
                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Seleccione una imagen del producto.");
                return;
            }

          
            try
            {
                string cargo = Combo_charge.SelectedItem.ToString();
                string imgPath = fileRoute;
                security security = new security();
                string pass = security.HashPassword(Txt_pass.Texts.Trim());

                if (string.IsNullOrWhiteSpace(imgPath))
                {
                    MessageBox.Show("No se encontró la ruta de la imagen. Asegúrate de haberla cargado correctamente.");
                    return;
                }

                if (!int.TryParse(txt_id.Texts.Trim(), out int doc))
                {
                    MessageBox.Show("El documento debe ser un número entero válido.");
                    return;
                }

                if (!int.TryParse(Txt_tel.Texts.Trim(), out int tel))
                {
                    MessageBox.Show("El telefono debe ser un número entero válido.");
                    return;
                }

                controllers_query.query_employee query = new controllers_query.query_employee();

                query.insertar_employee(doc, txt_name.Texts, txt_last.Texts, cargo, tel,pass, imgPath);
                MessageBox.Show(" ✅ Empleado registrado con éxito.");
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(" ❌ Error al registrar el empleado: " + ex.Message);
                return;




            }
        }

        private void sataButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
