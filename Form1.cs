using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Fixed
{
    public partial class FrmCalculator : Form
    {
        private Rectangle Cmd1_OriginalRectangle;
        private Rectangle Cmd2_OriginalRectangle;
        private Rectangle Cmd3_OriginalRectangle;
        private Rectangle Cmd4_OriginalRectangle;
        private Rectangle Cmd5_OriginalRectangle;
        private Rectangle Cmd6_OriginalRectangle;
        private Rectangle Cmd7_OriginalRectangle;
        private Rectangle Cmd8_OriginalRectangle;
        private Rectangle Cmd9_OriginalRectangle;
        private Rectangle Cmd0_OriginalRectangle;
        private Rectangle CmdBackspace_OriginalRectangle;
        private Rectangle CmdPlusMinus_OriginalRectangle;
        private Rectangle CmdClear_OriginalRectangle;
        private Rectangle CmdDecimal_OriginalRectangle;
        private Rectangle CmdSquareRoot_OriginalRectangle;
        private Rectangle CmdMultiply_OriginalRectangle;
        private Rectangle CmdDivide_OriginalRectangle;
        private Rectangle CmdMinus_OriginalRectangle;
        private Rectangle CmdEqual_OriginalRectangle;
        private Rectangle CmdPlus_OriginalRectangle;
        private Rectangle LblDisplay_OriginalRectangle;
        private Size originalFormSize;

        public FrmCalculator()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            Cmd1_OriginalRectangle = new Rectangle(Cmd1.Location.X, Cmd1.Location.Y, Cmd1.Width, Cmd1.Height);
            Cmd2_OriginalRectangle = new Rectangle(Cmd2.Location.X, Cmd2.Location.Y, Cmd2.Width, Cmd2.Height);
            Cmd3_OriginalRectangle = new Rectangle(Cmd3.Location.X, Cmd3.Location.Y, Cmd3.Width, Cmd3.Height);
            Cmd4_OriginalRectangle = new Rectangle(Cmd4.Location.X, Cmd4.Location.Y, Cmd4.Width, Cmd4.Height);
            Cmd5_OriginalRectangle = new Rectangle(Cmd5.Location.X, Cmd5.Location.Y, Cmd5.Width, Cmd5.Height);
            Cmd6_OriginalRectangle = new Rectangle(Cmd6.Location.X, Cmd6.Location.Y, Cmd6.Width, Cmd6.Height);
            Cmd7_OriginalRectangle = new Rectangle(Cmd7.Location.X, Cmd7.Location.Y, Cmd7.Width, Cmd7.Height);
            Cmd8_OriginalRectangle = new Rectangle(Cmd8.Location.X, Cmd8.Location.Y, Cmd8.Width, Cmd8.Height);
            Cmd9_OriginalRectangle = new Rectangle(Cmd9.Location.X, Cmd9.Location.Y, Cmd9.Width, Cmd9.Height);
            Cmd0_OriginalRectangle = new Rectangle(Cmd0.Location.X, Cmd0.Location.Y, Cmd0.Width, Cmd0.Height);
            CmdBackspace_OriginalRectangle = new Rectangle(CmdBackspace.Location.X, CmdBackspace.Location.Y, CmdBackspace.Width, CmdBackspace.Height);
            CmdPlusMinus_OriginalRectangle = new Rectangle(CmdPlusMinus.Location.X, CmdPlusMinus.Location.Y, CmdPlusMinus.Width, CmdPlusMinus.Height);
            CmdClear_OriginalRectangle = new Rectangle(CmdClear.Location.X, CmdClear.Location.Y, CmdClear.Width, CmdClear.Height);
            CmdDecimal_OriginalRectangle = new Rectangle(CmdDecimal.Location.X, CmdDecimal.Location.Y, CmdDecimal.Width, CmdDecimal.Height);
            CmdSquareRoot_OriginalRectangle = new Rectangle(CmdSquareRoot.Location.X, CmdSquareRoot.Location.Y, CmdSquareRoot.Width, CmdSquareRoot.Height);
            CmdMultiply_OriginalRectangle = new Rectangle(CmdMultiply.Location.X, CmdMultiply.Location.Y, CmdMultiply.Width, CmdMultiply.Height);
            CmdDivide_OriginalRectangle = new Rectangle(CmdDivide.Location.X, CmdDivide.Location.Y, CmdDivide.Width, CmdDivide.Height);
            CmdMinus_OriginalRectangle = new Rectangle(CmdMinus.Location.X, CmdMinus.Location.Y, CmdMinus.Width, CmdMinus.Height);
            CmdEqual_OriginalRectangle = new Rectangle(CmdEqual.Location.X, CmdEqual.Location.Y, CmdEqual.Width, CmdEqual.Height);
            CmdPlus_OriginalRectangle = new Rectangle(CmdPlus.Location.X, CmdPlus.Location.Y, CmdPlus.Width, CmdPlus.Height);
            LblDisplay_OriginalRectangle = new Rectangle(LblDisplay.Location.X, LblDisplay.Location.Y, LblDisplay.Width, LblDisplay.Height);
        }
        private void FrmCalculator_Resize(object sender, EventArgs e)
        {
            resizeControl(Cmd1_OriginalRectangle, Cmd1);
            resizeControl(Cmd2_OriginalRectangle, Cmd2);
            resizeControl(Cmd3_OriginalRectangle, Cmd3);
            resizeControl(Cmd4_OriginalRectangle, Cmd4);
            resizeControl(Cmd5_OriginalRectangle, Cmd5);
            resizeControl(Cmd6_OriginalRectangle, Cmd6);
            resizeControl(Cmd7_OriginalRectangle, Cmd7);
            resizeControl(Cmd8_OriginalRectangle, Cmd8);
            resizeControl(Cmd9_OriginalRectangle, Cmd9);
            resizeControl(Cmd0_OriginalRectangle, Cmd0);
            resizeControl(CmdBackspace_OriginalRectangle, CmdBackspace);
            resizeControl(CmdPlusMinus_OriginalRectangle, CmdPlusMinus);
            resizeControl(CmdClear_OriginalRectangle, CmdClear);
            resizeControl(CmdDecimal_OriginalRectangle, CmdDecimal);
            resizeControl(CmdSquareRoot_OriginalRectangle, CmdSquareRoot);
            resizeControl(CmdMultiply_OriginalRectangle, CmdMultiply);
            resizeControl(CmdDivide_OriginalRectangle, CmdDivide);
            resizeControl(CmdMinus_OriginalRectangle, CmdMinus);
            resizeControl(CmdEqual_OriginalRectangle, CmdEqual);
            resizeControl(CmdPlus_OriginalRectangle, CmdPlus);
            resizeControl(LblDisplay_OriginalRectangle, LblDisplay);
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        float num1, num2, result;
        char operation;
        bool dec = false;

        private void changeLabel(int numPressed)
        {
            if(dec == true)
            {
                int decimalCount = 0;
                foreach(char c in LblDisplay.Text)
                {
                    if(c == ',')
                    {
                        decimalCount++;
                    }
                }
                if(decimalCount < 1)
                {
                    LblDisplay.Text = LblDisplay.Text + ",";
                }
                dec = false;
            }
            else
            {
                if(LblDisplay.Text.Equals("0") == true && LblDisplay.Text != null)
                {
                    LblDisplay.Text = numPressed.ToString();
                }
                else if(LblDisplay.Text.Equals("-0") == true)
                {
                    LblDisplay.Text = "-" + numPressed.ToString();
                }
                else
                {
                    LblDisplay.Text =  LblDisplay.Text  + numPressed.ToString();
                }
            }
        }

        private void Cmd0_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void Cmd3_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void Cmd4_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void Cmd5_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void Cmd6_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void Cmd7_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void Cmd8_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void Cmd9_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void CmdDecimal_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void CmdPlusMinus_Click(object sender, EventArgs e)
        {
           LblDisplay.Text  = "-" + LblDisplay.Text;
        }

        private void CmdSquareRoot_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(LblDisplay.Text);
            if(num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                LblDisplay.Text = sqrt.ToString();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void CmdBackspace_Click(object sender, EventArgs e)
        {
            int stringLength = LblDisplay.Text.Length;
            if(stringLength > 1)
            {
                LblDisplay.Text = LblDisplay.Text.Substring(0, stringLength - 1);
            }
            else
            {
                LblDisplay.Text = "0";
            }
        }

        private void CmdMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(LblDisplay.Text);
            operation = '*';
            result = result * num1;
            LblDisplay.Text = "";
        }

        private void CmdDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(LblDisplay.Text);
            operation = '/';
            result = result / num1;
            LblDisplay.Text = "";
        }

        private void CmdMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(LblDisplay.Text);
            operation = '-';
            result = result - num1;
            LblDisplay.Text = "";
        }

        private void FrmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    Cmd1.PerformClick();
                    break;
                case Keys.D1:
                    Cmd1.PerformClick();
                    break;
                case Keys.NumPad2:
                    Cmd2.PerformClick();
                    break;
                case Keys.D2:
                    Cmd2.PerformClick();
                    break;
                case Keys.NumPad3:
                    Cmd3.PerformClick();
                    break;
                case Keys.D3:
                    Cmd3.PerformClick();
                    break;
                case Keys.NumPad4:
                    Cmd4.PerformClick();
                    break;
                case Keys.D4:
                    Cmd4.PerformClick();
                    break;
                case Keys.NumPad5:
                    Cmd5.PerformClick();
                    break;
                case Keys.D5:
                    Cmd5.PerformClick();
                    break;
                case Keys.NumPad6:
                    Cmd6.PerformClick();
                    break;
                case Keys.D6:
                    Cmd6.PerformClick();
                    break;
                case Keys.NumPad7:
                    Cmd7.PerformClick();
                    break;
                case Keys.D7:
                    Cmd7.PerformClick();
                    break;
                case Keys.NumPad8:
                    Cmd8.PerformClick();
                    break;
                case Keys.D8:
                    Cmd8.PerformClick();
                    break;
                case Keys.NumPad9:
                    Cmd9.PerformClick();
                    break;
                case Keys.D9:
                    Cmd9.PerformClick();
                    break;
                case Keys.Divide:
                    CmdDivide.PerformClick();
                    break;
                case Keys.Multiply:
                    CmdMultiply. PerformClick();
                    break;
                case Keys.Subtract:
                    CmdMinus.PerformClick();
                    break;
                case Keys.Add:
                    CmdPlus.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void FrmCalculator_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CmdEqual.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void CmdPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(LblDisplay.Text);
            operation = '+';
            result = result + num1;
            LblDisplay.Text = "";
        }

        private void CmdEqual_Click(object sender, EventArgs e)
        {
            result = 0;
            if(LblDisplay.Text.Equals("0") == false)
            {
                switch(operation)
                {
                    case '+':
                        num2 = float.Parse(LblDisplay.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(LblDisplay.Text);
                        result = num1 - num2;
                        break;
                    case '/':
                        num2 = float.Parse(LblDisplay.Text);
                        result = num1 / num2;
                        break;
                    case '*':
                        num2 = float.Parse(LblDisplay.Text);
                        result = num1 * num2;
                        break;
                    default:
                        break;
                }
            }
            LblDisplay.Text = result.ToString();
        }

    }
}
