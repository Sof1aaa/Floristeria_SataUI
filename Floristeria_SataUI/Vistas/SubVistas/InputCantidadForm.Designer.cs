namespace Floristeria_SataUI.Vistas.SubVistas
{
    partial class InputCantidadForm
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
            SATAUiFramework.BorderRadius borderRadius3 = new SATAUiFramework.BorderRadius();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.btnSalir = new FrameworkTest.SATAButton();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new SATATextBox();
            this.sataButton1 = new FrameworkTest.SATAButton();
            this.sataButton2 = new FrameworkTest.SATAButton();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(73)))));
            this.sataPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(73)))));
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius3.BottomLeft = 10;
            borderRadius3.BottomRight = 10;
            borderRadius3.TopLeft = 10;
            borderRadius3.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius3;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.btnSalir);
            this.sataPanel1.Location = new System.Drawing.Point(-13, -7);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(597, 36);
            this.sataPanel1.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonText = "";
            this.btnSalir.CheckedBackground = System.Drawing.Color.DarkOliveGreen;
            this.btnSalir.CheckedForeColor = System.Drawing.Color.White;
            this.btnSalir.CheckedImageTint = System.Drawing.Color.White;
            this.btnSalir.CheckedOutline = System.Drawing.Color.DarkOliveGreen;
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
            this.btnSalir.Location = new System.Drawing.Point(731, 8);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NormalBackground = System.Drawing.Color.DarkOliveGreen;
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
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(67)))));
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.txtCantidad.BorderRadius = 5;
            this.txtCantidad.BorderSize = 2;
            this.txtCantidad.Icon = null;
            this.txtCantidad.IconSize = new System.Drawing.Size(20, 20);
            this.txtCantidad.Location = new System.Drawing.Point(24, 80);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.Size = new System.Drawing.Size(327, 33);
            this.txtCantidad.TabIndex = 25;
            this.txtCantidad.Text = "sataTextBox1";
            this.txtCantidad.Texts = "";
            this.txtCantidad.UnderlinedStyle = false;
            // 
            // sataButton1
            // 
            this.sataButton1.ButtonText = "Aceptar";
            this.sataButton1.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton1.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton1.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton1.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.sataButton1.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sataButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.sataButton1.HoverForeColor = System.Drawing.Color.White;
            this.sataButton1.HoverImage = null;
            this.sataButton1.HoverImageTint = System.Drawing.Color.White;
            this.sataButton1.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton1.Image = null;
            this.sataButton1.ImageAutoCenter = true;
            this.sataButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton1.ImageTint = System.Drawing.Color.White;
            this.sataButton1.IsToggleButton = false;
            this.sataButton1.IsToggled = false;
            this.sataButton1.Location = new System.Drawing.Point(24, 132);
            this.sataButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataButton1.Name = "sataButton1";
            this.sataButton1.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton1.NormalForeColor = System.Drawing.Color.White;
            this.sataButton1.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton1.OutlineThickness = 2F;
            this.sataButton1.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton1.PressedForeColor = System.Drawing.Color.White;
            this.sataButton1.PressedImageTint = System.Drawing.Color.White;
            this.sataButton1.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton1.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton1.Size = new System.Drawing.Size(154, 31);
            this.sataButton1.TabIndex = 29;
            this.sataButton1.TextAutoCenter = true;
            this.sataButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton1.Click += new System.EventHandler(this.sataButton1_Click);
            // 
            // sataButton2
            // 
            this.sataButton2.ButtonText = "Cancelar";
            this.sataButton2.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton2.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton2.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton2.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.sataButton2.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sataButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.sataButton2.HoverForeColor = System.Drawing.Color.White;
            this.sataButton2.HoverImage = null;
            this.sataButton2.HoverImageTint = System.Drawing.Color.White;
            this.sataButton2.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton2.Image = null;
            this.sataButton2.ImageAutoCenter = true;
            this.sataButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton2.ImageTint = System.Drawing.Color.White;
            this.sataButton2.IsToggleButton = false;
            this.sataButton2.IsToggled = false;
            this.sataButton2.Location = new System.Drawing.Point(196, 132);
            this.sataButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataButton2.Name = "sataButton2";
            this.sataButton2.NormalBackground = System.Drawing.Color.LightCoral;
            this.sataButton2.NormalForeColor = System.Drawing.Color.White;
            this.sataButton2.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton2.OutlineThickness = 2F;
            this.sataButton2.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton2.PressedForeColor = System.Drawing.Color.White;
            this.sataButton2.PressedImageTint = System.Drawing.Color.White;
            this.sataButton2.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton2.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton2.Size = new System.Drawing.Size(154, 31);
            this.sataButton2.TabIndex = 30;
            this.sataButton2.TextAutoCenter = true;
            this.sataButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton2.Click += new System.EventHandler(this.sataButton2_Click);
            // 
            // InputCantidadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 184);
            this.Controls.Add(this.sataButton2);
            this.Controls.Add(this.sataButton1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputCantidadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioGeneral";
            this.sataPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SATAUiFramework.SATAPanel sataPanel1;
        private FrameworkTest.SATAButton btnSalir;
        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private System.Windows.Forms.Label label1;
        private SATATextBox txtCantidad;
        private FrameworkTest.SATAButton sataButton1;
        private FrameworkTest.SATAButton sataButton2;
    }
}