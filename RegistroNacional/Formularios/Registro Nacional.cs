using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroNacional.Clases;
using System.IO;         //Para el manejo de Archivos 

//Clases necesarias de iTextSharp
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace RegistroNacional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Procedimientos

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txt_AnnioVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txt_AnnioVehiculo_MouseHover(object sender, EventArgs e)
        {
            tt_Mensajes.ToolTipTitle = "Información";
            tt_Mensajes.SetToolTip(txt_valorFiscal, "Se debe ingresar el año del vehiculo.");
        }

        private void txt_Cedula_MouseHover(object sender, EventArgs e)
        {
            tt_Mensajes.ToolTipTitle = "Información";
            tt_Mensajes.SetToolTip(txt_Cedula, "Se es de 10 digitos exactos, incluyendo el cero (0).");
        }

        #endregion

        #region Botones/CheckBox

        private void btn_calculo_Click(object sender, EventArgs e)
        {

            int AnnioVehiculo = Convert.ToInt32(txt_anoVehiculo.Text);

            Cls_Vehiculo objCalcularMarchamo = new Cls_Vehiculo();
            objCalcularMarchamo.annio = Convert.ToInt32(txt_anoVehiculo.Text);
            objCalcularMarchamo.valorFiscal = Convert.ToDouble(txt_valorFiscal.Text);

            objCalcularMarchamo.calcularAntiguedad(AnnioVehiculo);
            txt_Marchamo.Text = objCalcularMarchamo.calculoMarchamo().ToString("0,##");
            
        }

        private void btn_GenerarPlaca_Click(object sender, EventArgs e)
        {

            ClsGenerarPlaca objGenerar = new ClsGenerarPlaca();
            objGenerar.cedula = txt_Cedula.Text;
            objGenerar.NombreCompleto = txt_NombreComp.Text;
            txt_Placa.Text = Convert.ToString(objGenerar.GenerarPlaca());

        }

        #endregion

        private void btn_Envio_Click(object sender, EventArgs e)
        {
            try
            {
                
                    ClsCorreo objCorreo = new ClsCorreo();
                    objCorreo.destinatario = txt_Email.Text;
                    objCorreo.NombreCompleto = txt_NombreComp.Text;
                    objCorreo.Cedula = txt_Cedula.Text;
                    objCorreo.Placa = txt_Placa.Text;
                    objCorreo.Marchamo = Convert.ToDouble(txt_Marchamo.Text);

                    if (objCorreo.ComprobarFormatoEmail(txt_Email.Text) == false)
                    {
                        MessageBox.Show("FORMATO DE CORREO INVALIDO, FAVOR DIGITAR EL CORRECTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        objCorreo.enviarCorreo();
                        MessageBox.Show("El Correo se ha enviado con Éxito");
                    }

            }
            catch (Exception)
            {
                MessageBox.Show("Alguno de los valores solicitados no es correcto, favor verificar e intentar nuevamente.");
            }

        }

    }
}
