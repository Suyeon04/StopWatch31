using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class btnStart : Form
    {
        private int elapsedTime = 0;
        public btnStart()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.elapsedTime++;
            this.lblStatus.Text = this.elapsedTime + "초 경과";
            this.tbStatus.Text = this.elapsedTime + "초 경과";
            this.progressBar1.Value = this.elapsedTime;
            if (this.progressBar1.Maximum == this.progressBar1.Value)
            {
                timer1.Enabled = false;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnStart.Text = "시작~";
            }
            else
            {
                timer1.Enabled = true;
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
