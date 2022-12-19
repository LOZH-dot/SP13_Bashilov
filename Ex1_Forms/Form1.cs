using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {

        List<Function> func = new List<Function>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("data.txt"))
            {
                foreach (var item in func)
                    sw.WriteLine($"{item.name}:{item.a}:{item.b}:{item.c}");
            }

            func.Clear();

            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] strs = line.Split(':');

                    switch (strs[0])
                    {
                        case "Прямая":
                            func.Add(new Line(double.Parse(strs[1]), double.Parse(strs[2])));
                            break;
                        case "Парабола":
                            func.Add(new Kub(double.Parse(strs[1]), double.Parse(strs[2]), double.Parse(strs[3])));
                            break;
                        case "Гипербола":
                            func.Add(new Hyperbola(double.Parse(strs[1]), double.Parse(strs[2])));
                            break;
                        default:
                            break;
                    }
                }
            }

            double x = 0;

            try
            {
                x = double.Parse(XTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные точки X!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = string.Empty;

            result += "Результат:\n";
            foreach (Function item in func)
            {
                result += ($"Функция: {item.name} при x = {x}, y = {Math.Round(item.Calculate(x), 2)}\n");
            }
            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddLineButton_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                a = double.Parse(LineATextBox.Text);
                b = double.Parse(LineBTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            func.Add(new Line(a, b));
            MessageBox.Show("Добавлено!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddParabolaButton_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = double.Parse(ParATextBox.Text);
                b = double.Parse(ParBTextBox.Text);
                c = double.Parse(ParBTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            func.Add(new Kub(a, b, c));
            MessageBox.Show("Добавлено!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HyperButton_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                a = double.Parse(HyperATextBox.Text);
                b = double.Parse(HyperBTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            func.Add(new Hyperbola(a, b));
            MessageBox.Show("Добавлено!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
