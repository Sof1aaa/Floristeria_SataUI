using Floristeria_SataUI.controllers_query;
using Floristeria_SataUI.Controllers_query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria_SataUI.Vistas.SubVistas
{
    public partial class actualizar_empleado : Form
    {

        private const string IMG_FOLDER_NAME = "Empleados_img";
        private readonly string imagesFolderPath;
        private string imageFileName = string.Empty;
        private string fileRoute = string.Empty;
        public actualizar_empleado()
        {
            imagesFolderPath = Path.Combine(Application.StartupPath, IMG_FOLDER_NAME);
            InitializeComponent();
            this.sataPanel1.MouseDown += Form1_MouseDown;
        }

        string imagenAnterior = "";
        long idEmpleado = 0;

        public void load_txt(long id)
        {
            idEmpleado = id;

            query_employee query = new query_employee();
            var employee = query.get_employee_byid(id).FirstOrDefault();

            if (employee != null)
            {
                txt_name.Texts = employee.Nombre;
                txt_last.Texts = employee.Apellido;
                Txt_tel.Texts = employee.telefono.ToString();
                Combo_charge.SelectedItem = employee.Cargo;

                imagenAnterior = employee.imagen; // <---- SIEMPRE GUARDAR

                if (!string.IsNullOrEmpty(employee.imagen) && File.Exists(employee.imagen))
                    pictureBox1.ImageLocation = employee.imagen;
                else
                    pictureBox1.BackColor = Color.LightGray;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado.");
            }
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
            if (string.IsNullOrEmpty(txt_name.Texts) || string.IsNullOrEmpty(txt_last.Texts) |Combo_charge.SelectedItem == null || string.IsNullOrEmpty(Txt_tel.Texts) || pictureBox1.Image == null)
            
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }
          

                string imgPath = string.IsNullOrEmpty(fileRoute) ? imagenAnterior : fileRoute;

            security security = new security();
            

            
                if(!long.TryParse(Txt_tel.Texts.Trim(), out long tel))
            {
                MessageBox.Show("Documento o teléfono no válidos.");
                return;
            }

            query_employee query = new query_employee();
            query.UpdateEmployee( idEmpleado ,txt_name.Texts, txt_last.Texts, Combo_charge.SelectedItem.ToString(), tel, imgPath);

            MessageBox.Show("✅ Empleado actualizado con éxito.");
            this.Close();
        }

        private void sataButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
