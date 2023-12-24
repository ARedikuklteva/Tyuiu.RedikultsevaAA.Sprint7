using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            labelUni_RAA.Font = new Font("Tobota", 14, FontStyle.Regular);
            buttonHelp_RAA.Font = new Font("Tobota", 10, FontStyle.Regular);
            buttonSearch_RAA.Font = new Font("Tobota", 10, FontStyle.Regular);
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSearch_RAA_Click(object sender, EventArgs e)
        {
            FormFinding formVariants = new FormFinding();
            formVariants.ShowDialog();
        }
    }
}
