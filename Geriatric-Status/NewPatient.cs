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
            //Проверяем чтобы данные были не пустые
            if (FTextBox.Text == "" && NTextBox.Text == "" && OTextBox.Text == "")
            {
                MessageBox.Show("Пустые поля!");
            }
            else
            {
                //Сохраняем значения
                Program.patient = new Patient();
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

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
