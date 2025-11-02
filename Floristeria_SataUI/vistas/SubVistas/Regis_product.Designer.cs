namespace Floristeria_SataUI.Vistas.SubVistas
{
    partial class Regis_product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.btnSalir = new FrameworkTest.SATAButton();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Combo_categoria = new SATAComboBox();
            this.Img_button = new FrameworkTest.SATAButton();
            this.Regis_btn = new FrameworkTest.SATAButton();
            this.Txt_nombre_prod = new SATATextBox();
            this.Txt_Descripcion = new SATATextBox();
            this.txt_Precio = new SATATextBox();
            this.txt_Stock = new SATATextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(73)))));
            this.sataPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(73)))));
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius1;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.btnSalir);
            this.sataPanel1.Location = new System.Drawing.Point(-13, -7);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(992, 36);
            this.sataPanel1.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonText = "";
            this.btnSalir.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(73)))));
            this.btnSalir.CheckedForeColor = System.Drawing.Color.White;
            this.btnSalir.CheckedImageTint = System.Drawing.Color.White;
            this.btnSalir.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(73)))));
            this.btnSalir.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSalir.HoverForeColor = System.Drawing.Color.White;
            this.btnSalir.HoverImage = null;
            this.btnSalir.HoverImageTint = System.Drawing.Color.White;
            this.btnSalir.HoverOutline = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Floristeria_SataUI.Properties.Resources.x;
            this.btnSalir.ImageAutoCenter = true;
            this.btnSalir.ImageExpand = new System.Drawing.Point(3, 3);
            this.btnSalir.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSalir.ImageTint = System.Drawing.Color.White;
            this.btnSalir.IsToggleButton = false;
            this.btnSalir.IsToggled = false;
            this.btnSalir.Location = new System.Drawing.Point(940, 11);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(73)))));
            this.btnSalir.NormalForeColor = System.Drawing.Color.White;
            this.btnSalir.NormalOutline = System.Drawing.Color.Empty;
            this.btnSalir.OutlineThickness = 2F;
            this.btnSalir.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSalir.PressedForeColor = System.Drawing.Color.White;
            this.btnSalir.PressedImageTint = System.Drawing.Color.White;
            this.btnSalir.PressedOutline = System.Drawing.Color.Empty;
            this.btnSalir.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSalir.Size = new System.Drawing.Size(27, 25);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.TextAutoCenter = true;
            this.btnSalir.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 35;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Formulario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(39, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(39, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Precio";
            // 
            // Combo_categoria
            // 
            this.Combo_categoria.BackColor = System.Drawing.Color.Transparent;
            this.Combo_categoria.BackgroundColor = System.Drawing.Color.White;
            this.Combo_categoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.Combo_categoria.BorderThickness = 2;
            this.Combo_categoria.CornerRadius = 5;
            this.Combo_categoria.Items = null;
            this.Combo_categoria.Keys = null;
            this.Combo_categoria.Location = new System.Drawing.Point(41, 496);
            this.Combo_categoria.Name = "Combo_categoria";
            this.Combo_categoria.SelectedIndex = -1;
            this.Combo_categoria.Size = new System.Drawing.Size(402, 33);
            this.Combo_categoria.TabIndex = 24;
            this.Combo_categoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Combo_categoria.TextOffset = new System.Windows.Forms.Padding(0);
            // 
            // Img_button
            // 
            this.Img_button.ButtonText = "Cargar imagen";
            this.Img_button.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.Img_button.CheckedForeColor = System.Drawing.Color.White;
            this.Img_button.CheckedImageTint = System.Drawing.Color.White;
            this.Img_button.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.Img_button.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.Img_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Img_button.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Img_button.HoverForeColor = System.Drawing.Color.White;
            this.Img_button.HoverImage = null;
            this.Img_button.HoverImageTint = System.Drawing.Color.White;
            this.Img_button.HoverOutline = System.Drawing.Color.Empty;
            this.Img_button.Image = null;
            this.Img_button.ImageAutoCenter = true;
            this.Img_button.ImageExpand = new System.Drawing.Point(0, 0);
            this.Img_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.Img_button.ImageTint = System.Drawing.Color.White;
            this.Img_button.IsToggleButton = false;
            this.Img_button.IsToggled = false;
            this.Img_button.Location = new System.Drawing.Point(547, 414);
            this.Img_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Img_button.Name = "Img_button";
            this.Img_button.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.Img_button.NormalForeColor = System.Drawing.Color.White;
            this.Img_button.NormalOutline = System.Drawing.Color.Empty;
            this.Img_button.OutlineThickness = 2F;
            this.Img_button.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.Img_button.PressedForeColor = System.Drawing.Color.White;
            this.Img_button.PressedImageTint = System.Drawing.Color.White;
            this.Img_button.PressedOutline = System.Drawing.Color.Empty;
            this.Img_button.Rounding = new System.Windows.Forms.Padding(5);
            this.Img_button.Size = new System.Drawing.Size(360, 63);
            this.Img_button.TabIndex = 29;
            this.Img_button.TextAutoCenter = true;
            this.Img_button.TextOffset = new System.Drawing.Point(0, 0);
            this.Img_button.Click += new System.EventHandler(this.Img_button_Click_1);
            // 
            // Regis_btn
            // 
            this.Regis_btn.ButtonText = "Registrar";
            this.Regis_btn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            this.Regis_btn.CheckedForeColor = System.Drawing.Color.White;
            this.Regis_btn.CheckedImageTint = System.Drawing.Color.White;
            this.Regis_btn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            this.Regis_btn.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.Regis_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Regis_btn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            this.Regis_btn.HoverForeColor = System.Drawing.Color.White;
            this.Regis_btn.HoverImage = null;
            this.Regis_btn.HoverImageTint = System.Drawing.Color.White;
            this.Regis_btn.HoverOutline = System.Drawing.Color.Empty;
            this.Regis_btn.Image = null;
            this.Regis_btn.ImageAutoCenter = true;
            this.Regis_btn.ImageExpand = new System.Drawing.Point(0, 0);
            this.Regis_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.Regis_btn.ImageTint = System.Drawing.Color.White;
            this.Regis_btn.IsToggleButton = false;
            this.Regis_btn.IsToggled = false;
            this.Regis_btn.Location = new System.Drawing.Point(696, 545);
            this.Regis_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Regis_btn.Name = "Regis_btn";
            this.Regis_btn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(30)))));
            this.Regis_btn.NormalForeColor = System.Drawing.Color.White;
            this.Regis_btn.NormalOutline = System.Drawing.Color.Empty;
            this.Regis_btn.OutlineThickness = 2F;
            this.Regis_btn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            this.Regis_btn.PressedForeColor = System.Drawing.Color.White;
            this.Regis_btn.PressedImageTint = System.Drawing.Color.White;
            this.Regis_btn.PressedOutline = System.Drawing.Color.Empty;
            this.Regis_btn.Rounding = new System.Windows.Forms.Padding(5);
            this.Regis_btn.Size = new System.Drawing.Size(211, 60);
            this.Regis_btn.TabIndex = 31;
            this.Regis_btn.TextAutoCenter = true;
            this.Regis_btn.TextOffset = new System.Drawing.Point(0, 0);
            this.Regis_btn.Click += new System.EventHandler(this.Regis_btn_Click_1);
            // 
            // Txt_nombre_prod
            // 
            this.Txt_nombre_prod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.Txt_nombre_prod.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.Txt_nombre_prod.BorderRadius = 5;
            this.Txt_nombre_prod.BorderSize = 2;
            this.Txt_nombre_prod.Icon = null;
            this.Txt_nombre_prod.IconSize = new System.Drawing.Size(20, 20);
            this.Txt_nombre_prod.Location = new System.Drawing.Point(41, 113);
            this.Txt_nombre_prod.Multiline = false;
            this.Txt_nombre_prod.Name = "Txt_nombre_prod";
            this.Txt_nombre_prod.PasswordChar = false;
            this.Txt_nombre_prod.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_nombre_prod.PlaceholderText = "";
            this.Txt_nombre_prod.Size = new System.Drawing.Size(403, 33);
            this.Txt_nombre_prod.TabIndex = 32;
            this.Txt_nombre_prod.Text = "sataTextBox1";
            this.Txt_nombre_prod.Texts = "";
            this.Txt_nombre_prod.UnderlinedStyle = false;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.Txt_Descripcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.Txt_Descripcion.BorderRadius = 5;
            this.Txt_Descripcion.BorderSize = 2;
            this.Txt_Descripcion.Icon = null;
            this.Txt_Descripcion.IconSize = new System.Drawing.Size(20, 20);
            this.Txt_Descripcion.Location = new System.Drawing.Point(41, 194);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.PasswordChar = false;
            this.Txt_Descripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_Descripcion.PlaceholderText = "";
            this.Txt_Descripcion.Size = new System.Drawing.Size(402, 78);
            this.Txt_Descripcion.TabIndex = 33;
            this.Txt_Descripcion.Text = "sataTextBox2";
            this.Txt_Descripcion.Texts = "";
            this.Txt_Descripcion.UnderlinedStyle = false;
            // 
            // txt_Precio
            // 
            this.txt_Precio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.txt_Precio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.txt_Precio.BorderRadius = 5;
            this.txt_Precio.BorderSize = 2;
            this.txt_Precio.Icon = null;
            this.txt_Precio.IconSize = new System.Drawing.Size(20, 20);
            this.txt_Precio.Location = new System.Drawing.Point(42, 322);
            this.txt_Precio.Multiline = false;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.PasswordChar = false;
            this.txt_Precio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Precio.PlaceholderText = "";
            this.txt_Precio.Size = new System.Drawing.Size(401, 33);
            this.txt_Precio.TabIndex = 34;
            this.txt_Precio.Text = "sataTextBox4";
            this.txt_Precio.Texts = "";
            this.txt_Precio.UnderlinedStyle = false;
            // 
            // txt_Stock
            // 
            this.txt_Stock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.txt_Stock.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.txt_Stock.BorderRadius = 5;
            this.txt_Stock.BorderSize = 2;
            this.txt_Stock.Icon = null;
            this.txt_Stock.IconSize = new System.Drawing.Size(20, 20);
            this.txt_Stock.Location = new System.Drawing.Point(41, 414);
            this.txt_Stock.Multiline = false;
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.PasswordChar = false;
            this.txt_Stock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Stock.PlaceholderText = "";
            this.txt_Stock.Size = new System.Drawing.Size(401, 33);
            this.txt_Stock.TabIndex = 35;
            this.txt_Stock.Text = "sataTextBox3";
            this.txt_Stock.Texts = "";
            this.txt_Stock.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(547, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Regis_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 667);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_nombre_prod);
            this.Controls.Add(this.Regis_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Img_button);
            this.Controls.Add(this.Combo_categoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Regis_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioGeneral";
            this.Load += new System.EventHandler(this.Regis_product_Load);
            this.sataPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SATAUiFramework.SATAPanel sataPanel1;
        private FrameworkTest.SATAButton btnSalir;
        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SATAComboBox Combo_categoria;
        private FrameworkTest.SATAButton Img_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FrameworkTest.SATAButton Regis_btn;
        private SATATextBox Txt_nombre_prod;
        private SATATextBox Txt_Descripcion;
        private SATATextBox txt_Precio;
        private SATATextBox txt_Stock;
    }
}