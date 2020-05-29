using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bismillah
{
    public partial class panelChildForm : Form
    {
        public panelChildForm()
        {
            InitializeComponent();
        }

        private void fiveCodPanelShadow1_Load(object sender, EventArgs e)
        {

        }

        private void fiveCodCloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fiveCodProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add(" ");
            chart1.Series["foll"].Points.AddXY("New", "30");
            chart1.Series["foll"].Points.AddXY("Unfoll", "10");
            chart1.Series["foll"].Points.AddXY("Dont Follback", "50");
            chart1.Series["foll"].Points.AddXY("Follback", "10");

            chart2.Titles.Add(" ");
            chart2.Series["day"].Points.AddXY("Sun", "10");
            chart2.Series["day"].Points.AddXY("Mon", "30");
            chart2.Series["day"].Points.AddXY("Tues", "10");
            chart2.Series["day"].Points.AddXY("Wedn", "5");
            chart2.Series["day"].Points.AddXY("Thurs", "10");
            chart2.Series["day"].Points.AddXY("Fri", "5");
            chart2.Series["day"].Points.AddXY("Sat", "30");

            chart3.Titles.Add(" ");
            chart3.Series["jenkel"].Points.AddXY("Perempuan", "30");
            chart3.Series["jenkel"].Points.AddXY("Laki-Laki", "70");
        }


        private void fiveCodLabel29_Click(object sender, EventArgs e)
        {

        }

        private void fiveCodFlatButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private Form childForm;

        public panelChildForm(Form activeForm)
        {
           
        }


        private readonly Form activForm = null;
        private void openChildForm(Form childFrom)
        {

        }

        private void fiveCodFlatButton2_Click(object sender, EventArgs e)
        {

        }
    }
}