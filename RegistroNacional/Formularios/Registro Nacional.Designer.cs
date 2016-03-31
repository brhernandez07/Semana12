namespace RegistroNacional
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_NombreComp = new System.Windows.Forms.TextBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.lblannio = new System.Windows.Forms.Label();
            this.txt_valorFiscal = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tt_Mensajes = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Marchamo = new System.Windows.Forms.TextBox();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.btn_Envio = new System.Windows.Forms.Button();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_anoVehiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GenerarPlaca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(12, 18);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Comp.";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(12, 176);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(93, 18);
            this.txt_Cedula.MaxLength = 10;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(327, 20);
            this.txt_Cedula.TabIndex = 1;
            this.txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_KeyPress);
            this.txt_Cedula.MouseHover += new System.EventHandler(this.txt_Cedula_MouseHover);
            // 
            // txt_NombreComp
            // 
            this.txt_NombreComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NombreComp.Location = new System.Drawing.Point(93, 46);
            this.txt_NombreComp.MaxLength = 50;
            this.txt_NombreComp.Name = "txt_NombreComp";
            this.txt_NombreComp.Size = new System.Drawing.Size(327, 20);
            this.txt_NombreComp.TabIndex = 2;
            this.txt_NombreComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Placa
            // 
            this.txt_Placa.Enabled = false;
            this.txt_Placa.Location = new System.Drawing.Point(93, 176);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(327, 20);
            this.txt_Placa.TabIndex = 8;
            // 
            // lblannio
            // 
            this.lblannio.AutoSize = true;
            this.lblannio.Location = new System.Drawing.Point(12, 150);
            this.lblannio.Name = "lblannio";
            this.lblannio.Size = new System.Drawing.Size(61, 13);
            this.lblannio.TabIndex = 8;
            this.lblannio.Text = "Valor Fiscal";
            // 
            // txt_valorFiscal
            // 
            this.txt_valorFiscal.Location = new System.Drawing.Point(93, 150);
            this.txt_valorFiscal.MaxLength = 1000;
            this.txt_valorFiscal.Name = "txt_valorFiscal";
            this.txt_valorFiscal.Size = new System.Drawing.Size(327, 20);
            this.txt_valorFiscal.TabIndex = 7;
            this.txt_valorFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AnnioVehiculo_KeyPress);
            this.txt_valorFiscal.MouseHover += new System.EventHandler(this.txt_AnnioVehiculo_MouseHover);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(93, 72);
            this.txt_Email.MaxLength = 50;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(327, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // tt_Mensajes
            // 
            this.tt_Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marchamo";
            // 
            // txt_Marchamo
            // 
            this.txt_Marchamo.Enabled = false;
            this.txt_Marchamo.Location = new System.Drawing.Point(93, 202);
            this.txt_Marchamo.Name = "txt_Marchamo";
            this.txt_Marchamo.Size = new System.Drawing.Size(327, 20);
            this.txt_Marchamo.TabIndex = 9;
            // 
            // btn_calculo
            // 
            this.btn_calculo.Location = new System.Drawing.Point(93, 228);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(75, 23);
            this.btn_calculo.TabIndex = 12;
            this.btn_calculo.Text = "Cálculo";
            this.btn_calculo.UseVisualStyleBackColor = true;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            // 
            // btn_Envio
            // 
            this.btn_Envio.Location = new System.Drawing.Point(345, 228);
            this.btn_Envio.Name = "btn_Envio";
            this.btn_Envio.Size = new System.Drawing.Size(75, 23);
            this.btn_Envio.TabIndex = 13;
            this.btn_Envio.Text = "Envio";
            this.btn_Envio.UseVisualStyleBackColor = true;
            this.btn_Envio.Click += new System.EventHandler(this.btn_Envio_Click);
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(93, 98);
            this.txt_Marca.MaxLength = 20;
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(327, 20);
            this.txt_Marca.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Marca";
            // 
            // txt_anoVehiculo
            // 
            this.txt_anoVehiculo.Location = new System.Drawing.Point(93, 124);
            this.txt_anoVehiculo.MaxLength = 4;
            this.txt_anoVehiculo.Name = "txt_anoVehiculo";
            this.txt_anoVehiculo.Size = new System.Drawing.Size(327, 20);
            this.txt_anoVehiculo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Año Vehiculo";
            // 
            // btn_GenerarPlaca
            // 
            this.btn_GenerarPlaca.Location = new System.Drawing.Point(209, 228);
            this.btn_GenerarPlaca.Name = "btn_GenerarPlaca";
            this.btn_GenerarPlaca.Size = new System.Drawing.Size(95, 23);
            this.btn_GenerarPlaca.TabIndex = 18;
            this.btn_GenerarPlaca.Text = "Generar Placa";
            this.btn_GenerarPlaca.UseVisualStyleBackColor = true;
            this.btn_GenerarPlaca.Click += new System.EventHandler(this.btn_GenerarPlaca_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 335);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_GenerarPlaca);
            this.Controls.Add(this.txt_anoVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Envio);
            this.Controls.Add(this.btn_calculo);
            this.Controls.Add(this.txt_Marchamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txt_valorFiscal);
            this.Controls.Add(this.lblannio);
            this.Controls.Add(this.txt_Placa);
            this.Controls.Add(this.txt_NombreComp);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro Nacional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_NombreComp;
        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.Label lblannio;
        private System.Windows.Forms.TextBox txt_valorFiscal;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ToolTip tt_Mensajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Marchamo;
        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.Button btn_Envio;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_anoVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GenerarPlaca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

