using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Project
{
    public partial class frmSimpleCalculator : Form
    {

        enum enOperations { Add = '+', Sub = '-', Mul = '*', Div = '/', Mod = '%'};
        bool VaildSize = true, PickedOpeation = false, PickedNum1 = false;
        double Number1, Number2;
        enOperations Op;

        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void CheckSizeAndZeroPlace(string Num)
        {
            if (textBox1.Text.Length == 1 && textBox1.Text.Equals("0"))
            {
                textBox1.Text = Num;
            }
            else if (!VaildSize) MessageBox.Show("The Number Is Too Long", "Size exceeded its limits."
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else textBox1.Text += Num;
        }

        private void IsPickedOp()
        {
            if(!PickedNum1 && PickedOpeation)
            {
                textBox1.Clear();
                PickedNum1 = true;
            }
        }

        private bool GetResult()
        {
            switch(Op)
            {
                case enOperations.Add:
                    Number1 += Number2;
                    return true;
                case enOperations.Sub:
                    Number1 -= Number2;
                    return true;
                case enOperations.Mul:
                    Number1 *= Number2;
                    return true;
                case enOperations.Div:
                    if(Number2 == 0) return false;
                    Number1 /= Number2;
                    return true;
                case enOperations.Mod:
                    if (Number2 == 0) return false;
                    Number1 %= Number2;
                    return true;
            }

            return false;
        }

        private void Calc()
        {
            PickedOpeation = false;
            Number2 = Convert.ToDouble(textBox1.Text);

            if(!GetResult())
            {
                MessageBox.Show("Can Not Divide Or Modulo By Zero", "Mathematical error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = Convert.ToString(Number1);
            }
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VaildSize = (textBox1.Text.Length != 13);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            PickedOpeation = false; PickedNum1 = false;
        }

        private void SetOp(enOperations enOP)
        {
            if (PickedOpeation)
            {
                if(Op == enOP) Calc();
                else
                {
                    Op = enOP;
                    label2.Text = ((char)enOP).ToString();
                }
            }
            else if(textBox1.Text.Length != 0)
            {
                Op = enOP;
                PickedNum1 = false;
                PickedOpeation = true;
                label2.Text = ((char)enOP).ToString();
                Number1 = Convert.ToDouble(textBox1.Text);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (PickedOpeation) Calc();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                textBox1.Text = "0.";
            }
            if (textBox1.Text.IndexOf(".") == -1)
            {
                textBox1.Text += '.';
            }
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    SetOp(enOperations.Add);
                    break;
                case "-":
                    SetOp(enOperations.Sub);
                    break;
                case "*":
                    SetOp(enOperations.Mul);
                    break;
                case "/":
                    SetOp(enOperations.Div);
                    break;
                case "%":
                    SetOp(enOperations.Mod);
                    break;
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IsPickedOp();
            CheckSizeAndZeroPlace(btn.Text);
        }


        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                label2.Text = "";
            if (textBox1.Text.Length != 0) 
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(button21.Text == "Dark Mode")
            {
                button21.Text = "Light Mode";
                this.BackColor = Color.FromArgb(59, 59, 59);
                foreach (Control c in Controls)
                {
                    if(c is Label)
                    {
                        c.ForeColor = Color.White;
                    }
                    else if(c is Button)
                    {
                        c.ForeColor = Color.White;
                        c.BackColor = Color.FromArgb(59, 59, 59);
                    }
                    else if(c is GroupBox)
                    {
                        c.ForeColor = Color.White;
                    }
                    else if(c is Panel)
                    {
                        if(c == panel1)
                        {
                            c.BackColor = Color.Orange;
                        }
                        else
                        {
                            c.BackColor = Color.FromArgb(59, 59, 59);
                        }
                    }
                }
            }
            else
            {
                button21.Text = "Dark Mode";
                this.BackColor = Color.White;
                foreach (Control c in Controls)
                {
                    if (c is Label)
                    {
                        c.ForeColor = Color.Black;
                    }
                    else if (c is Button)
                    {
                        c.ForeColor = Color.Black;
                        c.BackColor = Color.FromArgb(244, 247, 252);
                    }
                    else if (c is GroupBox)
                    {
                        c.ForeColor = Color.Black;
                    }
                    else if (c is Panel)
                    {
                        if (c == panel1)
                        {
                            c.BackColor = Color.LightCyan;
                        }
                        else
                        {
                            c.BackColor = Color.Black;
                        }
                    }
                }
            }
        }
    }
}

