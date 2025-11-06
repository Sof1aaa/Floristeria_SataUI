namespace Floristeria_SataUI.Vistas
{
    partial class Empleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrear = new FrameworkTest.SATAButton();
            this.sataTextBox1 = new SATATextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 707);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnCrear
            // 
            this.btnCrear.ButtonText = "Registrar empleado";
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
            this.btnCrear.TabIndex = 6;
            this.btnCrear.TextAutoCenter = true;
            this.btnCrear.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            this.sataTextBox1.Location = new System.Drawing.Point(34, 24);
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
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1173, 807);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.sataTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SATATextBox sataTextBox1;
        private FrameworkTest.SATAButton btnCrear;
    }
}