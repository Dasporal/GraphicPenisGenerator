using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicPenisGenerator
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string size;
        Generator Gen = new Generator(0,"");
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            labPenis.Text = Gen.generatedPenis(Gen.sizeD(Gen.setSize()));
            Gen.clear();
        }

        private void chkGen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGen.Checked== true)
            {
                grpBoxChoice.Visible = true;
                btnGenerate.Enabled = false;
            }
            if (chkGen.Checked == false)
            {
                grpBoxChoice.Visible = false;
                timer.Enabled = false;
                btnGenerate.Enabled = true;
            }
        }
        private void radMs_CheckedChanged(object sender, EventArgs e)
        {
            if (radMs.Checked == true)
            {  
                timer.Interval = 100;
                timer.Start();
                if (timer.Equals(timer.Interval))
                {
                    labPenis.Text = Gen.generatedPenis(Gen.sizeD(Gen.setSize()));
                    Gen.clear();
                }
            }
        }
        private void radSec_CheckedChanged(object sender, EventArgs e)
        {
            if (radSec.Checked == true)
            {   
                timer.Interval = 1000;
                timer.Enabled = true;
                timer.Start();
                if (timer.Equals(timer.Interval))
                {
                    labPenis.Text = Gen.generatedPenis(Gen.sizeD(Gen.setSize()));
                    Gen.clear();
                }
            }
        }

        private void radMin_CheckedChanged(object sender, EventArgs e)
        {
            if (radMin.Checked == true)
            {
                timer.Interval = 60000;
                timer.Start();
                if (timer.Equals(timer.Interval))
                {
                    labPenis.Text = Gen.generatedPenis(Gen.sizeD(Gen.setSize()));
                    Gen.clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labPenis.Text = "Cleared, regenerate me!";
        }
    }
}
