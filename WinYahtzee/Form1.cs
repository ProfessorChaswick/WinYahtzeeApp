using RollDice;
using ScoreOnes;
using ScoreTwos;
using ScoreThrees;
using ScoreFours;
using ScoreFives;
using ScoreSixes;
using Score3ofaKind;
using ScoreChance;
using ScoreYahtzee;
using Score4K;
using ScoreFullHouse;
using ScoreLgStraight;
using ScoreSmStraight;
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
        static bool AnyYahtzees;
        static int NumOfRolls;
        static int gt = 0;
        static bool allDone = false; // To award top bonus only one time.
        static int numOfTurns = 13;


        public Form1()
        {
            InitializeComponent();

        }
        //component arrays....
        PictureBox[] showDice = new PictureBox[5]; //so dice pictures work in a loop
        Button[] scoreButton = new Button[13];
        //Button[] holdButton = new Button[5]; //so I can reset all the hold buttons to green
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
            if (NumOfRolls == 0)
            {
                btnRoll.Enabled = false;
                panel1.Focus();
            }
            // temp bits for testing
            int rollTotal = 0;
            foreach (int c in cubes)
            {
                rollTotal += c;
            }
            //label1.Text = rollTotal.ToString();
            // end test
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TotalTop = 0;
            TotalBottom = 0;
            NumOfRolls = 3; //should start at 3 - 20 is for testing yahtzee
            AnyYahtzees = false;
            lblTotalTop.Text = TotalTop.ToString();
            lblTopBonus.Text = TopBonus.ToString();
            lblTotalBottom.Text = TotalBottom.ToString();
            //lblYahtzeeBonus.Text = YahtzeeBonus.ToString();// foreColor purple::backColor gold
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
            scoreBox[0] = lblOnes;
            scoreBox[1] = lblTwos;
            scoreBox[2] = lblThrees;
            scoreBox[3] = lblFours;
            scoreBox[4] = lblFives;
            scoreBox[5] = lblSixes;
            scoreBox[6] = lblTopBonus;
            scoreBox[7] = lblTotalTop;
            scoreBox[8] = lbl3K;
            scoreBox[9] = lbl4K;
            scoreBox[10] = lblFH;
            scoreBox[11] = lblSmall;
            scoreBox[12] = lblLarge;
            scoreBox[13] = lblYahtzee;
            scoreBox[14] = lblChance;
            scoreBox[15] = lblYahtzeeBonus;
            scoreBox[16] = lblTotalBottom;
            scoreBox[17] = lblGT;
            scoreButton[0] = scrBtnOne;
            scoreButton[1] = ScrBtnTwo;
            scoreButton[2] = scrBtnThree;
            scoreButton[3] = scrBtnFour;
            scoreButton[4] = scrBtnFive;
            scoreButton[5] = scrBtnSix;
            scoreButton[6] = scrBtn3K;
            scoreButton[7] = scrBtn4K;
            scoreButton[8] = scrBtnFH;
            scoreButton[9] = scrBtnSmStr;
            scoreButton[10] = scrBtnLgStr;
            scoreButton[11] = scrBtnYzee;
            scoreButton[12] = scrBtnChance;

        }

        private void picDi1_MouseHover(object sender, EventArgs e)
        {
            //lblHoverTip.Text = "Click to Hold";
            //lblHoverTip.Visible = true;
        }

        private async void picDi1_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(250);
            lblHoverTip.Visible = false;
        }

        private void scrBtnOne_Click(object sender, EventArgs e)
        {
            int ones = Score1.AddOnes(cubes);
            lblOnes.Text = ones.ToString();
            lblTotalTop.Text = AddTop(ones).ToString();
            scrBtnOne.BackColor = Color.LightSlateGray;
            scrBtnOne.Enabled = false;
            checkTopBonus(TotalTop);
            checkYahtzees();
            clearCubes();
        }

        private void ScrBtnTwo_Click(object sender, EventArgs e)
        {
            int twos = Score2.AddTwos(cubes);
            lblTwos.Text = twos.ToString();
            lblTotalTop.Text = AddTop(twos).ToString();
            ScrBtnTwo.BackColor = Color.LightSlateGray;
            ScrBtnTwo.Enabled = false;
            checkTopBonus(TotalTop);
            checkYahtzees();
            clearCubes();
        }
        public static int AddTop(int dots)
        {
            TotalTop += dots;
            return TotalTop;
        }
        public static int AddBottom(int dots)
        {
            TotalBottom += dots;
            return TotalBottom;
        }
        public static void addGT()
        {
            gt = TotalTop + TotalBottom + YahtzeeBonus;
        }

        private void scrBtnThree_Click(object sender, EventArgs e)
        {
            int threes = Score3.AddThrees(cubes);
            lblThrees.Text = threes.ToString();
            lblTotalTop.Text = AddTop(threes).ToString();
            scrBtnThree.BackColor = Color.LightSlateGray;
            scrBtnThree.Enabled = false;
            checkTopBonus(TotalTop);
            checkYahtzees();
            clearCubes();
        }

        private void scrBtnFour_Click(object sender, EventArgs e)
        {
            int fours = Score4.AddFours(cubes);
            lblFours.Text = fours.ToString();
            lblTotalTop.Text = AddTop(fours).ToString();
            scrBtnFour.BackColor = Color.LightSlateGray;
            scrBtnFour.Enabled = false;
            checkTopBonus(TotalTop);
            checkYahtzees();
            clearCubes();
        }

        private void scrBtnFive_Click(object sender, EventArgs e)
        {
            int fives = Score5.AddFives(cubes);
            lblFives.Text = fives.ToString();
            lblTotalTop.Text = AddTop(fives).ToString();
            scrBtnFive.BackColor = Color.LightSlateGray;
            scrBtnFive.Enabled = false;
            checkTopBonus(TotalTop);
            checkYahtzees();
            clearCubes();
        }

        private void scrBtnSix_Click(object sender, EventArgs e)
        {
            int sixes = Score6.AddSixes(cubes);
            lblSixes.Text = sixes.ToString();
            lblTotalTop.Text = AddTop(sixes).ToString();
            scrBtnSix.BackColor = Color.LightSlateGray;
            scrBtnSix.Enabled = false;
            checkTopBonus(TotalTop);
            checkYahtzees();
            clearCubes();
        }

        private void picDi1_Click(object sender, EventArgs e)
        {
            if (lblHeld1.Visible)
            {
                lblHeld1.Visible = false;
                picDi1.BackColor = Color.Green;
                lblHoverTip.Text = "Click to Hold";
            }
            else
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
            btnRoll.Focus();
            lblNumOfRolls.Text = NumOfRolls.ToString();
            //label1.Text = NumOfYahtzees.ToString(); /////for testing**
            addGT();
            lblGT.Text = gt.ToString();
            if (TopBonus == 35)
            {
                int announce;
                announce = TotalTop - TopBonus;
                lblBonusAnnounce.Text = "Bonus earned with: ";
                lblBonusAnnounce.Text += announce.ToString();
                lblBonusAnnounce.Visible = true;
            }
            numOfTurns--;
            label1.Text = numOfTurns.ToString();
            if (numOfTurns == 0)
            {
                lblGameOver.Visible = true;
                lblGameOver.Text = "Final Score: " + gt.ToString();
                lblNumOfRolls.Text = "";
                btnRoll.Enabled = false;
                btnNew.Visible = true;
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            lblBonusAnnounce.Text = "";
            TotalTop = 0;
            TotalBottom = 0;
            TopBonus = 0;
            YahtzeeBonus = 0;
            gt = 0;
            numOfTurns = 13;
            NumOfRolls = 3;
            lblNumOfRolls.Text = NumOfRolls.ToString();
            AnyYahtzees = false;
            btnRoll.Enabled = true;
            //Clear a all the score boxes and enable score buttons
            foreach (Label sb in scoreBox)
            {
                sb.Text = "";
            }
            foreach (Button sbn in scoreButton)
            {
                sbn.Enabled = true;
                sbn.BackColor = Color.Green;
            }
            foreach (PictureBox shDi in showDice)
            {
                shDi.Image = Resource1.blank;
                shDi.BackColor = Color.Green;
            }
            foreach (Label hb in holdBox)
            {
                hb.Visible = false;
            }
            lblTotalTop.Text = TotalTop.ToString();
            lblTotalBottom.Text = TotalBottom.ToString();
            lblGT.Text = gt.ToString();
            lblYahtzeeBonus.Text = "";
            lblYahtzeeBonus.BackColor = Color.WhiteSmoke;
            allDone = false;
            btnNew.Visible = false;
        }

        private void picDi2_Click(object sender, EventArgs e)
        {
            if (lblHeld2.Visible)
            {
                lblHeld2.Visible = false;
                picDi2.BackColor = Color.Green;
                lblHoverTip.Text = "Click to Hold";
            }
            else
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

        private void scrBtn3K_Click(object sender, EventArgs e)
        {
            int threeOfaKind = Score3k.Add3K(cubes);
            lbl3K.Text = threeOfaKind.ToString();
            lblTotalBottom.Text = AddBottom(threeOfaKind).ToString();
            scrBtn3K.BackColor = Color.LightSlateGray;
            scrBtn3K.Enabled = false;
            checkYahtzees();
            clearCubes();
        }

        private void scrBtnChance_Click(object sender, EventArgs e)
        {
            int chance = scrChance.AddChance(cubes);
            lblChance.Text = chance.ToString();
            lblTotalBottom.Text = AddBottom(chance).ToString();
            scrBtnChance.BackColor = Color.LightSlateGray;
            scrBtnChance.Enabled = false;
            checkYahtzees();
            clearCubes();
        }
        private void countYahtzees()
        {
            if (AnyYahtzees)
            {
                YahtzeeBonus += 100;
                lblYahtzeeBonus.Text = YahtzeeBonus.ToString();
                lblYahtzeeBonus.BackColor = Color.Gold;
            }


        }
        private void checkYahtzees()
        {
            if (cubes[0] == cubes[1] && cubes[1] == cubes[2] && cubes[2] == cubes[3] && cubes[3] == cubes[4])
            {
                //NumOfYahtzees++;
                countYahtzees();

            }
        }

        private void scrBtnYzee_Click(object sender, EventArgs e)
        {
            int yZee = ScrYhtzee.AddYahtzee(cubes);
            lblYahtzee.Text = yZee.ToString();
            lblTotalBottom.Text = AddBottom(yZee).ToString();
            scrBtnYzee.BackColor = Color.LightSlateGray;
            scrBtnYzee.Enabled = false;
            if (yZee == 50)
                AnyYahtzees = true;
            clearCubes();
        }

        private void scrBtn4K_Click(object sender, EventArgs e)
        {
            int fourOfKind = Score4k.Add4Kind(cubes);
            lbl4K.Text = fourOfKind.ToString();
            lblTotalBottom.Text = AddBottom(fourOfKind).ToString();
            scrBtn4K.BackColor = Color.LightSlateGray;
            scrBtn4K.Enabled = false;
            checkYahtzees();
            clearCubes();
        }

        private void scrBtnFH_Click(object sender, EventArgs e)
        {
            int fullHouse = 0;
            if (AnyYahtzees == true)
            {
                fullHouse = 25;
            }
            else
            {
                fullHouse = ScoreFH.AddFH(cubes);
            }

            lblFH.Text = fullHouse.ToString();
            lblTotalBottom.Text = AddBottom(fullHouse).ToString();
            scrBtnFH.BackColor = Color.LightSlateGray;
            scrBtnFH.Enabled = false;
            checkYahtzees();
            clearCubes();
        }   //I must rething these conditions for granting scores with bonus yahtzees

        private void scrBtnSmStr_Click(object sender, EventArgs e)
        {
            int smStr = 0;
            if (AnyYahtzees == true)
            {
                smStr = 30;
            }
            else
            {
                smStr = SmStr.Small(cubes);
            }
            lblSmall.Text = smStr.ToString();
            lblTotalBottom.Text = AddBottom(smStr).ToString();
            scrBtnSmStr.BackColor = Color.LightSlateGray;
            scrBtnSmStr.Enabled = false;
            checkYahtzees();
            clearCubes();
        }

        private void scrBtnLgStr_Click(object sender, EventArgs e)
        {
            int lgStr = 0;
            if (AnyYahtzees == true)
            {
                lgStr = 40;
            }
            else
            {
                lgStr = LgStr.Large(cubes);
            }

            lblLarge.Text = lgStr.ToString();
            lblTotalBottom.Text = AddBottom(lgStr).ToString();
            scrBtnLgStr.BackColor = Color.LightSlateGray;
            scrBtnLgStr.Enabled = false;
            checkYahtzees();
            clearCubes();

        }

        private void lblTotalTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // A little easter egg to show the "New Game" button
            btnNew.Visible = true;
            btnNew.Focus();
        }
    }
}