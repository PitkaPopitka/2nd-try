using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deGENERATOR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void up_Click(object sender, EventArgs e)
        {
            combination.SelectedText = up.Text;
        }

        private void down_Click(object sender, EventArgs e)
        {
            combination.SelectedText = down.Text;
        }

        private void upL_Click(object sender, EventArgs e)
        {
            combination.SelectedText = upL.Text;
        }

        private void downL_Click(object sender, EventArgs e)
        {
            combination.SelectedText = downL.Text;
        }

        private void number_Click(object sender, EventArgs e)
        {
            combination.SelectedText = number.Text;
        }

        private void up_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(up, "Заглавная буква кириллицы");
        }

        private void down_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(down, "строчная буква кириллицы");
        }

        private void upL_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(upL, "Заглавная буква латинницы");
        }

        private void downL_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(downL, "строчная буква латинницы");
        }

        private void combination_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(combination, "маска ввода");
        }

        private void result_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(result, "сгенерированные комбинации");
        }

        private void copy_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(copy, "скопировать комбинации в буфер обмена");
        }

        private void deGenerate_Click(object sender, EventArgs e) //генерация комбинации по заданной маске
        {
            string bigKir = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЫЭЮЯ"; //буквы и цифры, из которых будут генерироваться комбинации
            string smalKir = bigKir.ToLower();
            string bigLat = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string smalLat = bigLat.ToLower();
            string cifr = "1234567890";
            string s="";
            var r= new Random();
            for (int i1 = 0; i1 < quantity.Value; i1++)//цикл, выполняющийся до тех пор, пока счетчик не будет равен кол-ву генераций, указанных пользователем
            {
                foreach (var i in combination.Text)//сравнение содержимого поля маски ввода с символами, обозначающими ту или иную категорию элементов
                {
                    switch (i)
                    {
                        case 'A':
                            s += bigKir[r.Next(0, bigKir.Length)];
                            break;
                        case 'a':
                            s += smalKir[r.Next(0, smalKir.Length)];
                            break;
                        case 'Q':
                            s += bigLat[r.Next(0, bigLat.Length)];
                            break;
                        case 'q':
                            s += smalLat[r.Next(0, smalLat.Length)];
                            break;
                        case '1':
                            s += cifr[r.Next(0, cifr.Length)];
                            break;
                    }
                }
                result.Items.Add(s);
                s = "";
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "";
                foreach (object item in result.Items) s += item.ToString() + "\r\n";
                Clipboard.SetText(s);
            }
            catch (Exception)
            {
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Items.Clear();
        }

        private void number_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(number, "цифра");
        }
    }
}
