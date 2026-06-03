using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // По умолчанию выбираем Метод Цезяаря и Зашифровать
            radioButton1.Checked = true;
            radioButton5.Checked = true;
        }

        // Кнопка "Обработка" (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Берём текст из левого поля
            string vhod = richTextBox1.Text;

            // Если ничего не ввели, то выходим
            if (vhod == "")
            {
                richTextBox2.Text = "";
                return;
            }

            string rezultat = "";

            // Сначала определяем, что делаем: шифруем или расшифровываем
            int sdvig = 3; // Сдвиг по умолчанию

            // Если выбран radioButton6 (Расшифровать), то сдвиг делаем отрицательным
            if (radioButton6.Checked)
            {
                sdvig = -3;
            }

            // Теперь определяем, какой метод выбран
            if (radioButton1.Checked) // Метод Цезаря
            {
                rezultat = Caesar(vhod, sdvig);
            }
           /* else if (radioButton2.Checked) // Метод Атбаша
            {
                rezultat = ;
            }
            else if (radioButton3.Checked) // Метод Бэкона
            {
                rezultat = ;
            }*/

            // Выводим результат в правое поле
            richTextBox2.Text = rezultat;
        }

        // Функция шифра Цезаря
        string Caesar(string text, int sdvig)
        { 
            string result = "";

            // Перебираем каждую букву в тексте
            for (int i = 0; i < text.Length; i++)
            {
                char bukva = text[i];

                // Русские заглавные буквы (А-Я)
                if (bukva >= 'А' && bukva <= 'Я')
                {
                    int novaya = bukva + sdvig;

                    if (novaya > 'Я')
                        novaya = novaya - 32;
                    if (novaya < 'А')
                        novaya = novaya + 32;

                    result = result + (char)novaya;
                }
                // Русские маленькие буквы (а-я)
                else if (bukva >= 'а' && bukva <= 'я')
                {
                    int novaya = bukva + sdvig;

                    if (novaya > 'я')
                        novaya = novaya - 32;
                    if (novaya < 'а')
                        novaya = novaya + 32;

                    result = result + (char)novaya;
                }
                // Все остальные символы
                else
                {
                    result = result + bukva;
                }
            }
            return result;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}