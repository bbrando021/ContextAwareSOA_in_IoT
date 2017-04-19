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
    public partial class DisplayThing : Form
    {
        public DisplayThing()
        {
            InitializeComponent();
        }

        public void display(int i)
        {
            Thing thing = ServiceManager.getInstance().getThing(i);


            if (thing.ObjectName != "") 
                objNameL.Text = thing.ObjectName;
            if (thing.Brand != "")
            {
                br.Text = thing.Brand;
                br.Visible = true;
            }
            if (thing.Model != "")
            {
                mo.Text = thing.Model;
                mo.Visible = true;
            }
            if (thing.ObjectDescription != "")
            {
                de.Visible = true;
                de.Text = thing.ObjectDescription;
            }
            if (thing.ObjContextTag != null)
            {
                objCont.Items.Clear();
                objCont.Visible = true;
                for(int j =0; j < thing.ObjContextTag.Count; j++)
                {
                    Console.Out.WriteLine(thing.ObjContextTag[j] + "   " + thing.ObjContextDesc[j]);
                    objCont.Items.Add(thing.ObjContextTag[j] + " : " + thing.ObjContextDesc[j]);
                }
            }
            if (thing.ObjPropertiesTag != null)
            {
                objProp.Items.Clear();
                objProp.Visible = true;
                for (int j = 0; j < thing.ObjPropertiesTag.Count; j++)
                {
                    objProp.Items.Add(thing.ObjPropertiesTag[j] + " : " + thing.ObjPropertiesDesc[j]);
                }
            }
            if (thing.ServiceName != "")
            {
                label3.Visible = true;
                label3.Text = thing.ServiceName;
            }
            if (thing.ServiceDesc != "")
            {
                label4.Visible = true;
                label4.Text = thing.ServiceDesc;
            }
            if (thing.Output != "")
            {
                output.Visible = true;
                output.Text = thing.Output;
            }
            if (thing.ExampleOutput != "")
            {
                exOut.Visible = true;
                exOut.Text = thing.ExampleOutput;
            }
            if (true)
            {
                label18.Visible = true;
                label18.Text = thing.Cost.ToString();
            }
            if (thing.InteropOtherService != "")
            {
                label11.Visible = true;
                label11.Text = thing.InteropOtherService;
            }
            if (thing.Security != "")
            {
                label13.Visible = true;
                label13.Text = thing.Security;
            }
            if (true)
            {
                label15.Visible = true;
                label15.Text = thing.ScalabilityNum.ToString();
            }
            if (thing.PerformUnits != "")
            {
                label22.Visible = true;
                label22.Text = (thing.PerformTime + " " + thing.PerformUnits);
            }
            if (true)
            {
                label20.Visible = true;
                label20.Text = thing.Availability.ToString();
            }
            if (thing.AccessibilityLink != "")
            {
                label24.Visible = true;
                label24.Text = thing.AccessibilityLink;
            }


            if (thing.ServiceName == null && thing.ServiceDesc == null) {
                Console.Out.WriteLine("changing the size of frame");
                this.Width = 520;
                this.Height = 269;
                this.CenterToScreen();
            }
        }

        
        private void label17_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void DisplayThing_Load(object sender, EventArgs e)
        {

        }
    }
}
