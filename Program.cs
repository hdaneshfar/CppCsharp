using RoyalMailSenderClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string Smtp = "mail.diginotes.ir";
        public static string HostName = "mymail.diginotes.ir";
        public static string UserName = "info@diginotes.ir";
        public static string Password = "12345678A!";


        static void Main(string[] args)
        {
            // Link :
            // https://www.mspsoft.com/1390/05/12/%D8%B3%D9%88%D8%B1%D8%B3-%D8%A7%D8%B1%D8%B3%D8%A7%D9%84-%D8%A7%DB%8C%D9%85%DB%8C%D9%84-%D8%A8%D9%87-%D8%B2%D8%A8%D8%A7%D9%86-%D8%B3%DB%8C-%D8%B4%D8%A7%D8%B1%D9%BE/


            //**string Smtp: باید آدرس smtp سایت نوشته شود.
            //**HostName : باید آدرس webmail سایت نوشته شود.
            //**UserName و Password : باید نام کاربری و رمز عبوری که برای ایمیل خود در نظر گرفته اید وارد شود.
            //سپس با وارد کردن کد زیر دستور ارسال ایمیل را صادر میکنید:
            //string body = ms.Send(string Subject, string To, string Body, string fromMail, string fromName)

            //* *string Subject: بیان کننده موضوع پیام است.
            //* *string To: در این قسمت باید آدرس ایمیل نوشته شود.
            //**string Body: متن پیام باید در این قسمت نوشته شود.
            //**string fromMail: آدرس ایمیل خودتان را در این قسمت وارد کنید.
            //* *string fromName: نامی که میخواهید در ایمیل گیرنده نمایان شود را در این قسمت وارد نمایید. 




            // MailSender ms = new MailSender(Smtp, HostName, UserName, Password);
            //string body =  ms.Send("سلام", "mail.memco@gmail.com", "سلام. خوش گلدی", "info@diginotes.ir", "Hossein");

            string body = SendEmail("سلام", "mail.memco@gmail.com", "سلام. خوش گلدی", "info@diginotes.ir", "Hossein");

           

        }


        public static string SendEmail(string Subject, string To, string Body, string fromMail, string fromName)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient(Smtp);
                MailMessage mailMessage = new MailMessage();
                smtpClient.Host = HostName;
                mailMessage.To.Add(new MailAddress(To));
                mailMessage.Subject = Subject;
                mailMessage.SubjectEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;
                mailMessage.From = new MailAddress(fromMail, fromName);
                mailMessage.BodyEncoding = Encoding.UTF8;


                mailMessage.Body = PopulateBody("Hdaneshfar","سلام حسین عزیز" ,"www.diginotes.ir" ,"کد فعالسازی شما 123 میباشد");



                smtpClient.UseDefaultCredentials = false;
                NetworkCredential networkCredential = (NetworkCredential)(smtpClient.Credentials = new NetworkCredential(UserName, Password));
                smtpClient.Credentials = networkCredential;
                smtpClient.Send(mailMessage);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }








        public static string PopulateBody(string userName, string title, string url, string description)
        {
            // Tutorial Link :=> https://www.aspsnippets.com/Articles/Send-Email-using-HTML-Templates-in-ASPNet-with-C-and-VBNet.aspx
            // Search this text for create Html Email Body :=> search in google => free email template builder
            // Editor For Create Free Email Template :=> https://beefree.io/templates/
            // Check your Email Body for Spam :=> http://www.isnotspam.com/
            // Gmail, Yahoo, Hotmail are checking your body for spam



            string body = string.Empty;
            //using (StreamReader reader = new StreamReader("Server.MapPath("~/confirmation.htm"))
            using (StreamReader reader = new StreamReader("..\\..\\confirmation.htm"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{UserName}", userName);
            body = body.Replace("{Title}", title);
            //body = body.Replace("{Url}", url);
            //body = body.Replace("{Description}", description);
            return body;
        }







    }
}
