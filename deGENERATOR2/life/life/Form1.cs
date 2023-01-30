using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace life
{
    public partial class Form1 : Form
    {
        public Graphics gr, cl, sv;
        public int resol;
        public bool[,] cells;
        public bool[,] hunters;
        public bool[,] addCells;
        public int rows, rows2;
        public int cols, cols2;
        public int countNeighbours;

        
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        

        public void startLife() // метод, заполняющий изначальный массив клеток, зарождение первых охотников и добычи
        {
            int child1 = Class1.childDensity;// передача значения переменной из настроек
            int vadim = Class1.childHunters;
            try
            {
                label3.Text = "задержка";
                label3.ForeColor = Color.Black;
                int a = Convert.ToInt32(delay.Text);
                timer1.Interval = a;
                if (timer1.Enabled)
                {
                    return;
                }
                resolution.Enabled = false;// отключение элементов интерфейса на время выполнения 
                delay.Enabled = false;
                start_btn.Enabled = false;
                resol = (int)resolution.Value;
                cols = pictureBox1.Width / resol;// рассчет кол-во столбцов и строк в массиве
                rows = pictureBox1.Height / resol;
                cells = new bool[cols, rows];// создание массива клеток
                for (int x = 0; x < cols; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        cells[x, y] = rnd.Next(child1) == 0;// заполнение массива случайными значениями(0 - пустая клетка, 1 - живая клетка)
                    }
                }
                cols2 = pictureBox1.Width / resol;// выполнение аналогичных действий для охотников
                rows2 = pictureBox1.Height / resol;
                hunters = new bool[cols, rows];
                for (int x = 0; x < cols; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        hunters[x, y] = rnd.Next(vadim) == 0;
                    }
                }
                timer1.Start();// запуск таймера
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);// создание битмапа из pictureBox'а
                gr = Graphics.FromImage(pictureBox1.Image);
            }
            catch (Exception)
            {
                label3.Text = "некорректное значение";
                label3.ForeColor = Color.Red;
            }
        }

        public void drawLife() //метод отрисовки жизни
        {
            int cellsLifeNeighbours = Class1.childCellsLife;// принимает кол-во соседей для зарождения жизни, передаётся из настроек
            int cellsDeathNeigbours = Class1.childCellsDeath;// принимает кол-во соседей для гибели клетки
            int huntersCount = Class1.childHuntersCount;// принимает кол-во охотников для гибели клетки
            gr.Clear(Color.Black);
            var newCells = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighbour = neighbours(x, y);
                    var hunters = hunter_neighbours(x, y);
                    var alive = cells[x, y];
                    if (alive == false && neighbour == cellsLifeNeighbours && hunters < huntersCount)// если выполняются условия зарождения жизни- то клетка оживает
                    {
                        newCells[x, y] = true;
                    }

                    else if(alive == true && neighbour < 2 || neighbour > cellsDeathNeigbours || hunters > huntersCount)// если выполняются условия гибели- то клетка гибнет
                    {
                        newCells[x, y] = false;
                    }

                    else// в противном случае ничего не изменяется
                    {
                        newCells[x, y] = cells[x, y];
                    }
                    if (alive == true)// окрашивание живой клетки в соответствующий цвет
                    {
                        if (edge.Checked)// если стоит флаг- то клетка закрашивается кругом, что создаёт грани клеток
                        {
                            gr.FillEllipse(new SolidBrush(Color.LimeGreen), x * resol, y * resol, resol, resol);
                        }
                        else// простая заливка клеток
                        {
                            gr.FillRectangle(Brushes.LimeGreen, x * resol, y * resol, resol, resol);
                        }
                    }
                }
            }
            cells = newCells;

            var newHunters = new bool[cols2, rows2];// аналогичный процесс для охотников
            int huntersLifeNeighbours = Class1.childHuntersLife;
            int huntersDeathNeighbour = Class1.childHuntersDeath;
            int preyCount = Class1.childPreyCount;// кол-во добычи для гибели охотника
            for (int x = 0; x < cols2; x++)
            {
                for (int y = 0; y < rows2; y++)
                {
                    var neighbour = hunter_neighbours(x, y);
                    var prey = neighbours(x, y);
                    var alive = hunters[x, y];
                    if (alive == false && neighbour == huntersLifeNeighbours)
                    {
                        newHunters[x, y] = true;
                    }
                    else if (alive == true && neighbour < 2 || neighbour > huntersDeathNeighbour || prey > preyCount)
                    {
                        newHunters[x, y] = false;
                    }
                    else
                    {
                        newHunters[x, y] = hunters[x, y];
                    }
                    if (alive == true)
                    {
                        if (edge.Checked)
                        {
                            gr.FillEllipse(new SolidBrush(Color.Crimson), x * resol, y * resol, resol, resol);
                        }
                        else
                        {
                            gr.FillRectangle(Brushes.Crimson, x * resol, y * resol, resol, resol);
                        }
                    }
                }
            }
            hunters = newHunters;
            pictureBox1.Refresh();
        }

        public int neighbours(int x, int y) // метод подсчета кол-ва соседей клетки-добычи
        {
            int neighboursCount = 0; // счетчик соседей
            for (int i = -1; i < 2; i++)
            {
                for (int i1 = -1; i1 < 2; i1++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + i1 + rows) % rows;
                    var sameCell = col == x && row == y;
                    var aliveNeighbour = cells[col, row]; // массив живых соседей
                    if (aliveNeighbour == true && sameCell == false) // если сосед жив, и это клетка, отличная от текущей- счетчик соседей увеличивается
                    {
                        neighboursCount++;
                    }
                }
            }
            return neighboursCount;
        }

        public int hunter_neighbours(int x, int y) // метод подсчета кол-ва соседей клетки-охотника
        {
            int neighboursCount = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int i2 = -1; i2 < 2; i2++)
                {
                    var col = (x + i + cols2) % cols2;
                    var row = (y + i2 + rows2) % rows2;
                    var sameCell = col == x && row == y;
                    var aliveNeighbour = hunters[col, row];
                    if (aliveNeighbour == true && sameCell == false)
                    {
                        neighboursCount++;
                    }
                }
            }
            return neighboursCount;
        }

        public void stop() // метод остановки таймера 
        {
            if (timer1.Enabled) // проверка активности таймера и активация элементов интерфейса
            {
                timer1.Stop();
                resolution.Enabled = true;
                delay.Enabled = true;
                start_btn.Enabled = true;
                save_btn.Enabled = true;
            }
            else // активация таймера и деактивация элементов интерфейса
            {
                timer1.Start();
                resolution.Enabled = false;
                delay.Enabled = false;
                start_btn.Enabled = false;
                save_btn.Enabled = false;
            }
        }

        public void save() // метод сохранения изображения из pictureBox
        {
            if (pictureBox1.Image != null) // проверка наличия изображения
            {
                var save_image = pictureBox1.Image;
                SaveFileDialog save_dialog = new SaveFileDialog();
                save_dialog.Filter = ".JPG|.JPG|.PNG|.PNG|All files (*.*)|*.*";
                if (save_dialog.ShowDialog() == DialogResult.OK)
                {
                    save_image.Save(save_dialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("изображение отсутствует");
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (Class1.childDensity == 0)
            {
                MessageBox.Show("раметры построения жизни указаны некорректно");
            }
            else
            {
                startLife();
            }
            
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            setting settings = new setting();
            settings.TopMost = true;
            settings.Show();
            
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void edge_CheckedChanged(object sender, EventArgs e)
        {
            if (edge.Checked)
            {
                resolution.Minimum = 2;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawLife();
        }
    }
}
