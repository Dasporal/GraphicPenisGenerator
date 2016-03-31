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
            //labPenis.Text = " ";
            size = Gen.sizeD(Gen.setSize());
            labPenis.Text = Gen.generatedPenis(size);
            Gen.clear();
        }

        private void chkGen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGen.Checked== true)
            {
                grpBoxChoice.Visible = true;
            }
            if (chkGen.Checked == false)
            {
                grpBoxChoice.Visible = false;
            }
        }

        private void radSec_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
