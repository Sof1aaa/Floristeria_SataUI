namespace ProyectoFinal
{
    partial class Empleados_2
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
            this.btnCrear = new FrameworkTest.SATAButton();
            this.SuspendLayout();
            // 
            // Flow_panel
            // 
            this.Flow_panel.Location = new System.Drawing.Point(34, 69);
            this.Flow_panel.Name = "Flow_panel";
            this.Flow_panel.Size = new System.Drawing.Size(1102, 707);
            this.Flow_panel.TabIndex = 2;
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
            this.sataTextBox1.TabIndex = 3;
            this.sataTextBox1.Text = "sataTextBox1";
            this.sataTextBox1.Texts = "";
            this.sataTextBox1.UnderlinedStyle = false;
            // 
            // btnCrear
            // 
            this.btnCrear.ButtonText = "Registrar producto";
            this.btnCrear.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnCrear.CheckedForeColor = System.Drawing.Color.White;
            this.btnCrear.CheckedImageTint = System.Drawing.Color.White;
            this.btnCrear.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnCrear.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrear.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnCrear.HoverForeColor = System.Drawing.Color.White;
            this.btnCrear.HoverImage = null;
            this.btnCrear.HoverImageTint = System.Drawing.Color.White;
            this.btnCrear.HoverOutline = System.Drawing.Color.Empty;
            this.btnCrear.Image = null;
            this.btnCrear.ImageAutoCenter = true;
            this.btnCrear.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCrear.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCrear.ImageTint = System.Drawing.Color.White;
            this.btnCrear.IsToggleButton = false;
            this.btnCrear.IsToggled = false;
            this.btnCrear.Location = new System.Drawing.Point(1015, 12);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnCrear.NormalForeColor = System.Drawing.Color.White;
            this.btnCrear.NormalOutline = System.Drawing.Color.Empty;
            this.btnCrear.OutlineThickness = 2F;
            this.btnCrear.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnCrear.PressedForeColor = System.Drawing.Color.White;
            this.btnCrear.PressedImageTint = System.Drawing.Color.White;
            this.btnCrear.PressedOutline = System.Drawing.Color.Empty;
            this.btnCrear.Rounding = new System.Windows.Forms.Padding(5);
            this.btnCrear.Size = new System.Drawing.Size(121, 41);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.TextAutoCenter = true;
            this.btnCrear.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // Empleados_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1173, 807);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.sataTextBox1);
            this.Controls.Add(this.Flow_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Empleados_2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Flow_panel;
        private SATATextBox sataTextBox1;
        private FrameworkTest.SATAButton btnCrear;
    }
}