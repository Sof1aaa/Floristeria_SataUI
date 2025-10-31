using Floristeria_SataUI.Controllers_query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria_SataUI.Vistas.SubVistas
{
    public partial class Regis_product : Form
    {
        private const string IMG_FOLDER_NAME = "Img";
        private readonly string imagesFolderPath;
        private string imageFileName = string.Empty;
        private string fileRoute = string.Empty;
        public Regis_product()
        {
            imagesFolderPath = Path.Combine(Application.StartupPath, IMG_FOLDER_NAME);
            InitializeComponent();
        
            Combo_categoria.Items = new string[] { "Ramo" , "Ramillete" , "Peluche" , "Utileria" , "Detalles "};
            txt_Stock.KeyPress += SoloNumeros;
            txt_Precio.KeyPress += SoloNumeros;
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



        private void Regis_product_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public void cargar_imagen(object sender, EventArgs e)
        {
            try
            {
                string sourceFilePath = sender.ToString();
                string imagesFolderPath = Path.Combine(Application.StartupPath, "imagenes");

                if (!Directory.Exists(imagesFolderPath))
                    Directory.CreateDirectory(imagesFolderPath);

                imageFileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(imagesFolderPath, imageFileName);

                File.Copy(sourceFilePath, destinationFilePath, true);
                string relativePath = Path.Combine("imagenes", imageFileName);
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

        private void Img_button_Click_1(object sender, EventArgs e)
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

        private void Regis_btn_Click_1(object sender, EventArgs e)
        {
            // Validar campos vacíos individualmente
            if (string.IsNullOrWhiteSpace(Txt_nombre_prod.Texts))
            {
                MessageBox.Show("Falta el nombre del producto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Descripcion.Texts))
            {
                MessageBox.Show("Falta la descripción.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Precio.Texts))
            {
                MessageBox.Show("Falta el precio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Stock.Texts))
            {
                MessageBox.Show("Falta el stock.");
                return;
            }

            if (Combo_categoria.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Seleccione una imagen del producto.");
                return;
            }

            try
            {
                // Variables base
                string nombre = Txt_nombre_prod.Texts.Trim();
                string descripcion = Txt_Descripcion.Texts.Trim();

                // Limpiar y convertir precio
                string precioTexto = txt_Precio.Texts.Trim();
                precioTexto = precioTexto.Replace("$", "")
                                         .Replace("COP", "")
                                         .Replace(" ", "")
                                         .Replace(".", "")
                                         .Replace(",", ".")
                                         .Trim();

                if (!decimal.TryParse(precioTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio))
                {
                    MessageBox.Show($"El precio no tiene un formato válido. Valor ingresado: '{txt_Precio.Texts}'");
                    return;
                }

                // Validar stock
                if (!int.TryParse(txt_Stock.Texts.Trim(), out int stock))
                {
                    MessageBox.Show("El stock debe ser un número entero válido.");
                    return;
                }

                string categoria = Combo_categoria.SelectedItem.ToString();
                string imgPath = fileRoute; // asegúrate de que fileRoute tenga valor

                if (string.IsNullOrWhiteSpace(imgPath))
                {
                    MessageBox.Show("No se encontró la ruta de la imagen. Asegúrate de haberla cargado correctamente.");
                    return;
                }

                Querys_produ querys = new Querys_produ();
                querys.insertar_produ(nombre, descripcion, precio, stock, categoria, imgPath);

                MessageBox.Show("✅ Producto registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al registrar producto: " + ex.Message);
            }
        }

    }
}
