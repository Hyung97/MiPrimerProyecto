using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            sbyte NUM1 = sbyte.Parse(txt1.Text);
            sbyte NUM2 = sbyte.Parse(txt2.Text);
            lblAnswer.Text = "RESPUESTA: " + (NUM1 + NUM2);
        }
    }
}
