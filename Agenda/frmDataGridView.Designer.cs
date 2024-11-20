namespace Agenda
{
    partial class frmDataGridView
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
            dgPrueba = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            prueba = new DataGridViewTextBoxColumn();
            btnModificar = new Button();
            btnPrueba = new Button();
            btnOcultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPrueba).BeginInit();
            SuspendLayout();
            // 
            // dgPrueba
            // 
            dgPrueba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPrueba.Columns.AddRange(new DataGridViewColumn[] { Numero, prueba });
            dgPrueba.Location = new Point(12, 12);
            dgPrueba.Name = "dgPrueba";
            dgPrueba.RowHeadersWidth = 62;
            dgPrueba.Size = new Size(760, 225);
            dgPrueba.TabIndex = 0;
            // 
            // Numero
            // 
            Numero.HeaderText = "numero";
            Numero.MinimumWidth = 8;
            Numero.Name = "Numero";
            Numero.Width = 150;
            // 
            // prueba
            // 
            prueba.HeaderText = "prueba";
            prueba.MinimumWidth = 8;
            prueba.Name = "prueba";
            prueba.Width = 150;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(22, 253);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(220, 34);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar Propiedades";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(271, 253);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(112, 34);
            btnPrueba.TabIndex = 2;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // btnOcultar
            // 
            btnOcultar.Location = new Point(179, 311);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(112, 34);
            btnOcultar.TabIndex = 3;
            btnOcultar.Text = "Ocultar";
            btnOcultar.UseVisualStyleBackColor = true;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // frmDataGridView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 357);
            Controls.Add(btnOcultar);
            Controls.Add(btnPrueba);
            Controls.Add(btnModificar);
            Controls.Add(dgPrueba);
            Name = "frmDataGridView";
            Text = "frmDataGridView";
            ((System.ComponentModel.ISupportInitialize)dgPrueba).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPrueba;
        private Button btnModificar;
        private Button btnPrueba;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn prueba;
        private Button btnOcultar;
    }
}