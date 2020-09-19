using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
   
   
    public partial class Calculator : Form
    {
        int firstNumber=0;
        int secondNumber=0;
        float result=0;
        string operatortype = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AcceptNumber(object sender, EventArgs e)
        {
            
            
                txtresult.Text += (sender as Button).Text;
                
            
        }

        private void AcceptSecondNumber(object sender, EventArgs e)
        {
           operatortype= (sender as Button).Text;
            if (firstNumber == 0)
            {
                firstNumber = int.Parse (txtresult.Text);
                txtresult.Text = "";
            }
        }

        private void GetResult(object sender, EventArgs e)
        {
            secondNumber = int.Parse(txtresult.Text);
            
            if (operatortype == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operatortype == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operatortype == "x")
            {
                result = firstNumber * secondNumber;
            }
            else if (operatortype == "/")
            {
                result = firstNumber / secondNumber;
            }
            txtresult.Text = result.ToString();
        }

        private void ClearResult(object sender, EventArgs e)
        {
            txtresult.Text = "";
            firstNumber = 0;
            secondNumber = 0;
        }
    }
}
