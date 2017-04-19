using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IoT
{
    public partial class UploadSchema : Form
    {
        OpenFileDialog chooser = new OpenFileDialog();
        XmlValidation xml = new XmlValidation();

        public UploadSchema()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            chooser.Filter = "XSD Files|*.xsd";
            chooser.Title = "Select a XSD File";
            if (chooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xml.addThingschema(chooser.FileName);
                Console.Out.Write("here");
                panel2.Visible = true;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooser.Filter = "XSD Files|*.xsd";
            chooser.Title = "Select a XSD File";
            if (chooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xml.addRequesterSchema(chooser.FileName);
                //Console.Out.Write(chooser.FileName);
                panel1.Visible = true;
            }
       
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
