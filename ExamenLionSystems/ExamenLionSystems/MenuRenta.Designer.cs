namespace ExamenLionSystems
{
    partial class MenuRenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRenta));
            this.button_Reservar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.label_salasDisponibles = new System.Windows.Forms.Label();
            this.listView_SalasDisponibles = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button_Reservar
            // 
            this.button_Reservar.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reservar.Location = new System.Drawing.Point(12, 405);
            this.button_Reservar.Name = "button_Reservar";
            this.button_Reservar.Size = new System.Drawing.Size(450, 48);
            this.button_Reservar.TabIndex = 0;
            this.button_Reservar.Text = "Reservar Sala";
            this.button_Reservar.UseVisualStyleBackColor = true;
            this.button_Reservar.Click += new System.EventHandler(this.button_Reservar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.Location = new System.Drawing.Point(468, 405);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(121, 48);
            this.button_Salir.TabIndex = 1;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // label_salasDisponibles
            // 
            this.label_salasDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.label_salasDisponibles.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_salasDisponibles.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salasDisponibles.Location = new System.Drawing.Point(0, 0);
            this.label_salasDisponibles.Name = "label_salasDisponibles";
            this.label_salasDisponibles.Size = new System.Drawing.Size(601, 77);
            this.label_salasDisponibles.TabIndex = 3;
            this.label_salasDisponibles.Text = "Salas de Juntas Disponibles";
            this.label_salasDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView_SalasDisponibles
            // 
            this.listView_SalasDisponibles.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_SalasDisponibles.AutoArrange = false;
            this.listView_SalasDisponibles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_SalasDisponibles.BackgroundImage")));
            this.listView_SalasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_SalasDisponibles.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_SalasDisponibles.Location = new System.Drawing.Point(12, 75);
            this.listView_SalasDisponibles.Name = "listView_SalasDisponibles";
            this.listView_SalasDisponibles.Size = new System.Drawing.Size(577, 301);
            this.listView_SalasDisponibles.TabIndex = 2;
            this.listView_SalasDisponibles.UseCompatibleStateImageBehavior = false;
            this.listView_SalasDisponibles.View = System.Windows.Forms.View.List;
            // 
            // MenuRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 465);
            this.Controls.Add(this.label_salasDisponibles);
            this.Controls.Add(this.listView_SalasDisponibles);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Reservar);
            this.Name = "MenuRenta";
            this.Text = "Salas Disponibles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Reservar;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Label label_salasDisponibles;
        private System.Windows.Forms.ListView listView_SalasDisponibles;
    }
}