using RollDice;
using ScoreOnes;
using ScoreTwos;
using ScoreThrees;
using ScoreFours;
using ScoreFives;
using ScoreSixes;
using System.Drawing;
using System.Threading;

namespace WinYahtzee
{
    public partial class Form1 : Form
    {
        static int[] cubes = new int[5];
        static int TotalTop = 0;
        static int TotalBottom = 0;
        static int TopBonus = 0;
        static int YahtzeeBonus = 0;
        static int NumOfYahtzees = 0;
        static int NumOfRolls;
        static bool allDone = false; // To award top bonus only one time.


        public Form1()
        {
            InitializeComponent();
            
        }
        //component arrays....
        PictureBox[] showDice = new PictureBox[5]; //so dice pictures work in a loop
        Button[] scoreButton = new Button[15];
        Button[] holdButton = new Button[5]; //so I can reset all the hold buttons to green
        Label[] scoreBox = new Label[18]; //so I can set all the score labels to blank.
        Label[] holdBox = new Label[5];


        private async void btnRoll_Click(object sender, EventArgs e)
        {
            

            //label1.Text = cubes[0].ToString();

            for (int x = 0; x <= 4; x++)
            {
                if (holdBox[x].Visible)
                {
                    continue;
                }
                cubes[x] = Roll.rollEm();
                showDice[x].Image = Resource1.smDiceroll;
                await Task.Delay(275);
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
            NumOfRolls--;
            lblNumOfRolls.Text = NumOfRolls.ToString();
            if(NumOfRolls == 0)
            {
                btnRoll.Enabled = false;
            }
            // temp bits for testing
            int rollTotal = 0;
            foreach(int c in cubes)
            {
                rollTotal += c;
            }
            label1.Text = rollTotal.ToString();
            // end test
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TotalTop = 0;
            TotalBottom = 0;
            NumOfRolls = 3;
            NumOfYahtzees = 0;
            lblTotalTop.Text = TotalTop.ToString();
            lblTopBonus.Text = TopBonus.ToString();
            lblTotalBottom.Text = TotalBottom.ToString();
            lblYahtzee.Text = YahtzeeBonus.ToString();
            lblNumOfRolls.Text = NumOfRolls.ToString();
            showDice[0] = picDi1; //build the pictureBox array to work in loops!
            showDice[1] = picDi2;
            showDice[2] = picDi3;
            showDice[3] = picDi4;
            showDice[4] = picDi5;
            holdBox[0] = lblHeld1;
            holdBox[1] = lblHeld2;
            holdBox[2] = lblHeld3;
            holdBox[3] = lblHeld4;
            holdBox[4] = lblHeld5;

        }

        private void picDi1_MouseHover(object sender, EventArgs e)
        {
            lblHoverTip.Text = "Click to Hold";
            lblHoverTip.Visible = true;
        }

        private async void picDi1_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(250);
            lblHoverTip.Visible=false;
        }

        private void scrBtnOne_Click(object sender, EventArgs e)
        {
            int ones = Score1.AddOnes(cubes);
            lblOnes.Text = ones.ToString();
            lblTotalTop.Text = AddTop(ones).ToString();
            scrBtnOne.BackColor = Color.LightSlateGray;
            scrBtnOne.Enabled = false;
            btnRoll.Focus();
            clearCubes();
            checkTopBonus(TotalTop);
        }

        private void ScrBtnTwo_Click(object sender, EventArgs e)
        {
            int twos = Score2.AddTwos(cubes);
            lblTwos.Text = twos.ToString();
            lblTotalTop.Text = AddTop(twos).ToString();
            ScrBtnTwo.BackColor = Color.LightSlateGray;
            ScrBtnTwo.Enabled = false;
            btnRoll.Focus();
            clearCubes();
            checkTopBonus(TotalTop);
        }
        public static int AddTop(int dots)
            {
                TotalTop += dots;
                return TotalTop;
            }

        private void scrBtnThree_Click(object sender, EventArgs e)
        {
            int threes = Score3.AddThrees(cubes);
            lblThrees.Text = threes.ToString();
            lblTotalTop.Text = AddTop(threes).ToString();
            scrBtnThree.BackColor = Color.LightSlateGray;
            scrBtnThree.Enabled = false;
            btnRoll.Focus();
            clearCubes();
            checkTopBonus(TotalTop);
        }

