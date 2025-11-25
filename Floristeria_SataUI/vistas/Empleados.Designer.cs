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
            this.btnCrear = new FrameworkTest.SATAButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnCrear.Location = new System.Drawing.Point(1019, 9);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCrear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 70);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 737);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(34, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 7;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1173, 807);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FrameworkTest.SATAButton btnCrear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}