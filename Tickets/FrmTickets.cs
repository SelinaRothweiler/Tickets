using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class FrmTickets : Form
    {
        public FrmTickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            double price = 0;

            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter you age ", "Tickets", ""));

            if(age <= 12)
            {
                price = 5.00;
            }
            else if (age >= 13 && age <= 20)
            {
                price = 6.00;
            }
            else if (age >= 21 && age <= 64)
            {
                price = 10.00;
            }
            else if (age >=65)
            {
                price = 2.00;
            }

            MessageBox.Show("Your price is " + price.ToString("c"));
        }


        private void BtnAverage_Click(object sender, EventArgs e)
        {
            int mark1;
            int mark2;
            int mark3;
            int mark4;
            double average;

            mark1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter you mark ", "Average", ""));
            mark2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter you mark ", "Average", ""));
            mark3 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter you mark ", "Average", ""));
            mark4 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter you mark ", "Average", ""));

            average = (double)(mark1 + mark2 + mark3 + mark4) / 4;

            MessageBox.Show("Your average is " + average.ToString("n2"));

            if (average < 50)
            {
                MessageBox.Show("You failed :(");
            }
            else if (average >= 50)
            {
                MessageBox.Show("Yay...You Passed!");
            }

        }

        private void BtnGasBill_Click(object sender, EventArgs e)
        {
            int gas;
            double bill = 0;

            gas = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter your gas usage in ccf ", "Gas Bill", ""));

            if (gas <= 8)
            {
                bill = gas * .50;
            }
            else if (gas > 8)
            {
                bill = gas * .50 + (gas - 8) * .30;
            }

            MessageBox.Show("Here is your total gas bill. " + bill.ToString("c"));
        }
        private void BtnElectricBill_Click(object sender, EventArgs e)
        {
            int kwh;
            double bill = 0;

            kwh = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter your electric usage in kwh ", "Electric Bill", ""));

            if (kwh <= 12)
            {
                bill = 2.80;
            }
            else if (kwh > 12 && kwh <= 78)
            {
                bill = 2.80 + (kwh - 12) * .08;
            }
            else if(kwh >= 90)
            {
                bill = 2.80 + (78 * .08) + (kwh - 90) * .06;
            }

            MessageBox.Show("Here is your electric bill " + bill.ToString("c"));
        }
    }
}
