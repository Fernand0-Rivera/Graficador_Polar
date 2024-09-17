using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Graficador_Polar
{
    public partial class Form1 : Form{
        double xi, xf;
        int n;
        string fx, g;
        public Form1(){
            InitializeComponent();
            n = chart1.Width;
        }



        private void Btgraficar_Click(object sender, EventArgs e){
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);
            fx = tBfx.Text;
            Graficas gr1 = new Graficas(n);
            gr1.Graficador(xi, xf, fx);
            chart1.Series["Series1"].Points.Clear();
            lBsalida.Items.Clear();
            for (int k = 0; k < n; k++) {
                chart1.Series["Series1"].Points.AddXY(gr1.X[k], gr1.Y[k]);
                lBsalida.Items.Add(gr1.X[k] + "\t\t" + gr1.Y[k]);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Firma_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("Firma_2.exe");

        private void Btpolar_Click(object sender, EventArgs e) {
            string ga;
            double xi, xf;
            Graficas grp1 = new Graficas(n);
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);
            ga = tBga.Text;
            grp1.GrafPolar(xi, xf, ga);
            chart1.Series["Series1"].Points.Clear();
            lBsalida.Items.Clear();
            for (int k = 0; k < n; k++){
                chart1.Series["Series1"].Points.AddXY(grp1.X[k], grp1.Y[k]);
                lBsalida.Items.Add(grp1.X[k] + "\t\t" + grp1.Y[k]);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
