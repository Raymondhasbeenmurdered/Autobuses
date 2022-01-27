namespace CapaPresentacion
{
    partial class RutasPresentacion
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
            this.labelRutas = new System.Windows.Forms.Label();
            this.tablaRutas = new System.Windows.Forms.DataGridView();
            this.buttonNuevo = new FontAwesome.Sharp.IconButton();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.buttonEditar = new FontAwesome.Sharp.IconButton();
            this.buttonEliminar = new FontAwesome.Sharp.IconButton();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCodigo = new System.Windows.Forms.ComboBox();
            this.panelNombre = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.comboBoxParadaIntermedia = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.comboBoxAutobus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutas)).BeginInit();
            this.panelNombre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRutas
            // 
            this.labelRutas.AutoSize = true;
            this.labelRutas.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(8)))));
            this.labelRutas.Location = new System.Drawing.Point(23, 47);
            this.labelRutas.Name = "labelRutas";
            this.labelRutas.Size = new System.Drawing.Size(108, 37);
            this.labelRutas.TabIndex = 66;
            this.labelRutas.Text = "RUTAS";
            // 
            // tablaRutas
            // 
            this.tablaRutas.AllowUserToAddRows = false;
            this.tablaRutas.AllowUserToDeleteRows = false;
            this.tablaRutas.AllowUserToResizeColumns = false;
            this.tablaRutas.AllowUserToResizeRows = false;
            this.tablaRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaRutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaRutas.BackgroundColor = System.Drawing.Color.White;
            this.tablaRutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaRutas.CausesValidation = false;
            this.tablaRutas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaRutas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaRutas.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaRutas.EnableHeadersVisualStyles = false;
            this.tablaRutas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.tablaRutas.Location = new System.Drawing.Point(29, 264);
            this.tablaRutas.Name = "tablaRutas";
            this.tablaRutas.ReadOnly = true;
            this.tablaRutas.RowHeadersVisible = false;
            this.tablaRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRutas.Size = new System.Drawing.Size(674, 286);
            this.tablaRutas.TabIndex = 67;
            this.tablaRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRutas_CellClick);
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
            this.buttonNuevo.TabIndex = 68;
            this.buttonNuevo.Text = "NUEVO";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
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
            this.buttonGuardar.TabIndex = 71;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
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
            this.buttonEditar.TabIndex = 70;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
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
            this.buttonEliminar.TabIndex = 69;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtBuscador.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscador.Location = new System.Drawing.Point(615, 65);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(254, 19);
            this.txtBuscador.TabIndex = 80;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonBuscar.FlatAppearance.BorderSize = 0;
            this.iconButtonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.iconButtonBuscar.TabIndex = 79;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(739, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "AUTOBUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(737, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "CIUDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(619, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "DESTINO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(737, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "PARADA INTERMEDIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(323, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "PARTIDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(26, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 82;
            this.label6.Text = "CÓDIGO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(26, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "NOMBRE";
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
            this.comboBoxCodigo.Location = new System.Drawing.Point(29, 130);
            this.comboBoxCodigo.Name = "comboBoxCodigo";
            this.comboBoxCodigo.Size = new System.Drawing.Size(134, 28);
            this.comboBoxCodigo.TabIndex = 88;
            // 
            // panelNombre
            // 
            this.panelNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNombre.Controls.Add(this.txtNombre);
            this.panelNombre.Location = new System.Drawing.Point(29, 204);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(259, 34);
            this.panelNombre.TabIndex = 89;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(10, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 19);
            this.txtNombre.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtPartida);
            this.panel1.Location = new System.Drawing.Point(327, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 34);
            this.panel1.TabIndex = 64;
            // 
            // txtPartida
            // 
            this.txtPartida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartida.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtPartida.ForeColor = System.Drawing.Color.Gray;
            this.txtPartida.Location = new System.Drawing.Point(9, 7);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(233, 19);
            this.txtPartida.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtDestino);
            this.panel2.Location = new System.Drawing.Point(623, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 34);
            this.panel2.TabIndex = 64;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestino.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtDestino.ForeColor = System.Drawing.Color.Gray;
            this.txtDestino.Location = new System.Drawing.Point(8, 7);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(236, 19);
            this.txtDestino.TabIndex = 26;
            // 
            // comboBoxParadaIntermedia
            // 
            this.comboBoxParadaIntermedia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxParadaIntermedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParadaIntermedia.DropDownWidth = 200;
            this.comboBoxParadaIntermedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxParadaIntermedia.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxParadaIntermedia.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxParadaIntermedia.FormattingEnabled = true;
            this.comboBoxParadaIntermedia.IntegralHeight = false;
            this.comboBoxParadaIntermedia.ItemHeight = 20;
            this.comboBoxParadaIntermedia.Location = new System.Drawing.Point(741, 297);
            this.comboBoxParadaIntermedia.Name = "comboBoxParadaIntermedia";
            this.comboBoxParadaIntermedia.Size = new System.Drawing.Size(134, 28);
            this.comboBoxParadaIntermedia.TabIndex = 90;
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiudad.DropDownWidth = 200;
            this.comboBoxCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCiudad.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxCiudad.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.IntegralHeight = false;
            this.comboBoxCiudad.ItemHeight = 20;
            this.comboBoxCiudad.Location = new System.Drawing.Point(741, 402);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(134, 28);
            this.comboBoxCiudad.TabIndex = 91;
            // 
            // comboBoxAutobus
            // 
            this.comboBoxAutobus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxAutobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutobus.DropDownWidth = 200;
            this.comboBoxAutobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAutobus.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxAutobus.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxAutobus.FormattingEnabled = true;
            this.comboBoxAutobus.IntegralHeight = false;
            this.comboBoxAutobus.ItemHeight = 20;
            this.comboBoxAutobus.Location = new System.Drawing.Point(741, 522);
            this.comboBoxAutobus.Name = "comboBoxAutobus";
            this.comboBoxAutobus.Size = new System.Drawing.Size(134, 28);
            this.comboBoxAutobus.TabIndex = 92;
            // 
            // RutasPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.Controls.Add(this.comboBoxAutobus);
            this.Controls.Add(this.comboBoxCiudad);
            this.Controls.Add(this.comboBoxParadaIntermedia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNombre);
            this.Controls.Add(this.comboBoxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.tablaRutas);
            this.Controls.Add(this.labelRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RutasPresentacion";
            this.Text = "PresentacionRuta";
            this.Load += new System.EventHandler(this.PresentacionRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutas)).EndInit();
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRutas;
        private System.Windows.Forms.DataGridView tablaRutas;
        private FontAwesome.Sharp.IconButton buttonNuevo;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private FontAwesome.Sharp.IconButton buttonEditar;
        private FontAwesome.Sharp.IconButton buttonEliminar;
        private System.Windows.Forms.TextBox txtBuscador;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCodigo;
        private System.Windows.Forms.Panel panelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.ComboBox comboBoxParadaIntermedia;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.ComboBox comboBoxAutobus;
    }
}