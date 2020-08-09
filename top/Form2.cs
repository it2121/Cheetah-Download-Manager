using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using OctaneDownloadEngine;
using System.IO;
using NUnit.Framework;
using System.Threading;
using System.Net;
using NUnit.Framework.Internal;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using FileDownloaderApp;
using System.Diagnostics.Eventing.Reader;

namespace top
{





    public partial class Form2 : Form
    {
        //FileDownloader downloader = new FileDownloader();
         //event System.ComponentModel.ProgressChangedEventHandler ProgressChanged;
      //  public static bool isdownlonding = false;


        public static string filename = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );
        public Form2()
        {



           

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = new Icon("../../Resources/icon.ico");
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            string copyed = Clipboard.GetText();
           if (copyed.Substring(0,3).Equals("htt")) {
                urltext.Text = Clipboard.GetText();

           }
          //  guna2ProgressBar1.Value = 20;
            // Creating a new instance of a FileDownloader
            // To report progress from the background worker we need to set this property
            // backgroundWorker1.WorkerReportsProgress = true;
            // This event will be raised on the worker thread when the worker starts
            // backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            // This event will be raised when we call ReportProgress
            //backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }


        //public void testing() {

        // FileDownloader downloader = new FileDownloader();
        // A simple implementation of setting the directory path, 
        // adding files from a textbox and starting the download




        //     downloader.LocalDirectory = "C:\\Users\\Mohammad\\source\\repos\\top\\top\\bin\\Debug";

        //downloader.Files.Add(new FileDownloader.FileInfo(urltext.Text));;

        // Start the downloader
        // downloader.Start();


        //}


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void setbar(string text) {

            this.pathtxt.Text = text;
        
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            //getfullfilename();
            DownloadFile();
            //this.Close();

        }
        public static string GetFilenameFromUrl(string url)
        {
          

            Uri URL = new Uri(url);
            string filename = Path.GetFileName(URL.LocalPath);
          

            return filename;
        }
        public static string GetFileExtensionFromUrl(string url)
        {
            url = url.Split('?')[0];
            url = url.Split('/').Last();
            return url.Contains('.') ? url.Substring(url.LastIndexOf('.')) : "";
        }

       

        public String getfullfilename()
        {

            String u = urltext.Text.Trim();
            pathtxt.Text = "2";
            WebRequest request = WebRequest.CreateHttp(u);
            pathtxt.Text = "222";
            WebResponse response = request.GetResponse();
            pathtxt.Text = "22222";
            string contentType = response.ContentType;
            String ext = ".txt";
            var result = contentType.Substring(contentType.LastIndexOf('/') + 1);
            //  pathtxt.Text = contentType;


            pathtxt.Text = "1";


            switch (result)
            {

                case "jpeg":
                    ext = "jpeg";
                    break;
                case "jpg":
                    ext = "jpg";
                    break;
                case "png":
                    ext = "png";
                    break;
                case "zip":
                    ext = "zip";
                    break;
                    

                case "octet-stream":

                    String sstt = response.Headers.Get("content-disposition");
            
                    int pFrom = sstt.LastIndexOf(".") + ".".Length;
                    int pTo = sstt.LastIndexOf("\"");

                    String extention = sstt.Substring(pFrom, pTo - pFrom);

                    ext = extention;


                    break;
                default:
                    ext = result;
                    break;
            }
            response.Dispose();
           


            response.Close();
            request.Abort();
          
            pathtxt.Text = "3";
            string nnn = GetFilenameFromUrl(u);
            pathtxt.Text = "4";
            int index = nnn.LastIndexOf(".");
            if (index > 0)
                nnn = nnn.Substring(0, index); 

            String file = "";
            file = nnn+ "." + ext;
            filename = file;
           
            return file;


        }


        public static string name = "no.txt";

        public async Task DownloadFile()
        {
         

           name = getfullfilename();
           

            // File.Create(name);

            // OctaneEngine _engine = new OctaneEngine();
            // File.Create(Black Clover CH - 259.zip);

            string url = urltext.Text.Trim();
            if (name.Equals(""))
            {
                
                //await  rs.DownloadFile(url,url);

            }
            else
            {
                

              /*  System.Net.WebClient client = new System.Net.WebClient();
                client.OpenRead(urltext.Text);
                Int64 bytes_total = Convert.ToInt64(client.ResponseHeaders["Content-Length"]);
                */
             




                if (name.Equals(Form1.name))
                {
                    name = "(" + Form1.ind + ")"+ name ;
                   // path = path ;
                   Form1.ind++;
                   
                }


                //pathtxt.Text = path;



                Form1.LATER = pch.Checked;
                // Form1.PATH = path+"\\"+name;
                Form1.PATH = path;

                // Form1.fileSize = bytes_total / 1024 / 1024 + " MB";
                Form1.URL = urltext.Text;
                Form1.name = name;
                // Form1.name = path;
                Form1.addnewdownloadrowpre();
                Form1.once = false;
                this.Close();



            }
}

        
         void ShowThreadInfo()
        {

        
        }

      
    
        private void meth(byte[] obj)
        {
           // File.WriteAllBytes("246708957.rar", obj);

        }

        public async Task ddd()
        {

        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
          //  ddd();
        }

        private void pathtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_2(object sender, EventArgs e)
        {
            this.Close();

        }

  
        private void puse_Click(object sender, EventArgs e)
        {

        }
        public static string path="";
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            using(var dialog = new FolderBrowserDialog())
{
         

                if (dialog.ShowDialog() == DialogResult.OK)  
                   path = dialog.SelectedPath;
                    pathtxt.Text = path;
                   
                }
            }

        private void urltext_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

