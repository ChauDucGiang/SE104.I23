using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GooglePlace
{   
    public partial class Form1 : Form
    {   
        
        string[] temp = new string[5];
        public Form1()
        {
            InitializeComponent();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length >= 2)
                {
                    
                    String input = textBox1.Text;
                    String apiKey = "AIzaSyDT_q6mxGrEUXoDg-HeV51LfM9aTmZV0JI";
                    String URLString = "https://maps.googleapis.com/maps/api/place/autocomplete/xml?input=" + input + "&types=geocode&language=vi&key=" + apiKey;

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(URLString);

                    int i = 0;

                    foreach (XmlNode node in xmlDoc.GetElementsByTagName("prediction"))
                    {
                        foreach (XmlNode node1 in node.ChildNodes)
                        {

                            if (node1.Name == "description")
                            {
                                temp[i] = node1.InnerText;
                                i++;

                            }
                            break;

                        }

                    }
                    AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();


                    mycollection.AddRange(temp);

                    textBox1.AutoCompleteCustomSource = mycollection;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
    
    

