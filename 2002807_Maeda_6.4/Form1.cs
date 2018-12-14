using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _2002807_Maeda_6._4
{
    public partial class Form1 : Form
    {
        public static double prune = 0,
            apple = 0,
            pruneTotalS = 0,
            appleTotalS = 0,
            testers = 0;

        public Form1()
        {
            Thread splash = new Thread(new ThreadStart(SplashStart));
            splash.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            splash.Abort();
            pruneTotal.ReadOnly = true;
            appleTotal.ReadOnly = true;
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread summary = new Thread(new ThreadStart(SummaryStart));
            summary.Start();
        }

        public void SummaryStart()
        {
            Application.Run(new summary());
        }

        public void SplashStart()
        {
            Application.Run(new splashScreen());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addYourScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                prune = int.Parse(pruneInput.Text);
                if (prune > 10)
                {
                    MessageBox.Show("Please enter a number between 1 and 10", "Error");
                    pruneInput.Clear();
                }
                else if (prune < 1)
                {
                    MessageBox.Show("Please enter a number between 1 and 10", "Error");
                    appleInput.Clear();
                }
                else
                {
                    apple = int.Parse(appleInput.Text);
                    if (apple > 10)
                    {
                        MessageBox.Show("Please enter a number between 1 and 10", "Error");
                        appleInput.Clear();
                    }
                    else if (apple < 1)
                    {
                        MessageBox.Show("Please enter a number between 1 and 10", "Error");
                        appleInput.Clear();
                    }
                    else
                    {
                        testers++;
                        pruneTotalS += prune;
                        appleTotalS += apple;
                        pruneInput.Clear();
                        appleInput.Clear();
                        pruneTotal.Text = pruneTotalS.ToString();
                        appleTotal.Text = appleTotalS.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid input", "Error");
                pruneInput.Clear();
                appleInput.Clear();
            }
            }
        }
    }

