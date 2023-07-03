namespace WindowsFormsProductos1
{
    partial class FormProductos
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
            this.components = new System.ComponentModel.Container();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRecibido = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dgvCelulares = new System.Windows.Forms.DataGridView();
            this.rbtUsado = new System.Windows.Forms.RadioButton();
            this.epvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dtpRecibido = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(20, 376);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.cargarBtn_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(17, 181);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(17, 93);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(25, 13);
            this.lblAlto.TabIndex = 2;
            this.lblAlto.Text = "Alto";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(17, 140);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 3;
            this.lblAncho.Text = "Ancho";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 223);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Numero";
            // 
            // lblRecibido
            // 
            this.lblRecibido.AutoSize = true;
            this.lblRecibido.Location = new System.Drawing.Point(17, 264);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Size = new System.Drawing.Size(49, 13);
            this.lblRecibido.TabIndex = 6;
            this.lblRecibido.Text = "Recibido";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(70, 178);
            this.txtModelo.MaxLength = 25;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(70, 90);
            this.txtAlto.MaxLength = 5;
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(100, 20);
            this.txtAlto.TabIndex = 8;
            this.txtAlto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.atributosTxt_KeyPress);
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(70, 133);
            this.txtAncho.MaxLength = 5;
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 9;
            this.txtAncho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.atributosTxt_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(70, 45);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codTxt_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(70, 220);
            this.txtNumero.MaxLength = 15;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.atributosTxt_KeyPress);
            // 
            // dgvCelulares
            // 
            this.dgvCelulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCelulares.Location = new System.Drawing.Point(343, 12);
            this.dgvCelulares.Name = "dgvCelulares";
            this.dgvCelulares.Size = new System.Drawing.Size(759, 324);
            this.dgvCelulares.TabIndex = 13;
            // 
            // rbtUsado
            // 
            this.rbtUsado.AutoSize = true;
            this.rbtUsado.Location = new System.Drawing.Point(89, 317);
            this.rbtUsado.Name = "rbtUsado";
            this.rbtUsado.Size = new System.Drawing.Size(56, 17);
            this.rbtUsado.TabIndex = 16;
            this.rbtUsado.TabStop = true;
            this.rbtUsado.Text = "Usado";
            this.rbtUsado.UseVisualStyleBackColor = true;
            // 
            // epvError
            // 
            this.epvError.ContainerControl = this;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(143, 376);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // dtpRecibido
            // 
            this.dtpRecibido.Location = new System.Drawing.Point(70, 258);
            this.dtpRecibido.Name = "dtpRecibido";
            this.dtpRecibido.Size = new System.Drawing.Size(214, 20);
            this.dtpRecibido.TabIndex = 18;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.dtpRecibido);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.rbtUsado);
            this.Controls.Add(this.dgvCelulares);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblRecibido);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnCargar);
            this.Name = "FormProductos";
            this.Text = "FormularioProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DataGridView dgvCelulares;
        private System.Windows.Forms.RadioButton rbtUsado;
        private System.Windows.Forms.ErrorProvider epvError;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DateTimePicker dtpRecibido;
    }
}