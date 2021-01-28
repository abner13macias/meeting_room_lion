namespace ExamenLionSystems
{
    partial class MenuSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSalas));
            this.label_salasTotales = new System.Windows.Forms.Label();
            this.button_Salir = new System.Windows.Forms.Button();
            this.listView_InfoSalas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label_salasTotales
            // 
            this.label_salasTotales.BackColor = System.Drawing.Color.Transparent;
            this.label_salasTotales.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_salasTotales.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salasTotales.Location = new System.Drawing.Point(0, 0);
            this.label_salasTotales.Name = "label_salasTotales";
            this.label_salasTotales.Size = new System.Drawing.Size(601, 77);
            this.label_salasTotales.TabIndex = 4;
            this.label_salasTotales.Text = "Salas de Juntas ";
            this.label_salasTotales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // listView_InfoSalas
            // 
            this.listView_InfoSalas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_InfoSalas.AutoArrange = false;
            this.listView_InfoSalas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_InfoSalas.BackgroundImage")));
            this.listView_InfoSalas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_InfoSalas.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_InfoSalas.Location = new System.Drawing.Point(12, 82);
            this.listView_InfoSalas.Name = "listView_InfoSalas";
            this.listView_InfoSalas.Size = new System.Drawing.Size(577, 301);
            this.listView_InfoSalas.TabIndex = 6;
            this.listView_InfoSalas.UseCompatibleStateImageBehavior = false;
            this.listView_InfoSalas.View = System.Windows.Forms.View.List;
            // 
            // MenuSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 465);
            this.Controls.Add(this.listView_InfoSalas);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.label_salasTotales);
            this.Name = "MenuSalas";
            this.Text = "Información de Salas de Juntas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_salasTotales;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.ListView listView_InfoSalas;
    }
}