using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;


namespace RegistroNacional.Clases
{
    class ClsCorreo
    {

        public string NombreCompleto;
        public string Placa;
        public string Cedula;
        public double Marchamo;
        private String asunto = "Monto del Marchamo";
        public String destinatario;
        private String remitente;
        public String usuario;
        private String password;
        private String mensaje;
        private String servidorCorreo; //ojo
        private short puerto; // ojo
        public string dominio;

        public ClsCorreo()
        {
            servidorCorreo = "smtp.gmail.com";
            puerto = 587;
            dominio = "GMAIL";

        }

        private void definirServidor()
        {
            if (dominio.Equals("GMAIL"))
            {
                servidorCorreo = "smtp.gmail.com";
                usuario = "pruebaclaseprogra@gmail.com";
                password = "Programacion1234";
                remitente = usuario;
                puerto = 587;
            }
            else if (dominio.Equals("UMCA"))
            {
                servidorCorreo = "smtp.UMCA.com";
                usuario = "USUARIOUMCA@UMCA.com";
                password = "Programav";
                remitente = usuario;
                puerto = 689;
            }
        }

        public string MensajeEnvio()
        {
            mensaje = "Estimado(a) " + NombreCompleto + " la Placa nueva de su Vehiculo es: " + Placa + "";
            mensaje += "\n";
            mensaje += "El Monto del Marchamo es: ¢" + Marchamo.ToString("0,##") + "\n";
            mensaje += "\n \n";
            mensaje += "Cualquier consulta, estamos para servirle";
            mensaje += "\n";
            mensaje += "Saludos";

            return mensaje;
        }

        public bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void enviarCorreo()
        {
            definirServidor();
            MensajeEnvio();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(this.servidorCorreo);
            mail.From = new MailAddress(this.remitente);
            mail.To.Add(this.destinatario);
            mail.Subject = this.asunto;
            mail.Body = this.mensaje;

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = this.puerto;
            SmtpServer.Credentials = new System.Net.NetworkCredential(this.usuario, this.password);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

    }
}
