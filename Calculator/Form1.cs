using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        
       

        private void compute(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                var result = dt.Compute(screen.Text, "");
                screen.Text = "";
                Ans_Screen.Text = result.ToString();
                
            }
            catch(Exception)
            {
                screen.Text = "Syntax error";
            }
            

        }

        

        private void divide(object sender, EventArgs e)
        {
            screen.Text += '/';

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            screen.Text = "";
            Ans_Screen.Text = "";
        }

        private void num_btn(object sender, EventArgs e)//Numeric key Buttons
        {
            Button btn = new Button();
            btn = (Button)sender;
            screen.Text += btn.Text;

        }

        private void plus(object sender, EventArgs e)//Plus operator
        {
            screen.Text += '+';
        }

        private void subtract(object sender, EventArgs e)//Minus operator
        {
            screen.Text += '-';

        }

        private void multiply(object sender, EventArgs e)//Multiply operator
        {
            screen.Text += '*';

        }

        private void openingBraces(object sender, EventArgs e)
        {
            screen.Text += '(';
        }

        private void closingBraces(object sender, EventArgs e)
        {
            screen.Text += ')';

        }

        private void answer(object sender, EventArgs e)
        {
            
            screen.Text = Ans_Screen.Text;
        }

        private void back_space(object sender, EventArgs e)
        {
            if(screen.Text!="")
            {
                screen.Text = screen.Text.Remove(screen.Text.Length - 1);
            }
        }
    }
}
