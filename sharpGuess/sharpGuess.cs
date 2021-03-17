using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpGuess
{
    public partial class sharpGuess : Form
    {
        public int secretNumber;
        public sharpGuess()
        {
            Random rand = new Random();
            secretNumber = rand.Next(1, 1000);

            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = GetGuess();
            char result = Validate(guess);
            if(result == '✓')
                SetResultLabel(result.ToString(), Color.Green);
            else
                SetResultLabel(result.ToString(), Color.Red);
            
            AddWrongGuess(guess + " " + result.ToString());
        }

        private string GetGuess()
        {
            return tbUserGuess.Text;
        }

        private char Validate(string guess)
        {
            int value;
            if (!int.TryParse(guess, out value))
            {
                System.Environment.Exit(0);
            }

            if (value > secretNumber)
                return '>';
            else if (value < secretNumber)
                return '<';
            else
                return '✓';
        }

        private void SetResultLabel(string s, Color c)
        {
            if (!lblResult.Visible)
                lblResult.Visible = true;

            lblResult.Text = s;
            lblResult.ForeColor = c;
        }

        private void AddWrongGuess(string guess)
        {
            lGuessed.Items.Add(guess);
        }

    }
}
