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
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using System.Net;
using FileDownloaderApp;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ProgressBar = OctaneDownloadEngine.ProgressBar;
using System.Diagnostics;
using NUnit.Framework.Internal;
using System.Runtime.CompilerServices;

namespace top
{
    public partial class Form1 : Form
    {
      static  FileDownloader downloader1 = new FileDownloader();
      static  FileDownloader downloader2 = new FileDownloader();
      static  FileDownloader downloader3 = new FileDownloader();
      static  FileDownloader downloader4 = new FileDownloader();
      static  FileDownloader downloader5 = new FileDownloader();
        public static int downloader1idon = 0;
        public static int downloader2idon = 0;
        public static int downloader3idon = 0;
        public static int downloader4idon = 0;
        public static int downloader5idon = 0;
       static List<string> waitURL = new List<string> { };
        static List<string> waitname = new List<string> { };
        static List<int> waitIndex = new List<int> { };
       public  static bool once = true;
        static int donwlist = -1;
        public static int ind = 0;
        public static string URL = "";
        public static string name = "";
        public static string fileSize = "";
        public static string PATH = "";
        public static int downloadcount=1;
        public static bool donwIsOn=false;
        public static bool LATER=false;
       

        public void callme(){}

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );
        public Form1()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            this.Icon = new Icon("../../Resources/icon.ico");
      
            p1.BackColor = Color.FromArgb(50,p1.BackColor);
            p3.BackColor = Color.FromArgb(50,p3.BackColor);
            p1.Visible = true;
            p3.Visible = false;


            p1.ContextMenuStrip = contextMenuStrip1;
         p3.ContextMenuStrip = contextMenuStrip2;
            //this.guna2VScrollBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            //ScrollBar vScrollBar1 = new VScrollBar();
         
          
           // p1.ScrollControlIntoView(guna2VScrollBar1);
            getlist();
           // guna2VScrollBar1.ThumbSize = (guna2VScrollBar1.Height / p1.Height);
         




            //writeline("write the thing");


            // string text = System.IO.File.ReadAllText("list.txt");



            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            //p1.BackColor = Color.FromArgb(100,Color.White);


