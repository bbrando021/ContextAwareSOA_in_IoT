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

namespace IoT
{
    
    public partial class UploadRequest : Form
    {
        public static MainForm prog = Program.getForm();
        int done;
        XmlValidation xml = new XmlValidation();

        public UploadRequest()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string objName = null;

            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select a XML File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xml.addRequesterXML(openFileDialog1.FileName);
                //bool valid = xml.validateRequester();
                //Console.Out.WriteLine(valid);
                bool valid = true;

                ServiceManager.getInstance().Request = new Request();

                if (valid == true)
                {

                    using (XmlReader reader = XmlReader.Create(openFileDialog1.FileName))
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "cost")
                            {
                                //Console.Out.Write("Hello1");
                                ServiceManager.getInstance().Request.Cost = Convert.ToDouble(reader.ReadString());
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                                && reader.Name == "contextOfRequester")
                            {
                                while (reader.Read())
                                {
                                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "contextOfRequester")
                                    {
                                        break;
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "tag")
                                    {
                                        ServiceManager.getInstance().Request.ContextRequesterTag.Add(reader.ReadString());
                                    }
                                    else if (reader.NodeType == XmlNodeType.Element
                                        && reader.Name == "description")
                                    {
                                        ServiceManager.getInstance().Request.ContextRequesterDesc.Add(reader.ReadString());
                                    }
                                }
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                               && reader.Name == "interoperability")
                            {
                                ServiceManager.getInstance().Request.InteroperabilityWeight = Convert.ToDouble(reader.GetAttribute("weight"));
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                               && reader.Name == "security")
                            {
                                ServiceManager.getInstance().Request.SecurityWeight = Convert.ToDouble(reader.GetAttribute("weight"));
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                              && reader.Name == "scalability")
                            {
                                ServiceManager.getInstance().Request.ScalabilityWeight = Convert.ToDouble(reader.GetAttribute("weight"));
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                               && reader.Name == "performance")
                            {
                                ServiceManager.getInstance().Request.PerformanceWeight = Convert.ToDouble(reader.GetAttribute("weight"));
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                               && reader.Name == "availability")
                            {
                                //Console.Out.Write("Hello1");
                                ServiceManager.getInstance().Request.AvailabilityWeight = Convert.ToDouble(reader.GetAttribute("weight"));
                            }
                            else if (reader.NodeType == XmlNodeType.Element
                              && reader.Name == "accessibility")
                            {
                                //Console.Out.Write("Hello1");
                                ServiceManager.getInstance().Request.AccessibilityWeight = Convert.ToDouble(reader.GetAttribute("weight"));
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
                                        ServiceManager.getInstance().Request.SearchTags.Add(reader.ReadString());
                                    }
                                }
                            }

                        }
                    }
                }
            }
            this.Close();
            done = 0;
            prog.populateThings();
            //Console.Out.WriteLine(ServiceManager.getInstance().Request.InteroperabilityWeight);
            //Console.Out.WriteLine(ServiceManager.getInstance().Request.SecurityWeight);
            //Console.Out.WriteLine(ServiceManager.getInstance().Request.ScalabilityWeight);
            //Console.Out.WriteLine(ServiceManager.getInstance().Request.PerformanceWeight);
            //Console.Out.WriteLine(ServiceManager.getInstance().Request.AvailabilityWeight);
            //Console.Out.WriteLine(ServiceManager.getInstance().Request.AccessibilityWeight);

            //Console.Out.Write(ServiceManager.getInstance().Request.SearchTags[7]);

            //        //load xml
            //        reader.MoveToContent();
            //        while (reader.Read())
            //        {
            //            //check for cost
            //            if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "cost")
            //            {
            //                costW = reader.GetAttribute("weight");
            //                cost = reader.ReadString();
            //                Console.Out.WriteLine("\n\n" + costW);
            //            }
            //            //check for context, and keep looping until all context has been got
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "contextOfThing")
            //            {
            //                while (reader.Read())
            //                {
            //                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "contextOfThing")
            //                    {
            //                        break;
            //                    }
            //                    if (reader.NodeType == XmlNodeType.Element)
            //                    {
            //                        contextW[countC] = reader.GetAttribute("weight");
            //                        context[countC] = reader.ReadString();
            //                        countC++;
            //                    }
            //                }
            //            }
            //            //get interoperability boolean and string
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "interoperability")
            //            {
            //                interW = reader.GetAttribute("weight");

            //                while (reader.Read())
            //                {
            //                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "boolean")
            //                    {
            //                        if (reader.ReadString() == "true" || reader.ReadString() == "True")
            //                        {
            //                            inter = true;
            //                        }
            //                    }
            //                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "otherServiceName")
            //                    {
            //                        interS = reader.ReadString();
            //                        break;
            //                    }

            //                }
            //            }
            //            //get security string
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "security")
            //            {
            //                secW = reader.GetAttribute("weight");
            //                sec = reader.ReadString();
            //            }
            //            //get interoperability boolean and string
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "scalability")
            //            {
            //                scalW = reader.GetAttribute("weight");
            //                while (reader.Read())
            //                {
            //                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "boolean")
            //                    {
            //                        if (reader.ReadString() == "true" || reader.ReadString() == "True")
            //                        {
            //                            scal = true;
            //                        }
            //                    }
            //                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "scalabilityDesc")
            //                    {
            //                        scalS = reader.ReadString();
            //                        break;
            //                    }

            //                }
            //            }
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "performance")
            //            {
            //                perW = reader.GetAttribute("weight");
            //                per = reader.ReadString();
            //            }
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "availability")
            //            {
            //                avaW = reader.GetAttribute("weight");
            //                ava = reader.ReadString();
            //            }
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "accessibility")
            //            {
            //                accW = reader.GetAttribute("weight");
            //                acc = reader.ReadString();
            //            }
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "requirements")
            //            {
            //                req = reader.ReadString();
            //            }
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "input")
            //            {
            //                inp = reader.ReadString();
            //            }
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "output")
            //            {
            //                outp = reader.ReadString();
            //            }
            //            else if (reader.NodeType == XmlNodeType.Element
            //                && reader.Name == "searchTags")
            //            {
            //                while (reader.Read())
            //                {
            //                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "searchTags")
            //                    {
            //                        break;
            //                    }
            //                    if (reader.NodeType == XmlNodeType.Element)
            //                    {
            //                        tags[countT] = reader.ReadString();
            //                        countT++;
            //                    }
            //                }
            //            }
            //        }
            //    }



            //    //INITIALIZING REQUEST
            //    ServiceManager.getInstance().initializeRequest();
            //    //COST
            //    ServiceManager.getInstance().Request.Cost = Convert.ToDouble(cost);
            //    ServiceManager.getInstance().Request.CostWeight = Convert.ToDouble(costW);
            //    textBox1.Text = "(" + costW + ") " + "$" + cost;
            //    //CONTEXT
            //    for (int i = 0; i < countC; i++)
            //    {
            //        comboBox1.Items.Add("(" + contextW[i] + ") " +context[i]);
            //        ServiceManager.getInstance().Request.addContext(context[i]);
            //        ServiceManager.getInstance().Request.addContextWeight(Convert.ToDouble(contextW[i]));
            //    }
            //    comboBox1.SelectedIndex = 0;
            //    //INTEROPERABILITY
            //    textBox2.Text = "(" + interW + ") " + interS;
            //    ServiceManager.getInstance().Request.InteroperabilityBool = inter;
            //    ServiceManager.getInstance().Request.Interoperability = interS;
            //    ServiceManager.getInstance().Request.InteroperabilityWeight = Convert.ToDouble(interW);
            //    //SECURITY
            //    textBox3.Text = "(" + secW + ") "+ sec;
            //    ServiceManager.getInstance().Request.Security = sec;
            //    ServiceManager.getInstance().Request.SecurityWeight = Convert.ToDouble(secW);
            //    //SCALABILITY
            //    textBox4.Text = "(" + scalW + ") " + scalS;
            //    ServiceManager.getInstance().Request.Scalability = scalS;
            //    ServiceManager.getInstance().Request.ScalabilityBool = scal;
            //    ServiceManager.getInstance().Request.ScalabilityWeight = Convert.ToDouble(scalW);
            //    //PERFORMANCE
            //    textBox5.Text = "(" + perW + ") "+ per;
            //    ServiceManager.getInstance().Request.Performance = per;
            //    ServiceManager.getInstance().Request.PerformanceWeight = Convert.ToDouble(perW);
            //    //AVAILABILITY
            //    textBox10.Text = "(" + avaW + ") " + ava;
            //    ServiceManager.getInstance().Request.Availability = Convert.ToDouble(ava);
            //    ServiceManager.getInstance().Request.AvailabilityWeight = Convert.ToDouble(avaW);
            //    //ACCESSABILITY
            //    textBox6.Text = "(" + accW + ") "+ acc;
            //    ServiceManager.getInstance().Request.Accessibliity = acc;
            //    ServiceManager.getInstance().Request.AccessibilityWeight= Convert.ToDouble(accW);
            //    //REQUIREMENTS
            //    textBox11.Text = req;
            //    ServiceManager.getInstance().Request.Requirements = req;
            //    //INPUT
            //    textBox8.Text = inp;
            //    ServiceManager.getInstance().Request.Input = inp;
            //    //OUTPUT
            //    textBox9.Text = outp;
            //    ServiceManager.getInstance().Request.Output = outp;

            //    //TAGS
            //    string tempC = "";
            //    for (int i = 0; i < countT; i++)
            //    {
            //        tempC += ("<" + tags[i] + ">");
            //        ServiceManager.getInstance().Request.addTags(tags[i]);
            //    }
            //    textBox12.Text = tempC;

            //    this.Width = 425;
            //    this.Height = 710;
            //    textBox1.Visible = true;
            //    textBox2.Visible = true;
            //    textBox3.Visible = true;
            //    textBox4.Visible = true;
            //    textBox5.Visible = true;
            //    textBox6.Visible = true;
            //    textBox8.Visible = true;
            //    textBox9.Visible = true;
            //    textBox10.Visible = true;
            //    textBox11.Visible = true;
            //    textBox12.Visible = true;
            //    label3.Visible = true;
            //    label4.Visible = true;
            //    label5.Visible = true;
            //    label6.Visible = true;
            //    label7.Visible = true;
            //    label8.Visible = true;
            //    label9.Visible = true;
            //    label10.Visible = true;
            //    label12.Visible = true;
            //    label13.Visible = true;
            //    label15.Visible = true;
            //    label16.Visible = true;
            //    comboBox1.Visible = true;

            //    this.CenterToScreen();
            //    done = 1;
            //}
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceManager.getInstance().initializeRequest();
            this.Close();
            done = 0;
            
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if(done == 1)
                ServiceManager.getInstance().initializeRequest();
            this.Close();
            done = 0;
            
        }
    }
}
