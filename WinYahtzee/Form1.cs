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
        //component arrays....
        PictureBox[] showDice = new PictureBox[5]; //so dice pictures work in a loop
        Button[] scoreButton = new Button[15];
        Button[] holdButton = new Button[5]; //so I can reset all the hold buttons to green


        private async void btnRoll_Click(object sender, EventArgs e)
        {
            int[] cubes = new int[5];

            //cubes[0] = Roll.rollEm();
            //label1.Text = cubes[0].ToString();
            //picDi1.Image = Resource1.smDiceroll;
            //await Task.Delay(1500);
            //picDi1.Refresh();
            for (int x = 0; x <= 4; x++)
            {
                cubes[x] = Roll.rollEm();
                showDice[x].Image = Resource1.smDiceroll;
                await Task.Delay(333);
                showDice[x].Refresh();
                switch (cubes[x])
                {
                    case 1:
                        showDice[x].Image = Resource1.y1;
                        break;
                    case 2:
                        showDice[x].Image = Resource1.y2;
                        break;
                    case 3:
                        showDice[x].Image = Resource1.y3;
                        break;
                    case 4:
                        showDice[x].Image = Resource1.y4;
                        break;
                    case 5:
                        showDice[x].Image = Resource1.y5;
                        break;
                    case 6:
                        showDice[x].Image = Resource1.y6;
                        break;
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picDi1, "Click to hold");
            showDice[0] = picDi1; //build the pictureBox array to work in loops!
            showDice[1] = picDi2;
            showDice[2] = picDi3;
            showDice[3] = picDi4;
            showDice[4] = picDi5;
        }
    }
}