            //some();

        }
        public void getlist() {


            string[] lines = System.IO.File.ReadAllLines("list.txt");

            int o = 0;
            string a = "", b = "", c = "";

            foreach (string line in lines)
            {
                o++;
                //File.Create(line);
                if (o > 1 && (o % 3) == 0)
                {
                    c = line;
                    createtable(a, b, c);

                    o = 0;
                }
                else
                {

                    if (o == 1)
                    {
                        a = line;
                    }
                    else if (o == 2)
                    {

                        b = line;
                    }

                }

            }

        }
        public static void writeline(string line) {
        

           StreamWriter sw =new StreamWriter("list.txt", append: true);
            sw.WriteLine(line);
            sw.Close();



        }
        public  void setlabel3(string st){
            //label3.Text = st;


        }
        private void button1_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //p1.Visible = true;
            Form2 f2 = new Form2();
            f2.ShowDialog();


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            dlist = -1;
            getlist();

            ad.FillColor = p1.BackColor;
           // fd.FillColor = backp.BackColor;
            dd.FillColor = backp.BackColor;
            p1.Visible = true;
           // p2.Visible = false;
            p3.Visible = false;

        }

        private void fd_Click(object sender, EventArgs e)
        {
            ad.FillColor = backp.BackColor;
            //fd.FillColor = p1.BackColor;
            dd.FillColor = backp.BackColor;
            p1.Visible = false;
            //p2.Visible = true;
            p3.Visible = false;
        }

        private void dd_Click(object sender, EventArgs e)
        {
            ad.FillColor = backp.BackColor;
           // fd.FillColor = backp.BackColor;
            dd.FillColor = p1.BackColor;
            p1.Visible = false;
           // p2.Visible = false;
            p3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static int selectedindex = 0;
        public static void hoverlist(object sender, System.EventArgs e)
        {
            Label cb = (Label)sender;
            

             selectedindex = Convert.ToInt32(cb.Text);
         // testla.Text = selectedindex.ToString();
         // testla.Text = cb.Text;

        }

        public static int listindex = 0;
      public static   Guna.UI2.WinForms.Guna2CirclePictureBox icon;
        Label namel;
        Label hol;
        Guna.UI2.WinForms.Guna2Panel test1;
        private System.Windows.Forms.Button bb;
        public static int dlist=-1;
        void createtable(string name,string sizee,string location1) {

            // for (int i = 0; i < rows; i++) {
            dlist++;
            hol = new System.Windows.Forms.Label();
           icon= new Guna.UI2.WinForms.Guna2CirclePictureBox();
            icon.BackColor = System.Drawing.Color.Transparent;

            var result = name.Substring(name.LastIndexOf('.') + 1);
            if (result.Equals("mp4")) {
                icon.BackgroundImage = global::top.Properties.Resources.videoimage;


            } else if (result.Equals("png")|| result.Equals("jpg") || result.Equals("jpeg")) {
                icon.BackgroundImage = global::top.Properties.Resources.imageimage;

            }
            else if (result.Equals("mp4") || result.Equals("mp4"))
            {
                icon.BackgroundImage = global::top.Properties.Resources.videoimage;

            }
            else if (result.Equals("zip") || result.Equals("rar"))
            {
                icon.BackgroundImage = global::top.Properties.Resources.rarimage;

            }
            else
            {
                icon.BackgroundImage = global::top.Properties.Resources.fileimage;

            }

            icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            icon.ErrorImage = null;
            icon.InitialImage = null;
           // icon.Location = new System.Drawing.Point(-25, -3);
            icon.Name = "guna2CirclePictureBox2";
            icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            icon.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            icon.Size = new System.Drawing.Size(45, 40);
            icon.TabIndex = 36;
            icon.TabStop = false;
            icon.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            icon.Dock = System.Windows.Forms.DockStyle.Left;

            // donwlist = index;

            //puse = new Guna.UI2.WinForms.Guna2Button();


            fname = new System.Windows.Forms.Label();
            truesize = new System.Windows.Forms.Label();
            size = new System.Windows.Forms.Label();

            test1 = new Guna.UI2.WinForms.Guna2Panel();

            test1.BackColor = System.Drawing.Color.FromArgb(27, 40, 53);

            test1.Location = new System.Drawing.Point(14, (25 + (50 + 5) * dlist));
            test1.Name = "dp" + dlist;
            hol.Name = "dp" + dlist;
           
            test1.ShadowDecoration.Parent = test1;
            test1.Size = new System.Drawing.Size(739, 50);
            test1.TabIndex = dlist;


            hol.Text = ""+(dlist+1);
            fname.AutoSize = true;
            truesize.AutoSize = true;
            fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            truesize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //fname.Location = new System.Drawing.Point(220, 115);

            fname.Name = "o" + dlist;
            truesize.Name = "ts" + dlist;
            size.Name = "" + dlist;
            //fname.Size = new System.Drawing.Size(83, 91);

            //fname.Dock = System.Windows.Forms.DockStyle.Left;
            fname.Location = new System.Drawing.Point(64, 5);


        


            truesize.Location = new System.Drawing.Point(62, 25);

            size.Dock = System.Windows.Forms.DockStyle.Fill;
            hol.Dock = System.Windows.Forms.DockStyle.Fill;
            truesize.BackColor = System.Drawing.Color.Transparent;

            fname.TabIndex = 2;
            truesize.TabIndex = 3;
            size.TabIndex = dlist;
            fname.Text = name;
         truesize.Text = sizee ;
           // size.Text = sizee+" - "+ location1;
            hol.ForeColor = System.Drawing.Color.FromArgb(27, 40, 53);
            test1.Controls.Add(truesize);


            test1.Controls.Add(fname);

            test1.Controls.Add(truesize);
            test1.Controls.Add(hol);



            test1.Controls.Add(icon);





            p1.Controls.Add(test1);
            hol.MouseEnter += new System.EventHandler(hoverlist);

            //dlist++;

           // }
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //OctaneEngine o = new OctaneEngine();
         //   testla.Text = selectedindex.ToString();
           // testla.Text = downloader1idon.ToString();
            if ((downloader1idon == 1) && (downloadcount<=2)) {
                downloader1.Resume();
                downloader1idon = 2;

            }

            if (downloader2idon == 1 && downloadcount <= 3)
            {
                downloader2.Resume();
                downloader2idon = 2;

            }
            if (downloader3idon == 1 && downloadcount <= 3)
            {

                downloader3.Resume();
                downloader3idon = 2;
            }
            if (downloader4idon == 1 && downloadcount <= 5)
            {
                downloader4.Resume();
                downloader4idon = 2;

            }
            if (downloader5idon == 1 && downloadcount <= 6)
            {
                downloader5.Resume();
                downloader5idon = 2;
            }

        }

       


        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // testla.Text = selectedindex.ToString();
            int index = selectedindex;
            string[] lines = System.IO.File.ReadAllLines("list.txt");

            int o = 0;

            string ppaatthh = "";
            string namee = "";
            foreach (string line in lines)
            {
                o++;

                if (o == (index * 3))
                {
                    ppaatthh = line;



                }
                if (o == ((index * 3)-2)) {


                    namee = line;
                }


            }
            string full = ppaatthh +"\\"+ namee;
           // Process.Start("explorer.exe", ppaatthh);

            System.Diagnostics.Process.Start(full);



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        static Label fname;
        static Label size;
        static Label truesize;
        static Guna.UI2.WinForms.Guna2Panel downp;
        static Guna.UI2.WinForms.Guna2Button puse;
        static Guna.UI2.WinForms.Guna2ProgressBar yoyo;
        static Guna.UI2.WinForms.Guna2ProgressBar yoyo2;
        static Guna.UI2.WinForms.Guna2ProgressBar yoyo3;
        static Guna.UI2.WinForms.Guna2ProgressBar yoyo4;
        static Guna.UI2.WinForms.Guna2ProgressBar yoyo5;
        static Label speed1;
        static Label speed2;
        static Label speed3;
        static Label speed4;
        static Label speed5;
        public static Guna.UI2.WinForms.Guna2CirclePictureBox icond;

        public static bool ispaussed1 = false;
        public static bool ispaussed2 = false;
        public static bool ispaussed3 = false;
        public static bool ispaussed4 = false;
        public static bool ispaussed5 = false;
              public static void puse_click(object sender, EventArgs e)
        {


            if (selectedindex == 1) {
                if (ispaussed1 == false)
                {
                    downloader1.Pause();
                    downloader1idon = 1;
                    ispaussed1 = true;
                }
                else {
                    downloader1.Resume();
                    ispaussed1 = false;
                    downloader1idon = 2;


                }
            } else if (selectedindex == 2) {

                if (ispaussed2 == false)
                {
                    downloader2.Pause();
                    ispaussed2 = true;
                    downloader2idon = 1;

                }
                else
                {
                    downloader2.Resume();
                    ispaussed2 = false;
                    downloader2idon = 2;

                }
            }
            else if (selectedindex == 3)
            {
                if (ispaussed3 == false)
                {
                    downloader3.Pause();
                    ispaussed3 = true;
                    downloader3idon = 1;

                }
                else
                {
                    downloader3.Resume();
                    ispaussed3 = false;
                    downloader3idon = 2;
                }

            }
            else if (selectedindex == 4)
            {
                if (ispaussed4 == false)
                {
                    downloader4.Pause();
                    ispaussed4 = true;
                    downloader4idon = 1;
                }
                else
                {
                    downloader4.Resume();
                    ispaussed4 = false;
                    downloader4idon = 2;
                }


            }
            else if (selectedindex == 5)
            {

                if (ispaussed5 == false)
                {
                    downloader5.Pause();
                    ispaussed5 = true;
                    downloader5idon = 1;
                }
                else
                {
                    downloader5.Resume();
                    ispaussed5 = false;
                    downloader5idon = 2;
                }
            }

           // testla.Text = selectedindex.ToString();



        }
        // Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        static Label hoverbu;

        public static void addnewdownloadrowpre() {
            

                addnewdownloadrow();

           

        }

        public static void addnewdownloadrow() {
            donwlist++;

            hoverbu = new System.Windows.Forms.Label();
            hoverbu.Name = "dp" + donwlist;
            hoverbu.Dock = System.Windows.Forms.DockStyle.Fill;
          
         puse  = new Guna.UI2.WinForms.Guna2Button();

            // donwlist = index;


            icond = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            icond.BackColor = System.Drawing.Color.Transparent;

            var result = name.Substring(name.LastIndexOf('.') + 1);
            if (result.Equals("mp4"))
            {
                icond.BackgroundImage = global::top.Properties.Resources.videoimage;


            }
            else if (result.Equals("png") || result.Equals("jpg"))
            {
                icond.BackgroundImage = global::top.Properties.Resources.imageimage;

            }
            else if (result.Equals("mp4") || result.Equals("mp4"))
            {
                icond.BackgroundImage = global::top.Properties.Resources.videoimage;

            }
            else if (result.Equals("zip") || result.Equals("rar"))
            {
                icond.BackgroundImage = global::top.Properties.Resources.rarimage;

            }
            else
            {
                icond.BackgroundImage = global::top.Properties.Resources.fileimage;

            }

            icond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            icond.ErrorImage = null;
            icond.InitialImage = null;
            // icon.Location = new System.Drawing.Point(-25, -3);
            icond.Name = "guna2CirclePictureBox2";
            icond.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
          //  icond.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            icond.Size = new System.Drawing.Size(45, 40);
            icond.TabIndex = 36;
            icond.TabStop = false;
          //  icond.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            icond.Dock = System.Windows.Forms.DockStyle.Left;



            fname = new System.Windows.Forms.Label();
            truesize = new System.Windows.Forms.Label();
            size = new System.Windows.Forms.Label();

            downp = new Guna.UI2.WinForms.Guna2Panel();

                downp.BackColor = System.Drawing.Color.FromArgb(27, 40, 53);

                downp.Location = new System.Drawing.Point(14, (25 + (70 + 5) * donwlist));
                downp.Name = "dp" + donwlist;
                downp.ShadowDecoration.Parent = downp;
                downp.Size = new System.Drawing.Size(739, 70);
                downp.TabIndex = donwlist;

            hoverbu.ForeColor = System.Drawing.Color.FromArgb(27, 40, 53);

            fname.AutoSize = true;
            truesize.AutoSize = true;
            fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            truesize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //fname.Location = new System.Drawing.Point(220, 115);

            fname.Name = "o" + donwlist;
            truesize.Name = "ts" + donwlist;
            size.Name = "" + donwlist;
            //fname.Size = new System.Drawing.Size(83, 91);
            fname.Dock = System.Windows.Forms.DockStyle.Left;


            //truesize.Dock = System.Windows.Forms.DockStyle.Left;


            truesize.Location = new System.Drawing.Point(62,20);
            
            size.Dock = System.Windows.Forms.DockStyle.Fill;
          truesize.BackColor = System.Drawing.Color.Transparent;

            fname.TabIndex = 2;
            truesize.TabIndex = 3;
            size.TabIndex = donwlist;
                fname.Text = name;
            System.Net.WebClient client = new System.Net.WebClient();
            client.OpenRead(URL);
            Int64 bytes_total = Convert.ToInt64(client.ResponseHeaders["Content-Length"]);
            // client.Dispose();
            client.CancelAsync();
            truesize.Text = bytes_total / 1024 / 1024 + " MB";
            size.Text = fileSize;
            downp.Controls.Add(hoverbu);
            downp.Controls.Add(truesize);

            //   fname.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hoverlist);
            //  bb = new System.Windows.Forms.Button();

            puse.Animated = true;
            puse.BackColor = System.Drawing.Color.Transparent;
            puse.BorderColor = System.Drawing.Color.WhiteSmoke;
            puse.BorderRadius = 10;
            puse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            puse.BorderThickness = 1;
            puse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            puse.CheckedState.Parent = puse;
           puse.CustomImages.Parent = puse;
            puse.FillColor = System.Drawing.Color.Transparent;
            puse.Font = new System.Drawing.Font("Segoe UI", 9F);
            puse.ForeColor = System.Drawing.Color.White;
            puse.HoverState.Parent = puse;
            puse.Location = new System.Drawing.Point(309, 151);
            puse.Name = "puse";
            puse.ShadowDecoration.Parent = puse;
            puse.Size = new System.Drawing.Size(25, 25);
            puse.TabIndex = 73;
            puse.Text = "| |";
            puse.Dock = System.Windows.Forms.DockStyle.Right;

            puse.Click += new System.EventHandler(puse_click);

            downp.Controls.Add(puse);

            downp.Controls.Add(fname);
          
                downp.Controls.Add(size);
    
            hoverbu.MouseEnter += new System.EventHandler(hoverlist);


            p3.Controls.Add(downp);
            //size.MouseEnter += new System.EventHandler(hoverlist);



            if (downloadcount == 1)
            {



                yoyo = new Guna.UI2.WinForms.Guna2ProgressBar();

                yoyo.Name = "yoyo" + donwlist;
                yoyo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
                yoyo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                yoyo.Location = new System.Drawing.Point(63, 185);
                yoyo.Name = "yoyo";
                yoyo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                yoyo.ProgressColor2 = System.Drawing.Color.Teal;
                yoyo.ShadowDecoration.Parent = yoyo;
                yoyo.ShowPercentage = true;

                yoyo.Size = new System.Drawing.Size(496, 15);
                yoyo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo.TabIndex = 73;
                yoyo.TabStop = false;
                yoyo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
                yoyo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  


                yoyo.Value = 0;
                yoyo.Dock = System.Windows.Forms.DockStyle.Bottom;
                yoyo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

                yoyo.ForeColor = System.Drawing.Color.White;
                speed1 = new System.Windows.Forms.Label();
                speed1.AutoSize = true;
                speed1.Font = new System.Drawing.Font("Microsoft Sans Serif",8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                speed1.Name = "speed" + donwlist;
                 speed1.Dock = System.Windows.Forms.DockStyle.Bottom;
                 speed1.TabIndex = 2;
                speed1.Text = "1";
                downp.Controls.Add(speed1);
                downp.Controls.Add(icond);
                Label.CheckForIllegalCrossThreadCalls = false;

                hoverbu.Text = "1";
                downp.Controls.Add(yoyo);
                string y = PATH + "\\" + name;
                downloader1.LocalDirectory = @PATH;

                downloader1.Files.Add(new FileDownloader.FileInfo(URL)); ;
                downloader1.SupportsProgress = true;
                
                downloader1.Start();
                downloader1idon = 2;
                if (LATER) {
                    downloader1.Pause();
                    ispaussed1 = true;


                }
                

                downloadcount++;
                donwIsOn = true;

                var tt = Task.Run(() =>
                {
                    System.Net.WebClient clientt = new System.Net.WebClient();
                    clientt.OpenRead(URL);
                    Int64 bytes_totatl = Convert.ToInt64(clientt.ResponseHeaders["Content-Length"]);
                    clientt.CancelAsync();
                    string sss = bytes_totatl / 1024 / 1024 + "MB";
                    // double speed = 0;
                    //double speedold = downloader1.DownloadSpeed;
                    bool once = true;
                    int x = 0;
                    while ((int)downloader1.CurrentFilePercentage() <= 100)
                    {
                       
                    
                        // speed = (double)(speedold / downloader1.DownloadSpeed)+ downloader1.DownloadSpeed;
                        // int u = downloader1.DownloadSpeed;
                        yoyo.Value = (int)downloader1.CurrentFilePercentage();
                        if (x % 600000 == 1)
                        {
                            speed1.Text = FileDownloader.FormatSizeBinary(downloader1.DownloadSpeed)+"|" + FileDownloader.FormatSizeBinary(downloader1.CurrentFileProgress) ;
                        }



                        if (downloader1.SupportsProgress)
                        {
                            yoyo.Value = (int)downloader1.CurrentFilePercentage();
                            // =downloader1.CurrentFilePercentage()+"%";
                            if (x%600000==1) { 
                            speed1.Text = FileDownloader.FormatSizeBinary(downloader1.DownloadSpeed) + "|" + FileDownloader.FormatSizeBinary(downloader1.CurrentFileProgress);
                            }
                        }
                        if ((int)downloader1.CurrentFilePercentage() == 100)
                        {
                            if (once) { 
                            // downloadcount--;

                            writeline(name);
                            writeline(sss);
                            writeline(PATH);
                            donwIsOn = false;
                                once = false;
                                shownot(name);
                                downloader1idon = 0;

                            }
                        }
                        x++;
                        //speedold = speed;
                    }
                });
            }
       
             else if (downloadcount == 2)
            {
                yoyo2 = new Guna.UI2.WinForms.Guna2ProgressBar();

                yoyo2.Name = "yoyo2" + donwlist;
                yoyo2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
                yoyo2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                yoyo2.Location = new System.Drawing.Point(63, 185);
                yoyo2.Name = "yoyo2";
                yoyo2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                yoyo2.ProgressColor2 = System.Drawing.Color.Teal;
                yoyo2.ShadowDecoration.Parent = yoyo2;
                yoyo2.ShowPercentage = true;
                yoyo2.Size = new System.Drawing.Size(496, 15);
                yoyo2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo2.TabIndex = 73;
                yoyo2.TabStop = false;
                yoyo2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
                yoyo2.Value = 0;
                yoyo2.Dock = System.Windows.Forms.DockStyle.Bottom;
                yoyo2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                yoyo2.ForeColor = System.Drawing.Color.White;
                speed2 = new System.Windows.Forms.Label();
                speed2.AutoSize = true;
                speed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                speed2.Name = "speed" + donwlist;
                speed2.Dock = System.Windows.Forms.DockStyle.Bottom;
                speed2.TabIndex = 2;
                speed2.Text = "1";
                downp.Controls.Add(speed2);
                hoverbu.Text = "2";

                downp.Controls.Add(yoyo2);


                downloader2.LocalDirectory = PATH;

                downloader2.Files.Add(new FileDownloader.FileInfo(URL)); ;

                downloader2.Start();
                downloader2idon = 2;
                if (LATER)
                {
                    downloader2.Pause();
                    ispaussed2 = true;


                }
                downloadcount++;
                donwIsOn = true;

                var tt = Task.Run(() =>
                    {
                        System.Net.WebClient clientt2 = new System.Net.WebClient();
                        clientt2.OpenRead(URL);
                        Int64 bytes_totatl = Convert.ToInt64(clientt2.ResponseHeaders["Content-Length"]);
                        clientt2.CancelAsync();
                        string sss2 = bytes_totatl / 1024 / 1024 + "MB";

                        bool once2 = true;
                        int x = 0;
                        while ((int)downloader2.CurrentFilePercentage() <= 100)
                        {
                            yoyo2.Value = (int)downloader2.CurrentFilePercentage();
                            if (x % 600000 == 1)
                            {
                                speed2.Text = FileDownloader.FormatSizeBinary(downloader2.DownloadSpeed);
                            }


                            if (downloader2.SupportsProgress)
                            {
                                yoyo2.Value = (int)downloader2.CurrentFilePercentage();
                                if (x % 600000 == 1)
                                {
                                    speed2.Text = FileDownloader.FormatSizeBinary(downloader2.DownloadSpeed);
                                }

                            }
                            if ((int)downloader2.CurrentFilePercentage() == 100)
                            {
                                //downloadcount--;
                                if (once2)
                                {
                                    // downloadcount--;

                                    writeline(name);
                                    writeline(sss2);
                                    writeline(PATH);
                                    donwIsOn = false;
                                    once2 = false;
                                    shownot(name);
                                    downloader2idon = 0;


                                }


                            }
                            x++;
                        }
                       
                    });

            }
            else if (downloadcount == 3)
            {
                yoyo3 = new Guna.UI2.WinForms.Guna2ProgressBar();

                yoyo3.Name = "yoyo3" + donwlist;
                yoyo3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
                yoyo3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                yoyo3.Location = new System.Drawing.Point(63, 185);
                yoyo3.Name = "yoyo3";
                yoyo3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                yoyo3.ProgressColor2 = System.Drawing.Color.Teal;
                yoyo3.ShadowDecoration.Parent = yoyo3;
                yoyo3.ShowPercentage = true;
                yoyo3.Size = new System.Drawing.Size(496, 15);
                yoyo3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo3.TabIndex = 73;
                yoyo3.TabStop = false;
                yoyo3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
                yoyo3.Value = 0;
                yoyo3.Dock = System.Windows.Forms.DockStyle.Bottom;
                yoyo3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                yoyo3.ForeColor = System.Drawing.Color.White; yoyo.ForeColor = System.Drawing.Color.White;
                speed3 = new System.Windows.Forms.Label();
                speed3.AutoSize = true;
                speed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                speed3.Name = "speed" + donwlist;
                speed3.Dock = System.Windows.Forms.DockStyle.Bottom;
                speed3.TabIndex = 2;
                speed3.Text = "1";
                downp.Controls.Add(speed3);
                hoverbu.Text = "3";

                downp.Controls.Add(yoyo3);

                downloader3.LocalDirectory = PATH;

                downloader3.Files.Add(new FileDownloader.FileInfo(URL)); ;

                downloader3.Start();
                downloader3idon = 2;

                if (LATER)
                {
                    downloader3.Pause();
                    ispaussed3 = true;


                }
                downloadcount++;
                donwIsOn = true;

                var t = Task.Run(() =>
                    {
                        System.Net.WebClient clientt3 = new System.Net.WebClient();
                        clientt3.OpenRead(URL);
                        Int64 bytes_totatl = Convert.ToInt64(clientt3.ResponseHeaders["Content-Length"]);
                        clientt3.CancelAsync();
                        string sss3 = bytes_totatl / 1024 / 1024 + "MB";

                        bool once3 = true;
                        int x = 0;
                        while ((int)downloader3.CurrentFilePercentage() <= 100)
                        {
                            yoyo3.Value = (int)downloader3.CurrentFilePercentage();
                            if (x % 600000 == 1)
                            {
                                speed3.Text = FileDownloader.FormatSizeBinary(downloader3.DownloadSpeed);
                            }



                            if (downloader3.SupportsProgress)
                            {
                                yoyo3.Value = (int)downloader3.CurrentFilePercentage();
                                if (x % 600000 == 1)
                                {
                                    speed3.Text = FileDownloader.FormatSizeBinary(downloader3.DownloadSpeed);
                                }

                            }
                            if ((int)downloader3.CurrentFilePercentage() == 100)
                            {
                                // downloadcount--;
                                if (once3)
                                {
                                    // downloadcount--;

                                    writeline(name);
                                    writeline(sss3);
                                    writeline(PATH);
                                    donwIsOn = false;
                                    once3 = false;
                                    shownot(name);
                                    downloader3idon = 0;


                                }

                            }
                            x++;
                        }
                       
                    });
            }
            else if (downloadcount == 4)
            {
                yoyo4 = new Guna.UI2.WinForms.Guna2ProgressBar();

                yoyo4.Name = "yoyo4" + donwlist;
                yoyo4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
                yoyo4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                yoyo4.Location = new System.Drawing.Point(63, 185);
                yoyo4.Name = "yoyo4";
                yoyo4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                yoyo4.ProgressColor2 = System.Drawing.Color.Teal;
                yoyo4.ShadowDecoration.Parent = yoyo4;
                yoyo4.ShowPercentage = true;
                yoyo4.Size = new System.Drawing.Size(496, 15);
                yoyo4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo4.TabIndex = 73;
                yoyo4.TabStop = false;
                yoyo4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
                yoyo4.Value = 0;
                yoyo4.Dock = System.Windows.Forms.DockStyle.Bottom;
                yoyo4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                yoyo4.ForeColor = System.Drawing.Color.White;
                yoyo.ForeColor = System.Drawing.Color.White;
                speed4 = new System.Windows.Forms.Label();
                speed4.AutoSize = true;
                speed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                speed4.Name = "speed" + donwlist;
                speed4.Dock = System.Windows.Forms.DockStyle.Bottom;
                speed4.TabIndex = 2;
                speed4.Text = "1";
                downp.Controls.Add(speed4);
                hoverbu.Text = "4";

                downp.Controls.Add(yoyo4);

                downloader4.LocalDirectory = PATH;

                downloader4.Files.Add(new FileDownloader.FileInfo(URL)); ;

                downloader4.Start();
                downloader4idon = 2;

                if (LATER)
                {
                    downloader4.Pause();
                    ispaussed4 = true;


                }
                downloadcount++;
                donwIsOn = true;

                var t = Task.Run(() =>
                {
                    System.Net.WebClient clientt4 = new System.Net.WebClient();
                    clientt4.OpenRead(URL);
                    Int64 bytes_totatl = Convert.ToInt64(clientt4.ResponseHeaders["Content-Length"]);
                    clientt4.CancelAsync();
                    string sss4 = bytes_totatl / 1024 / 1024 + "MB";

                    bool once4 = true;
                    int x = 0;
                    while ((int)downloader4.CurrentFilePercentage() <= 100)
                    {
                        yoyo4.Value = (int)downloader4.CurrentFilePercentage();

                        if (x % 600000 == 1)
                        {
                            speed4.Text = FileDownloader.FormatSizeBinary(downloader4.DownloadSpeed);
                        }


                        if (downloader4.SupportsProgress)
                        {
                            yoyo4.Value = (int)downloader4.CurrentFilePercentage();
                            if (x % 600000 == 1)
                            {
                                speed4.Text = FileDownloader.FormatSizeBinary(downloader4.DownloadSpeed);
                            }

                        }
                        if ((int)downloader4.CurrentFilePercentage() == 100)
                        {
                            // downloadcount--;
                            if (once4)
                            {
                                // downloadcount--;

                                writeline(name);
                                writeline(sss4);
                                writeline(PATH);
                                donwIsOn = false;
                                once4 = false;
                                shownot(name);
                                downloader4idon = 0;


                            }

                        }
                        x++;
                    }
                });
            }
            else if (downloadcount == 5)
            {

                yoyo5 = new Guna.UI2.WinForms.Guna2ProgressBar();

                yoyo5.Name = "yoyo5" + donwlist;
                yoyo5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
                yoyo5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                yoyo5.Location = new System.Drawing.Point(63, 185);
                yoyo5.Name = "yoyo5";
                yoyo5.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                yoyo5.ProgressColor2 = System.Drawing.Color.Teal;
                yoyo5.ShadowDecoration.Parent = yoyo5;
                yoyo5.ShowPercentage = true;
                yoyo5.Size = new System.Drawing.Size(496, 15);
                yoyo5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo5.TabIndex = 73;
                yoyo5.TabStop = false;
                yoyo5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
                yoyo5.Value = 0;
                yoyo5.Dock = System.Windows.Forms.DockStyle.Bottom;
                yoyo5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                yoyo5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                yoyo5.ForeColor = System.Drawing.Color.White;
                yoyo.ForeColor = System.Drawing.Color.White;
                speed5 = new System.Windows.Forms.Label();
                speed5.AutoSize = true;
                speed5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                speed5.Name = "speed" + donwlist;
                speed5.Dock = System.Windows.Forms.DockStyle.Bottom;
                speed5.TabIndex = 2;
                speed5.Text = "1";
                downp.Controls.Add(speed5);
                hoverbu.Text = "5";

                downp.Controls.Add(yoyo5);
                downloader5.LocalDirectory = PATH;

                downloader5.Files.Add(new FileDownloader.FileInfo(URL)); ;

                downloader5.Start();
                downloader5idon = 2;

                if (LATER)
                {
                    downloader5.Pause();
                    ispaussed5 = true;


                }
                downloadcount++;
                donwIsOn = true;

                var t = Task.Run(() =>
                {
                    System.Net.WebClient clientt5 = new System.Net.WebClient();
                    clientt5.OpenRead(URL);
                    Int64 bytes_totatl = Convert.ToInt64(clientt5.ResponseHeaders["Content-Length"]);
                    clientt5.CancelAsync();
                    string sss5 = bytes_totatl / 1024 / 1024 + "MB";

                    bool once5 = true;
                    int x = 0;
                    while ((int)downloader5.CurrentFilePercentage() <= 100)
                    {
                        yoyo5.Value = (int)downloader5.CurrentFilePercentage();

                        if (x % 600000 == 1)
                        {
                            speed5.Text = FileDownloader.FormatSizeBinary(downloader5.DownloadSpeed);
                        }

                        if (downloader5.SupportsProgress)
                        {
                            yoyo5.Value = (int)downloader5.CurrentFilePercentage();
                            if (x % 600000 == 1)
                            {
                                speed5.Text = FileDownloader.FormatSizeBinary(downloader5.DownloadSpeed);
                            }
                        }
                        if ((int)downloader5.CurrentFilePercentage() == 100)
                        {
                            // downloadcount--;
                            if (once5)
                            {
                                // downloadcount--;

                                writeline(name);
                                writeline(sss5);
                                writeline(PATH);
                                donwIsOn = false;
                                once5 = false;
                                shownot(name);
                                downloader5idon = 0;

                            }

                        }
                        x++;
                    }
                });
            }



          



        }
        public static void okbitch() {

            yoyo = new Guna.UI2.WinForms.Guna2ProgressBar();

            yoyo.Name = "yoyo" + donwlist;
            yoyo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            yoyo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            yoyo.Location = new System.Drawing.Point(63, 185);
            yoyo.Name = "yoyo";
            yoyo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            yoyo.ProgressColor2 = System.Drawing.Color.Teal;
            yoyo.ShadowDecoration.Parent = yoyo;
            yoyo.ShowPercentage = true;
            yoyo.Size = new System.Drawing.Size(496, 15);
            yoyo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            yoyo.TabIndex = 73;
            yoyo.TabStop = false;
            yoyo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            yoyo.Value = 0;
            yoyo.Dock = System.Windows.Forms.DockStyle.Bottom;
            yoyo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
           // downp.Controls.Add(yoyo);

            downloader1.LocalDirectory = name;

            downloader1.Files.Add(new FileDownloader.FileInfo(URL)); ;

            downloader1.Start();
            downloadcount++;
            donwIsOn = true;
            var tt = Task.Run(() =>
            {
                int xx = donwlist;
                while ((int)downloader1.CurrentFilePercentage() <= 100)
                {
                    yoyo.Value = (int)downloader1.CurrentFilePercentage();



                    if (downloader1.SupportsProgress)
                    {
                        yoyo.Value = (int)downloader1.CurrentFilePercentage();

                    }
                    if ((int)downloader1.CurrentFilePercentage() == 100)
                    {
                        //downloadcount--;
                        donwIsOn = false;
                        startnextpre();


                    }
                }
            });

        }
        public static void startnextpre() {
            if (donwIsOn==false&&waitIndex.Count!=0) { 
            startnext();
            }
        }
        public static void startnext() {

            yoyo = new Guna.UI2.WinForms.Guna2ProgressBar();

            yoyo.Name = "yoyo" + donwlist;
            yoyo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            yoyo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            yoyo.Location = new System.Drawing.Point(63, 185);
            yoyo.Name = "yoyo";
            yoyo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            yoyo.ProgressColor2 = System.Drawing.Color.Teal;
            yoyo.ShadowDecoration.Parent = yoyo;
            yoyo.ShowPercentage = true;
            yoyo.Size = new System.Drawing.Size(496, 15);
            yoyo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            yoyo.TabIndex = 73;
            yoyo.TabStop = false;
            yoyo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            yoyo.Value = 0;
            yoyo.Dock = System.Windows.Forms.DockStyle.Bottom;
            yoyo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            foreach (Control contr in p3.Controls)
            {
                if (contr is Guna.UI2.WinForms.Guna2Panel)
                {
                    if (contr.Name.Equals("dp" + waitIndex.ElementAt(0))) {

                        contr.Controls.Add(yoyo);
                    }
                   


                }
            }
               


            downloader1.LocalDirectory = waitname.ElementAt(0);

                downloader1.Files.Add(new FileDownloader.FileInfo(waitURL.ElementAt(0))); ;

                downloader1.Start();
                downloadcount++;
                donwIsOn = true;
                var tt = Task.Run(() =>
                {
                    int xx = donwlist;
                    while ((int)downloader1.CurrentFilePercentage() <= 100)
                    {
                        yoyo.Value = (int)downloader1.CurrentFilePercentage();



                        if (downloader1.SupportsProgress)
                        {
                            yoyo.Value = (int)downloader1.CurrentFilePercentage();

                        }
                        if ((int)downloader1.CurrentFilePercentage() == 100)
                        {
                            //downloadcount--;
                            donwIsOn = false;
                            startnextpre();

                        }
                    }
                });

            waitIndex.RemoveAt(0);
            waitURL.RemoveAt(0);
            waitname.RemoveAt(0);

        }
        public static void removieaftercomp() {
            

            p3.Controls.RemoveAt(0);
            /* Invoke((Action)(() =>
                          {
                              p3.Controls.RemoveAt(x);
                          }));*/
            // Invoke(new Action(() => {  }));

            //fname.Text =  p3.Controls[x].ToString();
            //  removieaftercomp(x);
            // removieaftercomp();
        }


        int j = 0;


        public static void  shownot(string name) {

            NotifyIcon notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = "Download Complete";
            notifyIcon1.BalloonTipText = name;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //testla.Text = "" + downloader1.DownloadSpeed;

            /*
                        waitURL.Add("1");
                        waitURL.Add("2");
                        waitURL.Add("3");
                        waitURL.Add("4");


                        waitURL.RemoveAt(1);
                        testla.Text = waitURL.ElementAt(1);*/
            //  j++;

            // writeline("ok");




        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (downloader1idon == 2)
            {
                downloader1.Pause();
                downloader1idon = 1;

            }
            if (downloader2idon == 2)
            {
                downloader2.Pause();
                downloader2idon = 1;

            }
            if (downloader3idon == 2)
            {

                downloader3.Pause();
                downloader3idon = 1;
            }
            if (downloader4idon == 2)
            {
                downloader4.Pause();
                downloader4idon = 1;

            }
            if (downloader5idon == 2)
            {
                downloader5.Pause();
                downloader5idon = 1;
            }





            // for (int i = 0;i< 10;i++) {
            // Label lab = (Label)FindControlRecursive(downp, "o0");
            //  truesize.Text = lab.Text; 
            //fname.Text = downp.Controls[2].ToString() ;
            //}
            //truesize.Text =p3.GetChildAtPoint;
            // ForeachPanelControls("ass");
            // yoyo.Value = 50;
            //  GetControl(0);
        }
        public Control GetControl(int index)
        {
            Control backcont=null;
            foreach (Control contr in p3.Controls)
            {
                if (contr is Guna.UI2.WinForms.Guna2Panel)
                {
                    foreach (Control ccc in contr.Controls) {
                        ccc.BackColor = Color.White;

                        if (contr.Name.Equals("yoyo" + index)) {

                           // ccc.Value = 5;

                        }
                    }

                   
                }
              /*  else if (contr is TextBox)
                {
                    if (contr.Name.Equals(contName))
                        contr.Name = "The current value";
                    else
                        contr.Text = null;
                }*/
            }


            return backcont;
        }

        private void oneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
          //  testla.Text = selectedindex.ToString();
            int index = selectedindex;
            string[] lines = System.IO.File.ReadAllLines("list.txt");

            int o = 0;

            string ppaatthh = "";
            foreach (string line in lines)
            {
                o++;
               
                if (o == (index*3))
                {
                    ppaatthh = line;
                   

              
                }
                

            }

            if (File.Exists(ppaatthh))
            {
                Process.Start("explorer.exe", ppaatthh);
            }

        }

        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //testla.Text = selectedindex.ToString();
            int index = selectedindex;
            string[] lines = System.IO.File.ReadAllLines("list.txt");

            int o = 0;

            string ppaatthh = "";
            foreach (string line in lines)
            {
                o++;

                if (o == (index * 3))
                {
                    ppaatthh = @line;



                }


            }
            Process.Start("explorer.exe", ppaatthh);
            // string str = @"C:\Users\Mohammad\source\repos\top\top\bin\Debug";

            /* if (File.Exists(str))
             {*/

            //}

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = selectedindex;
           // testla.Text = index + "";
           
            List<string> quotelist = File.ReadAllLines("list.txt").ToList();
            string firstItem = quotelist[0];

            quotelist.RemoveAt((index * 3) - 1);
            quotelist.RemoveAt((index * 3) - 2);
            quotelist.RemoveAt((index * 3) - 3);
           // testla.Text = quotelist.Count+"";
            File.WriteAllLines("list.txt", quotelist.ToArray());
            

            p1.Visible = false;
            p1.Controls.Clear();
            test1.Refresh();
            test1.Controls.Clear();
            
            dlist = -1;
            getlist();
            p1.Visible = true;
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //p1.VerticalScroll.Value = 20;
           
        }
    }
}
