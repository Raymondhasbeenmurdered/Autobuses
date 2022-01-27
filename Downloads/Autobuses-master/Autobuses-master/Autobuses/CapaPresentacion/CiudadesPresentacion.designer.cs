
namespace CapaPresentacion
{
    partial class CiudadesPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new FontAwesome.Sharp.IconButton();
            this.buttonNuevo = new FontAwesome.Sharp.IconButton();
            this.buttonEditar = new FontAwesome.Sharp.IconButton();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.comboBoxCodigo = new System.Windows.Forms.ComboBox();
            this.panelNombre = new System.Windows.Forms.Panel();
            this.panelRegion = new System.Windows.Forms.Panel();
            this.labelCiudades = new System.Windows.Forms.Label();
            this.tablaCiudades = new System.Windows.Forms.DataGridView();
            this.panelNombre.SuspendLayout();
            this.panelRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(7, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 19);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegion.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtRegion.ForeColor = System.Drawing.Color.Gray;
            this.txtRegion.Location = new System.Drawing.Point(9, 8);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(284, 19);
            this.txtRegion.TabIndex = 48;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(110)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.buttonEliminar.IconColor = System.Drawing.Color.White;
            this.buttonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEliminar.IconSize = 36;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(376, 581);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonEliminar.Size = new System.Drawing.Size(154, 42);
            this.buttonEliminar.TabIndex = 50;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonNuevo.FlatAppearance.BorderSize = 0;
            this.buttonNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(110)))));
            this.buttonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonNuevo.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.buttonNuevo.IconColor = System.Drawing.Color.White;
            this.buttonNuevo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonNuevo.IconSize = 36;
            this.buttonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonNuevo.Location = new System.Drawing.Point(29, 581);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonNuevo.Size = new System.Drawing.Size(154, 42);
            this.buttonNuevo.TabIndex = 51;
            this.buttonNuevo.Text = "NUEVO";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(110)))));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.buttonEditar.IconColor = System.Drawing.Color.White;
            this.buttonEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonEditar.IconSize = 36;
            this.buttonEditar.Location = new System.Drawing.Point(202, 581);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonEditar.Size = new System.Drawing.Size(154, 42);
            this.buttonEditar.TabIndex = 52;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(110)))));
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.buttonGuardar.IconColor = System.Drawing.Color.White;
            this.buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonGuardar.IconSize = 36;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(571, 581);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonGuardar.Size = new System.Drawing.Size(304, 42);
            this.buttonGuardar.TabIndex = 53;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.Gray;
            this.labelCodigo.Location = new System.Drawing.Point(569, 137);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(61, 20);
            this.labelCodigo.TabIndex = 54;
            this.labelCodigo.Text = "CÓDIGO";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Gray;
            this.labelNombre.Location = new System.Drawing.Point(567, 220);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 20);
            this.labelNombre.TabIndex = 55;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion.ForeColor = System.Drawing.Color.Gray;
            this.labelRegion.Location = new System.Drawing.Point(570, 311);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(60, 20);
            this.labelRegion.TabIndex = 56;
            this.labelRegion.Text = "REGIÓN";
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtBuscador.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscador.Location = new System.Drawing.Point(612, 61);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(252, 19);
            this.txtBuscador.TabIndex = 58;
            this.txtBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonBuscar.FlatAppearance.BorderSize = 0;
            this.iconButtonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.iconButtonBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.Gray;
            this.iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBuscar.IconSize = 36;
            this.iconButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonBuscar.Location = new System.Drawing.Point(571, 47);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButtonBuscar.Size = new System.Drawing.Size(304, 47);
            this.iconButtonBuscar.TabIndex = 57;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            // 
            // comboBoxCodigo
            // 
            this.comboBoxCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodigo.DropDownWidth = 200;
            this.comboBoxCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxCodigo.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxCodigo.FormattingEnabled = true;
            this.comboBoxCodigo.IntegralHeight = false;
            this.comboBoxCodigo.ItemHeight = 20;
            this.comboBoxCodigo.Location = new System.Drawing.Point(571, 164);
            this.comboBoxCodigo.Name = "comboBoxCodigo";
            this.comboBoxCodigo.Size = new System.Drawing.Size(134, 28);
            this.comboBoxCodigo.TabIndex = 62;
            // 
            // panelNombre
            // 
            this.panelNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNombre.Controls.Add(this.txtNombre);
            this.panelNombre.Location = new System.Drawing.Point(571, 243);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(304, 34);
            this.panelNombre.TabIndex = 63;
            // 
            // panelRegion
            // 
            this.panelRegion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRegion.Controls.Add(this.txtRegion);
            this.panelRegion.Location = new System.Drawing.Point(571, 334);
            this.panelRegion.Name = "panelRegion";
            this.panelRegion.Size = new System.Drawing.Size(304, 34);
            this.panelRegion.TabIndex = 64;
            // 
            // labelCiudades
            // 
            this.labelCiudades.AutoSize = true;
            this.labelCiudades.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(8)))));
            this.labelCiudades.Location = new System.Drawing.Point(24, 47);
            this.labelCiudades.Name = "labelCiudades";
            this.labelCiudades.Size = new System.Drawing.Size(155, 37);
            this.labelCiudades.TabIndex = 65;
            this.labelCiudades.Text = "CIUDADES";
            // 
            // tablaCiudades
            // 
            this.tablaCiudades.AllowUserToAddRows = false;
            this.tablaCiudades.AllowUserToDeleteRows = false;
            this.tablaCiudades.AllowUserToResizeColumns = false;
            this.tablaCiudades.AllowUserToResizeRows = false;
            this.tablaCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCiudades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaCiudades.BackgroundColor = System.Drawing.Color.White;
            this.tablaCiudades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCiudades.CausesValidation = false;
            this.tablaCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCiudades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCiudades.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCiudades.EnableHeadersVisualStyles = false;
            this.tablaCiudades.GridColor = System.Drawing.Color.WhiteSmoke;
            this.tablaCiudades.Location = new System.Drawing.Point(31, 138);
            this.tablaCiudades.Name = "tablaCiudades";
            this.tablaCiudades.ReadOnly = true;
            this.tablaCiudades.RowHeadersVisible = false;
            this.tablaCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCiudades.Size = new System.Drawing.Size(499, 424);
            this.tablaCiudades.TabIndex = 68;
            this.tablaCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCiudades_CellClick);
            // 
            // CiudadesPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.Controls.Add(this.tablaCiudades);
            this.Controls.Add(this.comboBoxCodigo);
            this.Controls.Add(this.labelCiudades);
            this.Controls.Add(this.panelRegion);
            this.Controls.Add(this.panelNombre);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CiudadesPresentacion";
            this.Text = "FormCiudades";
            this.Load += new System.EventHandler(this.FormCiudades_Load);
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            this.panelRegion.ResumeLayout(false);
            this.panelRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRegion;
        private FontAwesome.Sharp.IconButton buttonEliminar;
        private FontAwesome.Sharp.IconButton buttonNuevo;
        private FontAwesome.Sharp.IconButton buttonEditar;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.TextBox txtBuscador;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.ComboBox comboBoxCodigo;
        private System.Windows.Forms.Panel panelNombre;
        private System.Windows.Forms.Panel panelRegion;
        private System.Windows.Forms.Label labelCiudades;
        private System.Windows.Forms.DataGridView tablaCiudades;
    }
}