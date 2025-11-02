namespace Floristeria_SataUI.Vistas.SubVistas
{
    partial class Details
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_product = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.des_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.stock_lbl = new System.Windows.Forms.Label();
            this.Tag_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.sataPanel1.Size = new System.Drawing.Size(823, 36);
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
            this.btnSalir.Location = new System.Drawing.Point(716, 11);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(50, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Precio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(346, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // id_product
            // 
            this.id_product.AutoSize = true;
            this.id_product.Location = new System.Drawing.Point(50, 508);
            this.id_product.Name = "id_product";
            this.id_product.Size = new System.Drawing.Size(35, 13);
            this.id_product.TabIndex = 36;
            this.id_product.Text = "label6";
            this.id_product.Visible = false;
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name_lbl.Location = new System.Drawing.Point(49, 98);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(86, 20);
            this.Name_lbl.TabIndex = 37;
            this.Name_lbl.Text = "Formulario";
            // 
            // des_lbl
            // 
            this.des_lbl.AutoSize = true;
            this.des_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.des_lbl.Location = new System.Drawing.Point(49, 189);
            this.des_lbl.Name = "des_lbl";
            this.des_lbl.Size = new System.Drawing.Size(86, 20);
            this.des_lbl.TabIndex = 38;
            this.des_lbl.Text = "Formulario";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Price_lbl.Location = new System.Drawing.Point(49, 276);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(86, 20);
            this.Price_lbl.TabIndex = 39;
            this.Price_lbl.Text = "Formulario";
            // 
            // stock_lbl
            // 
            this.stock_lbl.AutoSize = true;
            this.stock_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.stock_lbl.Location = new System.Drawing.Point(49, 370);
            this.stock_lbl.Name = "stock_lbl";
            this.stock_lbl.Size = new System.Drawing.Size(86, 20);
            this.stock_lbl.TabIndex = 40;
            this.stock_lbl.Text = "Formulario";
            // 
            // Tag_lbl
            // 
            this.Tag_lbl.AutoSize = true;
            this.Tag_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Tag_lbl.Location = new System.Drawing.Point(49, 454);
            this.Tag_lbl.Name = "Tag_lbl";
            this.Tag_lbl.Size = new System.Drawing.Size(86, 20);
            this.Tag_lbl.TabIndex = 41;
            this.Tag_lbl.Text = "Formulario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(50, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Categoria";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 570);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Tag_lbl);
            this.Controls.Add(this.stock_lbl);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.des_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.id_product);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label id_product;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Tag_lbl;
        private System.Windows.Forms.Label stock_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label des_lbl;
    }
}