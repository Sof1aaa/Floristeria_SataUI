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
    public partial class Actualizar : Form
    {
        private const string IMG_FOLDER_NAME = "Img";
        private readonly string imagesFolderPath;
        private string imageFileName = string.Empty;
        private string fileRoute = string.Empty;
        public Actualizar(int id)
        {
            InitializeComponent();
            this.sataPanel1.MouseDown += Form1_MouseDown;



            load_txt(id);
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





        string imagenAnterior = "";

        public void load_txt(int id)
        {
            Querys_produ query = new Querys_produ();
            var producto = query.get_all_products_by_id(id).FirstOrDefault();

            if (producto != null)
            {
                Txt_nombre_prod.Texts = producto.Nombre;
                Txt_Descripcion.Texts = producto.Descripcion;
                txt_Precio.Texts = producto.Precio.ToString();
                txt_Stock.Texts = producto.Stock.ToString();

                
                Combo_categoria.SelectedItem = producto.Categoria;

                pictureBox1.ImageLocation = producto.Imagen;
                id_product.Text = id.ToString();
                imagenAnterior = producto.Imagen;
            }
        }


        public void actualizar_btn_Click(object sender, EventArgs e)
        {

        }


        public void cargar_imagen(object sender, EventArgs e)
        {
            try
            {
                string sourceFilePath = sender.ToString();


                string imagesFolderPath = Path.Combine(Application.StartupPath, "imagenes");

                if (!Directory.Exists(imagesFolderPath))
                {
                    Directory.CreateDirectory(imagesFolderPath);
                }


                imageFileName = Path.GetFileName(sourceFilePath);


                string destinationFilePath = Path.Combine(imagesFolderPath, imageFileName);


                File.Copy(sourceFilePath, destinationFilePath, true);


                string relativePath = Path.Combine("imagenes", imageFileName);


                fileRoute = relativePath;

                img_load(destinationFilePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = fileRoute;

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




       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Img_button_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    cargar_imagen(openFileDialog.FileName, EventArgs.Empty);
                }
            }
        }

        private void Regis_btn_Click_1(object sender, EventArgs e)
        {
            if (Txt_nombre_prod.Texts == "" || Txt_Descripcion.Texts == "" || txt_Precio.Texts == "" || txt_Stock.Texts == "" || Combo_categoria.SelectedItem == null || pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else
            {
                string nombre = Txt_nombre_prod.Texts;
                string descripcion = Txt_Descripcion.Texts;
                decimal precio = Convert.ToDecimal(txt_Precio.Texts);
                int stock = Convert.ToInt32(txt_Stock.Texts);
                string categoria = Combo_categoria.SelectedItem.ToString();
                int id = Convert.ToInt32(id_product.Text);

                string imgPath = "";


                if (string.IsNullOrEmpty(fileRoute))
                {
                    imgPath = imagenAnterior;
                }
                else
                {
                    imgPath = fileRoute;
                }

                Querys_produ querys = new Controllers_query.Querys_produ();
                querys.update(id, nombre, descripcion, precio, stock, categoria, imgPath);

                this.Close();
            }
        }
    }
}
