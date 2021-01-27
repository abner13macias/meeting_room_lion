namespace ExamenLionSystems
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label_softwareName = new System.Windows.Forms.Label();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.button_Liberar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_softwareName
            // 
            this.label_softwareName.BackColor = System.Drawing.Color.Transparent;
            this.label_softwareName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_softwareName.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_softwareName.Location = new System.Drawing.Point(0, 0);
            this.label_softwareName.Name = "label_softwareName";
            this.label_softwareName.Size = new System.Drawing.Size(623, 77);
            this.label_softwareName.TabIndex = 0;
            this.label_softwareName.Text = "Sistema de Sala de Juntas";
            this.label_softwareName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Consultar
            // 
            this.button_Consultar.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Consultar.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Consultar.Location = new System.Drawing.Point(0, 77);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(206, 409);
            this.button_Consultar.TabIndex = 1;
            this.button_Consultar.Text = "Ver Salas Disponibles";
            this.button_Consultar.UseVisualStyleBackColor = true;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // button_Registrar
            // 
            this.button_Registrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Registrar.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Registrar.Location = new System.Drawing.Point(206, 77);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(206, 409);
            this.button_Registrar.TabIndex = 2;
            this.button_Registrar.Text = "Rentar una Sala";
            this.button_Registrar.UseVisualStyleBackColor = true;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click);
            // 
            // button_Liberar
            // 
            this.button_Liberar.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Liberar.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Liberar.Location = new System.Drawing.Point(412, 77);
            this.button_Liberar.Name = "button_Liberar";
            this.button_Liberar.Size = new System.Drawing.Size(211, 409);
            this.button_Liberar.TabIndex = 3;
            this.button_Liberar.Text = "Liberar una Sala";
            this.button_Liberar.UseVisualStyleBackColor = true;
            this.button_Liberar.Click += new System.EventHandler(this.button_Liberar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 486);
            this.Controls.Add(this.button_Liberar);
            this.Controls.Add(this.button_Registrar);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.label_softwareName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Abner Yael Díaz de León Macias - Examen ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_softwareName;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.Button button_Registrar;
        private System.Windows.Forms.Button button_Liberar;
    }
}

