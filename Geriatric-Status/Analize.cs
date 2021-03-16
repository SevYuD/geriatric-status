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
            Program.patient.Status = -21.583 - 8.427 * Program.patient.MotorActivity
                - 3.684 * Program.patient.Congnitive - 0.915 * Program.patient.Malnutrition;
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
            if (Program.patient.MotorActivity == 0)
                ma = "Норма";
            else
                ma = "Нарушение!";

            if (Program.patient.Malnutrition == 0)
                ml = "Норма";
            else
                ml = "Нарушение!";

            if (Program.patient.Congnitive == 0)
                co = "Норма";
            else
                co = "Нарушение!";


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

Гериатрический статус: {p.Status} 
";


            //Сохранение файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
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
