using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangulationOnConicalSurfaceApp
{
    public partial class MainForm : Form
    {
        private TriangulationManager triangulationManager = new TriangulationManager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCalculatePoints_Click(object sender, EventArgs e)
        {
            triangulationManager.initializeConicalSurface(Convert.ToDouble(numericUpDownHeight.Value), 
                Convert.ToDouble(numericUpDownRadius.Value));

            textBoxPoints.Clear();
            textBoxPoints.AppendText(triangulationManager.printPoints(decimal.ToInt32(numericUpDownSegmentsNum.Value)));
            buttonCalculateSurfaceNormals.Enabled = true;
        }

        private void buttonCalculateSurfaceNormals_Click(object sender, EventArgs e)
        {
            textBoxNormals.Clear();
            textBoxNormals.AppendText(triangulationManager.printNormals());
        }
    }
}
