using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("ftp://" + txtServidor.Text + "//");
            FtpWebRequest ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            NetworkCredential credenciales = new NetworkCredential();

            credenciales.Domain = "efloresp";
            credenciales.UserName = txtUsuario.Text;
            credenciales.Password = txtPass.Text;

            ClienteRequest.Credentials = credenciales;
            ClienteRequest.EnableSsl = false;
            ClienteRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            ClienteRequest.KeepAlive = true;
            ClienteRequest.UsePassive = true;

            FtpWebResponse respuesta = (FtpWebResponse)ClienteRequest.GetResponse();

            StreamReader sr = new StreamReader(respuesta.GetResponseStream(), Encoding.UTF8);
            string resultado = sr.ReadToEnd();
            rtbSalida.Text = resultado;
            respuesta.Close();





        }
    }
}
