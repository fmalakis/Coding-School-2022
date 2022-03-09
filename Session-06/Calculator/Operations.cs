namespace Calculator
{
    public static class Operations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static float Subtract(int a, float b)
        {
            return a - b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static float Multiply(int a, float b)
        {
            return a * b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(int a, int b)
        {
            return a / (float)b;
        }
        public static float Divide(int a, float b)
        {
            return a / b;
        }
        public static float Divide(float a, float b)
        {
            return a / b;
        }
        public static double Power(int a, int b)
        {
            return Math.Pow(a, b);
        }
        public static double Power(int a, float b)
        {
            return Math.Pow(a, b);
        }
        public static double Power(float a, float b)
        {
            return Math.Pow(a, b);
        }
        public static double Sqrt(int a)
        {
            return Math.Sqrt(a);
        }
        public static double Sqrt(float b)
        {
            return Math.Sqrt(b);
        }

    }
}