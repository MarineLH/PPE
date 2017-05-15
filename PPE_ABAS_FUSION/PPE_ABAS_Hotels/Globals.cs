using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace PPE_ABAS_Hotels
{
    public static class Globals
    {
        public static string MySQLConnectionString = "Server=ms-development.fr;Database=admin_abas;Uid=admin_abasUser;Pwd=vG9neMzz51;";
        public static Batiment selectedBat;
        public static Personnel selectedUser;

        public static string LeadingZero(int num)
        {
            string numero;

            if (num >= 0 && num < 10)
                numero = "0" + num.ToString();
            else
                numero = num.ToString();

            return numero;
        }

        public static bool sendMailToNewClient(string clientEmail)
        {
            if (IsValidEmail(clientEmail))
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("tmp.abashotels@gmail.com", "tmpabashotels"),
                    EnableSsl = true
                };
               
                var subject = "Inscription sur ABAS Hôtels";
                var body = "<p>Vous êtes à présent inscrit sur notre site web <a href='www.abas-hotels.com'>ABAS Hôtels</a>!</p>";
                body += "<p>Vous pouvez vous y connecter avec l'adresse mail fournie lors de la réservation et le mot de passe '123', que vous pourrez changer dès votre connexion.</p>";
                body += "<p>A très bientôt !</p>";
                body += "<p><small>Ceci est un message automatique, merci de ne pas répondre.</small></p>";

                var basicCredential = new NetworkCredential("tmp.abashotels@gmail.com", "tmpabashotels");

                MailMessage mail = new MailMessage("tmp.abashotels@gmail.com", clientEmail, subject, body);
                mail.IsBodyHtml = true;
                try
                {
                    client.Send(mail);
                    return true;
                } catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
