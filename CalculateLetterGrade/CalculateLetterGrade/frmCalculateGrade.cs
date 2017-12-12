using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // variables - take the number grade and converting it to int from string
            int numberGrade = Convert.ToInt32(txtNumberGrade.Text);

            //logic for the grading scale 
            if (numberGrade >= 88)
            {
                txtLetterGrade.Text = "A";
            }
            else if (numberGrade >= 80 & numberGrade <= 87)
            {
                txtLetterGrade.Text = "B";
            }
            else if (numberGrade >= 68 & numberGrade <= 79)
            {
                txtLetterGrade.Text = "C";
            }
            else if (numberGrade >= 60 & numberGrade <= 67)
            {
                txtLetterGrade.Text = "D";
            }
            else
            {
                txtLetterGrade.Text = "F";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
