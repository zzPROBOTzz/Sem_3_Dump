using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using xml_file.Properties;
using System.Xml.Linq;

namespace xml_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string dirPath = @".\Files\";
        string path = dirPath + "ProductsB.txt"; 
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; settings.IndentChars = (" ");
            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(path,settings);
            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Users");
            for (int i = 1; i < 6; i++)
            {
                xmlOut.WriteStartElement("Application");
                xmlOut.WriteElementString("Code", txtCode.Text + i);
                xmlOut.WriteElementString("Description", txtDescription.Text + i);
                xmlOut.WriteElementString("Price", txtPrice.Text + i);
                // write the end tag for the root element
                xmlOut.WriteEndElement();
            }
            // write the end tag for the root element
            xmlOut.WriteEndElement();
            // close the XmlWriter object
            xmlOut.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(path, settings);
            string textToPrint = "code \t description\t price\n";
            string description, code;
            string price;
            // read past all nodes to the first UseName node
            while (xmlIn.ReadToNextSibling("UserName"))
            {
                code = xmlIn.ReadElementContentAsString();
                description = xmlIn.ReadElementContentAsString();
                price = xmlIn.ReadElementContentAsString();
                textToPrint = code + "\t" + description + "\t" + price + "\n";
            }
            xmlIn.Close();
            MessageBox.Show(textToPrint);
           
            // close the XmlReader object
          
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath) == false) Directory.CreateDirectory(dirPath);
        }
    }
}
