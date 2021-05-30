using System;

namespace MyCalculator
{
    public static class CalculateOperators
    {
        /// <summary>
        /// Вычисляет сумму двух операндов
        /// </summary>
        /// <param name="a">Первый операнд</param>
        /// <param name="b">Второй операнд</param>
        /// <returns>Сумма первого и второго операнда</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычисляет разность двух операндов
        /// </summary>
        /// <param name="a">Первый операнд</param>
        /// <param name="b">Второй операнд</param>
        /// <returns>Разность первого и второго операнда</returns>
        public static double Sub(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Вычисляет произведение двух операндов
        /// </summary>
        /// <param name="a">Первый операнд</param>
        /// <param name="b">Второй операнд</param>
        /// <returns>Произведение двух чисел</returns>
        public static double Mult(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Вычисляет частное двух операндо
        /// </summary>
        /// <param name="a">Первый операнд</param>
        /// <param name="b">Второй операнд</param>
        /// <returns>Частное первого и второго операнда</returns>
        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Деление на 0");
            }
            return a / b;
        }

        /// <summary>
        /// Вычисляет квадратный корень операнда
        /// </summary>
        /// <param name="value">Операнд</param>
        /// <returns>Квадратный корень из операнда</returns>
        public static double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Ошибка ввода");
            }

