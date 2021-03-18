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
    public partial class Analize : Form
    {
        public Analize()
        {
            InitializeComponent();
        }

        private void Analize_Load(object sender, EventArgs e)
        {
            Program.patient.Status = -21.583 - 8.427 * Program.patient.MotorActivitySum
                - 3.684 * Program.patient.CognitiveBal - 0.915 * Program.patient.MalnutritionSum;
            Program.patient.Status = Math.Round(Program.patient.Status, 5);
            GSLabel.Text = Program.patient.Status.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RButton_Click(object sender, EventArgs e)
        {

            Patient p = Program.patient;
            String ma;
            String ml;
            String co;
            if (Program.patient.MotorActivitySum >= 0 && Program.patient.MotorActivitySum <= 20)
                ma = "Значительная степень нарушений";
            else if (Program.patient.MotorActivitySum >= 21 && Program.patient.MotorActivitySum <= 33)
                ma = "Умеренная степень нарушений";
            else if (Program.patient.MotorActivitySum >= 34 && Program.patient.MotorActivitySum <= 38)
                ma = "Легкая степень нарушений";
            else
                ma = "Норма";

            if (Program.patient.MalnutritionSum >= 24)
                ml = "Норма";
            else if (Program.patient.MalnutritionSum >= 17 && Program.patient.MalnutritionSum < 24)
                ml = "Hаличие риска развития синдрома мальнутриции";
            else
                ml = "Hаличие синдрома мальнутриции";


            if (Program.patient.CognitiveBal >= 25)
                co = "Норма";
            else if (Program.patient.CognitiveBal >= 21 && Program.patient.CognitiveBal <= 24)
                co = "Легкие нарушения когнитивной сферы";
            else if (Program.patient.CognitiveBal >= 10 && Program.patient.CognitiveBal <= 21)
                co = "Умеренные нарушения когнитивной сферы";
            else
                co = "Тяжелые нарушения когнитивной сферы";


            string report = $@"
Пациент:  Фамилия: {p.Surname} Имя: {p.Name} Отчество: {p.Otchestvo} Пол: {p.Gender}  Дата рождения: {p.BirthDate.ToShortDateString()}

Определение общей устойчивости: {p.OverallResilience} б. 
Состояние походки: {p.WalkViolation} б.
Степень способности к передвижению: {p.MotorActivitySum} б. 
Оценка: {ma}

Оценка риска развития синдрома мальнутриции: {p.MalnutritionSum} б. (Тест 1: {p.Malnutrition1}, Тест 2: {p.Malnutrition2})
Оценка: {ml}

Оценка когнитивных способностей: {p.CognitiveBal} б.
Оценка: {co}

Прогноз ГС: {p.Status} 
";


            //Сохранение файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = p.Surname;
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, report);
            MessageBox.Show("Отчет сохранен");
        }
    }
}
