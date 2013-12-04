using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace BaseClass._Library
{
    public class GMailLibrary
    {
        public String sender_email = "cuahangbangiay@gmail.com";
        public String sender_password = "kienkimkhung";
        public String receive_email = "quocdunginfo@gmail.com";
        public String receive_title = "Test email";
        public String receive_html = "Test body";
        public Boolean Send()
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(receive_email);
            
            mail.Subject = this.receive_title;
            mail.IsBodyHtml = true;
            mail.Body = this.receive_html;
            mail.From = new MailAddress(this.sender_email);
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                // setup Smtp authentication
                NetworkCredential credentials = new NetworkCredential(this.sender_email, this.sender_password);
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        /// <summary>
        /// Tạo HTML BODY cho this.receive_title và this.receive_html
        /// </summary>
        /// <param name="reset_link"></param>
        /// <returns></returns>
        public void Generate_ForgotPassword_Html(String reset_link)
        {
            this.receive_title = "Khôi phục mật khẩu Website Cửa hàng giày dép BigFoot";
            this.receive_html = "<img src=\"https://lh6.googleusercontent.com/-P2R_CIG6H7E/Upzdb6dcFmI/AAAAAAAAABY/rJJOpMz5wJo/w680-h353-no/CHIEW.gif" + "\" alt=\"Cửa hàng BigFoot\" style=\"margin-bottom:20px;box-shadow: 0px 0px 3px 4px #a1a1a1;max-height:110px\">";
            this.receive_html += "<br>";
            this.receive_html += "Bạn hoặc một ai đó đã gửi yêu cầu khôi phục lại mật khẩu tại Website <a href=\"http://localhost:53655/" + "\" title=\"Cửa hàng BigFoot\" target=\"_blank\"> Cửa hàng giày dép BigFoot</a>!";
            this.receive_html += "<br>";
            this.receive_html += "Click vào đường dẫn sau để tiến hành khôi phục lại mật khẩu:";
            this.receive_html += "<br>";
            this.receive_html += "<a href=\"" + reset_link + "\">";
            this.receive_html += reset_link;
            this.receive_html += "</a>";
        }
    }
}