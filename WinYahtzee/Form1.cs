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
           label1.Text = Roll.rollEm().ToString();
            picDi1.Image = Resource1.smDiceroll;
            await Task.Delay(2000);
            picDi1.Refresh();
            picDi1.Image = Resource1.y4;
        }
    }
}