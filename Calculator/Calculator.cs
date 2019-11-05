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
            label1.Focus();
            txtOutput.Text = "";
            btn0.Click += ButtonClickEvent;
            btn1.Click += ButtonClickEvent;
            btn2.Click += ButtonClickEvent;
            btn3.Click += ButtonClickEvent;
            btn4.Click += ButtonClickEvent;
            btn5.Click += ButtonClickEvent;
            btn6.Click += ButtonClickEvent;
            btn7.Click += ButtonClickEvent;
            btn8.Click += ButtonClickEvent;
            btn9.Click += ButtonClickEvent;
            btnAdd.Click += ButtonClickEvent;
            btnSubtract.Click += ButtonClickEvent;
            btnMultiply.Click += ButtonClickEvent;
            btnDivide.Click += ButtonClickEvent;

            btnEquals.Click += ButtonClickEventEquals;
            btnDelete.Click += ButtonClickEventDelete;
            btnClear.Click += ButtonClickEventClear;
            this.KeyUp += new KeyEventHandler(KeyUpEventEquals);
        }


        private void ButtonClickEvent(object sender, EventArgs e)
        {
            txtOutput.Text += (sender as Button).Text;
            label1.Focus();
        }
        private void ButtonClickEventEquals(object sender, EventArgs e)
        {
            string data = txtOutput.Text;
            DataTable temp = new DataTable();

            txtOutput.Text = (temp.Compute(data, string.Empty).ToString());
        }
        private void ButtonClickEventDelete(object sender, EventArgs e)
        {
            string data = txtOutput.Text;
            txtOutput.Text = data.Remove(data.Length - 1);
        }

        private void ButtonClickEventClear(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        private void KeyUpEventEquals(object sender, KeyEventArgs e)
        {
            string data = txtOutput.Text;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    DataTable temp = new DataTable();
                    txtOutput.Text = (temp.Compute(data, string.Empty).ToString());
                    break;
                case Keys.Delete:
                    txtOutput.Text = data.Remove(data.Length - 1);
                    break;
                case Keys.Back:
                    txtOutput.Text = data.Remove(data.Length - 1);
                    break;
                case Keys.Add:
                    txtOutput.Text += "+";
                    break;
                case Keys.Subtract:
                    txtOutput.Text += "-";
                    break;
                case Keys.OemMinus:
                    txtOutput.Text += "-";
                    break;
                case Keys.Multiply:
                    txtOutput.Text += "*";
                    break;
                case Keys.Divide:
                    txtOutput.Text += "/";
                    break;
                case Keys.OemBackslash:
                    txtOutput.Text += "/";
                    break;
                //case Keys.ShiftKey | Keys.D8:
                //    txtOutput.Text += "*";
                //    break;
                case Keys.D1:
                    txtOutput.Text += "1";
                    break;
                case Keys.D2:
                    txtOutput.Text += "2";
                    break;
                case Keys.D3:
                    txtOutput.Text += "3";
                    break;
                case Keys.D4:
                    txtOutput.Text += "4";
                    break;
                case Keys.D5:
                    txtOutput.Text += "5";
                    break;
                case Keys.D6:
                    txtOutput.Text += "6";
                    break;
                case Keys.D7:
                    txtOutput.Text += "7";
                    break;
                case Keys.D8:
                    if (e.Modifiers == Keys.Shift)
                    {
                        txtOutput.Text += "*";
                    }
                    else
                    {
                        txtOutput.Text += "8";
                    }
                    break;
                case Keys.D9:
                    txtOutput.Text += "9";
                    break;
                case Keys.D0:
                    txtOutput.Text += "0";
                    break;
            }


            //if (e.KeyCode == Keys.Enter)
            //{
            //    btnEquals.Click += ButtonClickEventEquals;
            //    MessageBox.Show("Enter key");
            //}
        }
    }
}
