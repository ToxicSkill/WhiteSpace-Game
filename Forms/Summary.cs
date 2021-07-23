using System.Drawing;
using System.Windows.Forms;

namespace WhiteSpaceNsp
{
    public partial class Summary : Form
    {
        public Summary(bool win, string points, string ratio)
        {
            InitializeComponent();

            //If player won
            if (win)
            {
                //setting text 
                labelStatus.Text = "YOU WIN!";
                //setting back color
                BackColor = Color.Blue;
            }
            //same but when lose
            else
            {
                labelStatus.Text = "YOU LOSE!";
                BackColor = Color.OrangeRed;
            }
            //setting points value
            valuePoints.Text = points;
            //...and hit ratio
            valueRatio.Text = ratio + " %";
        }

    }
}
