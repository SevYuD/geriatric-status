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
            NewPatient np = new NewPatient();
            np.ShowDialog();
            patientDataLabel.Text = Program.patient.Surname + " " + Program.patient.Name + " " + Program.patient.Otchestvo + " " + Program.patient.BirthDate.ToShortDateString();

            
            //Изначально все лайоуты скрыты
            OverallResilience.Hide();
            WalkViolation.Hide();
            MalnutriciaPart1.Hide();
            MalnutriciaPart2.Hide();
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            //Вызов окна создания нового пациента
            NewPatient np = new NewPatient();
            np.ShowDialog();
            patientDataLabel.Text = Program.patient.Surname + " " + Program.patient.Name + " " + Program.patient.Otchestvo + " " + Program.patient.BirthDate.ToShortDateString();
        }

        private void ORButton_Click(object sender, EventArgs e)
        {
            //Проверка, чтобы лайоут не открывался повторно
            if (OverallResilience.Visible == false)
            {
                OverallResilience.Show();
            }
        }

        //Расчет устойчивости
        private void ORSaveButton_Click(object sender, EventArgs e)
        {
            //Проверка всех комбобоксов на заполненность
            if(orcb1.SelectedIndex > -1 &&
                orcb2.SelectedIndex > -1 &&
                orcb3.SelectedIndex > -1 &&
                orcb4.SelectedIndex > -1 &&
                orcb5.SelectedIndex > -1 &&
                orcb6.SelectedIndex > -1 &&
                orcb7.SelectedIndex > -1 &&
                orcb8.SelectedIndex > -1 &&
                orcb9.SelectedIndex > -1 &&
                orcb10.SelectedIndex > -1 &&
                orcb11.SelectedIndex > -1 &&
                orcb12.SelectedIndex > -1 &&
                orcb13.SelectedIndex > -1 &&
                orcb14.SelectedIndex > -1 &&
                orcb15.SelectedIndex > -1  )
            {
                OverallResilience.Hide();

                //Расчет суммы баллов
                Program.patient.OverallResilience =
                    orcb1.SelectedIndex +
                    orcb2.SelectedIndex +
                    orcb3.SelectedIndex +
                    orcb4.SelectedIndex +
                    orcb5.SelectedIndex +
                    orcb6.SelectedIndex +
                    orcb7.SelectedIndex +
                    orcb8.SelectedIndex +
                    orcb9.SelectedIndex +
                    orcb10.SelectedIndex +
                    orcb11.SelectedIndex +
                    orcb12.SelectedIndex +
                    orcb13.SelectedIndex +
                    orcb14.SelectedIndex +
                    orcb15.SelectedIndex;
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
            if (WalkViolation.Visible == false)
            {
                WalkViolation.Show();
            }
        }

        private void WVSaveButton_Click(object sender, EventArgs e)
        {
            if (wvcb12.SelectedIndex > -1 &&
                wvcb11.SelectedIndex > -1 &&
                wvcb10.SelectedIndex > -1 &&
                wvcb9.SelectedIndex > -1 &&
                wvcb8.SelectedIndex > -1 &&
                wvcb7.SelectedIndex > -1 &&
                wvcb6.SelectedIndex > -1 &&
                wvcb5.SelectedIndex > -1 &&
                wvcb4.SelectedIndex > -1 &&
                wvcb3.SelectedIndex > -1 &&
                wvcb2.SelectedIndex > -1 &&
                wvcb1.SelectedIndex > -1   )
            {
                WalkViolation.Hide();

                Program.patient.WalkViolation =
                    wvcb12.SelectedIndex +
                    wvcb11.SelectedIndex +
                    wvcb10.SelectedIndex +
                    wvcb9.SelectedIndex +
                    wvcb8.SelectedIndex +
                    wvcb7.SelectedIndex +
                    wvcb6.SelectedIndex +
                    wvcb5.SelectedIndex +
                    wvcb4.SelectedIndex +
                    wvcb3.SelectedIndex +
                    wvcb2.SelectedIndex +
                    wvcb1.SelectedIndex;
                Program.patient.WalkViolationPassed = true;
         
                MessageBox.Show("Набрано баллов: " + Program.patient.WalkViolation);

                checkMotorActivity();
            }
            else
            {
                MessageBox.Show("Не все параметры выбраны!");
            }
        }

        private void Mbutton_Click(object sender, EventArgs e)
        {
            if (MalnutriciaPart1.Visible == false)
            {
                MalnutriciaPart1.Show();
            }
        }

        private void MSaveButton_Click(object sender, EventArgs e)
        {
            if (
               mcb6.SelectedIndex > -1 &&
               mcb5.SelectedIndex > -1 &&
               mcb4.SelectedIndex > -1 &&
               mcb3.SelectedIndex > -1 &&
               mcb2.SelectedIndex > -1 &&
               mcb1.SelectedIndex > -1)
            {
                MalnutriciaPart1.Hide();

                Program.patient.WalkViolation =
                    mcb6.SelectedIndex +
                    mcb5.SelectedIndex +
                    mcb4.SelectedIndex +
                    mcb3.SelectedIndex +
                    mcb2.SelectedIndex +
                    mcb1.SelectedIndex;


                MessageBox.Show("Набрано баллов: " + Program.patient.Malnutrition1);

                checkMotorActivity();
            }
            else
            {
                MessageBox.Show("Не все параметры выбраны!");
            }
        }

        private void M2Button_Click(object sender, EventArgs e)
        {
            if (MalnutriciaPart2.Visible == false)
                MalnutriciaPart2.Show();
        }

        private void M2SaveButton_Click(object sender, EventArgs e)
        {
            if (wvcb12.SelectedIndex > -1 &&
               m2cb11.SelectedIndex > -1 &&
               m2cb10.SelectedIndex > -1 &&
               m2cb9.SelectedIndex > -1 &&
               m2cb8.SelectedIndex > -1 &&
               m2cb7.SelectedIndex > -1 &&
               m2cb6.SelectedIndex > -1 &&
               m2cb5.SelectedIndex > -1 &&
               m2cb4.SelectedIndex > -1 &&
               m2cb3.SelectedIndex > -1 &&
               m2cb2.SelectedIndex > -1 &&
               m2cb1.SelectedIndex > -1)
            {
                WalkViolation.Hide();

                Program.patient.WalkViolation =
                    m2cb12.SelectedIndex +
                    wvcb11.SelectedIndex +
                    wvcb10.SelectedIndex +
                    wvcb9.SelectedIndex +
                    m2cb8.SelectedIndex +
                    m2cb7.SelectedIndex +
                    m2cb6.SelectedIndex/2 +
                    m2cb5.SelectedIndex +
                    m2cb4.SelectedIndex +
                    m2cb3.SelectedIndex +
                    m2cb2.SelectedIndex +
                    m2cb1.SelectedIndex;
                Program.patient.WalkViolationPassed = true;

                MessageBox.Show("Набрано баллов: " + Program.patient.WalkViolation);

                checkMotorActivity();
            }
            else
            {
                MessageBox.Show("Не все параметры выбраны!");
            }
        }
    }
}
