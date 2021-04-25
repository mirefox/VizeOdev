using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace VizeOdev
{
    public partial class Form1 : Form
    {
        XmlTextReader hedefSite;
        FileStream haberBaslikStream;
        FileStream haberİcerikStream;
        FileStream haberFotoStream;

        StreamWriter haberBaslikWriter;
        StreamWriter haberİcerikWriter;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hedefSite = new XmlTextReader("https://rss.haberler.com/rss.asp?kategori=giresun");

            haberBaslikStream = new FileStream("haber_baslik.txt", FileMode.OpenOrCreate, FileAccess.Write);
            haberİcerikStream = new FileStream("haber_icerik.txt", FileMode.OpenOrCreate, FileAccess.Write);
            haberFotoStream   = new FileStream("haber_foto.txt", FileMode.OpenOrCreate, FileAccess.Write);

            haberBaslikWriter = new StreamWriter(haberBaslikStream);
            haberİcerikWriter = new StreamWriter(haberİcerikStream);

            while (hedefSite.Read())
            {
                switch (hedefSite.Name)
                {
                    case "title":
                        haberBaslikWriter.WriteLine(hedefSite.ReadString());
                        haberBaslikları.Items.Add(hedefSite.ReadString());
                        break;


                    case "description":
                        haberİcerikWriter.WriteLine(hedefSite.ReadString());
                        break;


                    //case "media:content":
                    //    string test = hedefSite.ReadString();
                    //    break;

                }
            }

            hedefSite.Close();
            haberBaslikStream.Close();
            haberİcerikStream.Close();
            haberFotoStream.Close();
        }
    }
}
