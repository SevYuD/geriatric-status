using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geriatric_Status
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Program.patient = new Patient();
            label1.Text = Program.patient.Name;
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
           //this.Hide();
            NewPatient np = new NewPatient();
            np.ShowDialog();
            label1.Text = Program.patient.Name;
            //this.Show();
        }
    }
}
