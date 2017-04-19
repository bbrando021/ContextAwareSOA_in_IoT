using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace IoT
{
    public partial class UploadThing : Form
    {
        int done;
        private object listBox1;
        private int editCount = 0;
        XmlValidation xml = new XmlValidation();

        public UploadThing()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            comboBox1.Visible = false;
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string objName = null;

            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select a XML File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xml.addThingXML(openFileDialog1.FileName);
                //bool valid = xml.validateThing();
                //Console.Out.WriteLine(valid);
                bool valid = true;
                if (valid == true)
                {

                    using (XmlReader reader = XmlReader.Create(openFileDialog1.FileName))
                    {

                        ServiceManager.getInstance().addThings(new Thing());
                        int size = ServiceManager.getInstance().sizeThings() - 1;

                        //load xml
                        reader.MoveToContent();
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "objectName")
                            {
                                //Console.Out.Write("Hello1");
                                ServiceManager.getInstance().getThing(size).ObjectName = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "brand")
                            {
                                ServiceManager.getInstance().getThing(size).Brand = reader.ReadString();
                                Console.Out.Write(ServiceManager.getInstance().getThing(size).Brand);
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "model")
                            {
                                ServiceManager.getInstance().getThing(size).Model = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "objectDescription")
                            {
                                ServiceManager.getInstance().getThing(size).ObjectDescription = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "contextOfObject")
                            {
                                while (reader.Read())
                                {
                                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "contextOfObject")
                                    {
                                        break;
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "tag")
                                    {
                                        ServiceManager.getInstance().getThing(size).ObjContextTag.Add(reader.ReadString());
                                        Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).ObjContextTag[0]);
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "description")
                                    {
                                        ServiceManager.getInstance().getThing(size).ObjContextDesc.Add(reader.ReadString());
                                        Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).ObjContextDesc[0]);
                                    }
                                }
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "propertiesOfObject")
                            {
                                while (reader.Read())
                                {
                                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "propertiesOfObject")
                                    {
                                        break;
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "tag")
                                    {
                                        ServiceManager.getInstance().getThing(size).ObjPropertiesTag.Add(reader.ReadString());
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "description")
                                    {
                                        ServiceManager.getInstance().getThing(size).ObjPropertiesDesc.Add(reader.ReadString());
                                    }
                                }
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "serviceName")
                            {
                                ServiceManager.getInstance().getThing(size).ServiceName = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "serviceDescription")
                            {
                                ServiceManager.getInstance().getThing(size).ServiceDesc = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "input")
                            {
                                while (reader.Read())
                                {
                                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "input")
                                    {
                                        break;
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "name")
                                    {
                                        ServiceManager.getInstance().getThing(size).InputName.Add(reader.ReadString());
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "type")
                                    {
                                        ServiceManager.getInstance().getThing(size).InputType.Add(reader.ReadString());
                                    }
                                }
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "output")
                            {
                                ServiceManager.getInstance().getThing(size).Output = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "exampleOutput")
                            {
                                ServiceManager.getInstance().getThing(size).ExampleOutput = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "cost")
                            {
                                ServiceManager.getInstance().getThing(size).Cost = Convert.ToDouble(reader.ReadString());
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "boolean")
                            {
                                string s = reader.ReadString();
                                ServiceManager.getInstance().getThing(size).InteropBool1 = s;
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "otherServiceName")
                            {
                                ServiceManager.getInstance().getThing(size).InteropOtherService = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "security")
                            {
                                ServiceManager.getInstance().getThing(size).Security = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "scalability")
                            {
                                ServiceManager.getInstance().getThing(size).ScalabilityNum = Convert.ToInt32(reader.ReadString());
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "time")
                            {
                                ServiceManager.getInstance().getThing(size).PerformTime = Convert.ToInt32(reader.ReadString());
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "units")
                            {
                                ServiceManager.getInstance().getThing(size).PerformUnits = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "availability")
                            {
                                ServiceManager.getInstance().getThing(size).Availability = Convert.ToDouble(reader.ReadString());
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                       && reader.Name == "accessibility")
                            {
                                ServiceManager.getInstance().getThing(size).AccessibilityLink = reader.ReadString();
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "searchTags")
                            {
                                while (reader.Read())
                                {
                                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "searchTags")
                                    {
                                        break;
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "tag")
                                    {
                                        ServiceManager.getInstance().getThing(size).SearchTags.Add(reader.ReadString());
                                    }
                                }
                            }


                            }

                            Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).ObjContextTag[0]);
                            //Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).Brand);
                            //Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).Model);
                            //Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).ObjContextTag[0]);
                            //Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).ObjPropertiesDesc[0]);
                            //Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).Availability);
                            //Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).PerformUnits);
                            //Console.Out.WriteLine(ServiceManager.getInstance().getThing(size).SearchTags[6]);


                        //Console.Out.Write(objName);

                        //        //check for context, and keep looping until all context has been got
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "contextOfThing")
                        //        {
                        //            while (reader.Read())
                        //            {
                        //                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "contextOfThing")
                        //                {
                        //                    break;
                        //                }
                        //                if (reader.NodeType == XmlNodeType.Element)
                        //                {
                        //                    context[countC] = reader.ReadString();
                        //                    countC++;
                        //                }
                        //            }
                        //        }
                        //        //get interoperability boolean and string
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "interoperability")
                        //        {
                        //            while (reader.Read())
                        //            {
                        //                if (reader.NodeType == XmlNodeType.Element && reader.Name == "boolean")
                        //                {
                        //                    if (reader.ReadString() == "true" || reader.ReadString() == "True")
                        //                    {
                        //                        inter = true;
                        //                    }
                        //                }
                        //                if (reader.NodeType == XmlNodeType.Element && reader.Name == "otherServiceName")
                        //                {
                        //                    interS = reader.ReadString();
                        //                    break;
                        //                }

                        //            }
                        //        }
                        //        //get security string
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "security")
                        //        {
                        //            sec = reader.ReadString();
                        //        }
                        //        //get interoperability boolean and string
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "scalability")
                        //        {
                        //            while (reader.Read())
                        //            {
                        //                if (reader.NodeType == XmlNodeType.Element && reader.Name == "boolean")
                        //                {
                        //                    if (reader.ReadString() == "true" || reader.ReadString() == "True")
                        //                    {
                        //                        scal = true;
                        //                    }
                        //                }
                        //                if (reader.NodeType == XmlNodeType.Element && reader.Name == "scalabilityDesc")
                        //                {
                        //                    scalS = reader.ReadString();
                        //                    break;
                        //                }

                        //            }
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "performance")
                        //        {
                        //            per = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "availability")
                        //        {
                        //            ava = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "accessibility")
                        //        {
                        //            acc = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "exampleData")
                        //        {
                        //            exp = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "requirements")
                        //        {
                        //            req = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "input")
                        //        {
                        //            inp = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "output")
                        //        {
                        //            outp = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "thingName")
                        //        {
                        //            name = reader.ReadString();
                        //        }
                        //        else if (reader.NodeType == XmlNodeType.Element
                        //            && reader.Name == "searchTags")
                        //        {
                        //            while (reader.Read())
                        //            {
                        //                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "searchTags")
                        //                {
                        //                    break;
                        //                }
                        //                if (reader.NodeType == XmlNodeType.Element)
                        //                {
                        //                    tags[countT] = reader.ReadString();
                        //                    countT++;
                        //                }
                        //            }
                        //        }
                        //    }
                        //}



                        //     ServiceManager.getInstance().addThings(new Thing());
                        ////COST
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Cost = Convert.ToDouble(cost);
                        //     textBox1.Text = cost;
                        ////CONTEXT
                        //     for(int i = 0; i < countC; i++)
                        //     {
                        //         comboBox1.Items.Add(context[i]);
                        //         ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].addContext(context[i]);
                        //     }
                        //     comboBox1.SelectedIndex = 0;
                        ////INTEROPERABILITY
                        //     textBox2.Text = interS;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].InteroperabilityBool = inter;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Interoperability = interS;
                        ////SECURITY
                        //     textBox3.Text = sec;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Security = sec;
                        ////SCALABILITY
                        //     textBox4.Text = scalS;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].ScalabilityBool = scal;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Scalability = scalS;
                        ////PERFORMANCE
                        //     textBox5.Text = per;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Performance = per;
                        // //AVAILABILITY
                        //     textBox10.Text = ava;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Availability = Convert.ToDouble(ava);
                        // //ACCESSABILITY
                        //     textBox6.Text = acc;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Accessibliity = acc;
                        // //EXAMPLE DATA
                        //     textBox7.Text = exp;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].ExampleData = exp;
                        // //REQUIREMENTS
                        //     textBox11.Text = req;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Requirements = req;
                        // //INPUT
                        //     textBox8.Text = inp;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Input = inp;
                        // //OUTPUT
                        //     textBox9.Text = outp;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].Output = outp;
                        // //THINGNAME
                        //     label14.Text = name;
                        //     ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].ThingName = name;
                        // //TAGS
                        //     string tempC = "";
                        //     for (int i = 0; i < countT; i++)
                        //     {
                        //         tempC += ("<" + tags[i] + ">");
                        //         ServiceManager.getInstance().Things[ServiceManager.getInstance().sizeThings() - 1].addTags(tags[i]);
                        //     }
                        //     textBox12.Text = tempC;

                        //     this.Width = 425;
                        //     this.Height = 710;
                        //textBox1.Visible = true;
                        //textBox2.Visible = true;
                        //textBox3.Visible = true;
                        //textBox4.Visible = true;
                        //textBox5.Visible = true;
                        //textBox6.Visible = true;
                        //textBox7.Visible = true;
                        //textBox8.Visible = true;
                        //textBox9.Visible = true;
                        //textBox10.Visible = true;
                        //textBox11.Visible = true;
                        //textBox12.Visible = true;
                        //label3.Visible = true;
                        //label4.Visible = true;
                        //label5.Visible = true;
                        //label6.Visible = true;
                        //label7.Visible = true;
                        //label8.Visible = true;
                        //label9.Visible = true;
                        //label10.Visible = true;
                        //label11.Visible = true;
                        //label12.Visible = true;
                        //label13.Visible = true;
                        //label14.Visible = true;
                        //label15.Visible = true;
                        //label16.Visible = true;
                        //comboBox1.Visible = true;

                        this.CenterToScreen();
                        this.Close();
                        done = 0;
                        if(ServiceManager.getInstance().Request != null)
                            UploadRequest.prog.populateThings();
                    }
                }
            }
        }

            

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            done = 0;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceManager.getInstance().deleteLastThing();
            this.Close();
            done = 0;
            
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if(done == 1)
                ServiceManager.getInstance().deleteLastThing();
            this.Close();
            done = 0;
        }
    }
}
