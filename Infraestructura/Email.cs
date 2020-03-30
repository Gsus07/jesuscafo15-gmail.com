using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;
namespace infra
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;

        public Email()
        {
            smtp = new SmtpClient();
        }
        private void Configurarsmtp()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("inflvx000@gmail.com", "sebas123S");
        }
        private void ConfigurarEmail(Cliente cliente)
        {
            email = new MailMessage();
            email.To.Add(cliente.Correo);
            email.From = new MailAddress("inflvx000@gmail.com");
            email.Subject = "HA SIDO REGISTRADO EN LA BASE DE DATOS TEFRA PROYECT"
                + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            email.Body = $"<b>Sr {cliente.PrimerNombre} {cliente.SegundoNombre} {cliente.PrimerApellido} {cliente.SegundoApellido}</b> <br" +
                $" > Su Informacion Ha sido registrada correctamente";
            //email.Attachments.Add(new Attachment("Personas.pdf"));
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;



        }
        public string EnviarEmail(Cliente cliente)
        {
            try
            {
                Configurarsmtp();
                ConfigurarEmail(cliente);
                smtp.Send(email);
                return "correo enviado";
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }
    }
}
