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
                Program.patient.Name = NTextBox.Text;
                Program.patient.Surname = FTextBox.Text;
                Program.patient.Otchestvo = FTextBox.Text;
                Program.patient.BirthDate = dateTimePicker1.Value;
                this.Close();

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
