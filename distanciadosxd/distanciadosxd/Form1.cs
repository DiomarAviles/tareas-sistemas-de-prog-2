using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace distanciadosxd
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
        private void btn_calc_Click(object sender, EventArgs e)
        {
           
           
          
        }

        private void btn_calc_Click_1(object sender, EventArgs e)
        {
            {
                DISTANCIA llamar = new DISTANCIA(double.Parse(txtx1.Text), double.Parse(txt_x2.Text), double.Parse(txt_y1.Text), double.Parse(txt_y2.Text));

            }
        }
    }
}