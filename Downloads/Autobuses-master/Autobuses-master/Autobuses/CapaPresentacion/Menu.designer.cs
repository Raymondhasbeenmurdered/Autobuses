
namespace CapaPresentacion
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonUsuarios = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.buttonLogout = new FontAwesome.Sharp.IconButton();
            this.buttonConfiguracion = new FontAwesome.Sharp.IconButton();
            this.buttonBoletos = new FontAwesome.Sharp.IconButton();
            this.buttonIntermitentes = new FontAwesome.Sharp.IconButton();
            this.buttonAutobuses = new FontAwesome.Sharp.IconButton();
            this.buttonRutas = new FontAwesome.Sharp.IconButton();
            this.buttonAsistentes = new FontAwesome.Sharp.IconButton();
            this.buttonConductores = new FontAwesome.Sharp.IconButton();
            this.buttonSucursales = new FontAwesome.Sharp.IconButton();
            this.buttonParadas = new FontAwesome.Sharp.IconButton();
            this.buttonCiudades = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.titleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonCerrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCerrar.IconSize = 30;
            this.buttonCerrar.Location = new System.Drawing.Point(1110, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.buttonCerrar.Size = new System.Drawing.Size(30, 30);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.buttonUsuarios);
            this.panel1.Controls.Add(this.iconButtonMenu);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonConfiguracion);
            this.panel1.Controls.Add(this.buttonBoletos);
            this.panel1.Controls.Add(this.buttonIntermitentes);
            this.panel1.Controls.Add(this.buttonAutobuses);
            this.panel1.Controls.Add(this.buttonRutas);
            this.panel1.Controls.Add(this.buttonAsistentes);
            this.panel1.Controls.Add(this.buttonConductores);
            this.panel1.Controls.Add(this.buttonSucursales);
            this.panel1.Controls.Add(this.buttonParadas);
            this.panel1.Controls.Add(this.buttonCiudades);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 650);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(15, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 3);
            this.panel2.TabIndex = 3;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(28, 107);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(155, 23);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario - Rol";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.FlatAppearance.BorderSize = 0;
            this.buttonUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarios.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.buttonUsuarios.IconColor = System.Drawing.Color.White;
            this.buttonUsuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonUsuarios.IconSize = 36;
            this.buttonUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUsuarios.Location = new System.Drawing.Point(0, 540);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonUsuarios.Size = new System.Drawing.Size(220, 40);
            this.buttonUsuarios.TabIndex = 11;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.CausesValidation = false;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.iconButtonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            this.iconButtonMenu.IconColor = System.Drawing.Color.White;
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonMenu.IconSize = 100;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonMenu.Location = new System.Drawing.Point(52, 8);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Size = new System.Drawing.Size(111, 100);
            this.iconButtonMenu.TabIndex = 3;
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.buttonLogout.IconColor = System.Drawing.Color.White;
            this.buttonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLogout.IconSize = 36;
            this.buttonLogout.Location = new System.Drawing.Point(46, 610);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(40, 40);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.buttonConfiguracion.IconColor = System.Drawing.Color.White;
            this.buttonConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonConfiguracion.IconSize = 36;
            this.buttonConfiguracion.Location = new System.Drawing.Point(0, 610);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(40, 40);
            this.buttonConfiguracion.TabIndex = 9;
            this.buttonConfiguracion.UseVisualStyleBackColor = true;
            this.buttonConfiguracion.Click += new System.EventHandler(this.buttonConfiguracion_Click);
            // 
            // buttonBoletos
            // 
            this.buttonBoletos.FlatAppearance.BorderSize = 0;
            this.buttonBoletos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonBoletos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBoletos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoletos.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBoletos.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.buttonBoletos.IconColor = System.Drawing.Color.White;
            this.buttonBoletos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBoletos.IconSize = 36;
            this.buttonBoletos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonBoletos.Location = new System.Drawing.Point(0, 499);
            this.buttonBoletos.Name = "buttonBoletos";
            this.buttonBoletos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonBoletos.Size = new System.Drawing.Size(220, 40);
            this.buttonBoletos.TabIndex = 5;
            this.buttonBoletos.Text = "Boletos";
            this.buttonBoletos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBoletos.UseVisualStyleBackColor = true;
            this.buttonBoletos.Click += new System.EventHandler(this.buttonBoletos_Click);
            // 
            // buttonIntermitentes
            // 
            this.buttonIntermitentes.FlatAppearance.BorderSize = 0;
            this.buttonIntermitentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonIntermitentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonIntermitentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIntermitentes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIntermitentes.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIntermitentes.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
            this.buttonIntermitentes.IconColor = System.Drawing.Color.White;
            this.buttonIntermitentes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonIntermitentes.IconSize = 36;
            this.buttonIntermitentes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonIntermitentes.Location = new System.Drawing.Point(0, 376);
            this.buttonIntermitentes.Name = "buttonIntermitentes";
            this.buttonIntermitentes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonIntermitentes.Size = new System.Drawing.Size(220, 40);
            this.buttonIntermitentes.TabIndex = 5;
            this.buttonIntermitentes.Text = "Paradas intermitentes";
            this.buttonIntermitentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIntermitentes.UseVisualStyleBackColor = true;
            this.buttonIntermitentes.Click += new System.EventHandler(this.buttonParadasIntermitentes_Click);
            // 
            // buttonAutobuses
            // 
            this.buttonAutobuses.FlatAppearance.BorderSize = 0;
            this.buttonAutobuses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonAutobuses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonAutobuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutobuses.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutobuses.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAutobuses.IconChar = FontAwesome.Sharp.IconChar.Bus;
            this.buttonAutobuses.IconColor = System.Drawing.Color.White;
            this.buttonAutobuses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAutobuses.IconSize = 36;
            this.buttonAutobuses.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAutobuses.Location = new System.Drawing.Point(0, 417);
            this.buttonAutobuses.Name = "buttonAutobuses";
            this.buttonAutobuses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAutobuses.Size = new System.Drawing.Size(220, 40);
            this.buttonAutobuses.TabIndex = 7;
            this.buttonAutobuses.Text = "Autobuses";
            this.buttonAutobuses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAutobuses.UseVisualStyleBackColor = true;
            this.buttonAutobuses.Click += new System.EventHandler(this.buttonAutobuses_Click);
            // 
            // buttonRutas
            // 
            this.buttonRutas.FlatAppearance.BorderSize = 0;
            this.buttonRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRutas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutas.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRutas.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.buttonRutas.IconColor = System.Drawing.Color.White;
            this.buttonRutas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRutas.IconSize = 36;
            this.buttonRutas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRutas.Location = new System.Drawing.Point(0, 458);
            this.buttonRutas.Name = "buttonRutas";
            this.buttonRutas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRutas.Size = new System.Drawing.Size(220, 40);
            this.buttonRutas.TabIndex = 8;
            this.buttonRutas.Text = "Rutas";
            this.buttonRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRutas.UseVisualStyleBackColor = true;
            this.buttonRutas.Click += new System.EventHandler(this.buttonRutas_Click);
            // 
            // buttonAsistentes
            // 
            this.buttonAsistentes.FlatAppearance.BorderSize = 0;
            this.buttonAsistentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonAsistentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonAsistentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsistentes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsistentes.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAsistentes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.buttonAsistentes.IconColor = System.Drawing.Color.White;
            this.buttonAsistentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAsistentes.IconSize = 36;
            this.buttonAsistentes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAsistentes.Location = new System.Drawing.Point(0, 335);
            this.buttonAsistentes.Name = "buttonAsistentes";
            this.buttonAsistentes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAsistentes.Size = new System.Drawing.Size(220, 40);
            this.buttonAsistentes.TabIndex = 8;
            this.buttonAsistentes.Text = "Asistentes";
            this.buttonAsistentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAsistentes.UseVisualStyleBackColor = true;
            this.buttonAsistentes.Click += new System.EventHandler(this.buttonAsistentes_Click);
            // 
            // buttonConductores
            // 
            this.buttonConductores.FlatAppearance.BorderSize = 0;
            this.buttonConductores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonConductores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConductores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConductores.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConductores.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.buttonConductores.IconColor = System.Drawing.Color.White;
            this.buttonConductores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonConductores.IconSize = 36;
            this.buttonConductores.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConductores.Location = new System.Drawing.Point(0, 294);
            this.buttonConductores.Name = "buttonConductores";
            this.buttonConductores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonConductores.Size = new System.Drawing.Size(219, 40);
            this.buttonConductores.TabIndex = 7;
            this.buttonConductores.Text = "Conductores";
            this.buttonConductores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConductores.UseVisualStyleBackColor = true;
            this.buttonConductores.Click += new System.EventHandler(this.buttonConductores_Click);
            // 
            // buttonSucursales
            // 
            this.buttonSucursales.FlatAppearance.BorderSize = 0;
            this.buttonSucursales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonSucursales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSucursales.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSucursales.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSucursales.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.buttonSucursales.IconColor = System.Drawing.Color.White;
            this.buttonSucursales.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonSucursales.IconSize = 36;
            this.buttonSucursales.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSucursales.Location = new System.Drawing.Point(0, 253);
            this.buttonSucursales.Name = "buttonSucursales";
            this.buttonSucursales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSucursales.Size = new System.Drawing.Size(219, 40);
            this.buttonSucursales.TabIndex = 6;
            this.buttonSucursales.Text = "Sucursales";
            this.buttonSucursales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSucursales.UseVisualStyleBackColor = true;
            this.buttonSucursales.Click += new System.EventHandler(this.buttonSucursales_Click);
            // 
            // buttonParadas
            // 
            this.buttonParadas.FlatAppearance.BorderSize = 0;
            this.buttonParadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonParadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonParadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParadas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParadas.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonParadas.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.buttonParadas.IconColor = System.Drawing.Color.White;
            this.buttonParadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonParadas.IconSize = 36;
            this.buttonParadas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonParadas.Location = new System.Drawing.Point(0, 212);
            this.buttonParadas.Name = "buttonParadas";
            this.buttonParadas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonParadas.Size = new System.Drawing.Size(220, 40);
            this.buttonParadas.TabIndex = 5;
            this.buttonParadas.Text = "Paradas";
            this.buttonParadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonParadas.UseVisualStyleBackColor = true;
            this.buttonParadas.Click += new System.EventHandler(this.buttonParadas_Click);
            // 
            // buttonCiudades
            // 
            this.buttonCiudades.FlatAppearance.BorderSize = 0;
            this.buttonCiudades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonCiudades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonCiudades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCiudades.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCiudades.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCiudades.IconChar = FontAwesome.Sharp.IconChar.City;
            this.buttonCiudades.IconColor = System.Drawing.Color.White;
            this.buttonCiudades.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonCiudades.IconSize = 36;
            this.buttonCiudades.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCiudades.Location = new System.Drawing.Point(0, 171);
            this.buttonCiudades.Name = "buttonCiudades";
            this.buttonCiudades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCiudades.Size = new System.Drawing.Size(219, 40);
            this.buttonCiudades.TabIndex = 4;
            this.buttonCiudades.Text = " Ciudades";
            this.buttonCiudades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCiudades.UseVisualStyleBackColor = true;
            this.buttonCiudades.Click += new System.EventHandler(this.buttonCiudades_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.CausesValidation = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Maroon;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 300;
            this.iconButton2.Location = new System.Drawing.Point(323, 196);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(287, 287);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.titleBar.Controls.Add(this.buttonMinimize);
            this.titleBar.Controls.Add(this.buttonCerrar);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1140, 30);
            this.titleBar.TabIndex = 5;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMinimize.IconSize = 30;
            this.buttonMinimize.Location = new System.Drawing.Point(1076, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.buttonMinimize.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.iconButton2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(220, 30);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(920, 650);
            this.panelChildForm.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 680);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIENVENDOS";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonCerrar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton buttonCiudades;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private FontAwesome.Sharp.IconButton buttonBoletos;
        private FontAwesome.Sharp.IconButton buttonIntermitentes;
        private FontAwesome.Sharp.IconButton buttonAutobuses;
        private FontAwesome.Sharp.IconButton buttonRutas;
        private FontAwesome.Sharp.IconButton buttonAsistentes;
        private FontAwesome.Sharp.IconButton buttonConductores;
        private FontAwesome.Sharp.IconButton buttonSucursales;
        private FontAwesome.Sharp.IconButton buttonParadas;
        private FontAwesome.Sharp.IconButton buttonLogout;
        private FontAwesome.Sharp.IconButton buttonConfiguracion;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private FontAwesome.Sharp.IconButton buttonUsuarios;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel panel2;
    }
}

