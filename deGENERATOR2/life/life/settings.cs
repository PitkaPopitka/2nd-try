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
    public partial class setting : Form
    {

        public setting() // метод сохранения значений полей
        {
            InitializeComponent();
            density.Value = Class1.childDensity;
            huntersDensity.Value = Class1.childHunters;
            cellsLifeNeighbours.Value = Class1.childCellsLife;
            cellsDeathNeigbours.Value = Class1.childCellsDeath;
            huntersCount.Value = Class1.childHuntersCount;
            huntersLifeNeighbours.Value = Class1.childHuntersLife;
            huntersDeathNeighbour.Value = Class1.childHuntersDeath;
            preyCount.Value = Class1.childPreyCount;
        }

        private void button1_Click(object sender, EventArgs e) // присваивание переменным класса значения полей 
        {
            
            Class1.childDensity = (int)density.Value;
            Class1.childHunters = (int)huntersDensity.Value;
            Class1.childCellsLife = (int)cellsLifeNeighbours.Value;
            Class1.childCellsDeath = (int)cellsDeathNeigbours.Value;
            Class1.childHuntersCount = (int)huntersCount.Value;
            Class1.childHuntersLife = (int)huntersLifeNeighbours.Value;
            Class1.childHuntersDeath = (int)huntersDeathNeighbour.Value;
            Class1.childPreyCount = (int)preyCount.Value;
            this.Hide();
        }

        private void recommendBtn_Click(object sender, EventArgs e) // устанавливает рекомендуемые параметры построения жизни
        {
            density.Value = 10;
            huntersDensity.Value = 15;
            cellsLifeNeighbours.Value = 3;
            cellsDeathNeigbours.Value = 3;
            huntersCount.Value = 1;
            huntersLifeNeighbours.Value = 3;
            huntersDeathNeighbour.Value = 3;
            preyCount.Value = 5;
        }
    }
}
