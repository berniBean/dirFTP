﻿using System;
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
        private Uri uri;
        private FtpWebRequest ClienteRequest;
        private NetworkCredential credenciales;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {


                uri = new Uri("ftp://" + txtServidor.Text + "//");
                ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

                credenciales = new NetworkCredential();

                credenciales.Domain = "WORKGROUP";
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
                rtbSalida.Text = respuesta.WelcomeMessage + "\r\n" + resultado;

                respuesta.Close();

                List<Archivo> archivos = obtnerLista(resultado);
                foreach (Archivo item in archivos)
                {
                    ltvArchivos.Items.Add(item.nombre);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(""+ ex.ToString());
            }

        }
        private void btnCarga_Click(object sender, EventArgs e)
        {
            uri = new Uri("ftp://" + txtServidor.Text + "/" + "nuevoPDF.pdf");
            ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            credenciales = new NetworkCredential();

            credenciales.Domain = "WORKGROUP";
            credenciales.UserName = txtUsuario.Text;
            credenciales.Password = txtPass.Text;

            ClienteRequest.Credentials = credenciales;
            ClienteRequest.EnableSsl = false;
            ClienteRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            ClienteRequest.KeepAlive = true;
            ClienteRequest.UsePassive = true;

            ClienteRequest.Method = WebRequestMethods.Ftp.UploadFile;
            //FtpWebResponse respuesta = (FtpWebResponse)ClienteRequest.GetResponse();
            Stream destino = ClienteRequest.GetRequestStream();
            FileStream origen = new FileStream(txtCarga.Text +@"\" + txtArchivoCarga.Text, FileMode.Open, FileAccess.Read);
            crearArchivo(origen, destino);
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            string archivoDescarga = ltvArchivos.SelectedItems[0].Text;
            uri = new Uri("ftp://" + txtServidor.Text + "/" + archivoDescarga);
            ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            credenciales = new NetworkCredential();

            credenciales.Domain = "WORKGROUP";
            credenciales.UserName = txtUsuario.Text;
            credenciales.Password = txtPass.Text;

            ClienteRequest.Credentials = credenciales;
            ClienteRequest.EnableSsl = false;
            ClienteRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            ClienteRequest.KeepAlive = true;
            ClienteRequest.UsePassive = true;

            ClienteRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            FtpWebResponse respuesta = (FtpWebResponse)ClienteRequest.GetResponse();
            Stream s = respuesta.GetResponseStream();
            FileStream fs = new FileStream(@"C:\pruebaArchivo\" + archivoDescarga, FileMode.Create, FileAccess.Write);
            crearArchivo(s, fs);
        }


        private void crearArchivo(Stream origen, Stream destino)
        {

            byte[] buffer = new byte[1024];
            int bytesLeidos = origen.Read(buffer, 0, 1024);
            while( bytesLeidos != 0)
            {
                destino.Write(buffer, 0, bytesLeidos);
                bytesLeidos = origen.Read(buffer, 0, 1024);
            }

            origen.Close();
            destino.Close();
        }
        private List<Archivo> obtnerLista(string datos)
        {
            List<Archivo> retorno = new List<Archivo>();
            string[] registro = datos.Split(new char[] { '\n' },StringSplitOptions.RemoveEmptyEntries);
            string procesaItem = "";
            string fechaStr = "";
            string horaStr = "";
            foreach(string item in registro)
            {
                Archivo f = new Archivo();
                f.nombre = "..";
                procesaItem = item.Trim();
                fechaStr = procesaItem.Substring(0, 8);
                procesaItem = (procesaItem.Substring(8, procesaItem.Length - 8)).Trim();
                horaStr = procesaItem.Substring(0, 7);
                procesaItem = (procesaItem.Substring(7, procesaItem.Length - 7)).Trim();
                f.fecha = fechaStr + " " + horaStr;

                if (procesaItem.Substring(0, 5) == "<DIR>")
                {
                    f.bDirectorio = true;
                    procesaItem = (procesaItem.Substring(5, procesaItem.Length - 5)).Trim();
                }
                else
                {
                    string[] strs = procesaItem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    f.tamaño = Int64.Parse(strs[0]);
                    procesaItem = string.Join(" ",strs,1,strs.Length-1);
                    f.bDirectorio = false;
                }

                f.nombre = procesaItem;

                if(f.nombre != "" && f.nombre !="." && f.nombre != "..")
                {
                    retorno.Add(f);
                }

            }
            return retorno;
        }

        public struct Archivo
        {
            public string nombre;
            public bool bDirectorio;
            public Int64 tamaño;
            public string fecha;
        }


    }
}
