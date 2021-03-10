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
            Patient patient = Program.patient;
            OverallResilience.Hide();
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            Patient patient = Program.patient;
            NewPatient np = new NewPatient();
            np.ShowDialog();
            patientDataLabel.Text = patient.Surname + " " + patient.Name + " " + patient.Otchestvo + " " + patient.BirthDate.ToShortDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OverallResilience.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ORButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > -1 &&
                comboBox2.SelectedIndex > -1 &&
                comboBox3.SelectedIndex > -1 &&
                comboBox4.SelectedIndex > -1 &&
                comboBox5.SelectedIndex > -1 &&
                comboBox6.SelectedIndex > -1 &&
                comboBox7.SelectedIndex > -1 &&
                comboBox8.SelectedIndex > -1 &&
                comboBox9.SelectedIndex > -1 &&
                comboBox10.SelectedIndex > -1 &&
                comboBox11.SelectedIndex > -1 &&
                comboBox12.SelectedIndex > -1 &&
                comboBox13.SelectedIndex > -1 &&
                comboBox14.SelectedIndex > -1 &&
                comboBox15.SelectedIndex > -1  )
            {
                OverallResilience.Hide();

                Program.patient.OverallResilience =
                    comboBox1.SelectedIndex +
                    comboBox2.SelectedIndex +
                    comboBox3.SelectedIndex +
                    comboBox4.SelectedIndex +
                    comboBox5.SelectedIndex +
                    comboBox6.SelectedIndex +
                    comboBox7.SelectedIndex +
                    comboBox8.SelectedIndex +
                    comboBox9.SelectedIndex +
                    comboBox10.SelectedIndex +
                    comboBox11.SelectedIndex +
                    comboBox12.SelectedIndex +
                    comboBox13.SelectedIndex +
                    comboBox14.SelectedIndex +
                    comboBox15.SelectedIndex;

                MessageBox.Show("Набрано баллов: " + Program.patient.OverallResilience);
            }
            else
            {
                MessageBox.Show("Не все параметры выбраны!");
            }
        }
    }
}
