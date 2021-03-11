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

            GSLabel.Text = Program.patient.Status.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            Patient p = Program.patient;
            string report = $@"
Пациент:  {p.Surname} {p.Name} {p.Otchestvo} {p.BirthDate.ToShortDateString()}


Определение общей устойчивости: {p.OverallResilience} б.
Состояние походки: {p.WalkViolation} б.
Степень способности к передвижению: {p.MotorActivitySum} б.

Оценка риска развития синдрома мальнутриции: {p.Malnutrition} б.

Оценка когнитивных способностей: {p.CognitiveBal} б.

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
