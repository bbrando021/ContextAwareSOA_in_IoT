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
    public partial class MainForm : Form
    {
        List<MatchOrg> m = new List<MatchOrg>();
        Label l1, l2, l3;
        public MainForm()
        {
            InitializeComponent();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            l1 = this.label1;
            l2 = this.label2;
            l3= this.label3;

        }

        public class MatchOrg
        {
            public int matchCount;
            public int ThingOrder;
        }

        public void populateThings()
        {
            m = new List<MatchOrg>();
            panel1.Controls.Clear();

            int temp = 0;

            for (int i = 0; i < ServiceManager.getInstance().sizeThings(); i++)
            {
                Thing x = ServiceManager.getInstance().getThing(i);
                temp = 0;
                m.Add(new MatchOrg());
                for (int l = 0; l < x.SearchTags.Count; l++)
                {
                    Request r = ServiceManager.getInstance().Request;
                    for (int k = 0; k < r.SearchTags.Count; k++)
                    {
                        if (r.SearchTags[k].Equals(x.SearchTags[l]))
                        {
                            m[i].matchCount++;
                            m[i].ThingOrder = i;
                        }
                    }
                }
            }
            
            
            Console.Out.WriteLine(m.Count);
            int size = 0;
            size = m.Count - 1;
            if(m.Count == 1 && m[0].matchCount == 0)
            {
                return;  //THERE IS NO MATCHES OF SERVICES
            }

            if (size+1 > 0)
            {
                m = m.OrderBy(o => o.matchCount).ToList();
                panel1.Controls.Add(l1);
                panel1.Controls.Add(l2);
                panel1.Controls.Add(l3);
                
            }

            int xCord = 20, yCord = 55, pos = 0;


            for (int w = size; w >= 0; w--)
            {
                Console.Out.WriteLine(m[w].matchCount);
                while(m[w].matchCount == 0)
                {
                    w--;
                    if(w < 0) { return; }
                }
                l1.Visible = true;
                l2.Visible = true;
                l3.Visible = true;

                Label lab = new Label();
                lab.Location = new Point(xCord, yCord);
                xCord += 180;
                lab.Click += thingButtonClick;
                lab.Cursor = Cursors.Hand;
                lab.Text = ServiceManager.getInstance().getThing(m[w].ThingOrder).ObjectName;
                lab.Name = pos.ToString();
                lab.Size = new Size(180, 45);
                lab.Font = new Font("Microsoft Sans Seriff", 10);
                lab.BackColor = Color.Khaki;
                lab.TextAlign = ContentAlignment.MiddleLeft;
                panel1.Controls.Add(lab);

                lab = new Label();
                lab.Location = new Point(xCord, yCord);
                xCord += 360;
                lab.Size = new Size(360, 45);
                lab.Text = ServiceManager.getInstance().getThing(m[w].ThingOrder).ObjectDescription;
                lab.Font = new Font("Microsoft Sans Seriff", 10);
                lab.BackColor = Color.Khaki;
                lab.TextAlign = ContentAlignment.MiddleLeft;
                panel1.Controls.Add(lab);

                lab = new Label();
                lab.Location = new Point(xCord, yCord);
                xCord = 20;
                lab.Text = m[w].matchCount.ToString();
                lab.Size = new Size(90, 45);
                lab.Font = new Font("Microsoft Sans Seriff", 10);
                lab.BackColor = Color.Khaki;
                lab.TextAlign = ContentAlignment.MiddleLeft;
                panel1.Controls.Add(lab);

                yCord += 55;
                pos++;

                Console.Out.WriteLine((w + 1) + ": " + m[w].matchCount);
            }
        }

        private void thingButtonClick(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            for(int i = 0; i < m.Count; i++)
            {
                if (l.Name == m[i].ThingOrder.ToString())
                {
                    Console.Out.WriteLine("HERE");
                    DisplayThing d = new DisplayThing();
                    d.Visible = true;
                    d.display(m[i].ThingOrder);
                }
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UploadThing f = new UploadThing();
            f.Visible = true;
            f.TopMost = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UploadRequest f = new UploadRequest();
            f.Visible = true;
            f.TopMost = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {            
            UploadSchema f = new UploadSchema();
            f.Visible = true;
            f.TopMost = true;
        }
    }
}
