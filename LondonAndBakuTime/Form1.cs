using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LondonAndBakuTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bakubutton_MouseClick(object sender, MouseEventArgs e)
        {
            londonpictureBox.Visible = false;
            bakupictureBox.Visible = true;
            var now = DateTime.Now;
            bakubutton.Visible = false;
            timelabel.Text = now.ToString();
            timelabel.Visible = true;
            londonbutton.Visible = true;
        }

        private void londonbutton_MouseClick(object sender, MouseEventArgs e)
        {
            londonpictureBox.Visible = true;
            londonbutton.Visible = false;
            var now = DateTime.Now;
            timelabel.Text = now.AddHours(-3).ToString();
            timelabel.Visible = true;
            bakubutton.Visible = true;
        }

        private void bakupictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            londonpictureBox.Visible = true;
            londonbutton.Visible = false;
            var now = DateTime.Now;
            timelabel.Text = now.AddHours(-3).ToString();
            timelabel.Visible = true;
            bakubutton.Visible = true;
        }

        private void londonpictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            bakubutton.Visible = true;
            londonbutton.Visible = true;
            timelabel.Visible = false;
        }
    }
}
