namespace Agenda
{
    partial class frmAC
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPaterno = new TextBox();
            label3 = new Label();
            txtMaterno = new TextBox();
            label4 = new Label();
            mtbCurp = new MaskedTextBox();
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            label6 = new Label();
            cmbSexo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 31);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 3;
            label2.Text = "Ap. Paterno";
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(12, 116);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(207, 31);
            txtPaterno.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 5;
            label3.Text = "Ap. Materno";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(12, 193);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(207, 31);
            txtMaterno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 7;
            label4.Text = "CURP";
            // 
            // mtbCurp
            // 
            mtbCurp.Location = new Point(12, 272);
            mtbCurp.Name = "mtbCurp";
            mtbCurp.Size = new Size(207, 31);
            mtbCurp.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 25);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 9;
            label5.Text = "Fecha de Nacimiento";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(318, 53);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(339, 31);
            dtpFecha.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 98);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 11;
            label6.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "", "Hombre", "Mujer" });
            cmbSexo.Location = new Point(318, 124);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(182, 33);
            cmbSexo.TabIndex = 12;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(417, 270);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(545, 270);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 314);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbSexo);
            Controls.Add(label6);
            Controls.Add(dtpFecha);
            Controls.Add(label5);
            Controls.Add(mtbCurp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMaterno);
            Controls.Add(label2);
            Controls.Add(txtPaterno);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmAC";
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtPaterno;
        private Label label3;
        private TextBox txtMaterno;
        private Label label4;
        private MaskedTextBox mtbCurp;
        private Label label5;
        private DateTimePicker dtpFecha;
        private Label label6;
        private ComboBox cmbSexo;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}