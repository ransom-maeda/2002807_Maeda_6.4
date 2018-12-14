using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_6._4
{
    public partial class summary : Form
    {

        public double testers,
            apple,
            prune,
            averageA,
            averageP,
            totalPrune,
            totalApple;

        public summary()
        {
            InitializeComponent();
            testers = Form1.testers;
            prune = Form1.pruneTotalS;
            apple = Form1.appleTotalS;
            averageA = apple / testers;
            averageP = prune / testers;
            testerAmount.Text = testers.ToString();
            averageAOutput.Text = averageA.ToString();
            averagePOutput.Text = averageP.ToString();

            if(apple > prune)
            {
                labelWinner.Text = "Apple Won!";
            }
            else if(prune > apple)
            {
                labelWinner.Text = "Prune Won!";
            }
            else
            {
                labelWinner.Text = "It's a tie!";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
