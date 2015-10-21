using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace at.ac.tuwien.dsg.RIFramework.RMod.Visualization {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromStream(VisualizationApp.stream);//Image.FromFile(@"C:\Users\Ogi\Desktop\graf.png");
            
        }
    }
}
