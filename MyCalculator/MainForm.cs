using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static MyCalculator.CalculateOperators;

namespace MyCalculator
{
    public partial class MainForm : Form
    {
        Point currentPosition; //Текщее положение калькулятора

        private int minOpenedHeight = 498; // Высота калькулятора в закрытом состоянии
        private int maxOpenedHeight = 780; // Высота калькулятор в открытом положении
        private int panelAdvancedHeight = 282;
        private bool isExceptionTrow = false; // Флаг, указывающий о возникновении исключения при вычислении
        private int maxCharCount = 10; //Максимальное количество символов в поле вода

        public MainForm()
        {
            InitializeComponent();
            this.Height = minOpenedHeight;
        }

        #region Служебные события
        //Событие 'Click' кнопки закрытия
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPinActivate_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {
                (sender as Button).Image = Properties.Resources.pin_28px;
            }
            else
            {
                (sender as Button).Image = Properties.Resources.unpin_28px;
            }
            this.TopMost = !this.TopMost;
        }

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentPosition = new Point(e.X, e.Y);
            }
        }

        private void controlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - currentPosition.X;
                this.Top += e.Y - currentPosition.Y;
            }
        }

        private void btnShowAdvanced_Click(object sender, EventArgs e)
        {
            if (Height == minOpenedHeight)
            {
                Height = maxOpenedHeight;
                this.Top = this.Top - panelAdvancedHeight / 2;
                btnShowAdvanced.Image = Properties.Resources.collapse_arrow_15px;
            }
            else
            {
                Height = minOpenedHeight;
                this.Top = this.Top + panelAdvancedHeight / 2;
                btnShowAdvanced.Image = Properties.Resources.expand_arrow_15px;
            }

        }


        #endregion


        #region События формы
        //Событие 'Click' для кнопки ввода числа π
        private void btnPI_Click(object sender, EventArgs e)
        {
            tbxInput.Text = Math.Round(Math.PI, maxCharCount).ToString();
        }

        //Событие 'Click' для кнопок ввода цифр
        private void NumberClick(object sender, EventArgs e)
        {
            if(tbxInput.Text[0] == '0' && tbxInput.Text.Length == 1)
                tbxInput.Text = (sender as Button).Text;
            else
                tbxInput.Text += (sender as Button).Text;
        }

        //Событие 'Click' для кнопки очиски всех полей калькулятора
        private void ClearAll(object sender, EventArgs e)
        {
            ResetAll();
        }

        //Событие 'Click' для кнопки удаления последнего введенного символа
        private void ClearLast(object sender, EventArgs e)
        {
            tbxInput.Text = tbxInput.Text.Substring(0, tbxInput.Text.Length - 1);
        }

        //Событие 'TextChanged' для поля ввода символов
        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            if (tbxInput.Text == string.Empty) 
                ResetInput();

            if (isExceptionTrow)
            {
                ResetInput();
                isExceptionTrow = false;
            }
            ChangeInputFontSize();
        }

        //Метод, изменяющий размер шрифта поля ввода
        private void ChangeInputFontSize()
        {
            if (tbxInput.Text.Length > 14)
            {
                tbxInput.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Refresh();
            }
            else
            {
                tbxInput.Font = new Font("Lucida Console", 21.75f, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Refresh();
            }
        }

        //Собитие 'Click' кнопки ввода запятой
        private void InputComma(object sender, EventArgs e)
        {
            if (!tbxInput.Text.Contains(',')) tbxInput.Text += ",";
        }

        //Событие 'Click' для кнопок, запускащие операции с двумя операндами
        private void BaseOperationInvoke(object sender, EventArgs e)
        {
            btn_Equal_Click(null, null);

            lblPrevInput.Text = tbxInput.Text.EndsWith(",") ? tbxInput.Text + "0" : tbxInput.Text;
            lblOperation.Text = (sender as Button).Tag.ToString();

            ResetInput();
        } 

        //Событие 'Click' для кнопок, запускающие операции с одним операндом
        private void AnvancedOperationInvoke(object sender, EventArgs e)
        {
            lblPrevInput.Text = string.Empty;
            lblOperation.Text = (sender as Button).Text;
            btn_Equal_Click(sender, e);
        }

        //Собитие 'Click' для кнопки '='
        private void btn_Equal_Click(object sender, EventArgs e)
        {
            try
            {
                double first = GetFirstOperand();

                double second = Convert.ToDouble(tbxInput.Text);

                if (string.IsNullOrWhiteSpace(lblOperation.Text)) 
                    return;

                tbxInput.Text = Math.Round(Calculate(lblOperation.Text, first, second), maxCharCount).ToString();
                ResetOperationData();
            }
            catch (ArgumentException ex)
            {
                HandleException(ex.Message);
            }
            catch (Exception)
            {
                HandleException("Ошибка");
            }
        }

        #endregion


        /// <summary>
        /// Возвращает первый операнд для операций с 2-я операндами или 0, если 
        /// текущая операция имеет только один операнд
        /// </summary>
        /// <returns>Первый операнд</returns>
        private double GetFirstOperand()
        {
            if (!string.IsNullOrWhiteSpace(lblPrevInput.Text))
            {
                return Convert.ToDouble(lblPrevInput.Text);
            }
            return 0;
        }

        /// <summary>
        /// Обработка исключений, возникший при вычислении
        /// </summary>
        /// <param name="info">Информация об исключении</param>
        private void HandleException(string info)
        {
            tbxInput.Text = info;
            ResetOperationData();
            isExceptionTrow = true;
        }

        /// <summary>
        /// Метод, выполняющий заданную опрерация над операндами
        /// </summary>
        /// <param name="operation">Обозначение операции</param>
        /// <param name="first">Первый операнд</param>
        /// <param name="second">Второй операнд</param>
        /// <returns></returns>
        private double Calculate(string operation, double first, double second)
        {
            double corner = second;
            if (rbDegree.Checked) corner = DegreeToRadian(second);

            switch (operation)
            {
                case "+":
                    return Add(first, second);
                case "-":
                    return Sub(first, second);
                case "x":
                    return Mult(first, second);
                case "÷":
                    return Div(first, second);
                case "xⁿ":
                    return PowN(first, second);
                case "ⁿ√x":
                    return RootN(first, second);
                case "±":
                    return InverstSign(second);
                case "√x":
                    return SquareRoot(second);
                case "2ⁿ":
                    return TwoPowN(second);
                case "10ⁿ":
                    return TenPowN(second);
                case "x³":
                    return PowThree(second);
                case "ln":
                    return Ln(second);
                case "log":
                    return Log(second);
                case "|x|":
                    return AbsValue(second);
                case "x²":
                    return SquareValue(second);
                case "x!":
                    return Factorial(second);
                case "³√x":
                    return RootThree(second);
                case "1/x":
                    return ReverseValue(second);
                case "exp(x)":
                    return Exp(second);
                case "sin":
                    return Sin(corner);
                case "cos":
                    return Cos(corner);
                case "tg":
                    return Tan(corner);
                case "ctg":
                    return Ctan(corner);
                case "sin⁻¹":
                    return ArcSin(second);
                case "cos⁻¹":
                    return ArcSin(second);
                default:
                    throw new ArgumentException("Ошибка ввода");
            }
        }

        /// <summary>
        /// Сбрасывает состояние поля ввода
        /// </summary>
        private void ResetInput()
        {
            tbxInput.Text = "0";
        } 

        /// <summary>
        /// Сбрасывает служебный полей оператора
        /// </summary>
        private void ResetOperationData()
        {
            lblOperation.Text = string.Empty;
            lblPrevInput.Text = string.Empty;
        }

        /// <summary>
        /// Сбрасывает состояние всего калькулятора
        /// </summary>
        public void ResetAll()
        {
            ResetInput();
            ResetOperationData();
        }

    }
}

