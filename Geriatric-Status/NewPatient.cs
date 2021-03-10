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
    
    public partial class NewPatient : Form
    {
        
        public NewPatient()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FTextBox.Text == "" && NTextBox.Text == "" && OTextBox.Text == "")
            {
                MessageBox.Show("Пустые поля!");
            }
            else
            {
                //Program.patient = new Patient(dateTimePicker1.Value, NTextBox.Text, FTextBox.Text, OTextBox.Text);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