            return Math.Sqrt(value);
        }

        /// <summary>
        /// Меняет знак операнда на противоположный
        /// </summary>
        /// <param name="value">Операнд</param>
        /// <returns>Операнд с противоположным знаком</returns>
        public static double InverstSign(double value)
        {
            return value * (-1);
        }

        /// <summary>
        /// Вычисляет синус угла, который задается в радианах
        /// </summary>
        /// <param name="corner">Угол в радианах</param>
        /// <returns>Синус угла</returns>
        public static double Sin(double corner)
        {
            return Math.Sin(corner);
        }

        /// <summary>
        /// Вычисляет арксинус операнда 
        /// </summary>
        /// <param name="value">Операнд (должен быть в диапазоне от -1 до 1 включительно)</param>
        /// <returns>Арксинус операнада</returns>
        public static double ArcSin(double value)
        {
            if (value > 1 || value <= -1)
            {
                throw new ArgumentException("Ошибка ввода");
            }
            return Math.Asin(value);
        }

        /// <summary>
        /// Вычисляет косинус угла, который задается в радианах
        /// </summary>
        /// <param name="corner">Угол в радианах</param>
        /// <returns>Синус угла</returns>
        public static double Cos(double corner)
        {
            return Math.Cos(corner);
        }

        /// <summary>
        /// Вычисляет арккосинус операнда 
        /// </summary>
        /// <param name="value">Операнд (должен быть в диапазоне от -1 до 1 включительно)</param>
        /// <returns>Арккосинус операнада</returns>
        public static double ArcCos(double value)
        {
            if (value > 1 || value <= -1)
            {
                throw new ArgumentException("Ошибка ввода");
            }
            return Math.Acos(value);
        }

        /// <summary>
        /// Вычисляет тангенс угла, который задается в радианах
        /// </summary>
        /// <param name="corner">Угол в радианах</param>
        /// <returns>Тангенс угла</returns>
        public static double Tan(double corner)
        {
            return Math.Tan(corner);
        }

        /// <summary>
        /// Вычисляет котангенс угла, который задается в радианах
        /// </summary>
        /// <param name="corner">Угол в радианах</param>
        /// <returns>Котангенс угла</returns>
        public static double Ctan(double corner)
        {
            return 1.0 / Math.Tan(corner);
        }

        /// <summary>
        /// Вычисляет значение 'X', возведенное в степень 'n'
        /// </summary>
        /// <param name="x">Основание степени</param>
        /// <param name="n">Паказатель степени</param>
        /// <returns>Основание возведенное в степени паказателя</returns>
        public static double PowN(double x, double n)
        {
            return Math.Pow(x, n);
        }

        /// <summary>
        /// Вычисляет корень степени 'n' из числа 'X'
        /// </summary>
        /// <param name="x">Подкоренное выражение</param>
        /// <param name="n">Степень корня</param>
        /// <returns>Корень степени 'n' из числа 'X'</returns>
        public static double RootN(double x, double n)
        {
            if(n % 2 == 0 && x < 0)
            {
                throw new ArgumentException("Ошибка ввода");
            }

            return Math.Pow(x, 1.0 / n);
        } 

        /// <summary>
        /// Вычисляет 2 в степени 'n'
        /// </summary>
        /// <param name="n">Показатель степени 2</param>
        /// <returns>Значение двойки, возведенная в степень 'n'</returns>
        public static double  TwoPowN(double n)
        {
            return Math.Pow(2, n);
        }

        /// <summary>
        /// Вычисляет 10 в степени 'n'
        /// </summary>
        /// <param name="n">Показатель степени 10</param>
        /// <returns>Значение 10, возведенная в степень 'n'</returns>
        public static double TenPowN(double n)
        {
            return Math.Pow(10, n);
        }

        /// <summary>
        /// Вычисляет значение 'X', возведенное в степени 3
        /// </summary>
        /// <param name="value">Основание степени</param>
        /// <returns>Основание возведенное в степень 3</returns>
        public static double PowThree(double value)
        {
            return Math.Pow(value, 3);
        }

        /// <summary>
        /// Вычисляет натуральный логарифм числа 'value'
        /// </summary>
        /// <param name="value">Подлогарифмическое выражение</param>
        /// <returns>Натуральный логарифм числа</returns>
        public static double Ln(double value)
        {
            if(value <= 0)
            {
                throw new ArgumentException("Ошибка ввода");
            }
            return Math.Log(value);
        }

        /// <summary>
        /// Вычисляет логорифм по основанию 10 числа 'value'
        /// </summary>
        /// <param name="value">Подлогарифмическое выражение</param>
        /// <returns>Логарифм числа по основанию 10</returns>
        public static double Log(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Ошибка ввода");
            }
            return Math.Log(value, 10);
        }

        /// <summary>
        /// Вычисляет модуль операнда
        /// </summary>
        /// <param name="value">Операнд</param>
        /// <returns>Модель числа</returns>
        public static double AbsValue(double value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        /// Вычисляет квадрат операнда
        /// </summary>
        /// <param name="value">Операнд</param>
        /// <returns>Квадрат операнда</returns>
        public static double SquareValue(double value)
        {
            return Math.Pow(value, 2);
        }

        /// <summary>
        /// Вычисляет факториал операнда
        /// </summary>
        /// <param name="value">Операнд</param>
        /// <returns>Факториал операнда</returns>
        public static double Factorial(double value)
        {
            if(value == 1 || value == 0 || value < 0)
            {
                return 1;
            }
            
            return value * Factorial(value - 1);
        }

        /// <summary>
        /// Вычисляет корень 3-й степени из числа 'value'
        /// </summary>
        /// <param name="value">Подкоренное выражение</param>
        /// <returns>Корень степени 3 из числа 'value'</returns>
        public static double RootThree(double value)
        {
            return Math.Pow(value, 1 / 3.0);
        }

        /// <summary>
        /// Вычисляет число, равное 1 деленное на операнд 'value'
        /// </summary>
        /// <param name="value">Операнд</param>
        /// <returns>Обратное число (1 деленное на 'value')</returns>
        public static double ReverseValue(double value)
        {
            if(value == 0)
            {
                throw new ArgumentException("Ошибка ввода");
            }
            return 1.0 / value;
        }

        /// <summary>
        /// Возвращает число e, возведенное в указанную степень
        /// </summary>
        /// <param name="value">Степень</param>
        /// <returns>Степень числа 'e', возведенное в степень 'value'</returns>
        public static double Exp(double value)
        {
            return Math.Exp(value);
        }

        /// <summary>
        /// Конвертирует значение в радианах в градусы
        /// </summary>
        /// <param name="radian">Значение в радианах</param>
        /// <returns>Значение в радианах</returns>
        public static double RadianToDegree(double radian)
        {
            return radian *  (180.0 / Math.PI);
        }

        /// <summary>
        /// Конвертирует значение в градусах в радианы
        /// </summary>
        /// <param name="radian">Значение в градусах</param>
        /// <returns>Значение в градусах</returns>s>
        public static double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180.0);
        }

    }
}
