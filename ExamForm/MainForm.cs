using System;
using System.Windows.Forms;

#region Hints
// Extra marks are awarded for demonstrating extra skills and knowledge
// Stringbuilder, Tasks, LINQ, etc. though not required
//
// If you've got extra time, fix the resizing issue however you see fit
//
// Code clarity is paramount, messy code is frowned upon
//
// That hint label has an interesting name
#endregion

namespace ExamForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                if ((i%3 == 0) && (i%5 == 0))
                {
                    OutputRTB.AppendText(Environment.NewLine + BuzzTextBox.Text + FizzTextBox.Text);
                }
                else if (i%3 == 0)
                {
                    OutputRTB.AppendText(Environment.NewLine + BuzzTextBox.Text);
                }
                else if (i%5 == 0)
                {
                    OutputRTB.AppendText(Environment.NewLine + FizzTextBox.Text);
                }
                else
                {
                    OutputRTB.AppendText(Environment.NewLine + i);
                }
            }

            HintLabel.Text = "Finished!";
        }
    }
}
