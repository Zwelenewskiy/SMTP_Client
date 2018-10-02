using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;

namespace SMTP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_send_Click(object sender, EventArgs e)
        {
            string Sbuf = "";
            TcpClient Tcp = new TcpClient();
            try
            {
                Tcp.Connect(TB_host.Text, 25);

                using (NetworkStream stream = Tcp.GetStream())
                {
                    Sbuf = Read(stream);

                    if (Sbuf.IndexOf("220") != -1)
                    {
                        Write(stream, "HELO pavel6520");

                        Sbuf = Read(stream);

                        if (Sbuf.IndexOf("250") != -1)
                        {

                        }
                        else
                        {
                            MessageBox.Show(Sbuf);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Sbuf);
                    }
                }
                Tcp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex);
            }
        }

        private string Read(NetworkStream Nbuf)
        {
            byte[] Bbuf = new byte[1000];
            Nbuf.Read(Bbuf, 0, 1000);
            string Sbuf = Encoding.ASCII.GetString(Bbuf);
            Debug.Print("S: " + Sbuf);
            return Sbuf;
        }

        private void Write(NetworkStream Nbuf, string Sbuf)
        {
            byte[] Bbuf = Encoding.ASCII.GetBytes(Sbuf + "\r\n");
            Nbuf.Write(Bbuf, 0, Bbuf.Length);
            Debug.Print("C: " + Sbuf);
        }
    }
}
