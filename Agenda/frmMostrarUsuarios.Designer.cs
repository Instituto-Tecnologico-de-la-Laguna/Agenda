namespace Agenda
{
    partial class frmMostrarUsuarios
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
            components = new System.ComponentModel.Container();
            dgvUsuarios = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuEditar = new ToolStripMenuItem();
            toolStripMenuEliminar = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.ContextMenuStrip = contextMenuStrip1;
            dgvUsuarios.Location = new Point(0, 63);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(1128, 375);
            dgvUsuarios.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuEditar, toolStripMenuEliminar });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(241, 101);
            // 
            // toolStripMenuEditar
            // 
            toolStripMenuEditar.Name = "toolStripMenuEditar";
            toolStripMenuEditar.Size = new Size(240, 32);
            toolStripMenuEditar.Text = "Editar";
            toolStripMenuEditar.Click += toolStripMenuEditar_Click;
            // 
            // toolStripMenuEliminar
            // 
            toolStripMenuEliminar.Name = "toolStripMenuEliminar";
            toolStripMenuEliminar.Size = new Size(240, 32);
            toolStripMenuEliminar.Text = "Eliminar";
            // 
            // frmMostrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 450);
            Controls.Add(dgvUsuarios);
            Name = "frmMostrarUsuarios";
            Text = "Mostrar Usuarios";
            Load += frmMostrarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuEditar;
        private ToolStripMenuItem toolStripMenuEliminar;
    }
}