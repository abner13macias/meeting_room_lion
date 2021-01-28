namespace ExamenLionSystems
{
    partial class MenuLiberar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLiberar));
            this.label_salasOcupadas = new System.Windows.Forms.Label();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_Liberar = new System.Windows.Forms.Button();
            this.listView_SalasOcupadas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label_salasOcupadas
            // 
            this.label_salasOcupadas.BackColor = System.Drawing.Color.Transparent;
            this.label_salasOcupadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_salasOcupadas.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salasOcupadas.Location = new System.Drawing.Point(0, 0);
            this.label_salasOcupadas.Name = "label_salasOcupadas";
            this.label_salasOcupadas.Size = new System.Drawing.Size(601, 77);
            this.label_salasOcupadas.TabIndex = 4;
            this.label_salasOcupadas.Text = "Salas de Juntas Ocupadas";
            this.label_salasOcupadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Salir
            // 
            this.button_Salir.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.Location = new System.Drawing.Point(468, 405);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(121, 48);
            this.button_Salir.TabIndex = 5;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // button_Liberar
            // 
            this.button_Liberar.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Liberar.Location = new System.Drawing.Point(8, 405);
            this.button_Liberar.Name = "button_Liberar";
            this.button_Liberar.Size = new System.Drawing.Size(450, 48);
            this.button_Liberar.TabIndex = 6;
            this.button_Liberar.Text = "Liberar Sala";
            this.button_Liberar.UseVisualStyleBackColor = true;
            this.button_Liberar.Click += new System.EventHandler(this.button_Liberar_Click);
            // 
            // listView_SalasOcupadas
            // 
            this.listView_SalasOcupadas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_SalasOcupadas.AutoArrange = false;
            this.listView_SalasOcupadas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_SalasOcupadas.BackgroundImage")));
            this.listView_SalasOcupadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_SalasOcupadas.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_SalasOcupadas.Location = new System.Drawing.Point(12, 82);
            this.listView_SalasOcupadas.Name = "listView_SalasOcupadas";
            this.listView_SalasOcupadas.Size = new System.Drawing.Size(577, 301);
            this.listView_SalasOcupadas.TabIndex = 7;
            this.listView_SalasOcupadas.UseCompatibleStateImageBehavior = false;
            this.listView_SalasOcupadas.View = System.Windows.Forms.View.List;
            // 
            // MenuLiberar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 465);
            this.Controls.Add(this.listView_SalasOcupadas);
            this.Controls.Add(this.button_Liberar);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.label_salasOcupadas);
            this.Name = "MenuLiberar";
            this.Text = "MenuLiberar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_salasOcupadas;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_Liberar;
        private System.Windows.Forms.ListView listView_SalasOcupadas;
    }
}