        private void scrBtnFour_Click(object sender, EventArgs e)
        {
            int fours = Score4.AddFours(cubes);
            lblFours.Text = fours.ToString();
            lblTotalTop.Text = AddTop(fours).ToString();
            scrBtnFour.BackColor = Color.LightSlateGray;
            scrBtnFour.Enabled = false;
            btnRoll.Focus();
            clearCubes();
            checkTopBonus(TotalTop);
        }

        private void scrBtnFive_Click(object sender, EventArgs e)
        {
            int fives = Score5.AddFives(cubes);
            lblFives.Text = fives.ToString();
            lblTotalTop.Text = AddTop(fives).ToString();
            scrBtnFive.BackColor = Color.LightSlateGray;
            scrBtnFive.Enabled = false;
            btnRoll.Focus();
            clearCubes();
            checkTopBonus(TotalTop);
        }

        private void scrBtnSix_Click(object sender, EventArgs e)
        {
            int sixes = Score6.AddSixes(cubes);
            lblSixes.Text = sixes.ToString();
            lblTotalTop.Text = AddTop(sixes).ToString();
            scrBtnSix.BackColor = Color.LightSlateGray;
            scrBtnSix.Enabled = false;
            btnRoll.Focus();
            clearCubes();
            checkTopBonus(TotalTop);
        }

        private void picDi1_Click(object sender, EventArgs e)
        {
            if (lblHeld1.Visible)
            {
                lblHeld1.Visible = false;
                picDi1.BackColor = Color.Green;
                lblHoverTip.Text = "Click to Hold";
            }else
            {
                lblHeld1.Visible = true;
                picDi1.BackColor = Color.Red;
                lblHoverTip.Text = "Click to release";
            }
                
        }
        private void clearCubes()
        {
            NumOfRolls = 3;
            for (int i = 0; i <= 4; i++)
            {
                showDice[i].Image = Resource1.blank;
                showDice[i].BackColor = Color.Green;
                holdBox[i].Visible = false;
                cubes[i] = 0;
            }
            btnRoll.Enabled = true;
            NumOfRolls = 3;
            lblNumOfRolls.Text = NumOfRolls.ToString();


        }

        private void picDi2_Click(object sender, EventArgs e)
        {
            if (lblHeld2.Visible)
            {
                lblHeld2.Visible = false;
                picDi2.BackColor = Color.Green;
                lblHoverTip.Text = "Click to Hold";
            }else
            {
                lblHeld2.Visible = true;
                picDi2.BackColor = Color.Red;
                lblHoverTip.Text = "Click to release";
            }

        }

        private void picDi3_Click(object sender, EventArgs e)
        {
            if (lblHeld3.Visible)
            {
                lblHeld3.Visible = false;
                picDi3.BackColor = Color.Green;
                lblHoverTip.Text = "Click to Hold";
            }
            else
            {
                lblHeld3.Visible = true;
                picDi3.BackColor = Color.Red;
                lblHoverTip.Text = "Click to release";
            }
        }

        private void picDi4_Click(object sender, EventArgs e)
        {
            if (lblHeld4.Visible)
            {
                lblHeld4.Visible = false;
                picDi4.BackColor = Color.Green;
                lblHoverTip.Text = "Click to Hold";
            }
            else
            {
                lblHeld4.Visible = true;
                picDi4.BackColor = Color.Red;
                lblHoverTip.Text = "Click to release";
            }
        }

        private void picDi5_Click(object sender, EventArgs e)
        {
            if (lblHeld5.Visible)
            {
                lblHeld5.Visible = false;
                picDi5.BackColor = Color.Green;
                lblHoverTip.Text = "Click to Hold";
            }
            else
            {
                lblHeld5.Visible = true;
                picDi5.BackColor = Color.Red;
                lblHoverTip.Text = "Click to release";
            }
        }
        private void checkTopBonus(int topScore)
        {
            if (topScore >= 63 && allDone == false)
            {
                TopBonus = 35;
                allDone = true;
                lblTopBonus.Text = TopBonus.ToString();
                TotalTop += TopBonus;
                lblTotalTop.Text = TotalTop.ToString();
            }
        }
    }
}