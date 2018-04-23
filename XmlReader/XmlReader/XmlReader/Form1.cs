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
using System.Xml.XPath;
using System.Collections; 

namespace XmlReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xTReader = new XmlTextReader("Tickets.xml");
            xTReader.WhitespaceHandling = WhitespaceHandling.None;


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xTReader);
            XmlNodeList xNodeList =
            xDoc.DocumentElement.SelectNodes("/Tickets/Ticket/" + textBox1.Text);
            listBox1.Items.Clear();

            foreach (XmlNode xNode in xNodeList)
            {
                if (xNode.NodeType == XmlNodeType.Element)
                {
                    listBox1.Items.Add(xNode.Name + " = " + xNode.FirstChild.Value);
                }
                else
                {
                    listBox1.Items.Add(xNode.NodeType.ToString() + ": " +
                    xNode.Name + " = " + xNode.Value);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlTextReader xTReader = new XmlTextReader("Tickets.xml");
            xTReader.WhitespaceHandling = WhitespaceHandling.None;


                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(xTReader);
                XmlNodeList xNodeList =
                xDoc.DocumentElement.SelectNodes("/Tickets/Ticket/*");
                listBox1.Items.Clear();

                foreach (XmlNode xNode in xNodeList)
                {
                    if (xNode.NodeType == XmlNodeType.Element)
                    {
                        listBox1.Items.Add(xNode.Name + " = " + xNode.FirstChild.Value);
                    }
                    else
                    {
                        listBox1.Items.Add(xNode.NodeType.ToString() + ": " +
                        xNode.Name + " = " + xNode.Value);
                    }
                }
            }
        }
    }

