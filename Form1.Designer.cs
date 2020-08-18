namespace WindowsFormsApp2
{
    partial class Form1
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
            this.Servidor = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.rtbSalida = new System.Windows.Forms.RichTextBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.ltvArchivos = new System.Windows.Forms.ListView();
            this.btnCarga = new System.Windows.Forms.Button();
            this.txtArchivoCarga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Servidor
            // 
            this.Servidor.AutoSize = true;
            this.Servidor.Location = new System.Drawing.Point(15, 48);
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(46, 13);
            this.Servidor.TabIndex = 0;
            this.Servidor.Text = "Servidor";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(198, 48);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(391, 48);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 13);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(67, 45);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(100, 20);
            this.txtServidor.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(239, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(443, 45);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 6;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(567, 43);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // rtbSalida
            // 
            this.rtbSalida.Location = new System.Drawing.Point(201, 139);
            this.rtbSalida.Name = "rtbSalida";
            this.rtbSalida.Size = new System.Drawing.Size(441, 285);
            this.rtbSalida.TabIndex = 8;
            this.rtbSalida.Text = "";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(201, 98);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(75, 23);
            this.btnDescargar.TabIndex = 10;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(291, 98);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(85, 20);
            this.txtCarga.TabIndex = 11;
            // 
            // ltvArchivos
            // 
            this.ltvArchivos.HideSelection = false;
            this.ltvArchivos.Location = new System.Drawing.Point(18, 139);
            this.ltvArchivos.Name = "ltvArchivos";
            this.ltvArchivos.Size = new System.Drawing.Size(149, 285);
            this.ltvArchivos.TabIndex = 12;
            this.ltvArchivos.UseCompatibleStateImageBehavior = false;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(517, 98);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(75, 23);
            this.btnCarga.TabIndex = 13;
            this.btnCarga.Text = "Cargar";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // txtArchivoCarga
            // 
            this.txtArchivoCarga.Location = new System.Drawing.Point(410, 98);
            this.txtArchivoCarga.Name = "txtArchivoCarga";
            this.txtArchivoCarga.Size = new System.Drawing.Size(85, 20);
            this.txtArchivoCarga.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.txtArchivoCarga);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.ltvArchivos);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.rtbSalida);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Servidor);
            this.Name = "Form1";
            this.Text = "Cliente FTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Servidor;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.RichTextBox rtbSalida;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.ListView ltvArchivos;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.TextBox txtArchivoCarga;
    }
}

