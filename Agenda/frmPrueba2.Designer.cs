namespace Agenda
{
    partial class frmPrueba2
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
            btnAdministrador = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdministrador
            // 
            btnAdministrador.Location = new Point(485, 297);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(112, 34);
            btnAdministrador.TabIndex = 0;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(42, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 181);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmPrueba2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 353);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdministrador);
            Name = "frmPrueba2";
            Text = "frmPrueba2";
            Load += frmPrueba2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdministrador;
        private PictureBox pictureBox1;
    }
}