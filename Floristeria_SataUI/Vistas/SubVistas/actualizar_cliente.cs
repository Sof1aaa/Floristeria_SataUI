using Floristeria_SataUI.controllers_query;
using Floristeria_SataUI.models;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Floristeria_SataUI.Vistas.SubVistas
{
    public partial class actualizar_cliente : Form
    {
        private const string IMG_FOLDER_NAME = "Clientes_img";
        private readonly string imagesFolderPath;
        private string imageFileName = string.Empty;
        private string fileRoute = string.Empty;

        public actualizar_cliente()
        {
            imagesFolderPath = Path.Combine(Application.StartupPath, IMG_FOLDER_NAME);
            InitializeComponent();
            this.sataPanel1.MouseDown += Form1_MouseDown;
        }

        string imagenAnterior = "";
        string documentoCliente = "";

        public void LoadCliente(string documento)
        {
            documentoCliente = documento;

            query_cliente query = new query_cliente();
            var cliente = query.get_cliente_byid(documento);

            if (cliente != null)
            {
                txt_name.Texts = cliente.Nombre;
                txt_last.Texts = cliente.Apellido;
                Txt_tel.Texts = cliente.Telefono.ToString();
                Txt_email.Texts = cliente.Email;
                Txt_direccion.Texts = cliente.Direccion;

                imagenAnterior = cliente.Foto; // guardar foto anterior

                if (!string.IsNullOrEmpty(cliente.Foto) && File.Exists(cliente.Foto))
                    pictureBox1.ImageLocation = cliente.Foto;
                else
                    pictureBox1.BackColor = Color.LightGray;
            }
            else
            {
                MessageBox.Show("No se encontró el cliente.");
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
                    CargarImagen(openFileDialog.FileName);
                }
            }
        }

        public void CargarImagen(string sourceFilePath)
        {
            try
            {
                string imagesFolderPath = Path.Combine(Application.StartupPath, IMG_FOLDER_NAME);

                if (!Directory.Exists(imagesFolderPath))
                    Directory.CreateDirectory(imagesFolderPath);

                imageFileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(imagesFolderPath, imageFileName);

                File.Copy(sourceFilePath, destinationFilePath, true);
                fileRoute = destinationFilePath;

                pictureBox1.Image = new Bitmap(destinationFilePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                pictureBox1.Image = null;
            }
        }

        private void sataButton1_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrEmpty(txt_name.Texts) ||
                string.IsNullOrEmpty(txt_last.Texts) ||
                string.IsNullOrEmpty(Txt_tel.Texts) ||
                string.IsNullOrEmpty(Txt_email.Texts) ||
                string.IsNullOrEmpty(Txt_direccion.Texts))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (!long.TryParse(Txt_tel.Texts.Trim(), out long telefono))
            {
                MessageBox.Show("Teléfono no válido.");
                return;
            }

            string imgPath = string.IsNullOrEmpty(fileRoute) ? imagenAnterior : fileRoute;

            query_cliente query = new query_cliente();
            query.UpdateCliente(documentoCliente, txt_name.Texts, txt_last.Texts,
                                Txt_tel.Texts, Txt_email.Texts, Txt_direccion.Texts, imgPath);

            MessageBox.Show("✅ Cliente actualizado con éxito.");
            this.Close();
        }

        private void sataButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
