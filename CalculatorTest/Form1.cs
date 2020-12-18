using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTest
{
    public partial class Form1 : Form
    {
        public string FirstNo = "";
        public string SecondNo = "";
        public CalculationSigns currentSign = CalculationSigns.Nothing;  //定义全局变量无操作的
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button00_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "0";

        }

        private void button01_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "1";
        }

        private void button02_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "2";
        }

        private void button03_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "3";
        }

        private void button04_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "4";
        }

        private void button05_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "5";
        }

        private void button06_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "6";
        }

        private void button07_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "7";
        }

        private void button08_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "8";
        }

        private void button09_Click(object sender, EventArgs e)
        {
            this.数字显示框.Text += "9";
        }
        //抽象方法 按下运算按钮
        private void ClickDown() 
        {
            switch (currentSign)
            {
                case CalculationSigns.Nothing:
                    break;
                case CalculationSigns.Add:
                    this.运算表达试.Text = this.数字显示框.Text + "+";
                    break;
                case CalculationSigns.Subtract:
                    this.运算表达试.Text = this.数字显示框.Text + "-";
                    break;
                case CalculationSigns.Multiply:
                    this.运算表达试.Text = this.数字显示框.Text + "×";
                    break;
                case CalculationSigns.Divide:
                    this.运算表达试.Text = this.数字显示框.Text + "÷";
                    break;
                default:
                    break;
            }
            FirstNo = this.数字显示框.Text;
            this.数字显示框.Text = "";
        }

        //加法
        private void button_1_Click(object sender, EventArgs e)
        {
            currentSign = CalculationSigns.Add;
            ClickDown();

        }
        //减法
        private void button_2_Click(object sender, EventArgs e)
        {
            currentSign = CalculationSigns.Subtract;
            ClickDown();
        }
        //乘法
        private void button_3_Click(object sender, EventArgs e)
        {
            currentSign = CalculationSigns.Multiply;
            ClickDown();
        }
        //除法
        private void button_4_Click(object sender, EventArgs e)
        {
            currentSign = CalculationSigns.Divide;
            ClickDown();
        }

        //清零
        private void button111_Click(object sender, EventArgs e)
        {
            this.FirstNo = "";
            this.SecondNo = "";
            this.currentSign = CalculationSigns.Nothing;
            数字显示框.Text = "";
            运算表达试.Text = "";
        }

        //等于
        private void button000_Click(object sender, EventArgs e)
        {          
            SecondNo= this.数字显示框.Text;
            //把字符串变成整数
            int First = int.Parse(FirstNo);
            int Second = int.Parse(SecondNo);

            int result;
                switch (currentSign)
            {
                case CalculationSigns.Nothing:
                    break;
                case CalculationSigns.Add:
                    result = First + Second;
                    this.数字显示框.Text = result.ToString();
                    this.运算表达试.Text = First.ToString() + "+" + Second.ToString() + "=";
                    break;
                case CalculationSigns.Subtract:
                    result = First - Second;
                    this.数字显示框.Text = result.ToString();
                    this.运算表达试.Text = First.ToString() + "-" + Second.ToString() + "=";
                    break;
                case CalculationSigns.Multiply:
                    result = First * Second;
                    this.数字显示框.Text = result.ToString();
                    this.运算表达试.Text = First.ToString() + "×" + Second.ToString() + "=";
                    break;
                case CalculationSigns.Divide:
                    result = First / Second;
                    this.数字显示框.Text = result.ToString();
                    this.运算表达试.Text = First.ToString() + "÷" + Second.ToString() + "=";
                    break;
                default:
                    break;
            }
            
        }

       
    }
}
