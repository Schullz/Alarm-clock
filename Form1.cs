using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;            
            for (int i = 0; i < tt.Count; i++)
            {
                if (t > tt[i])
                {
                    tt.Remove(tt[i]);
                    this.TopMost = true;
                    var ss = listBox1.Items[i].ToString();
                    listBox1.Items.RemoveAt(i);
                    listBox2.Items.Add(t.ToLocalTime() + " " + ss);
                    MessageBox.Show(ss);
                    this.TopMost = false;
                    return;
                }
            }
        }

        List<DateTime> tt = new List<DateTime>();

        private void addB_Click(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            int dh = (int)hoursNUD.Value;
            int dm = (int)minutesNUD.Value;
            t = t.Add(new TimeSpan(dh, dm, 0));
            listBox1.Items.Add(t.ToString() + " " + textBox1.Text);
            tt.Add(t);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndex >= 0)
            {
                int id = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(id);
                tt.RemoveAt(id);
            }
        }
    }
}
