namespace FirstCmdLineApp.Maths

{
    public class Calculator
    {
        public float Parse(float a, float b)
        {
            return a / b * b;
        }

        public float ForceDivide(float a, float b)
        {
            return (a / b) * b;
        }
        public float ForceMultiply(float a, float b)
        {
            return a / (b * b);
        }

    }
}