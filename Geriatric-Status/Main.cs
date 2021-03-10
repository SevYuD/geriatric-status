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
          
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            np.Show();
        }
    }
}
