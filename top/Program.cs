using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OctaneDownloadEngine;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace top
{
   public  static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
     public   static void Main()
        {

            /*
                   Tests tt = new Tests();
                   tt.Init();
                   tt.DownloadFile();*/


            /*      dman t = new dman();
                  t.Init();
                  String url = "https://shth3.shabakaty.com/share-thumbs/73716ef1-7270-4f8b-8bf1-56a1bc5d3c38/4147effd3b9f452c97e24cfd74ba383c.jpg";

                  t.DownloadFile(url,"img.jpg");

                  Tests tt = new Tests();
                  tt.Init();
                  tt.DownloadFile();*/
          

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
   

        }
    }
}
