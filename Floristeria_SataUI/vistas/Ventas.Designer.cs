namespace Floristeria_SataUI.Vistas
{
    partial class Ventas
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
            this.Flow_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.sataTextBox1 = new SATATextBox();
            this.btnCarrito = new FrameworkTest.SATAButton();
            this.SuspendLayout();
            // 
            // Flow_panel
            // 
            this.Flow_panel.Location = new System.Drawing.Point(34, 69);
            this.Flow_panel.Name = "Flow_panel";
            this.Flow_panel.Size = new System.Drawing.Size(1102, 707);
            this.Flow_panel.TabIndex = 3;
            // 
            // sataTextBox1
            // 
            this.sataTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.sataTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.sataTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(171)))), ((int)(((byte)(21)))));
            this.sataTextBox1.BorderRadius = 15;
            this.sataTextBox1.BorderSize = 1;
            this.sataTextBox1.Icon = global::Floristeria_SataUI.Properties.Resources.Buscar;
            this.sataTextBox1.IconSize = new System.Drawing.Size(20, 20);
            this.sataTextBox1.Location = new System.Drawing.Point(34, 20);
            this.sataTextBox1.Multiline = false;
            this.sataTextBox1.Name = "sataTextBox1";
            this.sataTextBox1.PasswordChar = false;
            this.sataTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.sataTextBox1.PlaceholderText = "Buscar...";
            this.sataTextBox1.Size = new System.Drawing.Size(250, 31);
            this.sataTextBox1.TabIndex = 5;
            this.sataTextBox1.Text = "sataTextBox1";
            this.sataTextBox1.Texts = "";
            this.sataTextBox1.UnderlinedStyle = false;
            // 
            // btnCarrito
            // 
            this.btnCarrito.ButtonText = "";
            this.btnCarrito.CheckedBackground = System.Drawing.Color.Transparent;
            this.btnCarrito.CheckedForeColor = System.Drawing.Color.Transparent;
            this.btnCarrito.CheckedImageTint = System.Drawing.Color.Transparent;
            this.btnCarrito.CheckedOutline = System.Drawing.Color.Transparent;
            this.btnCarrito.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCarrito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCarrito.HoverBackground = System.Drawing.Color.Transparent;
            this.btnCarrito.HoverForeColor = System.Drawing.Color.Transparent;
            this.btnCarrito.HoverImage = null;
            this.btnCarrito.HoverImageTint = System.Drawing.Color.Transparent;
            this.btnCarrito.HoverOutline = System.Drawing.Color.Empty;
            this.btnCarrito.Image = global::Floristeria_SataUI.Properties.Resources.Carrito1;
            this.btnCarrito.ImageAutoCenter = true;
            this.btnCarrito.ImageExpand = new System.Drawing.Point(8, 8);
            this.btnCarrito.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCarrito.ImageTint = System.Drawing.Color.Black;
            this.btnCarrito.IsToggleButton = false;
            this.btnCarrito.IsToggled = false;
            this.btnCarrito.Location = new System.Drawing.Point(1100, 16);
            this.btnCarrito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.NormalBackground = System.Drawing.Color.Transparent;
            this.btnCarrito.NormalForeColor = System.Drawing.Color.Transparent;
            this.btnCarrito.NormalOutline = System.Drawing.Color.Empty;
            this.btnCarrito.OutlineThickness = 2F;
            this.btnCarrito.PressedBackground = System.Drawing.Color.Transparent;
            this.btnCarrito.PressedForeColor = System.Drawing.Color.Transparent;
            this.btnCarrito.PressedImageTint = System.Drawing.Color.Transparent;
            this.btnCarrito.PressedOutline = System.Drawing.Color.Empty;
            this.btnCarrito.Rounding = new System.Windows.Forms.Padding(5);
            this.btnCarrito.Size = new System.Drawing.Size(36, 38);
            this.btnCarrito.TabIndex = 4;
            this.btnCarrito.TextAutoCenter = true;
            this.btnCarrito.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1173, 807);
            this.Controls.Add(this.sataTextBox1);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.Flow_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ventas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow_panel;
        private FrameworkTest.SATAButton btnCarrito;
        private SATATextBox sataTextBox1;
    }
}