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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string size;
        private int sizeP;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random sizePenis = new Random();
            sizeP = sizePenis.Next(1,15);
            for(int i=0;i<sizeP;i++)
            {
                size += "=";
            }
            labPenis.Text = "";
            labPenis.Text = "8" + size + "D";
            size = "";
        }
    }
}
