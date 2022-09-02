using RollDice;
using System.Drawing;
using System.Threading;

namespace WinYahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void btnRoll_Click(object sender, EventArgs e)
        {
            int cube = Roll.rollEm();
            label1.Text = cube.ToString();
            picDi1.Image = Resource1.smDiceroll;
            await Task.Delay(1500);
            picDi1.Refresh();
            switch (cube)
            {
                case 1:
                    picDi1.Image = Resource1.y1;
                    break;
                case 2:
                    picDi1.Image = Resource1.y2;
                    break;
                case 3:
                    picDi1.Image = Resource1.y3;
                    break;
                case 4:
                    picDi1.Image = Resource1.y4;
                    break;
                case 5:
                    picDi1.Image = Resource1.y5;
                    break;
                case 6: 
                    picDi1.Image = Resource1.y6;
                    break;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picDi1, "Click to hold");
        }
    }
}