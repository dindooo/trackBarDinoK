using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackBarKontrolaDinoK
{
    public partial class TrackBar : Form
    {
        public TrackBar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trkVrijednost_Scroll(object sender, EventArgs e)
        {
            txtVrijednost.Clear();
            txtVrijednost.AppendText(trkVrijednost.Value.ToString());
           
        }

        private void txtVrijednost_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
