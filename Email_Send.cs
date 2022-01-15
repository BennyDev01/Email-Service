using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentEmail.Smtp;
using System.Net.Mail;
using FluentEmail.Core;


namespace Computer_Virus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)        {

            //define email service and port (gmail.com)
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                
                //email and password (From)
                Credentials = new System.Net.NetworkCredential("Email", "Email Password"),
                         
            };
            client.Send               (
                "Email", //from
                "user your sending to", //to
                "Sunject", //subject
                "Your message"//body
                );
            
        }
    }
}
