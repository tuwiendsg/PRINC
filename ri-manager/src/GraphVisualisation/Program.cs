using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GraphVizWrapper;

namespace at.ac.tuwien.dsg.RIFramework.RMod.Visualization {
    static class VisualizationApp {

        public static System.IO.Stream stream;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            var wrapper = new GraphVizWrapper.GraphVizWrapper();
            byte[] output = wrapper.GenerateGraph("digraph {n261998859; n305601358; n1673058824; n1578395868; n1673058824 -> n1578395868; n305601358 -> n1578395868; n261998859 -> n1578395868;}", Enums.GraphReturnType.Png);


            stream = new System.IO.MemoryStream(output);

          

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //System.Console.WriteLine("ok");  

        }
    }
}
