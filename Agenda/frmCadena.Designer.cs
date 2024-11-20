namespace Agenda
{
    partial class frmCadena
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
            btnClave = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClave
            // 
            btnClave.Location = new Point(178, 94);
            btnClave.Name = "btnClave";
            btnClave.Size = new Size(189, 46);
            btnClave.TabIndex = 0;
            btnClave.Text = "Obtener Clave";
            btnClave.UseVisualStyleBackColor = true;
            btnClave.Click += btnClave_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(355, 31);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // frmCadena
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 174);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnClave);
            Name = "frmCadena";
            Text = "Cadenas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClave;
        private TextBox txtNombre;
        private Label label1;
    }
}