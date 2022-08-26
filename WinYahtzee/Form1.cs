using RollDice;

namespace WinYahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
           label1.Text = Roll.rollEm().ToString();
        }
    }
}