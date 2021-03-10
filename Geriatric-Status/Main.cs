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

        //Проверка оценок устойчивости и хотьбы на заполненность
        private void checkMotorActivity()
        {
            if (Program.patient.WalkViolationPassed  && Program.patient.OverallResiliencePassed)
            {
                int sum = Program.patient.WalkViolation + Program.patient.OverallResilience;
                Program.patient.MotorActivitySum = sum;
                MessageBox.Show("Оценка двигательной активности: " + sum + " баллов");
                //Уточнить
                if (sum > 38)
                    Program.patient.MotorActivity = 1;
                else
                    Program.patient.MotorActivity = 0;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Program.patient = new Patient();
            //Изначально все лайоуты скрыты
            OverallResilience.Hide();
            WalkViolation.Hide();
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            //Вызов окна создания нового пациента
            NewPatient np = new NewPatient();
            np.ShowDialog();
            patientDataLabel.Text = Program.patient.Surname + " " + Program.patient.Name + " " + Program.patient.Otchestvo + " " + Program.patient.BirthDate.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка, чтобы лайоут не открывался повторно
            if(OverallResilience.Visible == false)
                OverallResilience.Show();
        }

        //Расчет устойчивости
        private void ORButton_Click(object sender, EventArgs e)
        {
            //Проверка всех комбобоксов на заполненность
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

                //Расчет суммы баллов
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
                Program.patient.OverallResiliencePassed = true;
                MessageBox.Show("Набрано баллов: " + Program.patient.OverallResilience);
                checkMotorActivity();
            }
            else
            {
                MessageBox.Show("Не все параметры выбраны!");
            }
        }

        private void WVButton_Click(object sender, EventArgs e)
        {
            if(WalkViolation.Visible == false)
                WalkViolation.Show();
        }

        private void WVSaveButton_Click(object sender, EventArgs e)
        {
            if (comboBox19.SelectedIndex > -1 &&
                comboBox20.SelectedIndex > -1 &&
                comboBox21.SelectedIndex > -1 &&
                comboBox22.SelectedIndex > -1 &&
                comboBox23.SelectedIndex > -1 &&
                comboBox24.SelectedIndex > -1 &&
                comboBox25.SelectedIndex > -1 &&
                comboBox26.SelectedIndex > -1 &&
                comboBox27.SelectedIndex > -1 &&
                comboBox28.SelectedIndex > -1 &&
                comboBox29.SelectedIndex > -1 &&
                comboBox30.SelectedIndex > -1   )
            {
                WalkViolation.Hide();

                Program.patient.WalkViolation =
                    comboBox19.SelectedIndex +
                    comboBox20.SelectedIndex +
                    comboBox21.SelectedIndex +
                    comboBox22.SelectedIndex +
                    comboBox23.SelectedIndex +
                    comboBox24.SelectedIndex +
                    comboBox25.SelectedIndex +
                    comboBox26.SelectedIndex +
                    comboBox27.SelectedIndex +
                    comboBox28.SelectedIndex +
                    comboBox29.SelectedIndex +
                    comboBox30.SelectedIndex;
                Program.patient.WalkViolationPassed = true;
                checkMotorActivity();
                MessageBox.Show("Набрано баллов: " + Program.patient.WalkViolation);
            }
            else
            {
                MessageBox.Show("Не все параметры выбраны!");
            }
        }
    }
}
