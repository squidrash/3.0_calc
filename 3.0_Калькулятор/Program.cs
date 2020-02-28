using System;

namespace _3._0_Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. +\t2. -\t3. *\t4. /\n" +
                    "5. sin\t6. cos\t7. tg\t8. arctg\n" +
                    "9. Ln\t10. Log10\t11. Exp\t12. !\n" +
                    "13. 1/x\t14. x^y");
            double x = Double.Parse(Console.ReadLine());
            int op = Int32.Parse(Console.ReadLine());
            //if (op ==  || op == "cos")
            double y = Double.Parse(Console.ReadLine());
            Calculator calculator = new Calculator(x,op,y);
            Console.WriteLine(calculator.Calc());
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public double x;
        public int op;
        public double y;
        public double result;
        public Calculator(double X, int Op, double Y) { x = X; op = Op; y = Y; }        
        public double Calc()
        {
            while (true)
            {
                if (op == 1 || op == 2 || op == 3 || op == 4 || op == 14)
                {
                    result = Calculate2(x, op, y);
                    return result;
                }
                else if (op == 5 || op == 6 || op == 7 || op == 8
                        || op == 9 || op == 10 || op == 11 || op == 12 || op == 13)
                {
                        result = Calculate1(x, op);
                        return result;

                 }
                    else
                    throw new Exception();
            }
        }
        public double Calculate1(double x, int op)
        {
            switch (op)
            {
                case 5:
                    result = Sin(x);
                    return result;
                case 6:
                    result = Cos(x);
                    return result;

                case 7:
                    result = Tan(x);
                    return result;

                case 8:
                    result = ATan(x);
                    return result;

                case 9:
                    result = Ln(x);
                    return result;

                case 10:
                    result = Log10(x);
                    return result;

                case 11:
                    result = Exp(x);
                    return result;


                case 12:
                    try
                    {
                        if (x % 1 == 0 && x >= 0)
                        {
                            result = Factorial(x);
                            return result;
                        }
                        else
                            throw new Exception("Число должно быть целое и больше 0");
                    }

                    catch (Exception)
                    {
                        //Console.WriteLine(e.Message);
                        return result = 0;
                    }
                case 13:
                    result = OneX(x);
                    return result;
            }
            return result = 001;

        }
        public double Sin(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double sinAngle = Math.Sin(angle);
            return sinAngle;
        }
        public double Cos(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double cosAngle = Math.Cos(angle);
            return cosAngle;
        }
        public double Tan(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double tanAngle = Math.Tan(angle);
            return tanAngle;

        }
        public double ATan(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double atanAngle = Math.Atan(angle);
            return atanAngle;
        }
        public double Factorial(double x)
        {
            if (x == 0)
                return 1;
            else
            {
                double result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        public double Ln(double x)
        {
            double n = Math.Log(x);
            return n;
        }
        public double Log10(double x)
        {
            double n = Math.Log10(x);
            return n;
        }
        public double Exp(double x)
        {
            double n = Math.Exp(x);
            return n;
        }
        public double OneX(double x)
        {
            double n = 1 / x;
            return n;
        }

        public double Calculate2(double x, int op, double y)
        {
            double n = 002;
            switch (op)
            {
                case 1:
                    n = Sum(x, y);
                    return n;

                case 2:
                    n = Subtract(x, y);
                    return n;
                case 3:
                    n = Multiply(x, y);
                    return n;
                case 4:
                    if (y == 0)
                    {
                        throw new Exception("Деление на 0");
                    }
                    else
                    {
                        n = Divide(x, y);
                        return n;
                    }
                case 14:
                    n = Pow(x, y);
                    return n;
                default:
                    break;
            }
            return n;
        }
        
        public double Sum(double x, double y)
        {
            double z = x + y;
            return z;
        }
        public double Subtract(double x, double y)
        {
            double z = x - y;
            return z;
        }
        public double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }
        public double Divide(double x, double y)
        {
            double z = x / y;
            return z;
        }
        public double Pow(double x,double y)
        {
            double z = Math.Pow(x, y);
            return z;
        }
    }
}
